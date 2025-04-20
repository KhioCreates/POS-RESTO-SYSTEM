Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmPOS
    Dim btnCategory As New Button
    Dim pic As New PictureBox
    Dim lblDesc As New Label
    Dim lblPrice As New Label

    Dim _filter As String = ""
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18)
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Guna2DataGridView1.EnableHeadersVisualStyles = False


        'Connection()
        loadCategory()
        LoadMenu()
        Me.KeyPreview = True
    End Sub


    Private Sub btnTable_Click(sender As Object, e As EventArgs) Handles btnTable.Click

    End Sub

    Sub LoadMenu()
        FlowLayoutPanel2.AutoScroll = True
        FlowLayoutPanel2.Controls.Clear()
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If

        cm = New MySqlCommand("select image, id, description, price, weight, status from tblproduct where category like '" & _filter & "%'order by description", cn)
        dr = cm.ExecuteReader
        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))
            pic = New PictureBox
            pic.Width = 142
            pic.Height = 107
            pic.BackgroundImageLayout = ImageLayout.Stretch
            Dim ms As New MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            pic.Tag = dr.Item("id").ToString

            lblDesc = New Label
            lblDesc.BackColor = Color.FromArgb(84, 71, 63)
            lblDesc.ForeColor = Color.White
            lblDesc.Font = New Font("Noto Sans Hebrew", 8, FontStyle.Bold)
            lblDesc.Text = dr.Item("description").ToString
            lblDesc.Dock = DockStyle.Top
            lblDesc.Cursor = Cursors.Hand
            lblDesc.AutoSize = True
            lblDesc.TextAlign = ContentAlignment.MiddleCenter
            lblDesc.Tag = dr.Item("id").ToString

            lblPrice = New Label
            lblPrice.BackColor = Color.FromArgb(84, 71, 63)
            lblPrice.ForeColor = Color.White
            lblPrice.Font = New Font("Noto Sans Hebrew", 9, FontStyle.Bold)
            lblPrice.Text = dr.Item("price").ToString
            lblPrice.Dock = DockStyle.Bottom
            lblPrice.Cursor = Cursors.Hand
            lblPrice.AutoSize = True
            lblPrice.TextAlign = ContentAlignment.MiddleCenter
            lblPrice.Tag = dr.Item("id").ToString


            pic.Controls.Add(lblDesc)
            pic.Controls.Add(lblPrice)
            FlowLayoutPanel2.Controls.Add(pic)

            AddHandler pic.Click, AddressOf select_Click
            AddHandler lblDesc.Click, AddressOf select_Click
            AddHandler lblPrice.Click, AddressOf select_Click
        End While
        dr.Close()
        cn.Close()
    End Sub
    Sub loadCategory()
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If

        cm = New MySqlCommand("select * from tblcategory", cn)
        dr = cm.ExecuteReader
        While dr.Read
            btnCategory = New Button
            btnCategory.Width = 100
            btnCategory.Height = 35
            btnCategory.Text = dr.Item("category").ToString
            btnCategory.FlatStyle = FlatStyle.Flat
            btnCategory.BackColor = Color.FromArgb(75, 207, 250)
            btnCategory.ForeColor = Color.White
            btnCategory.Cursor = Cursors.Hand
            btnCategory.TextAlign = ContentAlignment.MiddleLeft
            ' FlowLayoutPanel1.Controls.Add(btnCategory)

            AddHandler btnCategory.Click, AddressOf filter_Click

        End While
        dr.Close()
        cn.Close()
    End Sub

    Public Sub select_Click(sender As Object, e As EventArgs)
        Try
            If lblTransNo.Text = String.Empty Then
                MsgBox("Click New Order First!", vbCritical)
                Return
            End If
            Dim description As String, price As Double
            Dim weight As Boolean
            Dim id As String = sender.tag.ToString
            cn.Open()
            cm = New MySqlCommand("select * From tblproduct where id like '" & id & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                price = CDbl(dr.Item("price").ToString)
                weight = CBool(dr.Item("weight").ToString)

            End If
            dr.Close()
            cn.Close()

            cn.Open()

            cn.Close()
            With frmQty
                .AddToCart(id, price, weight)
                .Show()
            End With

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub LoadCart()
        Dim _total As Double
        Guna2DataGridView1.Rows.Clear()
        cn.Open()
        cm = New MySqlCommand("select c.id , p.description, c.price, c.qty, c.total from tblcart as c inner join tblproduct as p on p.id = c.pid where c.transno like '" & lblTransNo.Text & "'", cn)
        dr = cm.ExecuteReader
        While dr.Read
            _total += CDbl(dr.Item("total").ToString)
            Guna2DataGridView1.Rows.Add(dr.Item("id").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString)
        End While
        dr.Close()
        cn.Close()
        lblTotal.Text = Format(_total, "#,##0.00")

        If Guna2DataGridView1.Rows.Count < 1 Then
            btnSettle.Enabled = False

        Else
            btnSettle.Enabled = True

        End If

    End Sub


    Public Sub filter_Click(sender As Object, e As EventArgs)
        If lblTransNo.Text = String.Empty Then
            MsgBox("Click New Order First!", vbCritical)
            Return
        End If

        _filter = sender.text.ToString
        LoadMenu()

    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click

        If CheckTransaction() = True Then



            lblTransNo.Text = GetTransno()
            With frmSelectTable
                .loadTable()
                .ShowDialog()
            End With
            LoadCart()
        Else
            MsgBox("Transaction is already closed!", vbExclamation)
        End If
    End Sub

    Function GetTransno() As String
        Try
            Dim sdate As String = Now.ToString("yyyyMMdd")
            cn.Open()
            cm = New MySqlCommand("Select * from tblcart where transno Like '" & sdate & "%' order by id desc", cn)
            dr = cm.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                GetTransno = CLng(dr.Item("transno").ToString) + 1
            Else
                GetTransno = sdate & "0001"

            End If
            dr.Close()
            cn.Close()
            Return GetTransno
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try


    End Function

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel4.Click

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Dim colname As String = Guna2DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "colRemove" Then
            If MsgBox("Remove this item from the list?", vbYesNo + vbQuestion) = vbYes Then
                Try
                    ' Use "id" instead of "colID" (matches SQL field name)
                    Dim selectedID As String = Guna2DataGridView1.Rows(e.RowIndex).Cells("id").Value.ToString

                    ' Parameterized query
                    cn.Open()
                    Using cm As New MySqlCommand("DELETE FROM tblcart WHERE id = @id", cn)
                        cm.Parameters.AddWithValue("@id", selectedID)
                        cm.ExecuteNonQuery()
                    End Using
                    cn.Close()

                    LoadCart()
                    MsgBox("Item removed successfully!", vbInformation)
                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.Message, vbCritical)
                End Try
            End If
        End If
    End Sub

    Sub GetOrder()
        Dim found As Boolean
        Dim tno As String

        cn.Open()
        cm = New MySqlCommand("select * from tblcart where tableno like '" & lblTable.Text & "' and status like 'Pending'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            found = True
            tno = dr.Item("transno").ToString
        Else
            found = False
        End If
        dr.Close()
        cn.Close()
        If found = True Then
            lblTransNo.Text = tno
            LoadCart()
        End If
    End Sub

    Private Sub frmPOS_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F1 Then
            btnNewOrder_Click(sender, e)
        ElseIf e.KeyCode = Keys.F2 Then
            btnSettle_Click(sender, e)
        ElseIf e.KeyCode = Keys.F5 Then
            btnTable_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            btnSales_Click(sender, e)
        End If
    End Sub

    Private Sub btnSettle_Click(sender As Object, e As EventArgs) Handles btnSettle.Click
        With frmSettle
            .txtTotal.Text = lblTotal.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If CheckTransaction() = True Then

            With frmStart
                .ShowDialog()
            End With
        Else
            Dim sdate As String = Now.ToString("yyyy-MM-dd")
            cn.Open()
            cm = New MySqlCommand("select count(*) from tblstart where sdate between '" & sdate & "' and '" & sdate & "'and status like 'close'", cn)
            Dim count As Integer = CInt(cm.ExecuteScalar)
            cn.Close()

            If count = 0 Then
                With frmStart
                    .ShowDialog()
                End With
            Else
                MsgBox("Transaction this day is already closed!", vbExclamation)
            End If


        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Try
            cn.Open()
            cm = New MySqlCommand("select count(*) from tblcart where status like 'Pending'", cn)
            Dim icount As Integer = CInt(cm.ExecuteScalar)
            cn.Close()

            If icount > 0 Then
                MsgBox("Please settle the pending billing.", vbExclamation)
                Return
            Else
                If MsgBox("Do you want to close the transaction?", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New MySqlCommand("update tblstart set status = 'close' where id like '" & startid & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Sales transaction has been successfully closed!", vbInformation)
                End If
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) 
        With frmDailySales
            .GenerateSales()
            .ShowDialog()
        End With
    End Sub

    Private Sub frmPOS_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        If MsgBox("Do you want to logout?", vbYesNo + vbQuestion) = vbYes Then
            Me.Dispose()
            LogHistory("OUT")
            Form1.Show()
            Form1.txtUser.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        With frmCancelOrder
            .LoadRecords()
            .ShowDialog()
        End With
    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel2.Paint

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Guna2HtmlLabel7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)

    End Sub
End Class