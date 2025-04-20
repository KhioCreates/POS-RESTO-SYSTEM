Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmProduct
    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click
        Me.Dispose()
    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        With frmCategory
            .ShowDialog()
        End With
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Using ofd As New OpenFileDialog With {.Filter = "(Image Files)}| *.jpg;*.png;*.bmp;*.gif;*.ico|Jpg,|*.jpg|Png,|*.png|Bmp,|*.bmp|Gif,|*.gif|Ico,|*.ico",
               .Multiselect = False, .Title = "Select Image"}

            If ofd.ShowDialog = 1 Then
                PictureBox1.BackgroundImage = Image.FromFile(ofd.FileName)
                OpenFileDialog1.FileName = ofd.FileName
            End If
        End Using
    End Sub


    Sub LoadCategory()
        cboCategory.Items.Clear()
        cn.Open()
        cm = New MySqlCommand("select * from tblcategory", cn)
        dr = cm.ExecuteReader
        While dr.Read
            cboCategory.Items.Add(dr.Item("category").ToString)
        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If OpenFileDialog1.FileName = "OpenFileDialog1" Then
                MsgBox("Please select image!", vbCritical)
                Return
            End If
            If txtDescription.Text = String.Empty Or txtPrice.Text = String.Empty Then
                MsgBox("Please input data!", vbCritical)
                Return
            End If
            If cboCategory.Text = String.Empty Or cboStatus.Text = String.Empty Then
                MsgBox("Please select data from the list!", vbCritical)
                Return
            End If
            If MsgBox("Save this record?", vbYesNo + vbQuestion) = vbYes Then
                Dim mstream As New MemoryStream
                PictureBox1.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = mstream.GetBuffer


                cn.Open()
                cm = New MySqlCommand("insert into tblproduct(description, price, category, weight, image) values(@description, @price, @category, @weight, @image)", cn)
                With cm.Parameters
                    .AddWithValue("@description", txtDescription.Text)
                    .AddWithValue("@price", txtPrice.Text)
                    .AddWithValue("@category", cboCategory.Text)
                    .AddWithValue("@weight", CheckBox1.Checked.ToString)
                    .AddWithValue("@image", arrImage)
                End With

                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully saved!", vbInformation)
                Clear()
                With frmProductList
                    .LoadRecord()
                End With

            End If
            Dashboard()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub
    Sub Clear()
        txtDescription.Clear()
        txtID.Text = "(Auto)"
        txtPrice.Clear()
        cboCategory.Text = ""
        cboStatus.Text = ""
        PictureBox1.BackgroundImage = Nothing
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtDescription.Focus()


    End Sub
    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Clear()
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged

    End Sub

    Private Sub cboCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCategory.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtDescription.Text = String.Empty Or txtPrice.Text = String.Empty Then
                MsgBox("Please input data!", vbCritical)
                Return
            End If
            If cboCategory.Text = String.Empty Or cboStatus.Text = String.Empty Then
                MsgBox("Please select data from the list!", vbCritical)
                Return
            End If
            If MsgBox("Update this record?", vbYesNo + vbQuestion) = vbYes Then
                Dim mstream As New MemoryStream
                PictureBox1.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = mstream.GetBuffer


                cn.Open()
                cm = New MySqlCommand("update tblproduct set description=@description, price=@price, category=@category, weight=@weight, image=@image where id=@id", cn)
                With cm.Parameters
                    .AddWithValue("@description", txtDescription.Text)
                    .AddWithValue("@price", txtPrice.Text)
                    .AddWithValue("@category", cboCategory)
                    .AddWithValue("@weight", CheckBox1.Checked.ToString)
                    .AddWithValue("@image", arrImage)
                    .AddWithValue("@id", txtID.Text)
                End With

                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully updated!", vbInformation)
                Clear()
                With frmProductList
                    .LoadRecord()
                End With
                Me.Dispose()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub
End Class