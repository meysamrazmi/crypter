Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Form1
    Private binFolder As String = ""
    Private viewVideoFolder As String = ""
    Private videoDetailsFolder As String = ""

    Dim filesCount As Integer = 0
    Dim countedNumber As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog2.ShowDialog()
        TextBox1.Text = FolderBrowserDialog2.SelectedPath
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox2.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text.Length < 20 Then
            MsgBox("پوشه ای را برای قفل گزاری انتخاب نکرده اید.", MsgBoxStyle.Information, "خطا")
            Exit Sub
        End If
        If PackageName.Text = "اسم کامل پکیج" Or PackageName.Text.Length < 2 Then
            MsgBox("اسم پکیج برای نمایش در برنامه اجباری است.", MsgBoxStyle.Information, "خطا")
            Exit Sub
        End If
        If TxtPackageCode.Text.Length < 2 Then
            MsgBox("کد پکیج را درست وارد کنید. برای بوجود نیامدن مشکلات آتی حد اقل 2 حرف در نظر بگیرید.", MsgBoxStyle.Information, "خطا")
            Exit Sub
        End If
        If TxtOtherProducts.Text.Length < 20 Or TxtHelpFile.Text.Length < 20 Then
            MsgBox("فایل های راهنما و سایر محصولات اجباری هستند.", MsgBoxStyle.Information, "خطا")
            Exit Sub
        End If

        progress.Value = 0
        Me.Refresh()
        Dim plainDataFolder As String = FolderBrowserDialog2.SelectedPath
        Dim appFolder As String = Path.Combine(FolderBrowserDialog1.SelectedPath, "data")
        binFolder = Path.Combine(appFolder, "bin")
        Dim viewfolder As String = Path.Combine(appFolder, "view\main")
        viewVideoFolder = Path.Combine(appFolder, "view\video")
        Dim HelpFolder As String = Path.Combine(appFolder, "help")

        If Not Directory.Exists(viewVideoFolder) Then
            Directory.CreateDirectory(viewVideoFolder)
        End If

        filesCount = System.IO.Directory.GetFiles(plainDataFolder, "*.*", SearchOption.AllDirectories).Count()

        EncryptDirectory(plainDataFolder, viewfolder)

        Dim serveruri As String = "http://lock.civil808.com/808.php"
        'write settings
        Dim SettingsStr As String = serveruri.Trim & "@@" & TxtPackageCode.Text.Trim.ToLower & "@@" & folderCheksum(binFolder) & "@@" & PackageName.Text.Trim & "@@" & lblversion.Text.Trim
        File.WriteAllBytes(appFolder & "\Loader32.dll", CryptBytes(Encoding.UTF32.GetString(password), Encoding.UTF8.GetBytes(AES_encrypt(SettingsStr)), True))

        'Copy HelpFile & otherProducts
        If Directory.Exists(HelpFolder) = False Then
            Directory.CreateDirectory(HelpFolder)
        End If
        If TxtOtherProducts.Text <> "" Then FileSystem.FileCopy(TxtOtherProducts.Text, HelpFolder & "\OP.msc")
        If TxtHelpFile.Text <> "" Then FileSystem.FileCopy(TxtHelpFile.Text, HelpFolder & "\HP.msc")

        GboxVideos.Enabled = True
        videoDetailsTask(True)
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
    End Sub

    Public Sub EncryptDirectory(ByVal sourcePath As String, ByVal viewDirPath As String)
        Dim sourceDirectoryInfo As New System.IO.DirectoryInfo(sourcePath)

        ' If the destination folder don't exist then create it
        If Not Directory.Exists(binFolder) Then
            Directory.CreateDirectory(binFolder)
        End If
        If Not Directory.Exists(viewDirPath) Then
            Directory.CreateDirectory(viewDirPath)
        End If

        Dim fileSystemInfo As FileSystemInfo
        For Each fileSystemInfo In sourceDirectoryInfo.GetFileSystemInfos
            Dim newViewFolder As String = Path.Combine(viewDirPath, fileSystemInfo.Name)

            If TypeOf fileSystemInfo Is FileInfo Then

                Dim nullbyte As Byte() = {&H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20, &H20}

                Dim destPath As String = binFolder & "\" & ToMD5(fileSystemInfo.Name & "^g3cV98&3sZl)$A") & ".bin"
                FileSystem.FileCopy(fileSystemInfo.FullName, destPath)

                Dim arraySize As Integer = 1218
                'read header 1218 bytes
                Dim dest() As Byte = New Byte(arraySize - 1) {}
                Using fs As New FileStream(destPath, FileMode.Open, FileAccess.Read, FileShare.None)
                    fs.Read(dest, 0, dest.Length)
                End Using

                'write header 1218 bytes with null
                Using fs As New FileStream(destPath, FileMode.Open, FileAccess.ReadWrite)
                    fs.Seek(0, SeekOrigin.Begin)
                    fs.Write(nullbyte, 0, arraySize)
                End Using

                'Write view file main
                File.WriteAllBytes(newViewFolder, CryptBytes(Encoding.UTF32.GetString(password), dest, True))
                'write video 
                Dim tempExt As String = fileSystemInfo.Extension.ToLower
                If tempExt = ".mp4" Or tempExt = ".mov" Or tempExt = ".avi" Or tempExt = ".mpg" Or tempExt = ".wmv" Or tempExt = ".flv" Or tempExt = ".mkv" Or tempExt = ".bdmv" Or tempExt = ".evo" Or tempExt = ".hdmov" Or tempExt = ".webm" Or tempExt = ".ogm" Then
                    File.WriteAllBytes(Path.Combine(viewVideoFolder, fileSystemInfo.Name), CryptBytes(Encoding.UTF32.GetString(password), dest, True))
                End If

                changeProgress()
            Else
                EncryptDirectory(fileSystemInfo.FullName, newViewFolder)
            End If
        Next
    End Sub

    Private Sub changeProgress()
        countedNumber += 1
        progress.Value = CInt((countedNumber / filesCount) * 100)
    End Sub

    Private Sub GboxVideos_EnabledChanged(sender As Object, e As EventArgs) Handles GboxVideos.EnabledChanged
        If Directory.Exists(viewVideoFolder) = False Then
            If GboxVideos.Enabled = True Then
                GboxVideos.Enabled = False
            End If
        End If
    End Sub

    Private imgCount As Integer
    Private imgArray As List(Of String)
    Private txtStr As List(Of String)
    Private unselectedIndexes As List(Of Integer)
    Private finished As Boolean = True
    Private Sub videoDetailsTask(ByVal newRun As Boolean)
        If (newRun = True) Then
            imgCount = 0
            imgArray = New List(Of String)
            unselectedIndexes = New List(Of Integer)
            txtStr = New List(Of String)
            TxtDesc1.Text = ""
            TxtDesc2.Text = ""
            TxtMins.Text = ""
            TxtPicture.Text = ""
            lblVideoPath.Text = ""
            finished = False
            chkAdd.Checked = True

            videoDetailsFolder = Path.Combine(Directory.GetParent(viewVideoFolder).FullName, "video_details")
            If Not Directory.Exists(videoDetailsFolder) Then
                Directory.CreateDirectory(videoDetailsFolder)
            End If

            Dim sourceDirectoryInfo As New System.IO.DirectoryInfo(viewVideoFolder)
            Dim fileSystemInfo As FileSystemInfo
            For Each fileSystemInfo In sourceDirectoryInfo.GetFileSystemInfos
                imgArray.Add(fileSystemInfo.Name)
            Next
            For i As Integer = 1 To imgArray.Count
                unselectedIndexes.Add(i)
            Next
            CBoxSort.Items.Clear()
            For i As Integer = 1 To unselectedIndexes.Count
                CBoxSort.Items.Add(unselectedIndexes(i - 1))
            Next

            videoDetailsTask(False)
        Else

            If finished = True Then
                Exit Sub
            End If
            If imgCount > 0 Then
                If TxtPicture.Text = "" Then
                    TxtPicture.Text = Path.Combine(Environment.CurrentDirectory, "image\mp4.png")
                End If

                'index Code start
                Dim sortIndex As Integer = 0
                If IsNumeric(CBoxSort.Text) = False Then
                    sortIndex = unselectedIndexes(0)
                Else
                    sortIndex = CInt(CBoxSort.Text)
                End If
                unselectedIndexes.Remove(sortIndex)
                CBoxSort.Items.Clear()
                For i As Integer = 1 To unselectedIndexes.Count
                    CBoxSort.Items.Add(unselectedIndexes(i - 1))
                Next
                'index code end

                If chkAdd.Checked = True Then
                    txtStr.Add(sortIndex & "@" & toBase64(imgArray(imgCount - 1)) & "@" & toBase64(TxtDesc1.Text) & "@" & toBase64(TxtDesc2.Text) & "@" & toBase64(TxtMins.Text) & "@" & sortIndex & Path.GetExtension(TxtPicture.Text) & vbNewLine)

                    Dim newImgPath As String = Path.Combine(videoDetailsFolder, sortIndex & Path.GetExtension(TxtPicture.Text))
                    If (File.Exists(newImgPath)) Then
                        File.Delete(newImgPath)
                    End If
                    FileSystem.FileCopy(TxtPicture.Text, newImgPath)
                Else
                    File.Delete(Path.Combine(viewVideoFolder, imgArray(imgCount - 1)))
                End If

                If CBoxSort.Items.Count >= 1 Then
                    CBoxSort.Text = CBoxSort.Items(0)
                Else
                    CBoxSort.Text = "Random"
                End If
                TxtDesc1.Text = ""
                TxtDesc2.Text = ""
                TxtMins.Text = ""
                TxtPicture.Text = ""
            End If

            If imgCount < imgArray.Count Then
                lblVideoPath.Text = imgArray(imgCount)
            End If

            imgCount += 1
            If imgCount > imgArray.Count Then
                finished = True

                'str_list to string
                Dim Result As String = ""
                txtStr.Sort()
                For Each txtItem As String In txtStr
                    Result &= txtItem.Substring(txtItem.IndexOf("@") + 1)
                Next

                Dim iniPath As String = Path.Combine(Directory.GetParent(viewVideoFolder).FullName, "details.ini")
                If (File.Exists(iniPath)) Then
                    File.Delete(iniPath)
                End If
                Dim objWriter As New StreamWriter(New FileStream(iniPath, FileMode.CreateNew, FileAccess.ReadWrite), Encoding.UTF8)
                objWriter.Write(Result.Trim)
                objWriter.Close()



                If (File.Exists(Path.Combine(Directory.GetParent(viewVideoFolder).FullName, "mp4.png"))) = False Then
                    FileSystem.FileCopy(Path.Combine(Environment.CurrentDirectory, "image\mp4.png"), Path.Combine(Directory.GetParent(viewVideoFolder).FullName, "mp4.jpg"))
                End If


                MsgBox("با موفقیت انجام شد", MsgBoxStyle.Information, "")
                GboxVideos.Enabled = False
                videoDetailsTask(False)
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
                GroupBox3.Enabled = True
                TextBox1.Text = ""
            Else
                lblCount.Text = "(" & imgCount & "|" & imgArray.Count & "):"
                chkAdd.Checked = True
            End If

        End If
    End Sub

    Private Sub BtnChooseImg_Click(sender As Object, e As EventArgs) Handles BtnChooseImg.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TxtPicture.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnNextVideo_Click(sender As Object, e As EventArgs) Handles BtnNextVideo.Click
        videoDetailsTask(False)
    End Sub

    Private Sub BtnHelpFile_Click(sender As Object, e As EventArgs) Handles BtnHelpFile.Click
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            TxtHelpFile.Text = OpenFileDialog2.FileName
        End If
    End Sub

    Private Sub BtnOtherProducts_Click(sender As Object, e As EventArgs) Handles BtnOtherProducts.Click
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            TxtOtherProducts.Text = OpenFileDialog2.FileName
        End If
    End Sub

    Private Sub PackageName_GotFocus(sender As Object, e As EventArgs) Handles PackageName.GotFocus
        If PackageName.Text = "اسم کامل پکیج" Then
            PackageName.Text = ""
            PackageName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub PackageName_LostFocus(sender As Object, e As EventArgs) Handles PackageName.LostFocus
        If PackageName.Text = "" Then
            PackageName.Text = "اسم کامل پکیج"
            PackageName.ForeColor = Color.Silver
        End If
    End Sub

End Class
