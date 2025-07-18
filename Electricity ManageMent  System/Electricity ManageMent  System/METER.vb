Imports System.Data.OleDb
Public Class METER
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aditya\Documents\customer1.accdb")

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Open()

        Dim rs As String
        rs = "insert into meter values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
        Dim cmd As New OleDbCommand(rs, cn)
        cmd.ExecuteNonQuery()
        MsgBox("data save sucessfully")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        CALCULATION.Show()

        Dim adp As New OleDbDataAdapter("select* from meter", cn)
        Dim dn As New DataSet
        adp.Fill(dn, "meter")
        DataGridView1.DataSource = dn.Tables("meter")
        cn.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cn.Open()
        Dim rs As String
        rs = "select*from meter where meterid='" & TextBox1.Text & "'"
        Dim cmd As New OleDbCommand(rs, cn)
        Dim rd As OleDbDataReader

        rd = cmd.ExecuteReader
        If rd.Read() Then
            TextBox1.Text = rd(0)
            TextBox2.Text = rd(1)
            TextBox3.Text = rd(2)
            TextBox4.Text = rd(3)
            TextBox5.Text = rd(4)
        Else
            MsgBox("record not found")
        End If
        cn.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cn.Open()
        Dim rs As String
        rs = "update meter set meterid='" & TextBox1.Text & "', metervoltage ='" & TextBox2.Text & "', emailid='" & TextBox4.Text & "', address='" & TextBox5.Text & "' where meterno='" & TextBox3.Text & "'"
        Dim cmd As New OleDbCommand(rs, cn)
        cmd.ExecuteNonQuery()
        MsgBox("record updated")
        cn.Close()


    End Sub

    Private Sub METER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        meterno()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        cn.Open()
        Dim rs As String
        rs = "delete*from meter where meterid='" & TextBox1.Text & "'"
        Dim cmd As New OleDbCommand(rs, cn)
        cmd.ExecuteReader()
        MsgBox("record deleted")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""


        cn.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Public Sub meterno()
        cn.Open()
        Dim rs As String
        rs = "select max(meterid) from meter"
        Dim cmd As New OleDbCommand(rs, cn)
        Dim rd As OleDbDataReader
        rd = cmd.ExecuteReader()
        If rd.Read Then
            If rd.IsDBNull(0) Then
                TextBox1.Text = "100"
            Else
                TextBox1.Text = rd(0) + 1
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox2.Focus()

            End If
        End If

        cn.Close()
    End Sub
End Class