Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient

Public Class frmSales
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Sub LoadRecords()
        Try
            Dim total As Double
            Dim startamount As Double
            Dim i As Integer
            Guna2DataGridView1.Rows.Clear()

            ' Load records from vwcart
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM vwcart WHERE status LIKE 'Completed'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                total += CDbl(dr.Item("total").ToString())

                Guna2DataGridView1.Rows.Add(i, dr.Item("transno").ToString(), dr.Item("description").ToString(), dr.Item("price").ToString(), dr.Item("qty").ToString(), dr.Item("total").ToString(), dr.Item("tableno").ToString(), dr.Item("user").ToString(), CDate(dr.Item("tdate").ToString()).ToShortDateString())
            End While
            dr.Close()
            cn.Close()

            ' Get initial cash amount from tblstart
            cn.Open()
            cm = New MySqlCommand("SELECT IFNULL(SUM(initialcash), 0) AS cash FROM tblstart", cn)
            startamount = CDbl(cm.ExecuteScalar())
            cn.Close()

            ' Display the results in lblTotal
            lblTotal.Text = "Sales: " & Microsoft.VisualBasic.Format(total, "₱ #,##0.00") & Space(10) & "Start Amount: " & Microsoft.VisualBasic.Format(startamount, "₱ #,##0.00") & Space(20) & "Total Amount: " & Microsoft.VisualBasic.Format(total + startamount, "₱ #,##0.00")

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
