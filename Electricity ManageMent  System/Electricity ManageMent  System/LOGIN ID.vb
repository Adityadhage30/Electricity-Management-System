Imports System.Data.OleDb
Public Class LOGIN_ID
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aditya\Documents\customer1.accdb")
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("please enter your username")
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            MsgBox("please enter your password")
        Else

        End If
        cn.Open()
        Dim rs As String
        rs = "select* from register where username = '" & TextBox1.Text & "'"
        Dim cmd As New OleDbCommand(rs, cn)
        Dim rd As OleDbDataReader
        rd = cmd.ExecuteReader
        If rd.Read() Then
            MsgBox("login sucessful")
            MAINFORM.Show()
            Me.Hide()
            Me.Close()
        Else
            MsgBox("please enter corrent password")
        End If
        cn.Close()







    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        REGISTRATION.Show()
    End Sub

    Private Sub LOGIN_ID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
    End Sub
End Class