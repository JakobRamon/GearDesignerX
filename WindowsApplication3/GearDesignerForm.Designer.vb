<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GearDesignerForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InputTorque2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InputTorque1 = New System.Windows.Forms.TextBox()
        Me.InputRatio = New System.Windows.Forms.TextBox()
        Me.InputMaterial1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InputSigma1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.InputDistance = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.InputModul = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnGo = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnMatMgm = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblOverwriteName = New System.Windows.Forms.Label()
        Me.btnSaveDirectory = New System.Windows.Forms.Button()
        Me.tbSaveDirectory = New System.Windows.Forms.TextBox()
        Me.tbNewName = New System.Windows.Forms.TextBox()
        Me.cbSaveDirectory = New System.Windows.Forms.CheckBox()
        Me.cbOpen = New System.Windows.Forms.CheckBox()
        Me.cbOverwrite = New System.Windows.Forms.CheckBox()
        Me.cbSave = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.InputSigma2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.InputMaterial2 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.gearList = New System.Windows.Forms.ListView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.InputTorque2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.InputTorque1)
        Me.GroupBox1.Controls.Add(Me.InputRatio)
        Me.GroupBox1.Location = New System.Drawing.Point(321, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 51)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transmission"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Ratio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Output"
        '
        'InputTorque2
        '
        Me.InputTorque2.Location = New System.Drawing.Point(326, 19)
        Me.InputTorque2.Name = "InputTorque2"
        Me.InputTorque2.Size = New System.Drawing.Size(98, 20)
        Me.InputTorque2.TabIndex = 2
        Me.InputTorque2.Text = "50"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input"
        '
        'InputTorque1
        '
        Me.InputTorque1.Location = New System.Drawing.Point(52, 19)
        Me.InputTorque1.Name = "InputTorque1"
        Me.InputTorque1.Size = New System.Drawing.Size(91, 20)
        Me.InputTorque1.TabIndex = 0
        Me.InputTorque1.Text = "200"
        '
        'InputRatio
        '
        Me.InputRatio.Location = New System.Drawing.Point(216, 19)
        Me.InputRatio.Name = "InputRatio"
        Me.InputRatio.Size = New System.Drawing.Size(50, 20)
        Me.InputRatio.TabIndex = 1
        '
        'InputMaterial1
        '
        Me.InputMaterial1.FormattingEnabled = True
        Me.InputMaterial1.Location = New System.Drawing.Point(74, 19)
        Me.InputMaterial1.Name = "InputMaterial1"
        Me.InputMaterial1.Size = New System.Drawing.Size(121, 21)
        Me.InputMaterial1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Material"
        '
        'InputSigma1
        '
        Me.InputSigma1.Location = New System.Drawing.Point(74, 46)
        Me.InputSigma1.Name = "InputSigma1"
        Me.InputSigma1.ReadOnly = True
        Me.InputSigma1.Size = New System.Drawing.Size(65, 20)
        Me.InputSigma1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "σ"
        '
        'InputDistance
        '
        Me.InputDistance.Location = New System.Drawing.Point(78, 173)
        Me.InputDistance.Name = "InputDistance"
        Me.InputDistance.Size = New System.Drawing.Size(65, 20)
        Me.InputDistance.TabIndex = 0
        Me.InputDistance.Text = "200"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Distance"
        '
        'InputModul
        '
        Me.InputModul.Location = New System.Drawing.Point(302, 173)
        Me.InputModul.Name = "InputModul"
        Me.InputModul.Size = New System.Drawing.Size(65, 20)
        Me.InputModul.TabIndex = 1
        Me.InputModul.Text = "4"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(260, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Modul"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(149, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "mm"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(145, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "MPa"
        '
        'BtnGo
        '
        Me.BtnGo.Enabled = False
        Me.BtnGo.Location = New System.Drawing.Point(321, 491)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(106, 23)
        Me.BtnGo.TabIndex = 3
        Me.BtnGo.Text = "Generate Gear"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(433, 491)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(106, 23)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(373, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "mm"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Controls.Add(Me.InputDistance)
        Me.GroupBox3.Controls.Add(Me.InputModul)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(321, 158)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(446, 197)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Geometrie"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication3.My.Resources.Resources.picD
        Me.PictureBox1.Location = New System.Drawing.Point(23, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 151)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication3.My.Resources.Resources.picM
        Me.PictureBox3.Location = New System.Drawing.Point(263, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(178, 151)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.InputSigma1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.InputMaterial1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(321, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 82)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material Input Gear"
        '
        'BtnMatMgm
        '
        Me.BtnMatMgm.Location = New System.Drawing.Point(660, 491)
        Me.BtnMatMgm.Name = "BtnMatMgm"
        Me.BtnMatMgm.Size = New System.Drawing.Size(106, 23)
        Me.BtnMatMgm.TabIndex = 6
        Me.BtnMatMgm.Text = "Material Manager"
        Me.BtnMatMgm.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblOverwriteName)
        Me.GroupBox4.Controls.Add(Me.btnSaveDirectory)
        Me.GroupBox4.Controls.Add(Me.tbSaveDirectory)
        Me.GroupBox4.Controls.Add(Me.tbNewName)
        Me.GroupBox4.Controls.Add(Me.cbSaveDirectory)
        Me.GroupBox4.Controls.Add(Me.cbOpen)
        Me.GroupBox4.Controls.Add(Me.cbOverwrite)
        Me.GroupBox4.Controls.Add(Me.cbSave)
        Me.GroupBox4.Location = New System.Drawing.Point(321, 361)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(446, 124)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Files"
        '
        'lblOverwriteName
        '
        Me.lblOverwriteName.AutoSize = True
        Me.lblOverwriteName.Enabled = False
        Me.lblOverwriteName.Location = New System.Drawing.Point(156, 42)
        Me.lblOverwriteName.Name = "lblOverwriteName"
        Me.lblOverwriteName.Size = New System.Drawing.Size(110, 13)
        Me.lblOverwriteName.TabIndex = 27
        Me.lblOverwriteName.Text = "- no gearbox loaded - "
        '
        'btnSaveDirectory
        '
        Me.btnSaveDirectory.Enabled = False
        Me.btnSaveDirectory.Location = New System.Drawing.Point(371, 84)
        Me.btnSaveDirectory.Name = "btnSaveDirectory"
        Me.btnSaveDirectory.Size = New System.Drawing.Size(70, 23)
        Me.btnSaveDirectory.TabIndex = 26
        Me.btnSaveDirectory.Text = "change"
        Me.btnSaveDirectory.UseVisualStyleBackColor = True
        '
        'tbSaveDirectory
        '
        Me.tbSaveDirectory.Enabled = False
        Me.tbSaveDirectory.Location = New System.Drawing.Point(208, 84)
        Me.tbSaveDirectory.Name = "tbSaveDirectory"
        Me.tbSaveDirectory.Size = New System.Drawing.Size(156, 20)
        Me.tbSaveDirectory.TabIndex = 24
        '
        'tbNewName
        '
        Me.tbNewName.Location = New System.Drawing.Point(285, 16)
        Me.tbNewName.Name = "tbNewName"
        Me.tbNewName.Size = New System.Drawing.Size(156, 20)
        Me.tbNewName.TabIndex = 24
        Me.tbNewName.Text = "NewGear001"
        '
        'cbSaveDirectory
        '
        Me.cbSaveDirectory.AutoSize = True
        Me.cbSaveDirectory.Location = New System.Drawing.Point(14, 86)
        Me.cbSaveDirectory.Name = "cbSaveDirectory"
        Me.cbSaveDirectory.Size = New System.Drawing.Size(188, 17)
        Me.cbSaveDirectory.TabIndex = 25
        Me.cbSaveDirectory.Text = "Save files in the following directory"
        Me.cbSaveDirectory.UseVisualStyleBackColor = True
        '
        'cbOpen
        '
        Me.cbOpen.AutoSize = True
        Me.cbOpen.Checked = True
        Me.cbOpen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbOpen.Location = New System.Drawing.Point(14, 65)
        Me.cbOpen.Name = "cbOpen"
        Me.cbOpen.Size = New System.Drawing.Size(111, 17)
        Me.cbOpen.TabIndex = 25
        Me.cbOpen.Text = "open file in CATIA"
        Me.cbOpen.UseVisualStyleBackColor = True
        '
        'cbOverwrite
        '
        Me.cbOverwrite.AutoSize = True
        Me.cbOverwrite.Enabled = False
        Me.cbOverwrite.Location = New System.Drawing.Point(14, 42)
        Me.cbOverwrite.Name = "cbOverwrite"
        Me.cbOverwrite.Size = New System.Drawing.Size(147, 17)
        Me.cbOverwrite.TabIndex = 25
        Me.cbOverwrite.Text = "Overwrite loaded gearbox"
        Me.cbOverwrite.UseVisualStyleBackColor = True
        '
        'cbSave
        '
        Me.cbSave.AutoSize = True
        Me.cbSave.Location = New System.Drawing.Point(14, 19)
        Me.cbSave.Name = "cbSave"
        Me.cbSave.Size = New System.Drawing.Size(264, 17)
        Me.cbSave.TabIndex = 25
        Me.cbSave.Text = "Save in Gear Designer Catalogue under the name "
        Me.cbSave.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.InputSigma2)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.InputMaterial2)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Location = New System.Drawing.Point(548, 70)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(218, 82)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Material Output Gear"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Material"
        '
        'InputSigma2
        '
        Me.InputSigma2.Location = New System.Drawing.Point(74, 46)
        Me.InputSigma2.Name = "InputSigma2"
        Me.InputSigma2.ReadOnly = True
        Me.InputSigma2.Size = New System.Drawing.Size(65, 20)
        Me.InputSigma2.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(54, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "σ"
        '
        'InputMaterial2
        '
        Me.InputMaterial2.FormattingEnabled = True
        Me.InputMaterial2.Location = New System.Drawing.Point(74, 19)
        Me.InputMaterial2.Name = "InputMaterial2"
        Me.InputMaterial2.Size = New System.Drawing.Size(121, 21)
        Me.InputMaterial2.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(145, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "MPa"
        '
        'BtnLoad
        '
        Me.BtnLoad.Location = New System.Drawing.Point(7, 491)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(99, 23)
        Me.BtnLoad.TabIndex = 5
        Me.BtnLoad.Text = "Load"
        Me.BtnLoad.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(112, 491)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDelete.Size = New System.Drawing.Size(99, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.HelpVisible = False
        Me.PropertyGrid1.Location = New System.Drawing.Point(7, 322)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.PropertySort = System.Windows.Forms.PropertySort.NoSort
        Me.PropertyGrid1.Size = New System.Drawing.Size(308, 163)
        Me.PropertyGrid1.TabIndex = 12
        Me.PropertyGrid1.ToolbarVisible = False
        '
        'gearList
        '
        Me.gearList.Location = New System.Drawing.Point(7, 28)
        Me.gearList.Name = "gearList"
        Me.gearList.Size = New System.Drawing.Size(308, 288)
        Me.gearList.TabIndex = 13
        Me.gearList.UseCompatibleStateImageBehavior = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Gearbox library"
        '
        'GearDesignerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 526)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.gearList)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnMatMgm)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.BtnLoad)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnGo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GearDesignerForm"
        Me.Text = "Gear Designer 0.2 alpha"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InputTorque1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents InputTorque2 As System.Windows.Forms.TextBox
    Friend WithEvents InputRatio As System.Windows.Forms.TextBox
    Friend WithEvents InputMaterial1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents InputSigma1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents InputDistance As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents InputModul As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnGo As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnMatMgm As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tbNewName As System.Windows.Forms.TextBox
    Friend WithEvents cbSaveDirectory As System.Windows.Forms.CheckBox
    Friend WithEvents cbOpen As System.Windows.Forms.CheckBox
    Friend WithEvents cbSave As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents InputSigma2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents InputMaterial2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BtnLoad As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents gearList As System.Windows.Forms.ListView
    Friend WithEvents btnSaveDirectory As System.Windows.Forms.Button
    Friend WithEvents tbSaveDirectory As System.Windows.Forms.TextBox
    Friend WithEvents cbOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents lblOverwriteName As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
