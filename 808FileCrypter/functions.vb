Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Module functions
    Public Function folderCheksum(path As String) As String
        Dim finalStr As String = ""
        Dim files() As String = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
        Array.Sort(files)

        For Each filename As String In files
            finalStr &= System.IO.Path.GetFileNameWithoutExtension(filename.ToLower())
        Next

        Return ToMD5(AES_encrypt(finalStr))
    End Function

    Public Function ToMD5(ByVal input As String) As String
        Using md5Hash As MD5 = MD5.Create()
            Return GetMd5Hash(md5Hash, input)
        End Using
    End Function

    Public Function ToMD5(ByVal input As Byte()) As String
        Using md5Hash As MD5 = MD5.Create()
            Dim data As Byte() = md5Hash.ComputeHash(input)
            Dim sBuilder As New StringBuilder()
            Dim i As Integer
            For i = 0 To data.Length - 1
                sBuilder.Append(data(i).ToString("x2"))
            Next i
            Return sBuilder.ToString()
        End Using
    End Function

    Private Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function

    Public Function AES_encrypt(Input As String, Optional key As String = "", Optional iv As String = "") As String
        Dim aes As RijndaelManaged = New RijndaelManaged()
        aes.KeySize = 256
        aes.BlockSize = 256
        aes.Padding = PaddingMode.PKCS7
        If key = "" Or iv = "" Then
            aes.Key = Encoding.UTF8.GetBytes(PHPConKey)
            aes.IV = Encoding.UTF8.GetBytes(PHPConIV)
        Else
            aes.Key = Encoding.UTF8.GetBytes(key)
            aes.IV = Encoding.UTF8.GetBytes(iv)
        End If

        Dim encrypt As ICryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV)
        Dim xBuff As Byte() = Nothing
        Using ms As MemoryStream = New MemoryStream()
            Using cs As CryptoStream = New CryptoStream(ms, encrypt, CryptoStreamMode.Write)
                Dim xXml As Byte() = Encoding.UTF8.GetBytes(Input)
                cs.Write(xXml, 0, xXml.Length)
            End Using

            xBuff = ms.ToArray()
        End Using

        Dim Output As String = Convert.ToBase64String(xBuff)
        Return Output
    End Function

    Private Sub fastCopy(source As String, destination As String)
        Dim array_length As Integer = CType(Math.Pow(2, 19), Integer)
        Dim dataArray As Byte() = New Byte(array_length - 1) {}
        Using fsread As New FileStream(source, FileMode.Open, FileAccess.Read, FileShare.None, array_length)
            Using bwread As New BinaryReader(fsread)
                Using fswrite As New FileStream(destination, FileMode.Create, FileAccess.Write, FileShare.None, array_length)
                    Using bwwrite As New BinaryWriter(fswrite)
                        While True
                            Dim read As Integer = bwread.Read(dataArray, 0, array_length)
                            If 0 = read Then
                                Exit While
                            End If
                            bwwrite.Write(dataArray, 0, read)
                        End While
                    End Using
                End Using
            End Using
        End Using
    End Sub


    Public Function toBase64(input As String) As String
        Dim xo As Byte() = Encoding.UTF8.GetBytes(input)
        Return Convert.ToBase64String(xo)
    End Function
End Module
