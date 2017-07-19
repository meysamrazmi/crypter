Imports _808FileCrypter.ProgressBarSample
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnOtherProducts = New System.Windows.Forms.Button()
        Me.TxtOtherProducts = New System.Windows.Forms.TextBox()
        Me.BtnHelpFile = New System.Windows.Forms.Button()
        Me.TxtHelpFile = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPackageCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtServerURI = New System.Windows.Forms.TextBox()
        Me.GboxVideos = New System.Windows.Forms.GroupBox()
        Me.chkAdd = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBoxSort = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMins = New System.Windows.Forms.TextBox()
        Me.TxtDesc2 = New System.Windows.Forms.TextBox()
        Me.TxtDesc1 = New System.Windows.Forms.TextBox()
        Me.lblVideoPath = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnNextVideo = New System.Windows.Forms.Button()
        Me.BtnChooseImg = New System.Windows.Forms.Button()
        Me.TxtPicture = New System.Windows.Forms.TextBox()
        Me.btnChooseVideoDir = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog3 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.progress = New _808FileCrypter.ProgressBarSample.CustomProgress()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GboxVideos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(361, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(189, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "محل ذخیره سازی را انتخاب کنید:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(354, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(197, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "پوشه مورد نظر خود را انتخاب کنید:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(466, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "انتخاب"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(21, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(437, 23)
        Me.TextBox1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(465, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "انتخاب"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(20, 66)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(437, 23)
        Me.TextBox2.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Button3.Location = New System.Drawing.Point(12, 516)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(909, 35)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "ذخیره"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(564, 108)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مرحله 1: رمزنگاری فایل ها"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 341)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(564, 114)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "مرحله 3: محل ذخیره سازی"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnOtherProducts)
        Me.GroupBox3.Controls.Add(Me.TxtOtherProducts)
        Me.GroupBox3.Controls.Add(Me.BtnHelpFile)
        Me.GroupBox3.Controls.Add(Me.TxtHelpFile)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtPackageCode)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtServerURI)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 131)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(564, 199)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "مرحله 2: تنظیمات برنامه"
        '
        'BtnOtherProducts
        '
        Me.BtnOtherProducts.Font = New System.Drawing.Font("Tahoma", 8.75!)
        Me.BtnOtherProducts.Location = New System.Drawing.Point(467, 150)
        Me.BtnOtherProducts.Name = "BtnOtherProducts"
        Me.BtnOtherProducts.Size = New System.Drawing.Size(81, 36)
        Me.BtnOtherProducts.TabIndex = 20
        Me.BtnOtherProducts.Text = "سایر محصولات"
        Me.BtnOtherProducts.UseVisualStyleBackColor = True
        '
        'TxtOtherProducts
        '
        Me.TxtOtherProducts.Enabled = False
        Me.TxtOtherProducts.Location = New System.Drawing.Point(21, 156)
        Me.TxtOtherProducts.Name = "TxtOtherProducts"
        Me.TxtOtherProducts.Size = New System.Drawing.Size(437, 23)
        Me.TxtOtherProducts.TabIndex = 21
        '
        'BtnHelpFile
        '
        Me.BtnHelpFile.Font = New System.Drawing.Font("Tahoma", 8.75!)
        Me.BtnHelpFile.Location = New System.Drawing.Point(467, 105)
        Me.BtnHelpFile.Name = "BtnHelpFile"
        Me.BtnHelpFile.Size = New System.Drawing.Size(81, 36)
        Me.BtnHelpFile.TabIndex = 18
        Me.BtnHelpFile.Text = "فایل راهنما"
        Me.BtnHelpFile.UseVisualStyleBackColor = True
        '
        'TxtHelpFile
        '
        Me.TxtHelpFile.Enabled = False
        Me.TxtHelpFile.Location = New System.Drawing.Point(21, 112)
        Me.TxtHelpFile.Name = "TxtHelpFile"
        Me.TxtHelpFile.Size = New System.Drawing.Size(437, 23)
        Me.TxtHelpFile.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(487, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "پیش کد:"
        '
        'TxtPackageCode
        '
        Me.TxtPackageCode.ForeColor = System.Drawing.Color.Black
        Me.TxtPackageCode.Location = New System.Drawing.Point(21, 26)
        Me.TxtPackageCode.Name = "TxtPackageCode"
        Me.TxtPackageCode.Size = New System.Drawing.Size(437, 23)
        Me.TxtPackageCode.TabIndex = 16
        Me.TxtPackageCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(463, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "آدرس سایت:"
        '
        'txtServerURI
        '
        Me.txtServerURI.ForeColor = System.Drawing.Color.LightGray
        Me.txtServerURI.Location = New System.Drawing.Point(20, 68)
        Me.txtServerURI.Name = "txtServerURI"
        Me.txtServerURI.Size = New System.Drawing.Size(437, 23)
        Me.txtServerURI.TabIndex = 12
        Me.txtServerURI.Text = "http://www.example.com/808.php"
        Me.txtServerURI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GboxVideos
        '
        Me.GboxVideos.Controls.Add(Me.chkAdd)
        Me.GboxVideos.Controls.Add(Me.Label4)
        Me.GboxVideos.Controls.Add(Me.CBoxSort)
        Me.GboxVideos.Controls.Add(Me.Label8)
        Me.GboxVideos.Controls.Add(Me.Label7)
        Me.GboxVideos.Controls.Add(Me.Label6)
        Me.GboxVideos.Controls.Add(Me.TxtMins)
        Me.GboxVideos.Controls.Add(Me.TxtDesc2)
        Me.GboxVideos.Controls.Add(Me.TxtDesc1)
        Me.GboxVideos.Controls.Add(Me.lblVideoPath)
        Me.GboxVideos.Controls.Add(Me.lblCount)
        Me.GboxVideos.Controls.Add(Me.Label5)
        Me.GboxVideos.Controls.Add(Me.BtnNextVideo)
        Me.GboxVideos.Controls.Add(Me.BtnChooseImg)
        Me.GboxVideos.Controls.Add(Me.TxtPicture)
        Me.GboxVideos.Enabled = False
        Me.GboxVideos.Location = New System.Drawing.Point(596, 54)
        Me.GboxVideos.Name = "GboxVideos"
        Me.GboxVideos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GboxVideos.Size = New System.Drawing.Size(325, 401)
        Me.GboxVideos.TabIndex = 12
        Me.GboxVideos.TabStop = False
        Me.GboxVideos.Text = "مرحله 4: مشخصات فیلم ها"
        '
        'chkAdd
        '
        Me.chkAdd.AutoSize = True
        Me.chkAdd.Checked = True
        Me.chkAdd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAdd.Location = New System.Drawing.Point(227, 313)
        Me.chkAdd.Name = "chkAdd"
        Me.chkAdd.Size = New System.Drawing.Size(85, 20)
        Me.chkAdd.TabIndex = 21
        Me.chkAdd.Text = "اضافه شود"
        Me.chkAdd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ردیف (ترتیب):"
        '
        'CBoxSort
        '
        Me.CBoxSort.FormattingEnabled = True
        Me.CBoxSort.Location = New System.Drawing.Point(23, 95)
        Me.CBoxSort.Name = "CBoxSort"
        Me.CBoxSort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CBoxSort.Size = New System.Drawing.Size(194, 24)
        Me.CBoxSort.TabIndex = 18
        Me.CBoxSort.Text = "Random"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(250, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "طول فیلم:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(268, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "توضیح:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(270, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "عنوان:"
        '
        'TxtMins
        '
        Me.TxtMins.Location = New System.Drawing.Point(23, 281)
        Me.TxtMins.Name = "TxtMins"
        Me.TxtMins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMins.Size = New System.Drawing.Size(194, 23)
        Me.TxtMins.TabIndex = 12
        '
        'TxtDesc2
        '
        Me.TxtDesc2.Location = New System.Drawing.Point(23, 235)
        Me.TxtDesc2.Name = "TxtDesc2"
        Me.TxtDesc2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDesc2.Size = New System.Drawing.Size(194, 23)
        Me.TxtDesc2.TabIndex = 11
        '
        'TxtDesc1
        '
        Me.TxtDesc1.Location = New System.Drawing.Point(23, 188)
        Me.TxtDesc1.Name = "TxtDesc1"
        Me.TxtDesc1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDesc1.Size = New System.Drawing.Size(194, 23)
        Me.TxtDesc1.TabIndex = 10
        '
        'lblVideoPath
        '
        Me.lblVideoPath.Location = New System.Drawing.Point(6, 30)
        Me.lblVideoPath.Name = "lblVideoPath"
        Me.lblVideoPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVideoPath.Size = New System.Drawing.Size(211, 51)
        Me.lblVideoPath.TabIndex = 9
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(223, 30)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(48, 16)
        Me.lblCount.TabIndex = 8
        Me.lblCount.Text = "(0|0):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "فیلم"
        '
        'BtnNextVideo
        '
        Me.BtnNextVideo.Location = New System.Drawing.Point(6, 341)
        Me.BtnNextVideo.Name = "BtnNextVideo"
        Me.BtnNextVideo.Size = New System.Drawing.Size(313, 50)
        Me.BtnNextVideo.TabIndex = 6
        Me.BtnNextVideo.Text = "افزودن / بعدی"
        Me.BtnNextVideo.UseVisualStyleBackColor = True
        '
        'BtnChooseImg
        '
        Me.BtnChooseImg.Location = New System.Drawing.Point(223, 130)
        Me.BtnChooseImg.Name = "BtnChooseImg"
        Me.BtnChooseImg.Size = New System.Drawing.Size(88, 46)
        Me.BtnChooseImg.TabIndex = 4
        Me.BtnChooseImg.Text = "انتخاب عکس 32 در 32"
        Me.BtnChooseImg.UseVisualStyleBackColor = True
        '
        'TxtPicture
        '
        Me.TxtPicture.Enabled = False
        Me.TxtPicture.Location = New System.Drawing.Point(23, 140)
        Me.TxtPicture.Name = "TxtPicture"
        Me.TxtPicture.Size = New System.Drawing.Size(194, 23)
        Me.TxtPicture.TabIndex = 5
        '
        'btnChooseVideoDir
        '
        Me.btnChooseVideoDir.Location = New System.Drawing.Point(596, 12)
        Me.btnChooseVideoDir.Name = "btnChooseVideoDir"
        Me.btnChooseVideoDir.Size = New System.Drawing.Size(325, 36)
        Me.btnChooseVideoDir.TabIndex = 13
        Me.btnChooseVideoDir.Text = "انتخاب پوشه فیلم ها"
        Me.btnChooseVideoDir.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Images |*.jpg; *.jpeg; *.bmp;*.png;"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        Me.OpenFileDialog2.Filter = "PDF |*.pdf"
        '
        'progress
        '
        Me.progress.CustomText = Nothing
        Me.progress.DisplayStyle = _808FileCrypter.ProgressBarSample.ProgressBarDisplayText.Percentage
        Me.progress.Location = New System.Drawing.Point(12, 464)
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(909, 46)
        Me.progress.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 560)
        Me.Controls.Add(Me.progress)
        Me.Controls.Add(Me.btnChooseVideoDir)
        Me.Controls.Add(Me.GboxVideos)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ابزارک پکیج ساز قفل 808"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GboxVideos.ResumeLayout(False)
        Me.GboxVideos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtServerURI As TextBox
    Friend WithEvents GboxVideos As GroupBox
    Friend WithEvents lblCount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnNextVideo As Button
    Friend WithEvents BtnChooseImg As Button
    Friend WithEvents TxtPicture As TextBox
    Friend WithEvents lblVideoPath As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtMins As TextBox
    Friend WithEvents TxtDesc2 As TextBox
    Friend WithEvents TxtDesc1 As TextBox
    Friend WithEvents btnChooseVideoDir As Button
    Friend WithEvents FolderBrowserDialog3 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents CBoxSort As ComboBox
    Friend WithEvents progress As CustomProgress
    Friend WithEvents chkAdd As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPackageCode As TextBox
    Friend WithEvents BtnOtherProducts As Button
    Friend WithEvents TxtOtherProducts As TextBox
    Friend WithEvents BtnHelpFile As Button
    Friend WithEvents TxtHelpFile As TextBox
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
End Class
