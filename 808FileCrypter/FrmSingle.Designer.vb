<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSingle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSingle))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMainFile = New System.Windows.Forms.TextBox()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDest = New System.Windows.Forms.TextBox()
        Me.BtnSelectDest = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmbFormat = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPackageCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSelectDemo = New System.Windows.Forms.Button()
        Me.TxtDemoPath = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PackageName = New System.Windows.Forms.TextBox()
        Me.lblversion = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtMainFile)
        Me.GroupBox1.Controls.Add(Me.BtnSelect)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(777, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مرحله 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Location = New System.Drawing.Point(587, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(187, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "فایل مورد نظر خود را انتخاب کنید:"
        '
        'TxtMainFile
        '
        Me.TxtMainFile.Enabled = False
        Me.TxtMainFile.Location = New System.Drawing.Point(142, 57)
        Me.TxtMainFile.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.TxtMainFile.Multiline = True
        Me.TxtMainFile.Name = "TxtMainFile"
        Me.TxtMainFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMainFile.Size = New System.Drawing.Size(509, 30)
        Me.TxtMainFile.TabIndex = 0
        '
        'BtnSelect
        '
        Me.BtnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelect.ForeColor = System.Drawing.Color.White
        Me.BtnSelect.Location = New System.Drawing.Point(6, 57)
        Me.BtnSelect.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(137, 30)
        Me.BtnSelect.TabIndex = 1
        Me.BtnSelect.Text = "انتخاب"
        Me.BtnSelect.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDest)
        Me.GroupBox2.Controls.Add(Me.BtnSelectDest)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 105)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(777, 110)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "مرحله 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(563, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(211, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "مکان ذخیره سازی فایل را انتخاب کنید:"
        '
        'txtDest
        '
        Me.txtDest.Enabled = False
        Me.txtDest.Location = New System.Drawing.Point(142, 59)
        Me.txtDest.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtDest.Multiline = True
        Me.txtDest.Name = "txtDest"
        Me.txtDest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDest.Size = New System.Drawing.Size(509, 30)
        Me.txtDest.TabIndex = 0
        '
        'BtnSelectDest
        '
        Me.BtnSelectDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSelectDest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnSelectDest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnSelectDest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnSelectDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectDest.ForeColor = System.Drawing.Color.White
        Me.BtnSelectDest.Location = New System.Drawing.Point(6, 59)
        Me.BtnSelectDest.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.BtnSelectDest.Name = "BtnSelectDest"
        Me.BtnSelectDest.Size = New System.Drawing.Size(137, 30)
        Me.BtnSelectDest.TabIndex = 1
        Me.BtnSelectDest.Text = "انتخاب"
        Me.BtnSelectDest.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmbFormat)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 215)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(777, 71)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "مرحله 3"
        '
        'CmbFormat
        '
        Me.CmbFormat.FormattingEnabled = True
        Me.CmbFormat.Items.AddRange(New Object() {"Video (MP4, ...)", "Book (PDF)"})
        Me.CmbFormat.Location = New System.Drawing.Point(6, 26)
        Me.CmbFormat.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CmbFormat.Name = "CmbFormat"
        Me.CmbFormat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbFormat.Size = New System.Drawing.Size(227, 30)
        Me.CmbFormat.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Location = New System.Drawing.Point(578, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(196, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "فرمت فایل مورد نظر را انتخاب کنید:"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("IRANSans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(6, 468)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(198, 35)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "ذخیره"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TxtPackageCode)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.BtnSelectDemo)
        Me.GroupBox4.Controls.Add(Me.TxtDemoPath)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.PackageName)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 286)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox4.Size = New System.Drawing.Size(777, 172)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "مرحله 4: تنظیمات برنامه"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(717, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 22)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "کد پکیج:"
        '
        'TxtPackageCode
        '
        Me.TxtPackageCode.ForeColor = System.Drawing.Color.Black
        Me.TxtPackageCode.Location = New System.Drawing.Point(6, 62)
        Me.TxtPackageCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPackageCode.Name = "TxtPackageCode"
        Me.TxtPackageCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPackageCode.Size = New System.Drawing.Size(227, 30)
        Me.TxtPackageCode.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("IRANSans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(110, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(661, 27)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "قفل هایی که با یک کد پکیج یکسان قفل شوند بدون نیاز به فعال سازی دوباره در سیستم ک" &
    "اربر فعال خواهند شد."
        Me.Label5.UseCompatibleTextRendering = True
        '
        'BtnSelectDemo
        '
        Me.BtnSelectDemo.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSelectDemo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnSelectDemo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnSelectDemo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnSelectDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectDemo.ForeColor = System.Drawing.Color.White
        Me.BtnSelectDemo.Location = New System.Drawing.Point(6, 129)
        Me.BtnSelectDemo.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.BtnSelectDemo.Name = "BtnSelectDemo"
        Me.BtnSelectDemo.Size = New System.Drawing.Size(137, 30)
        Me.BtnSelectDemo.TabIndex = 3
        Me.BtnSelectDemo.Text = "انتخاب دمو"
        Me.BtnSelectDemo.UseVisualStyleBackColor = False
        '
        'TxtDemoPath
        '
        Me.TxtDemoPath.Enabled = False
        Me.TxtDemoPath.ForeColor = System.Drawing.Color.Black
        Me.TxtDemoPath.Location = New System.Drawing.Point(142, 129)
        Me.TxtDemoPath.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDemoPath.Multiline = True
        Me.TxtDemoPath.Name = "TxtDemoPath"
        Me.TxtDemoPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDemoPath.Size = New System.Drawing.Size(509, 30)
        Me.TxtDemoPath.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Location = New System.Drawing.Point(711, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 22)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "اسم پکیج:"
        '
        'PackageName
        '
        Me.PackageName.ForeColor = System.Drawing.Color.Silver
        Me.PackageName.Location = New System.Drawing.Point(6, 24)
        Me.PackageName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PackageName.Name = "PackageName"
        Me.PackageName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PackageName.Size = New System.Drawing.Size(645, 30)
        Me.PackageName.TabIndex = 0
        Me.PackageName.Text = "اسم کامل پکیج"
        '
        'lblversion
        '
        Me.lblversion.AutoSize = True
        Me.lblversion.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblversion.Location = New System.Drawing.Point(745, 490)
        Me.lblversion.Name = "lblversion"
        Me.lblversion.Size = New System.Drawing.Size(23, 13)
        Me.lblversion.TabIndex = 29
        Me.lblversion.Text = "2.0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(697, 490)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "version"
        '
        'FrmSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(777, 512)
        Me.Controls.Add(Me.lblversion)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("IRANSans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "FrmSingle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "808 Single File Crypter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMainFile As TextBox
    Friend WithEvents BtnSelect As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDest As TextBox
    Friend WithEvents BtnSelectDest As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmbFormat As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PackageName As TextBox
    Friend WithEvents BtnSelectDemo As Button
    Friend WithEvents TxtDemoPath As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPackageCode As TextBox
    Friend WithEvents lblversion As Label
    Friend WithEvents Label11 As Label
End Class
