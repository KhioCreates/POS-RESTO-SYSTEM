
Imports MySql.Data.MySqlClient

Public Class frmCategory


    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click
        Me.Dispose()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            If MsgBox("Save this category?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("insert into tblcategory (category)values(@category)", cn)
                cm.Parameters.AddWithValue("@category", txtCategory.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Category has been successfully saved!", vbInformation)
                txtCategory.Clear()
                txtCategory.Focus()
                With frmProduct
                    .LoadCategory()

                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click

    End Sub
End Class