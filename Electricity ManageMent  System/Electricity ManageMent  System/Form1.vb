Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ProgressBar1.Visible = True

        Dim i As Integer
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 300

        For i = 0 To 300 Step 1
            ProgressBar1.Value = i
            If i > ProgressBar1.Maximum Then
                i = ProgressBar1.Maximum
            End If
        Next
        MsgBox("You are Enter to Our project")
        REGISTRATION.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
    

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





    End Sub
End Class
