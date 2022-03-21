Public Class Form1
    Dim Makanan As Integer
    Dim Minuman As Integer
    Dim Total As Integer
    Dim Bayar As Integer
    Dim Kembalian As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox2.Text = 25000
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextBox2.Text = 30000
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBox2.Text = 15000
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextBox7.Text = 15000
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            TextBox7.Text = 15000
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            TextBox7.Text = 15000
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        RadioButton1.Checked = False
        RadioButton3.Checked = False
        RadioButton2.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then
            MsgBox("INPUT BELUM DI ISI")
        Else
            Total = TextBox6.Text
            Bayar = TextBox5.Text
            kembalian = bayar - Total
            TextBox4.Text = "Rp" & Kembalian
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then
            TextBox7.Text = ""
            MsgBox("Silahkan Memilih Menu makanan dan minuman yang tersedia")
        Else
            Makanan = TextBox2.Text
            Minuman = TextBox7.Text
            Total = Makanan + Minuman
            TextBox6.Text = Total

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        RadioButton1.Checked = False
        RadioButton3.Checked = False
        RadioButton2.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox2.Text = "" Then
            TextBox7.Text = ""
            MsgBox("Silahkan Memilih Menu Makanan Yang tersedia")
        Else
            Makanan = TextBox2.Text
            Total = Makanan
            TextBox6.Text = Total
            TextBox7.Text = "Tidak Dibeli"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox2.Text = "" Then
            TextBox7.Text = ""
            MsgBox("Silahkan Memilih Menu Makanan Yang tersedia")
        Else
            Minuman = TextBox2.Text
            Total = Minuman
            TextBox7.Text = Total
            TextBox6.Text = "Tidak Dibeli"
        End If
    End Sub

End Class
