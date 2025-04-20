Imports MySql.Data.MySqlClient
Public Class frmSelectTable
    Dim btnTable As New Button
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Sub loadTable()
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If

        cm = New MySqlCommand("select * from vwtable", cn)
        dr = cm.ExecuteReader
        While dr.Read
            btnTable = New Button
            btnTable.Width = 150
            btnTable.Height = 35

            btnTable.Font = New Font("Noto Sans Hebrew", 9, FontStyle.Bold)
            If CDbl(dr.Item("bill").ToString) > 1 Then
                btnTable.Text = dr.Item("tableno").ToString & " - ₱" & dr.Item("bill").ToString
                btnTable.BackColor = Color.Crimson
            Else
                btnTable.Text = dr.Item("tableno").ToString
                btnTable.BackColor = Color.FromArgb(255, 102, 0)

            End If

            btnTable.Tag = dr.Item("tableno").ToString
            btnTable.FlatStyle = FlatStyle.Flat

            btnTable.ForeColor = Color.White
            btnTable.Cursor = Cursors.Hand
            btnTable.TextAlign = ContentAlignment.MiddleLeft
            FlowLayoutPanel1.Controls.Add(btnTable)

            AddHandler btnTable.Click, AddressOf GetTable_Click

        End While
        dr.Close()
        cn.Close()
    End Sub

    Sub GetTable_Click(sender As Object, e As EventArgs)
        Dim table As String = sender.tag.ToString
        With frmPOS
            .lblTable.Text = table
            .GetOrder()

        End With
        Me.Dispose()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub frmSelectTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class