<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
    Inherits System.Windows.Forms.Form

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
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtCash = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnStart = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Noto Sans Hebrew", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 4)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(98, 24)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "Start of Day"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Noto Sans Hebrew", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(460, 4)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(67, 22)
        Me.Guna2HtmlLabel2.TabIndex = 4
        Me.Guna2HtmlLabel2.Text = "[ CLOSE ]"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Noto Sans Hebrew", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(19, 108)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(68, 20)
        Me.Guna2HtmlLabel3.TabIndex = 6
        Me.Guna2HtmlLabel3.Text = "Start Cash"
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
        Me.txtCash.Font = New System.Drawing.Font("Noto Sans Hebrew", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCash.HoverState.Parent = Me.txtCash
        Me.txtCash.Location = New System.Drawing.Point(93, 100)
        Me.txtCash.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCash.PlaceholderText = ""
        Me.txtCash.SelectedText = ""
        Me.txtCash.ShadowDecoration.BorderRadius = 10
        Me.txtCash.ShadowDecoration.Depth = 10
        Me.txtCash.ShadowDecoration.Enabled = True
        Me.txtCash.ShadowDecoration.Parent = Me.txtCash
        Me.txtCash.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 2, 8, 8)
        Me.txtCash.Size = New System.Drawing.Size(372, 39)
        Me.txtCash.TabIndex = 7
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BorderRadius = 10
        Me.btnStart.CheckedState.Parent = Me.btnStart
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.CustomImages.Parent = Me.btnStart
        Me.btnStart.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Noto Sans Hebrew", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.HoverState.Parent = Me.btnStart
        Me.btnStart.Location = New System.Drawing.Point(363, 143)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.ShadowDecoration.BorderRadius = 10
        Me.btnStart.ShadowDecoration.Depth = 10
        Me.btnStart.ShadowDecoration.Enabled = True
        Me.btnStart.ShadowDecoration.Parent = Me.btnStart
        Me.btnStart.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 2, 8, 8)
        Me.btnStart.Size = New System.Drawing.Size(102, 33)
        Me.btnStart.TabIndex = 15
        Me.btnStart.Text = "Start"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.LOGIN.My.Resources.Resources.Yellow_Abstract_Cooking_Fire_Free_Logo_4__removebg_preview
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(162, -50)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(233, 233)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 48
        Me.Guna2PictureBox2.TabStop = False
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 201)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtCash As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
End Class
