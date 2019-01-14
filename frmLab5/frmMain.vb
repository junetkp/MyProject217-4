Public Class frmMain

    Private Sub ออกจากระบบToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ออกจากระบบToolStripMenuItem.Click
        Dim Out As DialogResult
        Out = MessageBox.Show("คุณต้องการออกจากระบบ", "แน่ใจหรือไม่", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Out = DialogResult.Yes Then
            Me.Close()
        Else

        End If
    End Sub

    Private Sub ใบงาน5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงาน5ToolStripMenuItem.Click
        Dim frm5 As New frmLab5
        frmLab5.ShowDialog()
    End Sub

    Private Sub ใบงาน6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงาน6ToolStripMenuItem.Click
        Dim frm6 As New FrmJob6
        frm6.ShowDialog()
    End Sub

    Private Sub ใบงาน7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงาน7ToolStripMenuItem.Click
        Dim frm7 As New frmLab7
        frm7.ShowDialog()
    End Sub

    Private Sub ใบงาน8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงาน8ToolStripMenuItem.Click
        Dim frm8 As New frmLab8
        frm8.ShowDialog()
    End Sub

    Private Sub ใบงานๅToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานๅToolStripMenuItem.Click
        Dim frm1 As New frmLab1
        frm1.ShowDialog()
    End Sub

    Private Sub ใบงาน2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงาน2ToolStripMenuItem.Click
        Dim frm2 As New frmLab2
        frm2.ShowDialog()
    End Sub

    Private Sub ใบงาน3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงาน3ToolStripMenuItem.Click
        Dim frm3 As New frmLab3
        frm3.ShowDialog()
    End Sub

    Private Sub ใบงาน4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงาน4ToolStripMenuItem.Click
        Dim frm4 As New frmJob4
        frm4.ShowDialog()
    End Sub
End Class