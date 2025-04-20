Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmProductList
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        With frmProduct
            .LoadCategory()
            .ShowDialog()
        End With
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Sub LoadRecord()
        Guna2DataGridView1.Rows.Clear()
        Dim i As Integer

        cn.Open()
        cm = New MySqlCommand("select * from tblproduct", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            Guna2DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("category").ToString, dr.Item("weight"), dr.Item("image"), dr.Item("STATUS").ToString)




        End While
        dr.Close()

        cn.Close()

        For i = 0 To Guna2DataGridView1.Rows.Count - 1
            Dim r As DataGridViewRow = Guna2DataGridView1.Rows(i)
            r.Height = 100
        Next
        Dim imagecolumn = DirectCast(Guna2DataGridView1.Columns("Column8"), DataGridViewImageColumn) '
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Dim colname As String = Guna2DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "colEdit" Then
            With frmProduct
                cn.Open()
                cm = New MySqlCommand("select image from tblproduct where id like '" & Guna2DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                dr = cm.ExecuteReader
                While dr.Read
                    Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                    Dim array(CInt(len)) As Byte
                    dr.GetBytes(0, 0, array, 0, CInt(len))
                    Dim ms As New MemoryStream(array)
                    Dim bitmap As New System.Drawing.Bitmap(ms)
                    .PictureBox1.BackgroundImage = bitmap
                    .txtID.Text = Guna2DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtDescription.Text = Guna2DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtPrice.Text = Guna2DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                    .cboCategory.Text = Guna2DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                    .CheckBox1.Checked = CBool(Guna2DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString)
                    .cboStatus.Text = Guna2DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString


                End While
                dr.Close()
                cn.Close()
                .LoadCategory()
                .btnSave.Enabled = False
                .btnUpdate.Enabled = True
                .ShowDialog()
            End With
        ElseIf colname = "colDelete" Then
            If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("delete from tblproduct where id like '" & Guna2DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully deleted!", vbInformation)
                LoadRecord()
                Dashboard()
            End If


        End If


    End Sub



    Private Sub frmProductList_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18)
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Guna2DataGridView1.EnableHeadersVisualStyles = False

        ' Attach CellPainting event
        AddHandler Guna2DataGridView1.CellPainting, AddressOf Guna2DataGridView1_CellPainting


        Me.KeyPreview = True
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

    Private Sub frmProductList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Dispose()


    End Sub
End Class