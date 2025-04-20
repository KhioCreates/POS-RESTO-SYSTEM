Imports MySql.Data.MySqlClient

Public Class frmSettle
    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Try
            Dim total As Double = CDbl(txtTotal.Text)
            Dim change As Double = CDbl(txtCash.Text) - total
            If change < 0 Then
                txtChange.Text = "0.00"
            Else
                txtChange.Text = Format(change, "#,##0.00")
            End If
        Catch ex As Exception
            txtChange.Text = "0.00"

        End Try
    End Sub

    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case 13
                btnAccept_Click(sender, e)
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try
            Dim total As Double = CDbl(txtTotal.Text)
            Dim change As Double = CDbl(txtCash.Text) - total
            If change < 0 Then
                MsgBox("Insufficient Cash! Please enter correct amount.", vbExclamation)
                Return

            Else
                If MsgBox("Save this payment?", vbYesNo + vbQuestion) = vbYes Then
                    SavePayment()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub SavePayment()
        Try
            ' Check if the connection is closed, then open it
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            ' Get current date and time for the transaction
            Dim sdate As String = Now.ToString("yyyy-MM-dd")
            Dim stime As String = Now.ToString("hh:mm:ss")

            ' Insert payment details into tblsales
            cm = New MySqlCommand("insert into tblsales(transno, total, sdate, stime, cashier) values (@transno, @total, @sdate, @stime, @cashier)", cn)
            With cm
                .Parameters.AddWithValue("@transno", frmPOS.lblTransNo.Text)
                .Parameters.AddWithValue("@total", CDbl(txtTotal.Text))
                .Parameters.AddWithValue("@sdate", sdate)
                .Parameters.AddWithValue("@stime", stime)
                .Parameters.AddWithValue("@cashier", str_user)
                .ExecuteNonQuery()
            End With

            ' Update the cart status to 'Completed'
            cm = New MySqlCommand("update tblcart set status = 'Completed' where transno = @transno", cn)
            cm.Parameters.AddWithValue("@transno", frmPOS.lblTransNo.Text)
            cm.ExecuteNonQuery()

            ' Close the connection after the operations are completed
            cn.Close()

            ' Show success message
            MsgBox("Payment successfully saved!", vbInformation)

            ' Clear and refresh the cart in frmPOS
            With frmPOS
                ' Reload the cart (this will clear it if it's tied to a database)
                .LoadCart()

                ' Generate a new transaction number for the next purchase
                .lblTransNo.Text = .GetTransno()

                ' Clear the DataGridView manually if needed
                .Guna2DataGridView1.Rows.Clear() ' Make sure this is the correct DataGridView in frmPOS

                ' Clear the total label (set it to 0 or an empty string)
                .lblTotal.Text = "0.00"
            End With

            ' Close the settle form
            Me.Dispose()

        Catch ex As Exception
            ' Ensure connection is closed in case of any error
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            ' Display the error message
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub
    Private Sub frmSettle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub frmSettle_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
End Class