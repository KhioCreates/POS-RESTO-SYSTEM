<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSuperMain
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblRole = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblProduct = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTotalSales = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.btnLogHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSales = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTable = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblRole)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1203, 60)
        Me.Panel1.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(60, 42)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(92, 14)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Guna2HtmlLabel2"
        '
        'lblRole
        '
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.Location = New System.Drawing.Point(60, 24)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(92, 14)
        Me.lblRole.TabIndex = 1
        Me.lblRole.Text = "Guna2HtmlLabel1"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(60, 5)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(103, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Guna2HtmlLabel1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.btnLogHistory)
        Me.Panel2.Controls.Add(Me.Guna2Button5)
        Me.Panel2.Controls.Add(Me.btnCancelOrder)
        Me.Panel2.Controls.Add(Me.btnSales)
        Me.Panel2.Controls.Add(Me.btnTable)
        Me.Panel2.Controls.Add(Me.btnProduct)
        Me.Panel2.Location = New System.Drawing.Point(20, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(261, 497)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(281, 120)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(942, 497)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(20, 17)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(901, 149)
        Me.Panel4.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(677, 23)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 100)
        Me.Panel8.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(456, 23)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 100)
        Me.Panel7.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Green
        Me.Panel6.Controls.Add(Me.lblProduct)
        Me.Panel6.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel6.Location = New System.Drawing.Point(236, 23)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 100)
        Me.Panel6.TabIndex = 1
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = False
        Me.lblProduct.BackColor = System.Drawing.Color.Transparent
        Me.lblProduct.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.ForeColor = System.Drawing.Color.White
        Me.lblProduct.Location = New System.Drawing.Point(-13, 8)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(200, 65)
        Me.lblProduct.TabIndex = 3
        Me.lblProduct.Text = "0"
        Me.lblProduct.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Noto Sans Hebrew", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(10, 71)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(127, 22)
        Me.Guna2HtmlLabel3.TabIndex = 2
        Me.Guna2HtmlLabel3.Text = "TOTAL PRODUCT"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblTotalSales)
        Me.Panel5.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel5.Location = New System.Drawing.Point(17, 23)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 100)
        Me.Panel5.TabIndex = 0
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = False
        Me.lblTotalSales.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalSales.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.ForeColor = System.Drawing.Color.White
        Me.lblTotalSales.Location = New System.Drawing.Point(-14, 8)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(200, 65)
        Me.lblTotalSales.TabIndex = 1
        Me.lblTotalSales.Text = "0.00"
        Me.lblTotalSales.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Noto Sans Hebrew", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(10, 71)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(97, 22)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "TOTAL SALES"
        '
        'btnLogHistory
        '
        Me.btnLogHistory.CheckedState.Parent = Me.btnLogHistory
        Me.btnLogHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogHistory.CustomImages.Parent = Me.btnLogHistory
        Me.btnLogHistory.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnLogHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogHistory.ForeColor = System.Drawing.Color.White
        Me.btnLogHistory.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogHistory.HoverState.Parent = Me.btnLogHistory
        Me.btnLogHistory.Image = Global.LOGIN.My.Resources.Resources.history
        Me.btnLogHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogHistory.Location = New System.Drawing.Point(0, 190)
        Me.btnLogHistory.Name = "btnLogHistory"
        Me.btnLogHistory.ShadowDecoration.Parent = Me.btnLogHistory
        Me.btnLogHistory.Size = New System.Drawing.Size(261, 45)
        Me.btnLogHistory.TabIndex = 5
        Me.btnLogHistory.Text = "Log History"
        Me.btnLogHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button5.CheckedState.Parent = Me.Guna2Button5
        Me.Guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button5.CustomImages.Parent = Me.Guna2Button5
        Me.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button5.HoverState.Parent = Me.Guna2Button5
        Me.Guna2Button5.Image = Global.LOGIN.My.Resources.Resources._exit
        Me.Guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button5.Location = New System.Drawing.Point(-1, 452)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.Parent = Me.Guna2Button5
        Me.Guna2Button5.Size = New System.Drawing.Size(262, 45)
        Me.Guna2Button5.TabIndex = 4
        Me.Guna2Button5.Text = "Logout"
        Me.Guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.CheckedState.Parent = Me.btnCancelOrder
        Me.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelOrder.CustomImages.Parent = Me.btnCancelOrder
        Me.btnCancelOrder.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnCancelOrder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelOrder.ForeColor = System.Drawing.Color.White
        Me.btnCancelOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelOrder.HoverState.Parent = Me.btnCancelOrder
        Me.btnCancelOrder.Image = Global.LOGIN.My.Resources.Resources.wrong_parcel1
        Me.btnCancelOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancelOrder.Location = New System.Drawing.Point(0, 142)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.ShadowDecoration.Parent = Me.btnCancelOrder
        Me.btnCancelOrder.Size = New System.Drawing.Size(261, 45)
        Me.btnCancelOrder.TabIndex = 3
        Me.btnCancelOrder.Text = "Cancel Order"
        Me.btnCancelOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSales
        '
        Me.btnSales.CheckedState.Parent = Me.btnSales
        Me.btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSales.CustomImages.Parent = Me.btnSales
        Me.btnSales.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnSales.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSales.HoverState.Parent = Me.btnSales
        Me.btnSales.Image = Global.LOGIN.My.Resources.Resources.economy
        Me.btnSales.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSales.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnSales.Location = New System.Drawing.Point(0, 95)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.ShadowDecoration.Parent = Me.btnSales
        Me.btnSales.Size = New System.Drawing.Size(261, 45)
        Me.btnSales.TabIndex = 2
        Me.btnSales.Text = "Sales"
        Me.btnSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnTable
        '
        Me.btnTable.CheckedState.Parent = Me.btnTable
        Me.btnTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTable.CustomImages.Parent = Me.btnTable
        Me.btnTable.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnTable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTable.ForeColor = System.Drawing.Color.White
        Me.btnTable.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTable.HoverState.Parent = Me.btnTable
        Me.btnTable.Image = Global.LOGIN.My.Resources.Resources.table
        Me.btnTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTable.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnTable.Location = New System.Drawing.Point(1, 48)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.ShadowDecoration.Parent = Me.btnTable
        Me.btnTable.Size = New System.Drawing.Size(260, 45)
        Me.btnTable.TabIndex = 1
        Me.btnTable.Text = "Table"
        Me.btnTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnProduct
        '
        Me.btnProduct.CheckedState.Parent = Me.btnProduct
        Me.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProduct.CustomImages.Parent = Me.btnProduct
        Me.btnProduct.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnProduct.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnProduct.ForeColor = System.Drawing.Color.White
        Me.btnProduct.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProduct.HoverState.Parent = Me.btnProduct
        Me.btnProduct.Image = Global.LOGIN.My.Resources.Resources.add_to_basket
        Me.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnProduct.Location = New System.Drawing.Point(0, 1)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.ShadowDecoration.Parent = Me.btnProduct
        Me.btnProduct.Size = New System.Drawing.Size(261, 45)
        Me.btnProduct.TabIndex = 0
        Me.btnProduct.Text = "Product"
        Me.btnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.LOGIN.My.Resources.Resources.freelancer
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(10, 9)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(41, 41)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'frmSuperMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 637)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSuperMain"
        Me.Text = "POS System - Administrator Side"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblRole As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTable As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSales As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancelOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTotalSales As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblProduct As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnLogHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
End Class
