Public Class AddKeyword

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim logval = DomainUpDown1.SelectedIndex + 1
        If logval = 0 Then
            MsgBox(frm_AABF_MainWindow.s_need_to_logging_type, MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)
        Else
            If TextBox1.Text = "" Then
                MsgBox(frm_AABF_MainWindow.s_need_keyword & " """".", MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)
            Else
                Dim toparse = logval.ToString & " " & TextBox1.Text
                frm_AABF_MainWindow.fun_parser(toparse)
                frm_AABF_MainWindow.reloadFile()
                frm_AABF_MainWindow.mo_lin = 1
                frm_AABF_MainWindow.sb_FE.Text = "(" & frm_AABF_MainWindow.s_edited & ")"
                Me.Close()
            End If
        End If

    End Sub

    Private Sub AddKeyword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DomainUpDown1.Location = New Point(Label1.Location.X + Label1.Width + 5, DomainUpDown1.Location.Y)
        If DomainUpDown1.Location.X <= 103 Then
            DomainUpDown1.Location = New Point(103, DomainUpDown1.Location.Y)
        End If
        TextBox1.Location = New Point(Label2.Location.X + Label2.Width + 5, TextBox1.Location.Y)
        If TextBox1.Location.X <= 103 Then
            TextBox1.Location = New Point(103, TextBox1.Location.Y)
        End If
    End Sub
End Class