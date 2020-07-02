<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.txtAssetCost = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblAssetCost = New MaterialSkin.Controls.MaterialLabel()
        Me.lblSalvageValue = New MaterialSkin.Controls.MaterialLabel()
        Me.txtSalvageValue = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lstUsefulLife = New System.Windows.Forms.ListBox()
        Me.btnDepreciation = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnExit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSYD = New System.Windows.Forms.TextBox()
        Me.lblSYD = New MaterialSkin.Controls.MaterialLabel()
        Me.txtDDB = New System.Windows.Forms.TextBox()
        Me.lblDDB = New MaterialSkin.Controls.MaterialLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAssetCost
        '
        Me.txtAssetCost.Depth = 0
        Me.txtAssetCost.Hint = ""
        Me.txtAssetCost.Location = New System.Drawing.Point(48, 139)
        Me.txtAssetCost.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAssetCost.Name = "txtAssetCost"
        Me.txtAssetCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAssetCost.SelectedText = ""
        Me.txtAssetCost.SelectionLength = 0
        Me.txtAssetCost.SelectionStart = 0
        Me.txtAssetCost.Size = New System.Drawing.Size(131, 23)
        Me.txtAssetCost.TabIndex = 0
        Me.txtAssetCost.UseSystemPasswordChar = False
        '
        'lblAssetCost
        '
        Me.lblAssetCost.AutoSize = True
        Me.lblAssetCost.Depth = 0
        Me.lblAssetCost.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblAssetCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAssetCost.Location = New System.Drawing.Point(44, 117)
        Me.lblAssetCost.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAssetCost.Name = "lblAssetCost"
        Me.lblAssetCost.Size = New System.Drawing.Size(84, 19)
        Me.lblAssetCost.TabIndex = 1
        Me.lblAssetCost.Text = "Asset Cost"
        '
        'lblSalvageValue
        '
        Me.lblSalvageValue.AutoSize = True
        Me.lblSalvageValue.Depth = 0
        Me.lblSalvageValue.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSalvageValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSalvageValue.Location = New System.Drawing.Point(181, 117)
        Me.lblSalvageValue.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSalvageValue.Name = "lblSalvageValue"
        Me.lblSalvageValue.Size = New System.Drawing.Size(103, 19)
        Me.lblSalvageValue.TabIndex = 3
        Me.lblSalvageValue.Text = "Salvage Value"
        '
        'txtSalvageValue
        '
        Me.txtSalvageValue.Depth = 0
        Me.txtSalvageValue.Hint = ""
        Me.txtSalvageValue.Location = New System.Drawing.Point(185, 139)
        Me.txtSalvageValue.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtSalvageValue.Name = "txtSalvageValue"
        Me.txtSalvageValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSalvageValue.SelectedText = ""
        Me.txtSalvageValue.SelectionLength = 0
        Me.txtSalvageValue.SelectionStart = 0
        Me.txtSalvageValue.Size = New System.Drawing.Size(131, 23)
        Me.txtSalvageValue.TabIndex = 2
        Me.txtSalvageValue.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(318, 117)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(103, 19)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "Salvage Value"
        '
        'lstUsefulLife
        '
        Me.lstUsefulLife.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUsefulLife.FormattingEnabled = True
        Me.lstUsefulLife.ItemHeight = 19
        Me.lstUsefulLife.Location = New System.Drawing.Point(322, 139)
        Me.lstUsefulLife.Name = "lstUsefulLife"
        Me.lstUsefulLife.Size = New System.Drawing.Size(130, 80)
        Me.lstUsefulLife.TabIndex = 5
        '
        'btnDepreciation
        '
        Me.btnDepreciation.Depth = 0
        Me.btnDepreciation.Location = New System.Drawing.Point(158, 228)
        Me.btnDepreciation.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDepreciation.Name = "btnDepreciation"
        Me.btnDepreciation.Primary = True
        Me.btnDepreciation.Size = New System.Drawing.Size(246, 36)
        Me.btnDepreciation.TabIndex = 6
        Me.btnDepreciation.Text = "Display Depreciation Schedules"
        Me.btnDepreciation.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExit.Depth = 0
        Me.btnExit.Location = New System.Drawing.Point(411, 228)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Primary = False
        Me.btnExit.Size = New System.Drawing.Size(41, 36)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSYD)
        Me.GroupBox1.Controls.Add(Me.lblSYD)
        Me.GroupBox1.Controls.Add(Me.txtDDB)
        Me.GroupBox1.Controls.Add(Me.lblDDB)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(48, 289)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 199)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Depreciation Schedules"
        '
        'txtSYD
        '
        Me.txtSYD.Location = New System.Drawing.Point(207, 60)
        Me.txtSYD.Multiline = True
        Me.txtSYD.Name = "txtSYD"
        Me.txtSYD.ReadOnly = True
        Me.txtSYD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSYD.Size = New System.Drawing.Size(180, 133)
        Me.txtSYD.TabIndex = 12
        '
        'lblSYD
        '
        Me.lblSYD.AutoSize = True
        Me.lblSYD.Depth = 0
        Me.lblSYD.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSYD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSYD.Location = New System.Drawing.Point(203, 38)
        Me.lblSYD.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSYD.Name = "lblSYD"
        Me.lblSYD.Size = New System.Drawing.Size(174, 19)
        Me.lblSYD.TabIndex = 11
        Me.lblSYD.Text = "Sum-of-the-years'  digits:"
        '
        'txtDDB
        '
        Me.txtDDB.Location = New System.Drawing.Point(21, 60)
        Me.txtDDB.Multiline = True
        Me.txtDDB.Name = "txtDDB"
        Me.txtDDB.ReadOnly = True
        Me.txtDDB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDDB.Size = New System.Drawing.Size(180, 133)
        Me.txtDDB.TabIndex = 10
        '
        'lblDDB
        '
        Me.lblDDB.AutoSize = True
        Me.lblDDB.Depth = 0
        Me.lblDDB.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblDDB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDDB.Location = New System.Drawing.Point(17, 38)
        Me.lblDDB.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDDB.Name = "lblDDB"
        Me.lblDDB.Size = New System.Drawing.Size(180, 19)
        Me.lblDDB.TabIndex = 9
        Me.lblDDB.Text = "Double-declining balance:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDepreciation)
        Me.Controls.Add(Me.lstUsefulLife)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.lblSalvageValue)
        Me.Controls.Add(Me.txtSalvageValue)
        Me.Controls.Add(Me.lblAssetCost)
        Me.Controls.Add(Me.txtAssetCost)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Canton Manufacturing Company"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAssetCost As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblAssetCost As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblSalvageValue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtSalvageValue As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lstUsefulLife As ListBox
    Friend WithEvents btnDepreciation As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnExit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDDB As TextBox
    Friend WithEvents lblDDB As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtSYD As TextBox
    Friend WithEvents lblSYD As MaterialSkin.Controls.MaterialLabel
End Class
