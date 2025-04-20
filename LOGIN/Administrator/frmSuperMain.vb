Public Class frmSuperMain
    Private Sub frmSuperMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmSuperMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        With frmProductList
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            Panel3.Controls.Add(frmProductList)
            .LoadRecord()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        With frmSales
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            Panel3.Controls.Add(frmSales)
            .LoadRecords()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        With frmCancelOrderList
            .TopLevel = False
            Panel3.Controls.Add(frmCancelOrderList)
            .LoadRecords()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnTable.Click
        With frmTable
            .TopLevel = False
            Panel3.Controls.Add(frmTable)
            .btnUpdate.Enabled = False
            .Loadrecord()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        If MsgBox("Do you want to logout?", vbYesNo + vbQuestion) = vbYes Then
            Me.Dispose()
            LogHistory("OUT")
            Form1.txtUser.Focus()
        End If
    End Sub

    Private Sub btnLogHistory_Click(sender As Object, e As EventArgs) Handles btnLogHistory.Click
        With frmLogHistory
            .TopLevel = False
            Panel3.Controls.Add(frmLogHistory)
            .LoadRecords()
            .BringToFront()
            .Show()
        End With
    End Sub
End Class