<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTotal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRemove = New System.Windows.Forms.DataGridViewImageColumn()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTransNo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTable = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblRole = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnStart = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEnd = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnNewOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSettle = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTable = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button8 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotal.Font = New System.Drawing.Font("Noto Sans Hebrew", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotal.Location = New System.Drawing.Point(515, 19)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(35, 24)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "0.00"
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 30
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.colRemove})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(934, -1)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(390, 707)
        Me.Guna2DataGridView1.TabIndex = 9
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        Me.Column1.Width = 46
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.HeaderText = "DESCRIPTION"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 61
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column4.HeaderText = "Order"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 68
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 61
        '
        'colRemove
        '
        Me.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colRemove.HeaderText = ""
        Me.colRemove.Image = Global.LOGIN.My.Resources.Resources.icons8_rectangle_48__4_
        Me.colRemove.Name = "colRemove"
        Me.colRemove.Width = 5
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(195, 57)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(748, 650)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'lblTransNo
        '
        Me.lblTransNo.BackColor = System.Drawing.Color.Transparent
        Me.lblTransNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransNo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTransNo.Location = New System.Drawing.Point(126, 36)
        Me.lblTransNo.Name = "lblTransNo"
        Me.lblTransNo.Size = New System.Drawing.Size(3, 2)
        Me.lblTransNo.TabIndex = 2
        Me.lblTransNo.Text = Nothing
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Noto Sans Hebrew", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(157, 29)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(60, 19)
        Me.Guna2HtmlLabel3.TabIndex = 11
        Me.Guna2HtmlLabel3.Text = "Table No."
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Noto Sans Hebrew", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(157, 12)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(98, 19)
        Me.Guna2HtmlLabel4.TabIndex = 12
        Me.Guna2HtmlLabel4.Text = "Transaction No."
        '
        'lblTable
        '
        Me.lblTable.BackColor = System.Drawing.Color.Transparent
        Me.lblTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTable.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTable.Location = New System.Drawing.Point(126, 57)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(3, 2)
        Me.lblTable.TabIndex = 13
        Me.lblTable.Text = Nothing
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblName.Font = New System.Drawing.Font("Noto Sans Hebrew", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(15, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(42, 19)
        Me.lblName.TabIndex = 15
        Me.lblName.Text = "Name:"
        '
        'lblRole
        '
        Me.lblRole.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblRole.Font = New System.Drawing.Font("Noto Sans Hebrew", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.DimGray
        Me.lblRole.Location = New System.Drawing.Point(15, 29)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(33, 19)
        Me.lblRole.TabIndex = 14
        Me.lblRole.Text = "Role: "
        '
        'btnStart
        '
        Me.btnStart.BorderRadius = 10
        Me.btnStart.CheckedState.Parent = Me.btnStart
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.CustomImages.Parent = Me.btnStart
        Me.btnStart.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.HoverState.Parent = Me.btnStart
        Me.btnStart.Location = New System.Drawing.Point(3, 422)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.ShadowDecoration.Parent = Me.btnStart
        Me.btnStart.Size = New System.Drawing.Size(192, 39)
        Me.btnStart.TabIndex = 16
        Me.btnStart.Text = "[ START OF THE DAY ]"
        '
        'btnEnd
        '
        Me.btnEnd.BorderRadius = 10
        Me.btnEnd.CheckedState.Parent = Me.btnEnd
        Me.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnd.CustomImages.Parent = Me.btnEnd
        Me.btnEnd.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnEnd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnd.ForeColor = System.Drawing.Color.White
        Me.btnEnd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnd.HoverState.Parent = Me.btnEnd
        Me.btnEnd.Location = New System.Drawing.Point(2, 464)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.ShadowDecoration.Parent = Me.btnEnd
        Me.btnEnd.Size = New System.Drawing.Size(192, 39)
        Me.btnEnd.TabIndex = 17
        Me.btnEnd.Text = "[ END OF THE DAY ]"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Black
        Me.Guna2Panel2.Controls.Add(Me.btnStart)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel2.Controls.Add(Me.btnEnd)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.Controls.Add(Me.btnNewOrder)
        Me.Guna2Panel2.Controls.Add(Me.btnSettle)
        Me.Guna2Panel2.Controls.Add(Me.btnCancel)
        Me.Guna2Panel2.Controls.Add(Me.btnTable)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button8)
        Me.Guna2Panel2.Location = New System.Drawing.Point(-3, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(194, 707)
        Me.Guna2Panel2.TabIndex = 18
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderRadius = 50
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel4.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel4.Location = New System.Drawing.Point(1, 621)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.BorderRadius = 0
        Me.Guna2Panel4.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(193, 86)
        Me.Guna2Panel4.TabIndex = 20
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(97, 21)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(12, 18)
        Me.Guna2HtmlLabel7.TabIndex = 6
        Me.Guna2HtmlLabel7.Text = "X"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Silver
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(155, 60)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(26, 11)
        Me.Guna2HtmlLabel6.TabIndex = 5
        Me.Guna2HtmlLabel6.Text = "Legal"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Silver
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(92, 60)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(36, 11)
        Me.Guna2HtmlLabel5.TabIndex = 4
        Me.Guna2HtmlLabel5.Text = "Support"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Silver
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(17, 60)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(55, 11)
        Me.Guna2HtmlLabel2.TabIndex = 3
        Me.Guna2HtmlLabel2.Text = "Help Center"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(115, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(50, 27)
        Me.Guna2HtmlLabel1.TabIndex = 2
        Me.Guna2HtmlLabel1.Text = "POS"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.LOGIN.My.Resources.Resources.Yellow_Abstract_Cooking_Fire_Free_Logo_1_1
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(12, -12)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(90, 90)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 1
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel3.Location = New System.Drawing.Point(1, -2)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(227, 87)
        Me.Guna2Panel3.TabIndex = 19
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.LOGIN.My.Resources.Resources.Yellow_Abstract_Cooking_Fire_Free_Logo_1_2
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(8, -33)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(172, 172)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'btnNewOrder
        '
        Me.btnNewOrder.BorderRadius = 5
        Me.btnNewOrder.CheckedState.Parent = Me.btnNewOrder
        Me.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewOrder.CustomImages.Parent = Me.btnNewOrder
        Me.btnNewOrder.Enabled = False
        Me.btnNewOrder.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnNewOrder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewOrder.ForeColor = System.Drawing.Color.White
        Me.btnNewOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNewOrder.HoverState.Parent = Me.btnNewOrder
        Me.btnNewOrder.Image = Global.LOGIN.My.Resources.Resources.order_now
        Me.btnNewOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnNewOrder.Location = New System.Drawing.Point(1, 124)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.PressedColor = System.Drawing.Color.LightGray
        Me.btnNewOrder.ShadowDecoration.Color = System.Drawing.Color.IndianRed
        Me.btnNewOrder.ShadowDecoration.Depth = 100
        Me.btnNewOrder.ShadowDecoration.Parent = Me.btnNewOrder
        Me.btnNewOrder.Size = New System.Drawing.Size(192, 39)
        Me.btnNewOrder.TabIndex = 2
        Me.btnNewOrder.Text = "[ F1 - New Order ]"
        '
        'btnSettle
        '
        Me.btnSettle.BorderRadius = 5
        Me.btnSettle.CheckedState.Parent = Me.btnSettle
        Me.btnSettle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettle.CustomImages.Parent = Me.btnSettle
        Me.btnSettle.Enabled = False
        Me.btnSettle.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnSettle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSettle.ForeColor = System.Drawing.Color.White
        Me.btnSettle.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSettle.HoverState.Parent = Me.btnSettle
        Me.btnSettle.Image = Global.LOGIN.My.Resources.Resources.credit_card
        Me.btnSettle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSettle.Location = New System.Drawing.Point(2, 169)
        Me.btnSettle.Name = "btnSettle"
        Me.btnSettle.ShadowDecoration.Parent = Me.btnSettle
        Me.btnSettle.Size = New System.Drawing.Size(192, 39)
        Me.btnSettle.TabIndex = 3
        Me.btnSettle.Text = "[ F2 - Settle Payment ]"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 5
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Image = Global.LOGIN.My.Resources.Resources.wrong_parcel
        Me.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancel.Location = New System.Drawing.Point(2, 214)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(192, 39)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "[ F3 - Cancel Order ]"
        '
        'btnTable
        '
        Me.btnTable.BorderRadius = 5
        Me.btnTable.CheckedState.Parent = Me.btnTable
        Me.btnTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTable.CustomImages.Parent = Me.btnTable
        Me.btnTable.Enabled = False
        Me.btnTable.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnTable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTable.ForeColor = System.Drawing.Color.White
        Me.btnTable.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTable.HoverState.Parent = Me.btnTable
        Me.btnTable.Image = Global.LOGIN.My.Resources.Resources.business
        Me.btnTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTable.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnTable.Location = New System.Drawing.Point(1, 259)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.ShadowDecoration.Parent = Me.btnTable
        Me.btnTable.Size = New System.Drawing.Size(192, 39)
        Me.btnTable.TabIndex = 6
        Me.btnTable.Text = "[ F5 - Manage Table ]"
        '
        'Guna2Button8
        '
        Me.Guna2Button8.BorderRadius = 10
        Me.Guna2Button8.CheckedState.Parent = Me.Guna2Button8
        Me.Guna2Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button8.CustomImages.Parent = Me.Guna2Button8
        Me.Guna2Button8.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Guna2Button8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button8.ForeColor = System.Drawing.Color.White
        Me.Guna2Button8.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button8.HoverState.Parent = Me.Guna2Button8
        Me.Guna2Button8.Image = Global.LOGIN.My.Resources.Resources.logout
        Me.Guna2Button8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button8.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button8.Location = New System.Drawing.Point(1, 578)
        Me.Guna2Button8.Name = "Guna2Button8"
        Me.Guna2Button8.ShadowDecoration.Parent = Me.Guna2Button8
        Me.Guna2Button8.Size = New System.Drawing.Size(192, 39)
        Me.Guna2Button8.TabIndex = 10
        Me.Guna2Button8.Text = "[ F7- Log Out ]"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.Controls.Add(Me.lblName)
        Me.Guna2Panel1.Controls.Add(Me.lblTotal)
        Me.Guna2Panel1.Controls.Add(Me.lblRole)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel6)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel7)
        Me.Guna2Panel1.Location = New System.Drawing.Point(185, -2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(760, 61)
        Me.Guna2Panel1.TabIndex = 19
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Noto Sans Hebrew", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(443, 19)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(59, 22)
        Me.Guna2HtmlLabel8.TabIndex = 22
        Me.Guna2HtmlLabel8.Text = "TOTAL :"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2Panel5.Location = New System.Drawing.Point(9, 4)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(139, 52)
        Me.Guna2Panel5.TabIndex = 20
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2Panel6.Location = New System.Drawing.Point(151, 4)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(282, 52)
        Me.Guna2Panel6.TabIndex = 21
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2Panel7.Location = New System.Drawing.Point(436, 4)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.ShadowDecoration.Parent = Me.Guna2Panel7
        Me.Guna2Panel7.Size = New System.Drawing.Size(309, 52)
        Me.Guna2Panel7.TabIndex = 22
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.LOGIN.My.Resources.Resources.icons8_rectangle_48__4_
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1323, 701)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.lblTransNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSettle As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTable As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblTotal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button8 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblTransNo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTable As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblRole As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEnd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents colRemove As DataGridViewImageColumn
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
