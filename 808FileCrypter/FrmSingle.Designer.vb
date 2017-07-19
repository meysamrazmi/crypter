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
        Me.BtnSelectDemo = New System.Windows.Forms.Button()
        Me.TxtDemoPath = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPackageCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtServerURI = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(658, 101)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مرحله 1: انتخاب فایل"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(189, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "فایل مورد نظر خود را انتخاب کنید:"
        '
        'TxtMainFile
        '
        Me.TxtMainFile.Enabled = False
        Me.TxtMainFile.Location = New System.Drawing.Point(24, 59)
        Me.TxtMainFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMainFile.Name = "TxtMainFile"
        Me.TxtMainFile.Size = New System.Drawing.Size(525, 23)
        Me.TxtMainFile.TabIndex = 3
        '
        'BtnSelect
        '
        Me.BtnSelect.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelect.Location = New System.Drawing.Point(559, 56)
        Me.BtnSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(87, 28)
        Me.BtnSelect.TabIndex = 2
        Me.BtnSelect.Text = "انتخاب"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDest)
        Me.GroupBox2.Controls.Add(Me.BtnSelectDest)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 124)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(658, 103)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "مرحله 2: مکان ذخیره سازی"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(217, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "مکان ذخیره سازی فایل را انتخاب کنید:"
        '
        'txtDest
        '
        Me.txtDest.Enabled = False
        Me.txtDest.Location = New System.Drawing.Point(24, 59)
        Me.txtDest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDest.Name = "txtDest"
        Me.txtDest.Size = New System.Drawing.Size(524, 23)
        Me.txtDest.TabIndex = 3
        '
        'BtnSelectDest
        '
        Me.BtnSelectDest.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectDest.Location = New System.Drawing.Point(559, 56)
        Me.BtnSelectDest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSelectDest.Name = "BtnSelectDest"
        Me.BtnSelectDest.Size = New System.Drawing.Size(87, 28)
        Me.BtnSelectDest.TabIndex = 2
        Me.BtnSelectDest.Text = "انتخاب"
        Me.BtnSelectDest.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmbFormat)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(19, 235)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(658, 100)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "مرحله 3: فرمت مرورگر"
        '
        'CmbFormat
        '
        Me.CmbFormat.FormattingEnabled = True
        Me.CmbFormat.Items.AddRange(New Object() {"Video (MP4, ...)", "Book (PDF)"})
        Me.CmbFormat.Location = New System.Drawing.Point(24, 59)
        Me.CmbFormat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbFormat.Name = "CmbFormat"
        Me.CmbFormat.Size = New System.Drawing.Size(622, 24)
        Me.CmbFormat.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(405, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(197, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "فرمت فایل مورد نظر را انتخاب کنید:"
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(19, 509)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(658, 52)
        Me.BtnSave.TabIndex = 13
        Me.BtnSave.Text = "ذخیره"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnSelectDemo)
        Me.GroupBox4.Controls.Add(Me.TxtDemoPath)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.TxtPackageCode)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtServerURI)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 342)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox4.Size = New System.Drawing.Size(658, 160)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "مرحله 4: تنظیمات برنامه"
        '
        'BtnSelectDemo
        '
        Me.BtnSelectDemo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectDemo.Location = New System.Drawing.Point(563, 115)
        Me.BtnSelectDemo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSelectDemo.Name = "BtnSelectDemo"
        Me.BtnSelectDemo.Size = New System.Drawing.Size(87, 28)
        Me.BtnSelectDemo.TabIndex = 19
        Me.BtnSelectDemo.Text = "انتخاب دمو"
        Me.BtnSelectDemo.UseVisualStyleBackColor = True
        '
        'TxtDemoPath
        '
        Me.TxtDemoPath.Enabled = False
        Me.TxtDemoPath.ForeColor = System.Drawing.Color.Black
        Me.TxtDemoPath.Location = New System.Drawing.Point(23, 118)
        Me.TxtDemoPath.Name = "TxtDemoPath"
        Me.TxtDemoPath.Size = New System.Drawing.Size(534, 23)
        Me.TxtDemoPath.TabIndex = 18
        Me.TxtDemoPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(587, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "پیش کد:"
        '
        'TxtPackageCode
        '
        Me.TxtPackageCode.ForeColor = System.Drawing.Color.Black
        Me.TxtPackageCode.Location = New System.Drawing.Point(24, 34)
        Me.TxtPackageCode.Name = "TxtPackageCode"
        Me.TxtPackageCode.Size = New System.Drawing.Size(534, 23)
        Me.TxtPackageCode.TabIndex = 16
        Me.TxtPackageCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(563, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "آدرس سایت:"
        '
        'txtServerURI
        '
        Me.txtServerURI.ForeColor = System.Drawing.Color.Black
        Me.txtServerURI.Location = New System.Drawing.Point(24, 76)
        Me.txtServerURI.Name = "txtServerURI"
        Me.txtServerURI.Size = New System.Drawing.Size(533, 23)
        Me.txtServerURI.TabIndex = 12
        Me.txtServerURI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 569)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmSingle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSingle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents TxtPackageCode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtServerURI As TextBox
    Friend WithEvents BtnSelectDemo As Button
    Friend WithEvents TxtDemoPath As TextBox
End Class
