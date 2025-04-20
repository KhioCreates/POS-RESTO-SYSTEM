Imports MySql.Data.MySqlClient
Public Class frmLogHistory
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Sub LoadRecords()
        Try
            ' Clear existing rows in the DataGridView
            Guna2DataGridView1.Rows.Clear()

            ' Open the connection
            cn.Open()

            ' Create the MySQL command
            cm = New MySqlCommand("SELECT * FROM tbllog", cn)
            dr = cm.ExecuteReader()

            ' Read the data and add it to the DataGridView
            While dr.Read
                Guna2DataGridView1.Rows.Add(dr.Item("user").ToString(), dr.Item("timein").ToString(), dr.Item("timeout").ToString(), dr.Item("status").ToString())
            End While


            ' Close the reader
            dr.Close()
            lblCount.Text = "Record count (" & Guna2DataGridView1.RowCount & ")"
        Catch ex As Exception
            ' Display the error message
            MsgBox(ex.Message, vbCritical)
        Finally
            ' Ensure the connection is closed
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub

    Private Sub frmLogHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class