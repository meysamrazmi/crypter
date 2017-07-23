<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoader))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("IRANSans", 11.0!)
        Me.Button2.Image = Global._808FileCrypter.My.Resources.Resources.filelock1
        Me.Button2.Location = New System.Drawing.Point(12, 21)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(266, 177)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "قفل تک فایل"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("IRANSans", 11.0!)
        Me.Button1.Image = Global._808FileCrypter.My.Resources.Resources.packagelock
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(284, 21)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(269, 177)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "قفل پکیج"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(545, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "# بعد از اینکه پوشه قفل نهایی به اسم data آماده شد آن را در کنار خود قفل (فایل ex" &
    "e) قرار دهید."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(545, 43)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "# هر تعداد قفلی که با کد پکیج یکسان تعریف شوند با هم روی سیستم کاربر فعال خواهند " &
    "شد."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(545, 63)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "# پکیج هایی که بزرگ هستند و در چند دی وی دی آماده می شوند باید جداگانه قفل شوند و" &
    "لی ""کد پکیج"" آنها باید یکسان باشد."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("IRANSans", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(3, 368)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "version 2.0"
        '
        'FrmLoader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(563, 390)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("IRANSans", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "FrmLoader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "808 Crypter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
