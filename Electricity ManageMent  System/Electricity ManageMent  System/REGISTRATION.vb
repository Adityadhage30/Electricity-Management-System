Imports System.Data.OleDb
Public Class REGISTRATION
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aditya\Documents\customer1.accdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Open()

        Dim rs As String
        rs = "insert into register values('" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
        Dim cmd As New OleDbCommand(rs, cn)
        cmd.ExecuteNonQuery()

        MsgBox("register successfully")
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        Me.Hide()
        LOGIN_ID.Show()
        cn.Close()
    End Sub

    Private Sub REGISTRATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class