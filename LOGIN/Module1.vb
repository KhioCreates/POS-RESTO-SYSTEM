Imports MySql.Data.MySqlClient
Module Module1

    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Public str_user, str_pass, str_name, str_role As String
    Public startid As String
    Public id, transno As String
    Public amount As Double
    Public currencysymbol As String = "₱"
    Sub Connection()

        cn = New MySqlConnection
        With cn
            .ConnectionString = "server=localhost;user id=root;password=;database=posresto"
        End With

    End Sub

    Function CheckTransaction()
        Dim isOpen As Boolean
        cn.Open()
        cm = New MySqlCommand("select * from tblstart where id like '" & startid & "' and status like 'open'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            isOpen = True
        Else
            isOpen = False
        End If
        dr.Close()
        cn.Close()
        Return isOpen
    End Function

    Sub Dashboard()
        Try
            With frmSuperMain
                Dim sdate As String = Now.ToString("yyyy-MM-dd")
                cn.Open()
                cm = New MySqlCommand("select ifnull(sum(total),0) from tblsales where sdate between '" & sdate & "' and '" & sdate & "'", cn)
                Dim total As Double = CDbl(cm.ExecuteScalar)
                .lblTotalSales.Text = Format(total, currencysymbol & "#,##0.00")
                cn.Close()

                cn.Open()
                cm = New MySqlCommand("select count(*) from tblproduct", cn)
                Dim totproduct As Integer = CInt(cm.ExecuteScalar)
                .lblProduct.Text = totproduct
                cn.Close()


            End With

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Function CheckStatus() As Boolean
        Dim found As Boolean
        Dim sdate As String = Now.ToString("yyyy-MM-dd")

        cn.Open()
        cm = New MySqlCommand("select * from tblstart where sdate between '" & sdate & "' and '" & sdate & "'and status like 'open'", cn)
            dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            startid = dr.Item("id").ToString
            found = True
        Else
            found = False
        End If
        dr.Close()
        cn.Close()



        Return found
    End Function

    Function CountRecords(ByVal sql As String) As Integer
        Dim count As Integer
        cn.Open()
        cm = New MySqlCommand(sql, cn)
        count = CInt(cm.ExecuteScalar)
        cn.Close()

        Return count
    End Function

    Sub LogHistory(ByVal ptype As String)
        Try
            Dim sdate As String = Now.ToString("yyyy-MM-dd")
            Dim id As String = String.Empty

            If ptype = "IN" Then
                ' Insert new log entry with time-in
                cn.Open()
                cm = New MySqlCommand("INSERT INTO tbllog(user, sdate, timein) VALUES(@user, @sdate, @timein)", cn)
                With cm
                    .Parameters.AddWithValue("@user", str_user)
                    .Parameters.AddWithValue("@sdate", sdate)
                    .Parameters.AddWithValue("@timein", Now.ToString("hh:mm:ss tt"))
                    .ExecuteNonQuery()
                End With
                cn.Close()

            ElseIf ptype = "OUT" Then
                ' Retrieve the latest ID for the user to update the timeout
                cn.Open()
                cm = New MySqlCommand("SELECT MAX(id) AS id FROM tbllog WHERE user = @user AND sdate = @sdate", cn)
                cm.Parameters.AddWithValue("@user", str_user)
                cm.Parameters.AddWithValue("@sdate", sdate)
                dr = cm.ExecuteReader()
                dr.Read()
                If dr.HasRows Then
                    id = dr.Item("id").ToString()
                End If
                dr.Close()
                cn.Close()

                ' Update the timeout for the retrieved ID if found
                If Not String.IsNullOrEmpty(id) Then
                    cn.Open()
                    cm = New MySqlCommand("UPDATE tbllog SET status = 'Offline', timeout = @timeout WHERE id = @id", cn)
                    cm.Parameters.AddWithValue("@timeout", Now.ToString("hh:mm:ss tt"))
                    cm.Parameters.AddWithValue("@id", id)
                    cm.ExecuteNonQuery()
                    cn.Close()
                End If
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub



End Module
