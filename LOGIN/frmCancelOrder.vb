Imports MySql.Data.MySqlClient
Public Class frmCancelOrder
    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click
        Me.Dispose()
    End Sub

    Sub LoadRecords()
        Try

            Dim i As Integer
            Dim sdate1 As String = Now.ToString("yyyy-MM-dd")
            Dim sdate2 As String = Now.ToString("yyyy-MM-dd")
            Guna2DataGridView1.Rows.Clear()

            ' Load records from vwcart
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM vwcart WHERE status LIKE 'Completed'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                Guna2DataGridView1.Rows.Add(
    dr.Item("id").ToString(),
     dr.Item("transno").ToString(),' ID
    dr.Item("description").ToString(),      ' DESCRIPTION
    dr.Item("price").ToString(),            ' Price
    dr.Item("qty").ToString(),              ' Qty
    dr.Item("total").ToString(),            ' Total
    dr.Item("tableno").ToString(),          ' Table No
    dr.Item("user").ToString(),             ' Cashier
    dr.Item("status").ToString(),           ' Status
    "Cancel Order"                          ' Action Button
)



            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Dim colName As String = Guna2DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colCancel" Then
            With frmAdminPassword
                id = Guna2DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                transno = Guna2DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                amount = CDbl(Guna2DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString)
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub frmCancelOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18)
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Guna2DataGridView1.EnableHeadersVisualStyles = False
    End Sub
End Class