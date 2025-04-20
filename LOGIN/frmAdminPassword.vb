Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class frmAdminPassword

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            ValidatedPassword()
        End If
    End Sub

    Private Sub frmAdminPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.PasswordChar = Chr(149)
        Me.KeyPreview = True
    End Sub

    Sub ValidatedPassword()
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tbluser where role =@role and password = sha2(@password,224)", cn)
            With cm
                .Parameters.AddWithValue("@role", "Administrator")
                .Parameters.AddWithValue("@password", txtPass.Text)
            End With
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cn.Close()
                CancelOrder()
            Else
                dr.Close()
                cn.Close()
                MsgBox("Invalid password", vbCritical)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub CancelOrder()
        Try
            ' Confirm deletion
            If MsgBox("Cancel this order?", vbYesNo + vbQuestion) = vbYes Then
                ' Set status to "Cancel order" for the specific record
                cn.Open()
                cm = New MySqlCommand("UPDATE tblcart SET status = 'Cancel order' WHERE id = @id", cn)
                cm.Parameters.AddWithValue("@id", id) ' Use parameterized query for safety
                cm.ExecuteNonQuery()
                cn.Close()

                ' Update total in tblsales based on specific transaction number
                cn.Open()
                cm = New MySqlCommand("UPDATE tblsales SET total = total - @total WHERE transno = @transno", cn)
                cm.Parameters.AddWithValue("@total", amount)
                cm.Parameters.AddWithValue("@transno", transno)
                cm.ExecuteNonQuery()
                cn.Close()

                ' Show confirmation message and reload records
                MsgBox("Order successfully cancelled!", vbInformation)
                Me.Dispose()
                frmCancelOrder.LoadRecords()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox("An error occurred: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub
End Class