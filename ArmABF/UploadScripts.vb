Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Class UploadScripts
    Private Sub UploadScripts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = ""

        For Each file In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory)
            CheckedListBox1.EndUpdate()
            If Not My.Computer.FileSystem.GetFileInfo(file).Length = 0 Then
                If file.ToString.EndsWith("txt") Then
                    CheckedListBox1.Items.Add(file)
                    CheckedListBox1.SetItemChecked(CheckedListBox1.Items.Count - 1, True)
                End If
                If file.ToString.EndsWith("log") Then
                    CheckedListBox1.Items.Add(file)
                    CheckedListBox1.SetItemChecked(CheckedListBox1.Items.Count - 1, True)
                End If
                CheckedListBox1.BeginUpdate()
            End If
        Next
        CheckedListBox1.EndUpdate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub



    Public Function GeneratePassword()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox(frm_AABF_MainWindow.s_upload_explain)
        Else
            If CheckedListBox1.CheckedItems.Count = 0 Then
                MsgBox(frm_AABF_MainWindow.s_upload_one_file)
            Else
                If TextBox2.Text <> "" And (Not TextBox2.Text.Contains("@") Or Not TextBox2.Text.Contains(".")) Then
                    MsgBox(frm_AABF_MainWindow.s_upload_email)
                Else
                    File.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "\problem_report.txt", TextBox1.Text)
                    If TextBox2.Text <> "" And TextBox2.Text.Contains("@") And TextBox2.Text.Contains(".") Then
                        File.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "\email_address.txt", TextBox2.Text)
                    End If

                    Label3.Text = frm_AABF_MainWindow.s_upload_zip
                    Me.Refresh()
                    Dim zipname = GeneratePassword() & ".zip"
                    Dim fullname = My.Computer.FileSystem.CurrentDirectory & "\" & zipname
                    Using zip As ZipArchive = ZipFile.Open(zipname, ZipArchiveMode.Create)
                    End Using
                    Using modFile As ZipArchive = ZipFile.Open(zipname, ZipArchiveMode.Update)
                        For Each item In CheckedListBox1.CheckedItems
                            modFile.CreateEntryFromFile(item, Path.GetFileName(item))
                        Next
                        modFile.CreateEntryFromFile(My.Computer.FileSystem.CurrentDirectory & "\problem_report.txt", Path.GetFileName(My.Computer.FileSystem.CurrentDirectory & "\problem_report.txt"))
                        If TextBox2.Text <> "" Then
                            modFile.CreateEntryFromFile(My.Computer.FileSystem.CurrentDirectory & "\email_address.txt", Path.GetFileName(My.Computer.FileSystem.CurrentDirectory & "\email_address.txt"))
                        End If
                    End Using
                    Label3.Text = frm_AABF_MainWindow.s_upload_upload_zip
                    Me.Refresh()
                    My.Computer.Network.UploadFile(fullname, "http://bem.themeq.xyz/upload.php")
                    Label3.Text = frm_AABF_MainWindow.s_uploaded_zip
                    Me.Refresh()
                    MsgBox(frm_AABF_MainWindow.s_upload_thanks)
                    My.Computer.FileSystem.DeleteFile(fullname)
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.CurrentDirectory & "\problem_report.txt")
                    If TextBox2.Text <> "" And TextBox2.Text.Contains("@") And TextBox2.Text.Contains(".") Then
                        My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.CurrentDirectory & "\email_address.txt")
                    End If
                    Label3.Text = ""
                    Me.Hide()
                End If
            End If
        End If

    End Sub
End Class