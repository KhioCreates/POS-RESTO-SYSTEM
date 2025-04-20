Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient
Public Class frmDailySales
    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click
        Me.Dispose()
    End Sub

    Private Sub frmDailySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub GenerateSales()
        Try
            Dim sdate As String = Now.ToString("yyyy-MM-dd")

            cn.Open()
            cm = New MySqlCommand("SELECT IFNULL(SUM(total), 0) AS total FROM tblcart WHERE tdate BETWEEN '" & sdate & "' AND '" & sdate & "' AND status LIKE 'Completed'", cn)
            lblSales.Text = Microsoft.VisualBasic.Strings.Format(CDbl(cm.ExecuteScalar()), "#,##0.00")
            cn.Close()

            cn.Open()
            cm = New MySqlCommand("SELECT IFNULL(SUM(initialcash), 0) AS total FROM tblstart WHERE sdate BETWEEN '" & sdate & "' AND '" & sdate & "'", cn)
            lblInitial.Text = Microsoft.VisualBasic.Strings.Format(CDbl(cm.ExecuteScalar()), "#,##0.00")
            cn.Close()

            Dim _total As Double = CDbl(lblSales.Text) + CDbl(lblInitial.Text)
            lblTotal.Text = Microsoft.VisualBasic.Strings.Format(_total, "#,##0.00")

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With frmSalesDetails
            .LoadSales()
            .ShowDialog()
        End With

    End Sub
End Class