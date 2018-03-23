Imports System.IO

Public Class ImportFromLogs

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ImportFromLogs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sel_file = frm_AABF_MainWindow.fs_LoadedFile
        sel_file = sel_file.ToString.Substring(0, sel_file.ToString.Length - 4).ToLower & ".log"
        If My.Computer.FileSystem.FileExists(sel_file) Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Me.Show()
            Me.Refresh()
            Dim lineCount = File.ReadAllLines(sel_file).Length
            Me.Focus()
            Dim curlinec = 0
            ToolStripProgressBar1.Maximum = lineCount
            ToolStripStatusLabel1.Text = frm_AABF_MainWindow.s_scanning & " " & sel_file & "..."
            Dim sr As New StreamReader(sel_file.ToString)
            Dim line As String
            Dim splitter
            Dim curstring = ""
            Dim nl = 0
            Dim fl = 1
            Dim sm = 0
            Dim b4 = False
            Dim complete = ""
            Dim curline = 0
            CheckedListBox1.BeginUpdate()
            Do
                line = sr.ReadLine
                If line Is Nothing Then
                    If sel_file = "scripts.log" Then
                        Dim shouldadd = True
                        complete = "#" & curline & "-""" & curstring
                        complete = complete.Substring(0, complete.Length - 2)

                        For Each item In CheckedListBox1.Items
                            If item.ToString = complete Then
                                shouldadd = False
                            End If
                        Next

                        Dim checks() = Split(frm_AABF_MainWindow.dgv_FileLoaded(3, curline).Value, """ !")
                        For Each item In checks
                            If item.ToString.Replace("\""", """").Contains(curstring.Substring(0, curstring.Length - 2)) Then
                                shouldadd = False
                            End If
                        Next

                        If shouldadd = True Then
                            CheckedListBox1.EndUpdate()
                            CheckedListBox1.Items.Add(complete)
                            Me.Refresh()
                            CheckedListBox1.BeginUpdate()
                        End If
                    End If
                    Exit Do
                End If
                curlinec = curlinec + 1
                ToolStripProgressBar1.Value = curlinec - 1
                If curlinec <= 50000 Then
                    If sel_file = "scripts.log" Then

                        If line.Length >= 19 Then
                            If IsDate(line.Substring(0, 19)) Then
                                nl = 1
                            End If
                        End If

                        If nl = 1 Then
                            If curstring.Length > 1 Then
                                Dim shouldadd = True
                                complete = "#" & curline & "-""" & curstring
                                complete = complete.Substring(0, complete.Length - 2)

                                For Each item In CheckedListBox1.Items
                                    If item.ToString = complete Then
                                        shouldadd = False
                                    End If
                                Next

                                Dim checks() = Split(frm_AABF_MainWindow.dgv_FileLoaded(3, curline).Value, """ !")
                                For Each item In checks
                                    If item.ToString.Replace("\""", """").Contains(curstring.Substring(0, curstring.Length - 2)) Then
                                        shouldadd = False
                                    End If
                                Next

                                If shouldadd = True Then
                                    CheckedListBox1.EndUpdate()
                                    CheckedListBox1.Items.Add(complete)
                                    Me.Refresh()
                                    CheckedListBox1.BeginUpdate()
                                End If
                            End If
                            curstring = ""
                            curline = 0
                            complete = ""
                            nl = 0
                            splitter = line.Split(" ")
                            Dim s_linefind = 0
                            Dim s_count = splitter.length
                            For s_find = s_count - 1 To 0 Step -1
                                If splitter(s_find).ToString.StartsWith("#") Then
                                    s_linefind = s_find
                                End If
                            Next
                            curline = splitter(s_linefind).ToString.Substring(1)
                            For s_find = s_linefind + 1 To s_count - 1
                                curstring = curstring & " " & splitter(s_find).ToString
                            Next
                            curstring = curstring.Substring(2) & "\n"
                        Else
                            curstring = curstring & line & "\n"
                        End If

                        'ElseIf sel_file = "createvehicle.log" Then
                        '    b4 = True
                        '    Dim s_linefind = 0
                        '    splitter = line.Split(" ")
                        '    Dim s_count = splitter.length
                        '    For s_find = s_count - 1 To 0 Step -1
                        '        If splitter(s_find).ToString.StartsWith("#") Then
                        '            s_linefind = s_find
                        '        End If
                        '    Next

                        '    Dim shouldadd = True
                        '    complete = splitter(s_linefind) & "-" & splitter(s_linefind + 1)

                        '    For Each item In CheckedListBox1.Items 
                        '        If item.ToString = complete Then
                        '            shouldadd = False
                        '        End If
                        '    Next
                        '    If shouldadd = True Then
                        '        CheckedListBox1.EndUpdate()
                        '        CheckedListBox1.Items.Add(complete)
                        '        Me.Refresh()
                        '        CheckedListBox1.BeginUpdate()
                        '    End If
                    ElseIf sel_file = "selectplayer.log" Then
                        b4 = True
                        Dim s_linefind = 0
                        splitter = line.Split(" ")
                        Dim s_count = splitter.length
                        For s_find = s_count - 1 To 0 Step -1
                            If splitter(s_find).ToString.StartsWith("#") Then
                                s_linefind = s_find
                            End If
                        Next

                        Dim shouldadd = True
                        complete = splitter(s_linefind) & "-" & splitter(s_linefind + 2)

                        For Each item In CheckedListBox1.Items
                            If item.ToString = complete Then
                                shouldadd = False
                            End If
                        Next
                        If shouldadd = True Then
                            CheckedListBox1.EndUpdate()
                            CheckedListBox1.Items.Add(complete)
                            Me.Refresh()
                            CheckedListBox1.BeginUpdate()
                        End If
                    Else
                        MsgBox(frm_AABF_MainWindow.s_not_supported, MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)
                        Exit Do
                    End If
                Else
                    MsgBox(frm_AABF_MainWindow.s_too_long, MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)
                    ToolStripProgressBar1.Maximum = 10
                    ToolStripProgressBar1.Value = 10
                    Exit Do
                End If

            Loop
            CheckedListBox1.EndUpdate()
            Application.DoEvents()

            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            If b4 = True Then
                MsgBox(String.Format(frm_AABF_MainWindow.s_not_scripts, vbNewLine), MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)

            End If
            ToolStripStatusLabel1.Text = frm_AABF_MainWindow.s_done
            ToolStripProgressBar1.Value = ToolStripProgressBar1.Maximum
            sr.Close()
        Else
            MsgBox(frm_AABF_MainWindow.s_no_log, MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)
            Me.Close()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim countchecked = CheckedListBox1.CheckedItems.Count
        If countchecked = 0 Then
            MsgBox(frm_AABF_MainWindow.s_nothing_to_import, MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)
        Else
            Dim splitline
            Dim add_linenumber
            Dim add_textstring
            For Each item In CheckedListBox1.CheckedItems

                splitline = item.ToString.Split("-")

                add_linenumber = splitline(0).ToString.Substring(1)
                add_textstring = item.ToString.Substring(splitline(0).ToString.Length + 2)
                add_textstring = add_textstring.substring(0, add_textstring.length - 1)
                Dim nvalue = add_textstring.Replace(Chr(34), "\""")
                add_textstring = """" & nvalue & """"
                frm_AABF_MainWindow.dgv_FileLoaded.Item(3, add_linenumber).Value = frm_AABF_MainWindow.dgv_FileLoaded.Item(3, add_linenumber).Value & " !=" & add_textstring
            Next
            frm_AABF_MainWindow.mo_lin = 1
            frm_AABF_MainWindow.sb_FE.Text = "(" & frm_AABF_MainWindow.s_edited & ")"
            frm_AABF_MainWindow.lb_Exceptions.Items.Clear()
            frm_AABF_MainWindow.lb_Lines.ClearSelected()
            MsgBox(frm_AABF_MainWindow.s_items_imported, MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim countchecked = CheckedListBox1.CheckedItems.Count
        If countchecked = 0 Then
            MsgBox(frm_AABF_MainWindow.s_nothing_to_import, MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)
        Else
            Dim splitline
            Dim add_linenumber
            Dim add_textstring
            For Each item In CheckedListBox1.CheckedItems
                splitline = item.ToString.Split("-")
                add_linenumber = splitline(0).ToString.Substring(1)
                add_textstring = splitline(1).ToString.Substring(1, splitline(1).ToString.Length - 2)
                Dim nvalue = add_textstring.Replace(Chr(34), "\""")
                add_textstring = """" & nvalue & """"
                frm_AABF_MainWindow.dgv_FileLoaded.Item(3, add_linenumber).Value = frm_AABF_MainWindow.dgv_FileLoaded.Item(3, add_linenumber).Value & " !" & add_textstring
            Next
            frm_AABF_MainWindow.mo_lin = 1
            frm_AABF_MainWindow.sb_FE.Text = "(edited)"
            frm_AABF_MainWindow.lb_Exceptions.Items.Clear()
            frm_AABF_MainWindow.lb_Lines.ClearSelected()
            MsgBox(frm_AABF_MainWindow.s_items_imported, MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For k = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(k, True)

        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For k = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(k, False)

        Next
    End Sub
End Class
