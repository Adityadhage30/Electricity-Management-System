Imports System.Data.OleDb

Public Class CALCULATION
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aditya\Documents\customer1.accdb")
    Private Sub CALCULATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cn.Open()
        Dim rs As String
        rs = "insert into calculation values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
        Dim cmd As New OleDbCommand(rs, cn)
        cmd.ExecuteNonQuery()
        MsgBox("payement suceesfull")
        cn.Close()
        thanks.Show()
    End Sub
End Class