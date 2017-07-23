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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PackageName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnOtherProducts = New System.Windows.Forms.Button()
        Me.TxtOtherProducts = New System.Windows.Forms.TextBox()
        Me.BtnHelpFile = New System.Windows.Forms.Button()
        Me.TxtHelpFile = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPackageCode = New System.Windows.Forms.TextBox()
        Me.GboxVideos = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.FolderBrowserDialog3 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.progress = New _808FileCrypter.ProgressBarSample.CustomProgress()
        Me.lblversion = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GboxVideos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(448, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(190, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "پوشه مورد نظر خود را انتخاب کنید:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(8, 72)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "انتخاب"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(147, 72)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(422, 30)
        Me.TextBox1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(8, 40)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "انتخاب"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(147, 40)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(422, 30)
        Me.TextBox2.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("IRANSans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(408, 504)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 35)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "ذخیره"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(408, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(645, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مرحله 1: رمزنگاری فایل ها"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(408, 404)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(645, 92)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "مرحله 3: محل ذخیره سازی"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.PackageName)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.BtnOtherProducts)
        Me.GroupBox3.Controls.Add(Me.TxtOtherProducts)
        Me.GroupBox3.Controls.Add(Me.BtnHelpFile)
        Me.GroupBox3.Controls.Add(Me.TxtHelpFile)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtPackageCode)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(408, 146)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(645, 248)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "مرحله 2: تنظیمات برنامه"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(575, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 22)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "اسم پکیج:"
        '
        'PackageName
        '
        Me.PackageName.ForeColor = System.Drawing.Color.Silver
        Me.PackageName.Location = New System.Drawing.Point(8, 27)
        Me.PackageName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PackageName.Name = "PackageName"
        Me.PackageName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PackageName.Size = New System.Drawing.Size(561, 30)
        Me.PackageName.TabIndex = 24
        Me.PackageName.Text = "اسم کامل پکیج"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("IRANSans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(460, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(174, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "هر دو فایل pdf بالا اجباری هستند."
        Me.Label10.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("IRANSans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(626, 32)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "قفل هایی که با یک کد پکیج یکسان قفل شوند بدون نیاز به فعال سازی دوباره در سیستم ک" &
    "اربر فعال خواهند شد."
        Me.Label1.UseCompatibleTextRendering = True
        '
        'BtnOtherProducts
        '
        Me.BtnOtherProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnOtherProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnOtherProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnOtherProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnOtherProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOtherProducts.ForeColor = System.Drawing.Color.White
        Me.BtnOtherProducts.Location = New System.Drawing.Point(8, 179)
        Me.BtnOtherProducts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnOtherProducts.Name = "BtnOtherProducts"
        Me.BtnOtherProducts.Size = New System.Drawing.Size(141, 30)
        Me.BtnOtherProducts.TabIndex = 5
        Me.BtnOtherProducts.Text = "pdf سایر محصولات"
        Me.BtnOtherProducts.UseVisualStyleBackColor = False
        '
        'TxtOtherProducts
        '
        Me.TxtOtherProducts.Enabled = False
        Me.TxtOtherProducts.Location = New System.Drawing.Point(147, 179)
        Me.TxtOtherProducts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtOtherProducts.Multiline = True
        Me.TxtOtherProducts.Name = "TxtOtherProducts"
        Me.TxtOtherProducts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtOtherProducts.Size = New System.Drawing.Size(422, 30)
        Me.TxtOtherProducts.TabIndex = 4
        '
        'BtnHelpFile
        '
        Me.BtnHelpFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnHelpFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnHelpFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnHelpFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnHelpFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHelpFile.ForeColor = System.Drawing.Color.White
        Me.BtnHelpFile.Location = New System.Drawing.Point(8, 141)
        Me.BtnHelpFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnHelpFile.Name = "BtnHelpFile"
        Me.BtnHelpFile.Size = New System.Drawing.Size(141, 30)
        Me.BtnHelpFile.TabIndex = 3
        Me.BtnHelpFile.Text = "pdf فایل راهنما"
        Me.BtnHelpFile.UseVisualStyleBackColor = False
        '
        'TxtHelpFile
        '
        Me.TxtHelpFile.Enabled = False
        Me.TxtHelpFile.Location = New System.Drawing.Point(147, 141)
        Me.TxtHelpFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtHelpFile.Multiline = True
        Me.TxtHelpFile.Name = "TxtHelpFile"
        Me.TxtHelpFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtHelpFile.Size = New System.Drawing.Size(422, 30)
        Me.TxtHelpFile.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(581, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 22)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "کد پکیج:"
        '
        'TxtPackageCode
        '
        Me.TxtPackageCode.ForeColor = System.Drawing.Color.Black
        Me.TxtPackageCode.Location = New System.Drawing.Point(8, 65)
        Me.TxtPackageCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPackageCode.Name = "TxtPackageCode"
        Me.TxtPackageCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPackageCode.Size = New System.Drawing.Size(294, 30)
        Me.TxtPackageCode.TabIndex = 0
        '
        'GboxVideos
        '
        Me.GboxVideos.Controls.Add(Me.lblversion)
        Me.GboxVideos.Controls.Add(Me.Label12)
        Me.GboxVideos.Controls.Add(Me.Label11)
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
        Me.GboxVideos.Location = New System.Drawing.Point(14, 16)
        Me.GboxVideos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GboxVideos.Name = "GboxVideos"
        Me.GboxVideos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GboxVideos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GboxVideos.Size = New System.Drawing.Size(371, 554)
        Me.GboxVideos.TabIndex = 4
        Me.GboxVideos.TabStop = False
        Me.GboxVideos.Text = "مرحله 4: مشخصات فیلم ها"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("IRANSans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(7, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(348, 44)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "این مشخصات فقط برای فیلم های پکیج است که در صفحه پیش فرض قفل لیست می شوند."
        Me.Label12.UseCompatibleTextRendering = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(4, 537)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "version"
        '
        'chkAdd
        '
        Me.chkAdd.AutoSize = True
        Me.chkAdd.Checked = True
        Me.chkAdd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAdd.Location = New System.Drawing.Point(272, 433)
        Me.chkAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkAdd.Name = "chkAdd"
        Me.chkAdd.Size = New System.Drawing.Size(83, 26)
        Me.chkAdd.TabIndex = 7
        Me.chkAdd.Text = "اضافه شود"
        Me.chkAdd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ردیف (ترتیب):"
        '
        'CBoxSort
        '
        Me.CBoxSort.FormattingEnabled = True
        Me.CBoxSort.Location = New System.Drawing.Point(7, 183)
        Me.CBoxSort.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBoxSort.Name = "CBoxSort"
        Me.CBoxSort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CBoxSort.Size = New System.Drawing.Size(221, 30)
        Me.CBoxSort.TabIndex = 0
        Me.CBoxSort.Text = "Random"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(298, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 22)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "طول فیلم:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(315, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 22)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "توضیح:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(324, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "عنوان:"
        '
        'TxtMins
        '
        Me.TxtMins.Location = New System.Drawing.Point(7, 388)
        Me.TxtMins.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMins.Name = "TxtMins"
        Me.TxtMins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMins.Size = New System.Drawing.Size(221, 30)
        Me.TxtMins.TabIndex = 5
        '
        'TxtDesc2
        '
        Me.TxtDesc2.Location = New System.Drawing.Point(7, 336)
        Me.TxtDesc2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDesc2.Name = "TxtDesc2"
        Me.TxtDesc2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtDesc2.Size = New System.Drawing.Size(221, 30)
        Me.TxtDesc2.TabIndex = 4
        '
        'TxtDesc1
        '
        Me.TxtDesc1.Location = New System.Drawing.Point(7, 283)
        Me.TxtDesc1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDesc1.Name = "TxtDesc1"
        Me.TxtDesc1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtDesc1.Size = New System.Drawing.Size(221, 30)
        Me.TxtDesc1.TabIndex = 3
        '
        'lblVideoPath
        '
        Me.lblVideoPath.Location = New System.Drawing.Point(7, 81)
        Me.lblVideoPath.Name = "lblVideoPath"
        Me.lblVideoPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVideoPath.Size = New System.Drawing.Size(221, 88)
        Me.lblVideoPath.TabIndex = 9
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(277, 82)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(48, 16)
        Me.lblCount.TabIndex = 8
        Me.lblCount.Text = "(0|0):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "فیلم"
        '
        'BtnNextVideo
        '
        Me.BtnNextVideo.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnNextVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnNextVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnNextVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnNextVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNextVideo.Font = New System.Drawing.Font("IRANSans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNextVideo.ForeColor = System.Drawing.Color.White
        Me.BtnNextVideo.Location = New System.Drawing.Point(7, 428)
        Me.BtnNextVideo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnNextVideo.Name = "BtnNextVideo"
        Me.BtnNextVideo.Size = New System.Drawing.Size(134, 35)
        Me.BtnNextVideo.TabIndex = 6
        Me.BtnNextVideo.Text = "بعدی"
        Me.BtnNextVideo.UseVisualStyleBackColor = False
        '
        'BtnChooseImg
        '
        Me.BtnChooseImg.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnChooseImg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnChooseImg.FlatAppearance.BorderSize = 0
        Me.BtnChooseImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnChooseImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnChooseImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnChooseImg.Font = New System.Drawing.Font("IRANSans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChooseImg.ForeColor = System.Drawing.Color.White
        Me.BtnChooseImg.Location = New System.Drawing.Point(252, 236)
        Me.BtnChooseImg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnChooseImg.Name = "BtnChooseImg"
        Me.BtnChooseImg.Size = New System.Drawing.Size(109, 30)
        Me.BtnChooseImg.TabIndex = 2
        Me.BtnChooseImg.Text = "تصویر 250x250"
        Me.BtnChooseImg.UseVisualStyleBackColor = False
        '
        'TxtPicture
        '
        Me.TxtPicture.Enabled = False
        Me.TxtPicture.Location = New System.Drawing.Point(7, 236)
        Me.TxtPicture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPicture.Name = "TxtPicture"
        Me.TxtPicture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPicture.Size = New System.Drawing.Size(221, 30)
        Me.TxtPicture.TabIndex = 1
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
        Me.progress.BackColor = System.Drawing.Color.White
        Me.progress.CustomText = Nothing
        Me.progress.DisplayStyle = _808FileCrypter.ProgressBarSample.ProgressBarDisplayText.Percentage
        Me.progress.Location = New System.Drawing.Point(408, 547)
        Me.progress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(645, 23)
        Me.progress.TabIndex = 14
        '
        'lblversion
        '
        Me.lblversion.AutoSize = True
        Me.lblversion.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblversion.Location = New System.Drawing.Point(52, 537)
        Me.lblversion.Name = "lblversion"
        Me.lblversion.Size = New System.Drawing.Size(23, 13)
        Me.lblversion.TabIndex = 27
        Me.lblversion.Text = "2.0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1063, 581)
        Me.Controls.Add(Me.progress)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GboxVideos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Font = New System.Drawing.Font("IRANSans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "808 Package Crypter"
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
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PackageName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblversion As Label
End Class
