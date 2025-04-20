Imports MySql.Data.MySqlClient
Public Class frmTable
    Dim table As String

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If txtTable.Text = String.Empty Then Return
            If MsgBox("Save tableno?", vbYesNo + vbQuestion) = vbYes Then

                cn.Open()
                cm = New MySqlCommand("insert into tbltable (tableno)values (@tableno)", cn)
                cm.Parameters.AddWithValue("@tableno", txtTable.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully saved!", vbInformation)
                Loadrecord()
                btnCancel_Click(sender, e)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub
    Sub Loadrecord()
        Dim i As Integer
        Guna2DataGridView1.Rows.Clear()
        cn.Open()
        cm = New MySqlCommand("select * from tbltable", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            Guna2DataGridView1.Rows.Add(i, dr.Item("tableno").ToString)
        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Dim colname As String = Guna2DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "colEdit" Then
            table = Guna2DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            txtTable.Text = table
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        ElseIf colname = "colDelete" Then
            If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("delete from tbltable where tableno like '" & Guna2DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully deleted!", vbInformation)
                Loadrecord()
            End If
        End If
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        table = ""
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtTable.Focus()




    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            If txtTable.Text = String.Empty Then Return
            If MsgBox("Update tableno?", vbYesNo + vbQuestion) = vbYes Then

                cn.Open()
                cm = New MySqlCommand("update tbltable set tableno = @tableno where tableno like '" & table & "'", cn)
                cm.Parameters.AddWithValue("@tableno", txtTable.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully updated!", vbInformation)
                Loadrecord()
                btnCancel_Click(sender, e)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub frmTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18)
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Guna2DataGridView1.EnableHeadersVisualStyles = False

        ' Attach CellPainting event
        AddHandler Guna2DataGridView1.CellPainting, AddressOf Guna2DataGridView1_CellPainting
    End Sub
    Private Sub Guna2DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)
        ' Check if the cell is in the header row and the first column (index 0)
        If e.RowIndex = -1 AndAlso e.ColumnIndex = 0 Then
            ' Set custom background color and text color for the header cell
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(18, 18, 18)), e.CellBounds)
            e.Graphics.DrawString(e.FormattedValue.ToString(), e.CellStyle.Font, Brushes.White, e.CellBounds, StringFormat.GenericDefault)

            ' Prevent default painting to avoid overriding
            e.Handled = True




        End If
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        
    End Sub
End Class