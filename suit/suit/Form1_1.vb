Public Class Form1


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Not sure if I have to code anything for the txtboxes b/c not liked to data base  
        'So I have some code showing what It would be if it was linked 
        'Dim strSQL As String
        'strSQL = "UPDATE tblInfo SET fldName = '" & Me.TextBox1.Text & "' WHERE fldFoo = somevalue"
        'DoCmd.RunSql strSQL
        MsgBox("Error Database Not linked yet", 0, "Error")

    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        MessageBox.Show("This is Larry's suit program. For help call (336)333-3210 ")
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        MessageBox.Show("This is Larry's suit program. Made to help Larry go digital with his business! ")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class

