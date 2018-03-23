Public Class AddFilter

    Public hasasked = 0

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim logval = DomainUpDown1.SelectedIndex + 1
        If logval = 0 Then
            MsgBox(frm_AABF_MainWindow.s_need_to_exception_type, MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)
        Else

            If TextBox1.Text = "" Then
                MsgBox(frm_AABF_MainWindow.s_need_value, MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)
            Else
                If TextBox1.Text.Contains("\n") And hasasked = 0 Then
                    If MsgBox(frm_AABF_MainWindow.s_fix_backslash, MsgBoxStyle.YesNo, frm_AABF_MainWindow.s_wait) = MsgBoxResult.Yes Then

                        Dim str = TextBox1.Text.Replace("\", "\\")
                        TextBox1.Text = str

                    End If
                End If
                hasasked = 1
                TextBox1.Text = TextBox1.Text.Replace(Chr(13) & Chr(10), "\n")
                If Not TextBox1.Text.StartsWith("""") And Not TextBox1.Text.EndsWith("""") Then
                    TextBox1.Text = """" & TextBox1.Text & """"
                End If
                Dim value = TextBox1.Text.Substring(1, TextBox1.TextLength - 2)
                Dim nvalue = value.Replace(Chr(34), "\""")
                TextBox1.Text = """" & nvalue & """"
                Dim exc = ""
                If logval = 1 Then
                    exc = "!="
                Else
                    exc = "!"
                End If
                If frm_AABF_MainWindow.dgv_SelectedRow.Item(0, 0).Value = "!" And frm_AABF_MainWindow.dgv_SelectedRow.Item(1, 0).Value = "" Then
                    frm_AABF_MainWindow.dgv_SelectedRow.Rows.Clear()
                End If
                frm_AABF_MainWindow.dgv_SelectedRow.Rows.Add({exc, TextBox1.Text})
                frm_AABF_MainWindow.dgv_FileLoaded.Item(3, frm_AABF_MainWindow.lb_Lines.SelectedIndex).Value = frm_AABF_MainWindow.dgv_FileLoaded.Item(3, frm_AABF_MainWindow.lb_Lines.SelectedIndex).Value & " " & exc & TextBox1.Text
                frm_AABF_MainWindow.lb_Exceptions.Items.Add(exc & TextBox1.Text)
                frm_AABF_MainWindow.mo_lin = 1
                frm_AABF_MainWindow.sb_FE.Text = "(" & frm_AABF_MainWindow.s_edited & ")"
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub AddFilter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        hasasked = 0
        DomainUpDown1.Location = New Point(Label1.Location.X + Label1.Width + 5, DomainUpDown1.Location.Y)
        If DomainUpDown1.Location.X <= 103 Then
            DomainUpDown1.Location = New Point(103, DomainUpDown1.Location.Y)
        End If
    End Sub
End Class