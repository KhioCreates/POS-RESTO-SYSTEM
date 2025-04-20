Imports MySql.Data.MySqlClient

Public Class frmSalesDetails
    Private Sub frmSalesDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18)
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Guna2DataGridView1.EnableHeadersVisualStyles = False
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Sub LoadSales()
        Dim _total As Double
        Dim i As Integer
        Guna2DataGridView1.Rows.Clear()
        Dim sdate As String = Now.ToString("yyyy-MM-dd")
        cn.Open()
        cm = New MySqlCommand("SELECT c.id, c.transno, c.pid, p.description, c.price, c.qty, c.total FROM `tblcart` as c inner join tblproduct as p on c.pid = p.id where c.tdate between '" & sdate & "' and '" & sdate & "' and c.status like 'Completed'", cn)
        dr = cm.ExecuteReader

        While dr.Read
            i += 1
            _total += CDbl(dr.Item("total").ToString)
            Guna2DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("transno").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("total").ToString)
        End While

        dr.Close()
        cn.Close()

        lblTotal.Text = "TOTAL : " & Format(_total, "#,#0.00")
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub
End Class