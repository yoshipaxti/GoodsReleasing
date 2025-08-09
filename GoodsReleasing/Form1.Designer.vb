<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.BtnReset = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSDepartment = New System.Windows.Forms.TextBox()
        Me.TxtSName = New System.Windows.Forms.TextBox()
        Me.TxtSId = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DtView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOfRecievedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OTCBagPackDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalendarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShirtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheeseballDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CannedGoodsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BonusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OthersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleasingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GoodsReleasingDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GoodsReleasingDataSet = New GoodsReleasing.GoodsReleasingDataSet()
        Me.ReleasingTableAdapter = New GoodsReleasing.GoodsReleasingDataSetTableAdapters.ReleasingTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DtView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReleasingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GoodsReleasingDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GoodsReleasingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightGreen
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripButton1, Me.BtnReset})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(840, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNew
        '
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(59, 24)
        Me.BtnNew.Text = "New"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(78, 24)
        Me.ToolStripButton1.Text = "Refresh"
        '
        'BtnReset
        '
        Me.BtnReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnReset.Image = CType(resources.GetObject("BtnReset.Image"), System.Drawing.Image)
        Me.BtnReset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(65, 24)
        Me.BtnReset.Text = "Reset"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtSDepartment)
        Me.Panel1.Controls.Add(Me.TxtSName)
        Me.Panel1.Controls.Add(Me.TxtSId)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 632)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 536)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(186, 90)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Percentage of Recieved Goods"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 39)
        Me.Label7.TabIndex = 9
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 421)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Overall Monitoring"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(103, 440)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(90, 90)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Unrecieved "
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 39)
        Me.Label6.TabIndex = 9
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 440)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(90, 90)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recieved"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 39)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = " "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Department:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID:"
        '
        'TxtSDepartment
        '
        Me.TxtSDepartment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSDepartment.Location = New System.Drawing.Point(11, 129)
        Me.TxtSDepartment.Name = "TxtSDepartment"
        Me.TxtSDepartment.Size = New System.Drawing.Size(185, 24)
        Me.TxtSDepartment.TabIndex = 3
        '
        'TxtSName
        '
        Me.TxtSName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSName.Location = New System.Drawing.Point(11, 78)
        Me.TxtSName.Name = "TxtSName"
        Me.TxtSName.Size = New System.Drawing.Size(185, 24)
        Me.TxtSName.TabIndex = 2
        '
        'TxtSId
        '
        Me.TxtSId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSId.Location = New System.Drawing.Point(11, 29)
        Me.TxtSId.Name = "TxtSId"
        Me.TxtSId.Size = New System.Drawing.Size(185, 24)
        Me.TxtSId.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DtView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(203, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 632)
        Me.Panel2.TabIndex = 2
        '
        'DtView
        '
        Me.DtView.AllowUserToAddRows = False
        Me.DtView.AllowUserToDeleteRows = False
        Me.DtView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        Me.DtView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtView.AutoGenerateColumns = False
        Me.DtView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DtView.BackgroundColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.TimeOfRecievedDataGridViewTextBoxColumn, Me.OTCBagPackDataGridViewTextBoxColumn, Me.HamDataGridViewTextBoxColumn, Me.CalendarDataGridViewTextBoxColumn, Me.ShirtDataGridViewTextBoxColumn, Me.CheeseballDataGridViewTextBoxColumn, Me.CannedGoodsDataGridViewTextBoxColumn, Me.BonusDataGridViewTextBoxColumn, Me.OthersDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn})
        Me.DtView.DataSource = Me.ReleasingBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtView.DefaultCellStyle = DataGridViewCellStyle3
        Me.DtView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DtView.Location = New System.Drawing.Point(0, 0)
        Me.DtView.Name = "DtView"
        Me.DtView.ReadOnly = True
        Me.DtView.Size = New System.Drawing.Size(637, 632)
        Me.DtView.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 47
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 73
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PositionDataGridViewTextBoxColumn.Width = 87
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentDataGridViewTextBoxColumn.Width = 110
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 75
        '
        'TimeOfRecievedDataGridViewTextBoxColumn
        '
        Me.TimeOfRecievedDataGridViewTextBoxColumn.DataPropertyName = "Time of Recieved"
        Me.TimeOfRecievedDataGridViewTextBoxColumn.HeaderText = "Time of Recieved"
        Me.TimeOfRecievedDataGridViewTextBoxColumn.Name = "TimeOfRecievedDataGridViewTextBoxColumn"
        Me.TimeOfRecievedDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeOfRecievedDataGridViewTextBoxColumn.Width = 135
        '
        'OTCBagPackDataGridViewTextBoxColumn
        '
        Me.OTCBagPackDataGridViewTextBoxColumn.DataPropertyName = "OTC Bag pack"
        Me.OTCBagPackDataGridViewTextBoxColumn.HeaderText = "OTC Bag pack"
        Me.OTCBagPackDataGridViewTextBoxColumn.Name = "OTCBagPackDataGridViewTextBoxColumn"
        Me.OTCBagPackDataGridViewTextBoxColumn.ReadOnly = True
        Me.OTCBagPackDataGridViewTextBoxColumn.Width = 91
        '
        'HamDataGridViewTextBoxColumn
        '
        Me.HamDataGridViewTextBoxColumn.DataPropertyName = "Ham"
        Me.HamDataGridViewTextBoxColumn.HeaderText = "Ham"
        Me.HamDataGridViewTextBoxColumn.Name = "HamDataGridViewTextBoxColumn"
        Me.HamDataGridViewTextBoxColumn.ReadOnly = True
        Me.HamDataGridViewTextBoxColumn.Width = 65
        '
        'CalendarDataGridViewTextBoxColumn
        '
        Me.CalendarDataGridViewTextBoxColumn.DataPropertyName = "Calendar"
        Me.CalendarDataGridViewTextBoxColumn.HeaderText = "Calendar"
        Me.CalendarDataGridViewTextBoxColumn.Name = "CalendarDataGridViewTextBoxColumn"
        Me.CalendarDataGridViewTextBoxColumn.ReadOnly = True
        Me.CalendarDataGridViewTextBoxColumn.Width = 92
        '
        'ShirtDataGridViewTextBoxColumn
        '
        Me.ShirtDataGridViewTextBoxColumn.DataPropertyName = "Shirt"
        Me.ShirtDataGridViewTextBoxColumn.HeaderText = "Shirt"
        Me.ShirtDataGridViewTextBoxColumn.Name = "ShirtDataGridViewTextBoxColumn"
        Me.ShirtDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShirtDataGridViewTextBoxColumn.Width = 63
        '
        'CheeseballDataGridViewTextBoxColumn
        '
        Me.CheeseballDataGridViewTextBoxColumn.DataPropertyName = "Cheeseball"
        Me.CheeseballDataGridViewTextBoxColumn.HeaderText = "Cheeseball"
        Me.CheeseballDataGridViewTextBoxColumn.Name = "CheeseballDataGridViewTextBoxColumn"
        Me.CheeseballDataGridViewTextBoxColumn.ReadOnly = True
        Me.CheeseballDataGridViewTextBoxColumn.Width = 106
        '
        'CannedGoodsDataGridViewTextBoxColumn
        '
        Me.CannedGoodsDataGridViewTextBoxColumn.DataPropertyName = "Canned Goods"
        Me.CannedGoodsDataGridViewTextBoxColumn.HeaderText = "Canned Goods"
        Me.CannedGoodsDataGridViewTextBoxColumn.Name = "CannedGoodsDataGridViewTextBoxColumn"
        Me.CannedGoodsDataGridViewTextBoxColumn.ReadOnly = True
        Me.CannedGoodsDataGridViewTextBoxColumn.Width = 123
        '
        'BonusDataGridViewTextBoxColumn
        '
        Me.BonusDataGridViewTextBoxColumn.DataPropertyName = "Bonus"
        Me.BonusDataGridViewTextBoxColumn.HeaderText = "Bonus"
        Me.BonusDataGridViewTextBoxColumn.Name = "BonusDataGridViewTextBoxColumn"
        Me.BonusDataGridViewTextBoxColumn.ReadOnly = True
        Me.BonusDataGridViewTextBoxColumn.Width = 76
        '
        'OthersDataGridViewTextBoxColumn
        '
        Me.OthersDataGridViewTextBoxColumn.DataPropertyName = "Others"
        Me.OthersDataGridViewTextBoxColumn.HeaderText = "Others"
        Me.OthersDataGridViewTextBoxColumn.Name = "OthersDataGridViewTextBoxColumn"
        Me.OthersDataGridViewTextBoxColumn.ReadOnly = True
        Me.OthersDataGridViewTextBoxColumn.Width = 78
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        Me.RemarksDataGridViewTextBoxColumn.ReadOnly = True
        Me.RemarksDataGridViewTextBoxColumn.Width = 94
        '
        'ReleasingBindingSource
        '
        Me.ReleasingBindingSource.DataMember = "Releasing"
        Me.ReleasingBindingSource.DataSource = Me.GoodsReleasingDataSetBindingSource
        '
        'GoodsReleasingDataSetBindingSource
        '
        Me.GoodsReleasingDataSetBindingSource.DataSource = Me.GoodsReleasingDataSet
        Me.GoodsReleasingDataSetBindingSource.Position = 0
        '
        'GoodsReleasingDataSet
        '
        Me.GoodsReleasingDataSet.DataSetName = "GoodsReleasingDataSet"
        Me.GoodsReleasingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReleasingTableAdapter
        '
        Me.ReleasingTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 659)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DtView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReleasingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GoodsReleasingDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GoodsReleasingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DtView As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSDepartment As TextBox
    Friend WithEvents TxtSName As TextBox
    Friend WithEvents TxtSId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnReset As ToolStripButton
    Friend WithEvents BtnNew As ToolStripButton
    Friend WithEvents GoodsReleasingDataSetBindingSource As BindingSource
    Friend WithEvents GoodsReleasingDataSet As GoodsReleasingDataSet
    Friend WithEvents ReleasingBindingSource As BindingSource
    Friend WithEvents ReleasingTableAdapter As GoodsReleasingDataSetTableAdapters.ReleasingTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeOfRecievedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OTCBagPackDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalendarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShirtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheeseballDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CannedGoodsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BonusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OthersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
