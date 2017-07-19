Imports System.IO
Imports System.Text

Public Class FrmSingle
    Private ReadOnly nullbyte As Byte() = {&H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20}
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            If OpenFileDialog1.FileName.Length < 2 Then
                MsgBox("فایل را به درستی انتخاب کنید", vbCritical, "خطا")
            Else
                TxtMainFile.Text = OpenFileDialog1.FileName
            End If
        End If
    End Sub

    Private Sub BtnSelectDest_Click(sender As Object, e As EventArgs) Handles BtnSelectDest.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            If FolderBrowserDialog1.SelectedPath.Length < 2 Then
                MsgBox("مسیر را به درستی انتخاب کنید", vbCritical, "خطا")
            Else
                txtDest.Text = FolderBrowserDialog1.SelectedPath
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If txtDest.Text.Length < 2 Or TxtMainFile.Text.Length < 2 Or CmbFormat.SelectedIndex < 0 Then
            MsgBox("فیلدها را به درستی و طبق مراحل پر کنید", vbCritical, "خطا")
            txtDest.Text = ""
            TxtMainFile.Text = ""
            Exit Sub
        End If

        Try
            Dim destPath As String = Path.Combine(txtDest.Text, "data")
            Dim binfile As String = Path.Combine(destPath, "data.bin")
            Dim detailsfile As String = Path.Combine(destPath, "details.bin")
            If Directory.Exists(destPath) = False Then
                Directory.CreateDirectory(destPath)
            End If

            FileSystem.FileCopy(TxtMainFile.Text, binfile)

            Dim arraySize As Integer = 1218
            'read header 1218 bytes
            Dim dest() As Byte = New Byte(arraySize - 1) {}
            Using fs As New FileStream(binfile, FileMode.Open, FileAccess.Read, FileShare.None)
                fs.Read(dest, 0, dest.Length)
            End Using

            'rewrite header with null
            Using fs As New FileStream(binfile, FileMode.Open, FileAccess.ReadWrite)
                fs.Seek(0, SeekOrigin.Begin)
                fs.Write(nullbyte, 0, arraySize)
            End Using

            'write encoded header to details.bin
            File.WriteAllBytes(detailsfile, CryptBytes(Encoding.UTF32.GetString(password), dest, True))

            'copy player
            Select Case CmbFormat.SelectedIndex
                Case 0
                    My.Computer.FileSystem.CopyDirectory(Path.Combine(Environment.CurrentDirectory, "player\video"), Path.Combine(destPath, "video"), True)
                Case 1
                    My.Computer.FileSystem.CopyDirectory(Path.Combine(Environment.CurrentDirectory, "player\book"), Path.Combine(destPath, "book"), True)
            End Select

            'copy demo
            If TxtDemoPath.Text <> "" Then
                FileSystem.FileCopy(TxtDemoPath.Text, Path.Combine(destPath, "demo.mov"))
            End If

            Dim SettingsStr As String = txtServerURI.Text.Trim & "@@" & TxtPackageCode.Text.Trim.ToLower & "@@" & ToMD5(File.ReadAllBytes(detailsfile))
            File.WriteAllBytes(destPath & "\Loader32.dll", CryptBytes(Encoding.UTF32.GetString(password), Encoding.UTF8.GetBytes(AES_encrypt(SettingsStr)), True))

            MsgBox("با موفقیت انجام شد", vbInformation, "موفق")
        Catch ee As Exception
            MsgBox("خطا حین عملیات:" & vbNewLine & ee.Message, vbCritical, "خطا")
        End Try
    End Sub

    Private Sub BtnSelectDemo_Click(sender As Object, e As EventArgs) Handles BtnSelectDemo.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            If OpenFileDialog1.FileName.Length < 2 Then
                MsgBox("فایل را به درستی انتخاب کنید", vbCritical, "خطا")
            Else
                TxtDemoPath.Text = OpenFileDialog1.FileName
            End If
        End If
    End Sub

End Class