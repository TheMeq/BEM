Public Class EditFilter

    Private Sub EditFilter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If frm_AABF_MainWindow.dgv_SelectedRow.Item(0, frm_AABF_MainWindow.lb_Exceptions.SelectedIndex).Value = "!=" Then
            DomainUpDown1.SelectedIndex = 0
        Else
            DomainUpDown1.SelectedIndex = 1
        End If
        DomainUpDown1.Location = New Point(Label1.Location.X + Label1.Width + 5, DomainUpDown1.Location.Y)
        If DomainUpDown1.Location.X <= 103 Then
            DomainUpDown1.Location = New Point(103, DomainUpDown1.Location.Y)
        End If
        TextBox1.Text = frm_AABF_MainWindow.dgv_SelectedRow.Item(1, frm_AABF_MainWindow.lb_Exceptions.SelectedIndex).Value
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim logval = DomainUpDown1.SelectedIndex + 1
        If logval = 0 Then
            MsgBox(frm_AABF_MainWindow.s_need_to_exception_type, MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)
        Else
            If TextBox1.Text = "" Then
                MsgBox(frm_AABF_MainWindow.s_need_value, MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)
            Else
                Dim exc = ""
                If logval = 1 Then
                    exc = "!="
                Else
                    exc = "!"
                End If
                frm_AABF_MainWindow.lb_Exceptions.Items.RemoveAt(frm_AABF_MainWindow.lb_Exceptions.SelectedIndex)
                frm_AABF_MainWindow.lb_Exceptions.Items.Add(exc & TextBox1.Text)
                frm_AABF_MainWindow.dgv_SelectedRow.Rows.Clear()
                frm_AABF_MainWindow.dgv_FileLoaded.Item(3, frm_AABF_MainWindow.lb_Lines.SelectedIndex).Value = ""
                For k = 0 To frm_AABF_MainWindow.lb_Exceptions.Items.Count - 1
                    Dim t = frm_AABF_MainWindow.lb_Exceptions.Items(k)
                    Dim r = ""
                    Dim s = ""
                    If t.ToString.StartsWith("!=") Then
                        r = "!="
                        s = t.ToString.Substring(2)
                    Else
                        r = "!"
                        s = t.ToString.Substring(1)
                    End If

                    frm_AABF_MainWindow.dgv_SelectedRow.Rows.Add({r, s})
                    frm_AABF_MainWindow.dgv_FileLoaded.Item(3, frm_AABF_MainWindow.lb_Lines.SelectedIndex).Value = frm_AABF_MainWindow.dgv_FileLoaded.Item(3, frm_AABF_MainWindow.lb_Lines.SelectedIndex).Value & " " & r & s
                Next


                frm_AABF_MainWindow.mo_lin = 1
                frm_AABF_MainWindow.sb_FE.Text = "(" & frm_AABF_MainWindow.s_edited & ")"
                Me.Close()
            End If
        End If
    End Sub

End Class