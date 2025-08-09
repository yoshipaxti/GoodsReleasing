<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sform
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkBonus = New System.Windows.Forms.CheckBox()
        Me.ChkOthers = New System.Windows.Forms.CheckBox()
        Me.ChkCannedGoods = New System.Windows.Forms.CheckBox()
        Me.ChkBag = New System.Windows.Forms.CheckBox()
        Me.ChkCheese = New System.Windows.Forms.CheckBox()
        Me.ChkShirt = New System.Windows.Forms.CheckBox()
        Me.ChkCalendar = New System.Windows.Forms.CheckBox()
        Me.ChkHam = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtRemarks = New System.Windows.Forms.TextBox()
        Me.TxtTime = New System.Windows.Forms.TextBox()
        Me.TxtStatus = New System.Windows.Forms.ComboBox()
        Me.TxtDepartment = New System.Windows.Forms.TextBox()
        Me.TxtPosition = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkBonus)
        Me.GroupBox1.Controls.Add(Me.ChkOthers)
        Me.GroupBox1.Controls.Add(Me.ChkCannedGoods)
        Me.GroupBox1.Controls.Add(Me.ChkBag)
        Me.GroupBox1.Controls.Add(Me.ChkCheese)
        Me.GroupBox1.Controls.Add(Me.ChkShirt)
        Me.GroupBox1.Controls.Add(Me.ChkCalendar)
        Me.GroupBox1.Controls.Add(Me.ChkHam)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.TxtRemarks)
        Me.GroupBox1.Controls.Add(Me.TxtTime)
        Me.GroupBox1.Controls.Add(Me.TxtStatus)
        Me.GroupBox1.Controls.Add(Me.TxtDepartment)
        Me.GroupBox1.Controls.Add(Me.TxtPosition)
        Me.GroupBox1.Controls.Add(Me.TxtName)
        Me.GroupBox1.Controls.Add(Me.TxtID)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 415)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Details"
        '
        'ChkBonus
        '
        Me.ChkBonus.AutoSize = True
        Me.ChkBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBonus.Location = New System.Drawing.Point(137, 246)
        Me.ChkBonus.Name = "ChkBonus"
        Me.ChkBonus.Size = New System.Drawing.Size(61, 19)
        Me.ChkBonus.TabIndex = 19
        Me.ChkBonus.Text = "Bonus"
        Me.ChkBonus.UseVisualStyleBackColor = True
        '
        'ChkOthers
        '
        Me.ChkOthers.AutoSize = True
        Me.ChkOthers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkOthers.Location = New System.Drawing.Point(247, 248)
        Me.ChkOthers.Name = "ChkOthers"
        Me.ChkOthers.Size = New System.Drawing.Size(62, 19)
        Me.ChkOthers.TabIndex = 18
        Me.ChkOthers.Text = "Others"
        Me.ChkOthers.UseVisualStyleBackColor = True
        '
        'ChkCannedGoods
        '
        Me.ChkCannedGoods.AutoSize = True
        Me.ChkCannedGoods.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCannedGoods.Location = New System.Drawing.Point(247, 225)
        Me.ChkCannedGoods.Name = "ChkCannedGoods"
        Me.ChkCannedGoods.Size = New System.Drawing.Size(108, 19)
        Me.ChkCannedGoods.TabIndex = 17
        Me.ChkCannedGoods.Text = "Canned Goods"
        Me.ChkCannedGoods.UseVisualStyleBackColor = True
        '
        'ChkBag
        '
        Me.ChkBag.AutoSize = True
        Me.ChkBag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBag.Location = New System.Drawing.Point(137, 179)
        Me.ChkBag.Name = "ChkBag"
        Me.ChkBag.Size = New System.Drawing.Size(105, 19)
        Me.ChkBag.TabIndex = 1
        Me.ChkBag.Text = "OTC Bag Pack"
        Me.ChkBag.UseVisualStyleBackColor = True
        '
        'ChkCheese
        '
        Me.ChkCheese.AutoSize = True
        Me.ChkCheese.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCheese.Location = New System.Drawing.Point(137, 225)
        Me.ChkCheese.Name = "ChkCheese"
        Me.ChkCheese.Size = New System.Drawing.Size(88, 19)
        Me.ChkCheese.TabIndex = 16
        Me.ChkCheese.Text = "Cheesedall"
        Me.ChkCheese.UseVisualStyleBackColor = True
        '
        'ChkShirt
        '
        Me.ChkShirt.AutoSize = True
        Me.ChkShirt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShirt.Location = New System.Drawing.Point(247, 202)
        Me.ChkShirt.Name = "ChkShirt"
        Me.ChkShirt.Size = New System.Drawing.Size(62, 19)
        Me.ChkShirt.TabIndex = 15
        Me.ChkShirt.Text = "T-Shirt"
        Me.ChkShirt.UseVisualStyleBackColor = True
        '
        'ChkCalendar
        '
        Me.ChkCalendar.AutoSize = True
        Me.ChkCalendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCalendar.Location = New System.Drawing.Point(137, 202)
        Me.ChkCalendar.Name = "ChkCalendar"
        Me.ChkCalendar.Size = New System.Drawing.Size(76, 19)
        Me.ChkCalendar.TabIndex = 14
        Me.ChkCalendar.Text = "Calendar"
        Me.ChkCalendar.UseVisualStyleBackColor = True
        '
        'ChkHam
        '
        Me.ChkHam.AutoSize = True
        Me.ChkHam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHam.Location = New System.Drawing.Point(247, 179)
        Me.ChkHam.Name = "ChkHam"
        Me.ChkHam.Size = New System.Drawing.Size(53, 19)
        Me.ChkHam.TabIndex = 13
        Me.ChkHam.Text = "Ham"
        Me.ChkHam.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(61, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Remarks:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Time of Recieved:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(77, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Status:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Department:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Position:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID:"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(247, 372)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemarks.Location = New System.Drawing.Point(135, 301)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(187, 65)
        Me.TxtRemarks.TabIndex = 6
        '
        'TxtTime
        '
        Me.TxtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTime.Location = New System.Drawing.Point(135, 271)
        Me.TxtTime.Name = "TxtTime"
        Me.TxtTime.ReadOnly = True
        Me.TxtTime.Size = New System.Drawing.Size(187, 24)
        Me.TxtTime.TabIndex = 5
        '
        'TxtStatus
        '
        Me.TxtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStatus.FormattingEnabled = True
        Me.TxtStatus.Items.AddRange(New Object() {"Recieved", "Incomplete"})
        Me.TxtStatus.Location = New System.Drawing.Point(135, 149)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(187, 26)
        Me.TxtStatus.TabIndex = 4
        '
        'TxtDepartment
        '
        Me.TxtDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepartment.Location = New System.Drawing.Point(135, 119)
        Me.TxtDepartment.Name = "TxtDepartment"
        Me.TxtDepartment.Size = New System.Drawing.Size(187, 24)
        Me.TxtDepartment.TabIndex = 3
        '
        'TxtPosition
        '
        Me.TxtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPosition.Location = New System.Drawing.Point(135, 89)
        Me.TxtPosition.Name = "TxtPosition"
        Me.TxtPosition.Size = New System.Drawing.Size(187, 24)
        Me.TxtPosition.TabIndex = 2
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(135, 59)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(187, 24)
        Me.TxtName.TabIndex = 1
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtID.Location = New System.Drawing.Point(135, 29)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(187, 24)
        Me.TxtID.TabIndex = 0
        '
        'Sform
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(424, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Sform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtDepartment As TextBox
    Friend WithEvents TxtPosition As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents TxtRemarks As TextBox
    Friend WithEvents TxtTime As TextBox
    Friend WithEvents TxtStatus As ComboBox
    Friend WithEvents ChkBag As CheckBox
    Friend WithEvents ChkCannedGoods As CheckBox
    Friend WithEvents ChkCheese As CheckBox
    Friend WithEvents ChkShirt As CheckBox
    Friend WithEvents ChkCalendar As CheckBox
    Friend WithEvents ChkHam As CheckBox
    Friend WithEvents ChkBonus As CheckBox
    Friend WithEvents ChkOthers As CheckBox
End Class
