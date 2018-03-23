Imports System.IO
Imports System.Net

Public Class frm_AABF_MainWindow

    Public fs_LoadedFile = ""

    Public ob_LineNumber = -1
    Public mo_lin = 0
    Public aa_thisver = "1.7.0.5"
    Public aa_latever = ""
    Public file_error = 0
    Public current_language = "EN"
    Public rm As Resources.ResourceManager
    Public Shared s_changes_to_file, s_could_not_open_file, s_processing, s_loading_error, s_unable_to_launch, s_no_files_found
    Public Shared s_update_application, s_latest_version, s_need_to_open_file, s_need_to_select_line, s_confirm_delete_keyword
    Public Shared s_need_to_select_filter, s_confirm_delete_filter, s_backed_up, s_failed_backed_up, s_need_to_logging_type
    Public Shared s_need_keyword, s_edited, s_need_to_exception_type, s_need_value, s_fix_backslash, s_scanning, s_not_supported
    Public Shared s_too_long, s_not_scripts, s_done, s_no_log, s_nothing_to_import, s_items_imported, s_upload_explain
    Public Shared s_upload_one_file, s_upload_email, s_upload_zip, s_upload_upload_zip, s_upload_thanks, s_wait, s_uploaded_zip, s_write_protect

    Private Sub frm_AABF_MainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("lang.cfg", False)
            file.WriteLine(current_language)
            file.Close()
        Catch ex As Exception
            MsgBox(s_write_protect)
        End Try
    End Sub

    Private Sub 簡體中文KondouToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 簡體中文KondouToolStripMenuItem.Click
        SetLanguage("CNS")
        ToolStripDropDownButton2.Image = My.Resources.cn
        current_language = "CNS"
    End Sub

    Private Sub DeutscheKaioniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeutscheKaioniToolStripMenuItem.Click
        SetLanguage("DE")
        ToolStripDropDownButton2.Image = My.Resources.de
        current_language = "DE"
    End Sub

    Private Sub DutchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DutchToolStripMenuItem.Click
        SetLanguage("NL")
        ToolStripDropDownButton2.Image = My.Resources.nl
        current_language = "NL"
    End Sub

    Private Sub 繁體中文KondouToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 繁體中文KondouToolStripMenuItem.Click
        SetLanguage("CNT")
        ToolStripDropDownButton2.Image = My.Resources.cn
        current_language = "CNT"
    End Sub

    Private Sub РусскийMentaiCosmicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РусскийMentaiCosmicToolStripMenuItem.Click
        SetLanguage("RU")
        ToolStripDropDownButton2.Image = My.Resources.ru
        current_language = "RU"
    End Sub

    Private Sub FranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FranToolStripMenuItem.Click
        SetLanguage("FR")
        ToolStripDropDownButton2.Image = My.Resources.fr
        current_language = "FR"
    End Sub

    Private Sub 한국어MinimalResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 한국어MinimalResultsToolStripMenuItem.Click
        SetLanguage("KR")
        ToolStripDropDownButton2.Image = My.Resources.kr
        current_language = "KR"
    End Sub

    Private Sub SpanishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpanishToolStripMenuItem.Click
        SetLanguage("SP")
        ToolStripDropDownButton2.Image = My.Resources.es
        current_language = "SP"
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        SetLanguage("FI")
        ToolStripDropDownButton2.Image = My.Resources.fi
        current_language = "FI"
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        SetLanguage("EN")
        ToolStripDropDownButton2.Image = My.Resources.gb
        current_language = "EN"
    End Sub


    Public Sub SetLanguage(ByVal strLanguage As String)
        rm = My.Resources.English.ResourceManager
        If strLanguage = "EN" Then
            rm = My.Resources.English.ResourceManager
            ToolStripDropDownButton2.Image = My.Resources.gb
        ElseIf strLanguage = "FI" Then
            rm = My.Resources.Finnish.ResourceManager
            ToolStripDropDownButton2.Image = My.Resources.fi
        ElseIf strLanguage = "KR" Then
            rm = My.Resources.Korean.ResourceManager
            ToolStripDropDownButton2.Image = My.Resources.kr
        ElseIf strLanguage = "SP" Then
            rm = My.Resources.Spanish.ResourceManager
            ToolStripDropDownButton2.Image = My.Resources.es
        ElseIf strLanguage = "FR" Then
            rm = My.Resources.French.ResourceManager
            ToolStripDropDownButton2.Image = My.Resources.fr
        ElseIf strLanguage = "RU" Then
            rm = My.Resources.Russian.ResourceManager
            ToolStripDropDownButton2.Image = My.Resources.ru
        ElseIf strLanguage = "CNS" Then
            rm = My.Resources.ChineseS.ResourceManager
            ToolStripDropDownButton2.Image = My.Resources.cn
        ElseIf strLanguage = "CNT" Then
            rm = My.Resources.ChineseT.ResourceManager
            ToolStripDropDownButton2.Image = My.Resources.cn
        ElseIf strLanguage = "DE" Then
            rm = My.Resources.German.ResourceManager
            ToolStripDropDownButton2.Image = My.Resources.de
        ElseIf strLanguage = "NL" Then
            rm = My.Resources.Dutch.ResourceManager
            ToolStripDropDownButton2.Image = My.Resources.nl
        Else
            rm = My.Resources.English.ResourceManager
            ToolStripDropDownButton2.Image = My.Resources.gb
        End If

        ' Main Window
        tsl_File.Text = rm.GetString("t_choose_file")
        If fs_LoadedFile = "" Then
            tsc_FileSelector.Text = rm.GetString("t_no_file_selected")
            tssl_FileLoaded.Text = rm.GetString("t_load_to_start")
        End If

        tsb_Load.Text = rm.GetString("t_load_file")
        tsb_Save.Text = rm.GetString("t_save_file")
        ToolStripButton2.Text = rm.GetString("t_upload_scripts")
        ToolStripButton10.Text = rm.GetString("t_import_from_logs")
        ToolStripDropDownButton1.Text = rm.GetString("t_options")
        DonateToolStripMenuItem.Text = rm.GetString("t_donate")
        CheckForUpdatesToolStripMenuItem.Text = rm.GetString("t_check_for_updates")
        AboutToolStripMenuItem.Text = rm.GetString("t_about")
        ToolStripButton5.Text = rm.GetString("t_add_keyword")
        ToolStripButton6.Text = rm.GetString("t_remove_keyword")
        ToolStripButton7.Text = rm.GetString("t_edit_keyword")
        tsb_AddEntry.Text = rm.GetString("t_add_filter")
        ToolStripButton1.Text = rm.GetString("t_remove_filter")
        ToolStripButton8.Text = rm.GetString("t_edit_filter")
        tssl_CurrentlyLoaded.Text = rm.GetString("t_currently_loaded")

        ' Form 2
        AddKeyword.Text = rm.GetString("t_add_keyword")
        AddKeyword.Label1.Text = rm.GetString("t_logging_type") & ":"
        AddKeyword.Label2.Text = rm.GetString("t_keyword") & ":"
        AddKeyword.DomainUpDown1.Text = "- " & rm.GetString("t_choose") & " -"
        AddKeyword.Label3.Text = rm.GetString("t_keyword_double_quotes") & vbNewLine & rm.GetString("t_keyword_backslash")
        AddKeyword.Button2.Text = rm.GetString("t_cancel")
        AddKeyword.Button1.Text = rm.GetString("t_add_keyword")
        AddKeyword.DomainUpDown1.Items.Clear()
        AddKeyword.DomainUpDown1.Items.Add("1 - " & rm.GetString("t_logging_type_1"))
        AddKeyword.DomainUpDown1.Items.Add("2 - " & rm.GetString("t_logging_type_2"))
        AddKeyword.DomainUpDown1.Items.Add("3 - " & rm.GetString("t_logging_type_3"))
        AddKeyword.DomainUpDown1.Items.Add("4 - " & rm.GetString("t_logging_type_4"))
        AddKeyword.DomainUpDown1.Items.Add("5 - " & rm.GetString("t_logging_type_5"))
        AddKeyword.DomainUpDown1.Items.Add("6 - " & rm.GetString("t_logging_type_6"))
        AddKeyword.DomainUpDown1.Items.Add("7 - " & rm.GetString("t_logging_type_7"))

        ' Form 3
        AddFilter.Text = rm.GetString("t_add_filter")
        AddFilter.Label1.Text = rm.GetString("t_exception_type") & ":"
        AddFilter.Label2.Text = rm.GetString("t_value") & ":"
        AddFilter.DomainUpDown1.Text = "- " & rm.GetString("t_choose") & " -"
        AddFilter.Label3.Text = rm.GetString("t_value_double_quotes")
        AddFilter.Button2.Text = rm.GetString("t_cancel")
        AddFilter.Button1.Text = rm.GetString("t_add_filter")
        AddFilter.DomainUpDown1.Items.Clear()
        AddFilter.DomainUpDown1.Items.Add("!= " & rm.GetString("t_parameter_match_1"))
        AddFilter.DomainUpDown1.Items.Add("! - " & rm.GetString("t_parameter_match_2"))

        'Form 4
        EditKeyword.Text = rm.GetString("t_edit_keyword")
        EditKeyword.Label1.Text = rm.GetString("t_logging_type") & ":"
        EditKeyword.Label2.Text = rm.GetString("t_keyword") & ":"
        EditKeyword.DomainUpDown1.Text = "- " & rm.GetString("t_choose") & " -"
        EditKeyword.Label3.Text = rm.GetString("t_keyword_double_quotes") & vbNewLine & rm.GetString("t_keyword_backslash")
        EditKeyword.Button2.Text = rm.GetString("t_cancel")
        EditKeyword.Button1.Text = rm.GetString("t_edit_keyword")
        EditKeyword.DomainUpDown1.Items.Clear()
        EditKeyword.DomainUpDown1.Items.Add("1 - " & rm.GetString("t_logging_type_1"))
        EditKeyword.DomainUpDown1.Items.Add("2 - " & rm.GetString("t_logging_type_2"))
        EditKeyword.DomainUpDown1.Items.Add("3 - " & rm.GetString("t_logging_type_3"))
        EditKeyword.DomainUpDown1.Items.Add("4 - " & rm.GetString("t_logging_type_4"))
        EditKeyword.DomainUpDown1.Items.Add("5 - " & rm.GetString("t_logging_type_5"))
        EditKeyword.DomainUpDown1.Items.Add("6 - " & rm.GetString("t_logging_type_6"))
        EditKeyword.DomainUpDown1.Items.Add("7 - " & rm.GetString("t_logging_type_7"))

        'Form 5
        EditFilter.Text = rm.GetString("t_edit_filter")
        EditFilter.Label1.Text = rm.GetString("t_exception_type") & ":"
        EditFilter.Label2.Text = rm.GetString("t_value") & ":"
        EditFilter.DomainUpDown1.Text = "- " & rm.GetString("t_choose") & " -"
        EditFilter.Label3.Text = rm.GetString("t_value_double_quotes")
        EditFilter.Button2.Text = rm.GetString("t_cancel")
        EditFilter.Button1.Text = rm.GetString("t_edit_filter")
        EditFilter.DomainUpDown1.Items.Clear()
        EditFilter.DomainUpDown1.Items.Add("!= - " & rm.GetString("t_parameter_match_1"))
        EditFilter.DomainUpDown1.Items.Add("! - " & rm.GetString("t_parameter_match_2"))

        'Form 6
        ImportFromLogs.Text = rm.GetString("t_import_from_logs")
        ImportFromLogs.Button4.Text = rm.GetString("t_select_all")
        ImportFromLogs.Button5.Text = rm.GetString("t_select_none")
        ImportFromLogs.Button2.Text = rm.GetString("t_cancel")
        ImportFromLogs.Button3.Text = rm.GetString("t_import_as") & " !"
        ImportFromLogs.Button1.Text = rm.GetString("t_import_as") & " !="
        ImportFromLogs.ToolStripStatusLabel1.Text = rm.GetString("t_idle")

        'Form 7
        UploadScripts.Text = rm.GetString("t_upload_scripts")
        UploadScripts.Label1.Text = rm.GetString("t_upload_intro")
        UploadScripts.Label2.Text = rm.GetString("t_upload_filelist")
        UploadScripts.Label4.Text = rm.GetString("t_upload_message")
        UploadScripts.Label5.Text = rm.GetString("t_upload_email")
        UploadScripts.Button2.Text = rm.GetString("t_cancel")
        UploadScripts.Button1.Text = rm.GetString("t_send")

        ' Strings
        s_wait = rm.GetString("t_wait")
        s_changes_to_file = rm.GetString("s_changes_to_file")
        s_could_not_open_file = rm.GetString("s_could_not_open_file")
        s_processing = rm.GetString("s_processing")
        s_loading_error = rm.GetString("s_loading_error")
        s_unable_to_launch = rm.GetString("s_unable_to_launch")
        s_no_files_found = rm.GetString("s_no_files_found")
        s_update_application = rm.GetString("s_update_application")
        s_latest_version = rm.GetString("s_latest_version")
        s_need_to_open_file = rm.GetString("s_need_to_open_file")
        s_need_to_select_line = rm.GetString("s_need_to_select_line")
        s_confirm_delete_keyword = rm.GetString("s_confirm_delete_keyword")
        s_need_to_select_filter = rm.GetString("s_need_to_select_filter")
        s_confirm_delete_filter = rm.GetString("s_confirm_delete_filter")
        s_backed_up = rm.GetString("s_backed_up")
        s_failed_backed_up = rm.GetString("s_failed_backed_up")
        s_need_to_logging_type = rm.GetString("s_need_to_logging_type")
        s_need_keyword = rm.GetString("s_need_keyword")
        s_edited = rm.GetString("s_edited")
        s_need_to_exception_type = rm.GetString("s_need_to_exception_type")
        s_need_value = rm.GetString("s_need_value")
        s_fix_backslash = rm.GetString("s_fix_backslash")
        s_scanning = rm.GetString("s_scanning")
        s_not_supported = rm.GetString("s_not_supported")
        s_too_long = rm.GetString("s_too_long")
        s_not_scripts = rm.GetString("s_not_scripts")
        s_done = rm.GetString("s_done")
        s_no_log = rm.GetString("s_no_log")
        s_nothing_to_import = rm.GetString("s_nothing_to_import")
        s_items_imported = rm.GetString("s_items_imported")
        s_upload_explain = rm.GetString("s_upload_explain")
        s_upload_one_file = rm.GetString("s_upload_one_file")
        s_upload_email = rm.GetString("s_upload_email")
        s_upload_zip = rm.GetString("s_upload_zip")
        s_upload_upload_zip = rm.GetString("s_upload_upload_zip")
        s_upload_thanks = rm.GetString("s_upload_thanks")
        s_uploaded_zip = rm.GetString("s_uploaded_zip")
        s_write_protect = rm.GetString("s_write_protect")
    End Sub

    Public Sub fun_parser(ob_ToParse)
        Dim b()
        If Not ob_ToParse.ToString.StartsWith("//") Or Not ob_ToParse Is Nothing Then
            ob_LineNumber = ob_LineNumber + 1
            b = Split(ob_ToParse, " ")
            Try
                Dim count_b = b.Count
                Dim exception_catch = b(0)
                Dim keyword = ""
                Dim foundend = 0
                If b.Length > 1 Then
                    If b(1).ToString.StartsWith("""") And Not b(1).ToString.EndsWith("""") Then
                        For k = 2 To b.Count() - 1
                            If b(k).ToString.EndsWith("""") And foundend = 0 Then
                                foundend = k
                            End If
                        Next
                        For k = 1 To foundend
                            keyword = keyword & " " & b(k)
                        Next
                    ElseIf b(1).ToString = """" Then
                        For k = 2 To b.Count() - 1
                            If b(k).ToString = ("""") And b(k - 1).ToString <> "\" Then
                                foundend = k
                            End If
                        Next
                        For k = 1 To foundend
                            keyword = keyword & " " & b(k)
                        Next
                    Else
                        keyword = b(1)
                    End If
                End If
                Dim parameters = ""
                If foundend <> 0 Then
                    For k = foundend + 1 To count_b - 1
                        parameters = parameters & " " & b(k)
                    Next
                Else
                    For k = 2 To count_b - 1
                        parameters = parameters & " " & b(k)
                    Next
                End If
                If Not exception_catch.startswith("//") Then
                    If Not exception_catch = "" Then
                        dgv_FileLoaded.Rows.Add(New String() {exception_catch, ob_LineNumber, keyword, parameters})
                    End If
                End If

            Catch ex As Exception
                file_error = 1
            End Try
        End If
    End Sub

    Public Sub reloadFile()
        lb_Lines.Items.Clear()
        lb_Exceptions.Items.Clear()
        dgv_SelectedRow.Rows.Clear()

        For k = 0 To dgv_FileLoaded.RowCount - 1
            dgv_FileLoaded.Item(1, k).Value = k
            lb_Lines.Items.Add("Line " & dgv_FileLoaded.Item(1, k).Value & ",Log " & dgv_FileLoaded.Item(0, k).Value & ",Keyword " & dgv_FileLoaded.Item(2, k).Value)
        Next

        Dim myDelims As String() = New String() {""" !"}
        If dgv_FileLoaded.Rows.Count > 0 Then
            Dim param = dgv_FileLoaded.Item(3, 0).Value.ToString
            Dim loadup() = param.Trim.Split(myDelims, StringSplitOptions.None)

            For k = 0 To loadup.Length() - 1
                If loadup(k).StartsWith("=") Then
                    dgv_SelectedRow.Rows.Add(New String() {"!=", loadup(k).Substring(1) & """"})
                ElseIf loadup(k).StartsWith("!=") Then
                    dgv_SelectedRow.Rows.Add(New String() {"!=", loadup(k).Substring(2) & """"})
                ElseIf loadup(k).StartsWith("!") Then
                    dgv_SelectedRow.Rows.Add(New String() {"!", loadup(k).Substring(1) & """"})
                Else
                    dgv_SelectedRow.Rows.Add(New String() {"!", loadup(k) & """"})
                End If
                If k = loadup.Length() - 1 Then
                    dgv_SelectedRow.Item(1, k).Value = dgv_SelectedRow.Item(1, k).Value.ToString.Substring(0, dgv_SelectedRow.Item(1, k).Value.ToString.Length - 1)
                End If
            Next
        Else
            lb_Lines.Items.Clear()
        End If

    End Sub

    Private Sub tsb_Load_Click(sender As System.Object, e As System.EventArgs) Handles tsb_Load.Click
        file_error = 0
        If mo_lin = 1 Then
            Dim result = MsgBox(String.Format(frm_AABF_MainWindow.s_changes_to_file, vbNewLine), MsgBoxStyle.OkCancel, s_wait)
            If result = MsgBoxResult.Ok Then
                mo_lin = 0
                tsc_FileSelector.SelectedIndex = tsc_FileSelector.FindString(fs_LoadedFile.ToString.Substring(0, fs_LoadedFile.ToString.Length - 5))
                sb_FE.Text = "(" & frm_AABF_MainWindow.s_edited & ")"
            End If
        Else
            If Not My.Computer.FileSystem.FileExists(tsc_FileSelector.Text.ToString & ".txt") Then
                MsgBox(String.Format(frm_AABF_MainWindow.s_could_not_open_file, tsc_FileSelector.Text.ToString), MsgBoxStyle.OkOnly, s_wait)
                sb_FE.Text = ""
            Else
                sb_FE.Text = ""
                lb_Exceptions.Items.Clear()
                lb_Lines.Items.Clear()
                dgv_FileLoaded.Rows.Clear()
                dgv_SelectedRow.Rows.Clear()
                ob_LineNumber = 0
                tssl_FileLoaded.Text = frm_AABF_MainWindow.s_processing & " " & tsc_FileSelector.Text.ToString & "..."
                Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(tsc_FileSelector.Text.ToString & ".txt")
                Dim a As String
                Do
                    a = reader.ReadLine
                    If Not a Is Nothing And file_error <> 1 Then

                        fun_parser(a)

                    End If

                Loop Until a Is Nothing
                reader.Close()

                reloadFile()
                If file_error = 0 Then
                    fs_LoadedFile = tsc_FileSelector.Text.ToString & ".txt"
                    tssl_FileLoaded.Text = tsc_FileSelector.Text.ToString
                Else
                    tssl_FileLoaded.Text = frm_AABF_MainWindow.s_loading_error
                    lb_Lines.Items.Clear()
                    lb_Exceptions.Items.Clear()

                End If
            End If
        End If

    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs)
        End
    End Sub

    Private Sub frm_AABF_MainWindow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("lang.cfg") Then
            Using r As StreamReader = New StreamReader("lang.cfg")
                current_language = r.ReadLine
            End Using
        Else
            current_language = "EN"
        End If

        SetLanguage(current_language)
        If Not My.Computer.FileSystem.FileExists("scripts.txt") Then
            MsgBox(String.Format(frm_AABF_MainWindow.s_unable_to_launch, vbNewLine), vbOKOnly, s_wait)
            End
        End If
        For Each File In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory)
            If File.EndsWith(".txt") And Not File.ToLower.EndsWith("bans.txt") And Not File.ToLower.EndsWith("eula.txt") Then
                tsc_FileSelector.Items.Add(My.Computer.FileSystem.GetName(File).Substring(0, My.Computer.FileSystem.GetName(File).ToString.Length - 4))
            End If
        Next
        If tsc_FileSelector.Items.Count > 0 Then
            tsc_FileSelector.Text = tsc_FileSelector.Items(0).ToString
        Else
            tsc_FileSelector.Text = frm_AABF_MainWindow.s_no_files_found
        End If
        update_timer.Enabled = True
        Dim address As String = "http://themeq.xyz/aabefm/ver.txt"
        Dim client As WebClient = New WebClient()
        client.CachePolicy = New System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore)
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        aa_latever = reader.ReadToEnd
        reader.Close()

        If aa_latever <> aa_thisver Then
            CheckForUpdatesToolStripMenuItem.Text = frm_AABF_MainWindow.s_update_application & " (" & frm_AABF_MainWindow.s_latest_version & ": " & aa_latever & ")"
            CheckForUpdatesToolStripMenuItem.ForeColor = Color.Red
            ToolStripDropDownButton1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub lb_Lines_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lb_Lines.SelectedIndexChanged
        If lb_Lines.SelectedIndex >= 0 Then
            lb_Exceptions.Items.Clear()
            dgv_SelectedRow.Rows.Clear()
            Dim myDelims As String() = New String() {""" !"}
            Dim loadup() = dgv_FileLoaded.Item(3, lb_Lines.SelectedIndex).Value.ToString.Trim.Split(myDelims, StringSplitOptions.None)

            For k = 0 To loadup.Length() - 1
                If loadup(k).StartsWith("=") Then
                    dgv_SelectedRow.Rows.Add(New String() {"!=", loadup(k).Substring(1) & """"})
                ElseIf loadup(k).StartsWith("!=") Then
                    dgv_SelectedRow.Rows.Add(New String() {"!=", loadup(k).Substring(2) & """"})
                ElseIf loadup(k).StartsWith("!") Then
                    dgv_SelectedRow.Rows.Add(New String() {"!", loadup(k).Substring(1) & """"})
                Else
                    dgv_SelectedRow.Rows.Add(New String() {"!", loadup(k) & """"})
                End If
                If k = loadup.Length() - 1 Then
                    dgv_SelectedRow.Item(1, k).Value = dgv_SelectedRow.Item(1, k).Value.ToString.Substring(0, dgv_SelectedRow.Item(1, k).Value.ToString.Length - 1)
                End If
            Next



            For k = 0 To dgv_SelectedRow.RowCount - 1
                lb_Exceptions.Items.Add(dgv_SelectedRow.Item(0, k).Value & dgv_SelectedRow.Item(1, k).Value)
            Next

            If lb_Exceptions.Items.Count = 1 And lb_Exceptions.Items(0) = "!" Then
                lb_Exceptions.Items.Clear()
            End If


        End If
    End Sub



    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        If fs_LoadedFile = "" Then
            MsgBox(frm_AABF_MainWindow.s_need_to_open_file, MsgBoxStyle.OkOnly, s_wait)
        Else
            SetLanguage(current_language)
            AddKeyword.Show()
        End If

    End Sub

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        If fs_LoadedFile = "" Then
            MsgBox(frm_AABF_MainWindow.s_need_to_open_file, MsgBoxStyle.OkOnly, s_wait)
        Else
            If lb_Lines.SelectedItems.Count = 0 Then
                MsgBox(frm_AABF_MainWindow.s_need_to_select_line, MsgBoxStyle.OkOnly, s_wait)
            Else
                Dim result = MsgBox(frm_AABF_MainWindow.s_confirm_delete_keyword, MsgBoxStyle.YesNo, s_wait)
                If result = MsgBoxResult.Yes Then
                    dgv_FileLoaded.Rows.RemoveAt(lb_Lines.SelectedIndex)
                    reloadFile()
                    mo_lin = 1
                End If
            End If
        End If
    End Sub

    Private Sub tsb_AddEntry_Click(sender As System.Object, e As System.EventArgs) Handles tsb_AddEntry.Click
        If fs_LoadedFile = "" Then
            MsgBox(frm_AABF_MainWindow.s_need_to_open_file, MsgBoxStyle.OkOnly, s_wait)
        Else
            If lb_Lines.SelectedItems.Count = 0 Then
                MsgBox(frm_AABF_MainWindow.s_need_to_select_line, MsgBoxStyle.OkOnly, s_wait)
            Else
                SetLanguage(current_language)
                AddFilter.Show()
            End If
        End If
    End Sub

    Public Sub rebuildExceptions()
        Dim parambuilder = ""
        For Each item In lb_Exceptions.Items
            parambuilder = parambuilder & " " & item.ToString
        Next
        dgv_FileLoaded.Item(3, lb_Lines.SelectedIndex).Value = parambuilder
        If lb_Lines.SelectedIndex >= 0 Then
            lb_Exceptions.Items.Clear()
            dgv_SelectedRow.Rows.Clear()
            Dim myDelims As String() = New String() {""" !"}
            Dim loadup() = dgv_FileLoaded.Item(3, lb_Lines.SelectedIndex).Value.ToString.Trim.Split(myDelims, StringSplitOptions.None)

            For k = 0 To loadup.Length() - 1
                If loadup(k).StartsWith("=") Then
                    dgv_SelectedRow.Rows.Add(New String() {"!=", loadup(k).Substring(1) & """"})
                ElseIf loadup(k).StartsWith("!=") Then
                    dgv_SelectedRow.Rows.Add(New String() {"!=", loadup(k).Substring(2) & """"})
                ElseIf loadup(k).StartsWith("!") Then
                    dgv_SelectedRow.Rows.Add(New String() {"!", loadup(k).Substring(1) & """"})
                Else
                    dgv_SelectedRow.Rows.Add(New String() {"!", loadup(k) & """"})
                End If
                If k = loadup.Length() - 1 Then
                    dgv_SelectedRow.Item(1, k).Value = dgv_SelectedRow.Item(1, k).Value.ToString.Substring(0, dgv_SelectedRow.Item(1, k).Value.ToString.Length - 1)
                End If
            Next
            For k = 0 To dgv_SelectedRow.RowCount - 1
                lb_Exceptions.Items.Add(dgv_SelectedRow.Item(0, k).Value & dgv_SelectedRow.Item(1, k).Value)
            Next
            If lb_Exceptions.Items.Count = 1 And lb_Exceptions.Items(0) = "!" Then
                lb_Exceptions.Items.Clear()
            End If
        End If
    End Sub


    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        If fs_LoadedFile = "" Then
            MsgBox(frm_AABF_MainWindow.s_need_to_open_file, MsgBoxStyle.OkOnly, s_wait)
        Else
            If lb_Lines.SelectedItems.Count = 0 Then
                MsgBox(frm_AABF_MainWindow.s_need_to_select_line, MsgBoxStyle.OkOnly, s_wait)
            Else
                If lb_Exceptions.SelectedItems.Count = 0 Then
                    MsgBox(frm_AABF_MainWindow.s_need_to_select_filter, MsgBoxStyle.OkOnly, s_wait)
                Else
                    Dim result = MsgBox(frm_AABF_MainWindow.s_confirm_delete_filter, MsgBoxStyle.YesNo, s_wait)
                    If result = MsgBoxResult.Yes Then
                        dgv_SelectedRow.Rows.RemoveAt(lb_Exceptions.SelectedIndex)
                        lb_Exceptions.Items.RemoveAt(lb_Exceptions.SelectedIndex)
                        rebuildExceptions()
                        mo_lin = 1
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
        If fs_LoadedFile = "" Then
            MsgBox(frm_AABF_MainWindow.s_need_to_open_file, MsgBoxStyle.OkOnly, s_wait)
        Else
            If lb_Lines.SelectedItems.Count = 0 Then
                MsgBox(frm_AABF_MainWindow.s_need_to_select_line, MsgBoxStyle.OkOnly, s_wait)
            Else
                SetLanguage(current_language)
                EditKeyword.Show()
            End If
        End If
    End Sub

    Private Sub ToolStripButton8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton8.Click
        If fs_LoadedFile = "" Then
            MsgBox(frm_AABF_MainWindow.s_need_to_open_file, MsgBoxStyle.OkOnly, s_wait)
        Else
            If lb_Lines.SelectedItems.Count = 0 Then
                MsgBox(frm_AABF_MainWindow.s_need_to_select_line, MsgBoxStyle.OkOnly, s_wait)
            Else
                If lb_Exceptions.SelectedItems.Count = 0 Then
                    MsgBox(frm_AABF_MainWindow.s_need_to_select_filter, MsgBoxStyle.OkOnly, s_wait)
                Else
                    SetLanguage(current_language)
                    EditFilter.Show()
                End If
            End If
        End If
    End Sub

    Public mode = 0

    Private Sub tss_3_Click(sender As System.Object, e As System.EventArgs) Handles tss_3.Click
        mode = mode + 1
        If mode > 3 Then
            mode = 0
        End If
        If mode = 1 Then
            dgv_FileLoaded.Visible = True
            dgv_SelectedRow.Visible = False
        End If
        If mode = 2 Then
            dgv_FileLoaded.Visible = False
            dgv_SelectedRow.Visible = True
        End If
        If mode = 3 Then
            dgv_FileLoaded.Visible = True
            dgv_SelectedRow.Visible = True
        End If
        If mode = 0 Then
            dgv_FileLoaded.Visible = False
            dgv_SelectedRow.Visible = False
        End If
    End Sub

    Private Sub tsc_FileSelector_Click(sender As System.Object, e As System.EventArgs) Handles tsc_FileSelector.Click

    End Sub

    Private Sub tsb_Save_Click(sender As System.Object, e As System.EventArgs) Handles tsb_Save.Click
        If My.Computer.FileSystem.FileExists(tsc_FileSelector.Text.ToString & ".txt") Then
            Try
                My.Computer.FileSystem.RenameFile(tsc_FileSelector.Text.ToString & ".txt", tsc_FileSelector.Text.ToString & ".txt" & "." & Replace(Replace(Date.UtcNow, "/", "-").ToString, ":", "-").ToString)
                FileOpen(1, tsc_FileSelector.Text.ToString & ".txt", OpenMode.Output)
                PrintLine(1, "//new2")
                For k = 0 To dgv_FileLoaded.Rows.Count - 1
                    PrintLine(1, dgv_FileLoaded.Item(0, k).Value.ToString.Trim & " " & dgv_FileLoaded.Item(2, k).Value.ToString.Trim & " " & dgv_FileLoaded.Item(3, k).Value.ToString.Trim)
                Next
                FileClose(1)
                MsgBox(String.Format(frm_AABF_MainWindow.s_backed_up, tsc_FileSelector.Text.ToString), MsgBoxStyle.OkOnly, s_wait)
                mo_lin = 1
                sb_FE.Text = ""
            Catch ex As Exception
                MsgBox(String.Format(frm_AABF_MainWindow.s_failed_backed_up, vbNewLine, ex.Message), MsgBoxStyle.OkOnly, s_wait)
            End Try

        End If
    End Sub

    Private Sub ToolStripButton9_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton10_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton10.Click
        If fs_LoadedFile = "" Then
            MsgBox(frm_AABF_MainWindow.s_need_to_open_file, MsgBoxStyle.OkOnly, s_wait)
        Else
            SetLanguage(current_language)
            ImportFromLogs.Show()
        End If

    End Sub

    Private Sub DonateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolStripMenuItem.Click
        Process.Start("http://paypal.me/themeq")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Process.Start("http://themeq.xyz/aabefm/update.php?cur_ver=" & aa_thisver)
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        SetLanguage(current_language)
        UploadScripts.Show()
    End Sub

    Private Sub update_timer_Tick(sender As Object, e As EventArgs) Handles update_timer.Tick
        Dim address As String = "http://themeq.xyz/aabefm/ver.txt"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        aa_latever = reader.ReadToEnd
        reader.Close()

        If aa_latever <> aa_thisver Then
            CheckForUpdatesToolStripMenuItem.Text = frm_AABF_MainWindow.s_update_application & " (" & frm_AABF_MainWindow.s_latest_version & ": " & aa_latever & ")"
            CheckForUpdatesToolStripMenuItem.ForeColor = Color.Red
            ToolStripDropDownButton1.ForeColor = Color.Red
        End If
    End Sub
End Class
