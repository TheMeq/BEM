Public Class EditKeyword

    Private Sub EditKeyword_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DomainUpDown1.SelectedIndex = frm_AABF_MainWindow.dgv_FileLoaded.Item(0, frm_AABF_MainWindow.lb_Lines.SelectedIndex).Value - 1
        DomainUpDown1.Location = New Point(Label1.Location.X + Label1.Width + 5, DomainUpDown1.Location.Y)
        If DomainUpDown1.Location.X <= 103 Then
            DomainUpDown1.Location = New Point(103, DomainUpDown1.Location.Y)
        End If
        TextBox1.Location = New Point(Label2.Location.X + Label2.Width + 5, TextBox1.Location.Y)
        If TextBox1.Location.X <= 103 Then
            TextBox1.Location = New Point(103, TextBox1.Location.Y)
        End If
        TextBox1.Text = frm_AABF_MainWindow.dgv_FileLoaded.Item(2, frm_AABF_MainWindow.lb_Lines.SelectedIndex).Value
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox(frm_AABF_MainWindow.s_need_keyword & """"".", MsgBoxStyle.OkOnly, frm_AABF_MainWindow.s_wait)
        Else
            frm_AABF_MainWindow.dgv_FileLoaded.Item(2, frm_AABF_MainWindow.lb_Lines.SelectedIndex).Value = TextBox1.Text
            frm_AABF_MainWindow.dgv_FileLoaded.Item(0, frm_AABF_MainWindow.lb_Lines.SelectedIndex).Value = (CInt(DomainUpDown1.SelectedIndex) + 1)
            frm_AABF_MainWindow.reloadFile()
            frm_AABF_MainWindow.mo_lin = 1
            frm_AABF_MainWindow.sb_FE.Text = "(" & frm_AABF_MainWindow.s_edited & ")"
            Me.Close()
        End If
    End Sub
End Class