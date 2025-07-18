Imports System.Data.OleDb
Public Class CUSTOMER
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aditya\Documents\customer1.accdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Open()
        Dim rs As String
        rs = " insert into customer values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
        Dim cmd As New OleDbCommand(rs, cn)
        cmd.ExecuteNonQuery()
        MsgBox("data save sucessfully")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

        Dim adp As New OleDbDataAdapter("select * from customer", cn)
        Dim dn As New DataSet
        adp.Fill(dn, "customer")
        DataGridView1.DataSource = dn.Tables("customer")
        cn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cn.Open()
        Dim rs As String
        rs = "select* from customer where meterno='" & TextBox2.Text & "'"
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cn.Open()
        Dim rs As String
        rs = "delete* from customer where meterno='" & TextBox2.Text & "'"
        Dim cmd As New OleDbCommand(rs, cn)
        cmd.ExecuteNonQuery()
        MsgBox("record deleted")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        METER.Show()
        Me.Hide()
        cn.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cn.Open()
        Dim rs As String
        rs = "update customer set customer_name = '" & TextBox1.Text & "',  mobileno = '" & TextBox3.Text & "',emailid = '" & TextBox4.Text & "', address = '" & TextBox5.Text & "' where meterno = '" & TextBox2.Text & "'"
        Dim cmd As New OleDbCommand(rs, cn)
        cmd.ExecuteNonQuery()
        MsgBox("record updated")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        cn.Close()
    End Sub

    Private Sub CUSTOMER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        customer()


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Public Sub customer()
        cn.Open()
        Dim rs As String
        rs = "select max(meterno) from customer"
        Dim cmd As New OleDbCommand(rs, cn)
        Dim rd As OleDbDataReader
        rd = cmd.ExecuteReader()
        If rd.Read Then
            If rd.IsDBNull(0) Then
                TextBox2.Text = "100"
            Else
                TextBox2.Text = rd(0) + 1
                TextBox1.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox2.Focus()

            End If
        End If

        cn.Close()
    End Sub

End Class