<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCash = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtChange = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnAccept = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Noto Sans Hebrew", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(158, 118)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(51, 22)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "TOTAL"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Transparent
        Me.txtTotal.BorderRadius = 10
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.DefaultText = ""
        Me.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.DisabledState.Parent = Me.txtTotal
        Me.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.Enabled = False
        Me.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.FocusedState.Parent = Me.txtTotal
        Me.txtTotal.Font = New System.Drawing.Font("Noto Sans Hebrew", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.HoverState.Parent = Me.txtTotal
        Me.txtTotal.Location = New System.Drawing.Point(72, 146)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.PlaceholderText = ""
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.ShadowDecoration.BorderRadius = 10
        Me.txtTotal.ShadowDecoration.Depth = 10
        Me.txtTotal.ShadowDecoration.Enabled = True
        Me.txtTotal.ShadowDecoration.Parent = Me.txtTotal
        Me.txtTotal.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 2, 8, 8)
        Me.txtTotal.Size = New System.Drawing.Size(224, 36)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.Transparent
        Me.txtCash.BorderRadius = 10
        Me.txtCash.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCash.DefaultText = ""
        Me.txtCash.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCash.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCash.DisabledState.Parent = Me.txtCash
        Me.txtCash.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCash.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCash.FocusedState.Parent = Me.txtCash
        Me.txtCash.Font = New System.Drawing.Font("Noto Sans Hebrew", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtCash.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCash.HoverState.Parent = Me.txtCash
        Me.txtCash.Location = New System.Drawing.Point(72, 228)
        Me.txtCash.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCash.PlaceholderText = ""
        Me.txtCash.SelectedText = ""
        Me.txtCash.ShadowDecoration.BorderRadius = 10
        Me.txtCash.ShadowDecoration.Depth = 10
        Me.txtCash.ShadowDecoration.Enabled = True
        Me.txtCash.ShadowDecoration.Parent = Me.txtCash
        Me.txtCash.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 2, 8, 8)
        Me.txtCash.Size = New System.Drawing.Size(223, 36)
        Me.txtCash.TabIndex = 3
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Noto Sans Hebrew", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(161, 200)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(42, 22)
        Me.Guna2HtmlLabel2.TabIndex = 2
        Me.Guna2HtmlLabel2.Text = "CASH"
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.Color.Transparent
        Me.txtChange.BorderRadius = 10
        Me.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChange.DefaultText = ""
        Me.txtChange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChange.DisabledState.Parent = Me.txtChange
        Me.txtChange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChange.Enabled = False
        Me.txtChange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChange.FocusedState.Parent = Me.txtChange
        Me.txtChange.Font = New System.Drawing.Font("Noto Sans Hebrew", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtChange.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChange.HoverState.Parent = Me.txtChange
        Me.txtChange.Location = New System.Drawing.Point(72, 319)
        Me.txtChange.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChange.PlaceholderText = ""
        Me.txtChange.SelectedText = ""
        Me.txtChange.ShadowDecoration.BorderRadius = 10
        Me.txtChange.ShadowDecoration.Depth = 10
        Me.txtChange.ShadowDecoration.Enabled = True
        Me.txtChange.ShadowDecoration.Parent = Me.txtChange
        Me.txtChange.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 2, 8, 8)
        Me.txtChange.Size = New System.Drawing.Size(223, 36)
        Me.txtChange.TabIndex = 5
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Noto Sans Hebrew", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(151, 291)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(65, 22)
        Me.Guna2HtmlLabel3.TabIndex = 4
        Me.Guna2HtmlLabel3.Text = "CHANGE"
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.Transparent
        Me.btnAccept.BorderRadius = 15
        Me.btnAccept.CheckedState.Parent = Me.btnAccept
        Me.btnAccept.CustomImages.Parent = Me.btnAccept
        Me.btnAccept.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAccept.Font = New System.Drawing.Font("Noto Sans Hebrew", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.ForeColor = System.Drawing.Color.White
        Me.btnAccept.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnAccept.HoverState.Parent = Me.btnAccept
        Me.btnAccept.Location = New System.Drawing.Point(78, 384)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.ShadowDecoration.BorderRadius = 15
        Me.btnAccept.ShadowDecoration.Depth = 10
        Me.btnAccept.ShadowDecoration.Enabled = True
        Me.btnAccept.ShadowDecoration.Parent = Me.btnAccept
        Me.btnAccept.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 2, 8, 8)
        Me.btnAccept.Size = New System.Drawing.Size(211, 36)
        Me.btnAccept.TabIndex = 6
        Me.btnAccept.Text = "ACCEPT PAYMENT"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.LOGIN.My.Resources.Resources.Yellow_Abstract_Cooking_Fire_Free_Logo_4__removebg_preview3
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(62, -55)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(250, 250)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 49
        Me.Guna2PictureBox2.TabStop = False
        '
        'frmSettle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 479)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCash As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtChange As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAccept As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
End Class
