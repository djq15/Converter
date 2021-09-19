Public Class Form4


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Choose one . . . "
        ComboBox1.Items.Add("bits/s")
        ComboBox1.Items.Add("Kbit/s")
        ComboBox1.Items.Add("Mbit/s")
        ComboBox1.Items.Add("Gbit/s")
        ComboBox1.Items.Add("Tbit/s")


        ComboBox2.Text = "Choose one . . . "
        ComboBox2.Items.Add("bits/s")
        ComboBox2.Items.Add("Kbit/s")
        ComboBox2.Items.Add("Mbit/s")
        ComboBox2.Items.Add("Gbit/s")
        ComboBox2.Items.Add("Tbit/s")

        TextBox3.Enabled = False
        TextBox4.Enabled = False

        RadioButton1.Checked = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If ComboBox1.Text = "bits/s" And ComboBox2.Text = "bits/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "bps"
                TextBox4.Text = "bps"
            ElseIf ComboBox1.Text = "bits/s" And ComboBox2.Text = "bits/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "bps"
                TextBox4.Text = "bps"

            ElseIf ComboBox1.Text = "bits/s" And ComboBox2.Text = "Kbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "bps"
                TextBox4.Text = "Kbps"
            ElseIf ComboBox1.Text = "bits/s" And ComboBox2.Text = "Kbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "bps"
                TextBox4.Text = "Kbps"

            ElseIf ComboBox1.Text = "bits/s" And ComboBox2.Text = "Mbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000000))
                TextBox3.Text = "bps"
                TextBox4.Text = "Mbps"
            ElseIf ComboBox1.Text = "bits/s" And ComboBox2.Text = "Mbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000000))
                TextBox3.Text = "bps"
                TextBox4.Text = "Mbps"

            ElseIf ComboBox1.Text = "bits/s" And ComboBox2.Text = "Gbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000000000))
                TextBox3.Text = "bps"
                TextBox4.Text = "Gbps"
            ElseIf ComboBox1.Text = "bits/s" And ComboBox2.Text = "Gbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000000000))
                TextBox3.Text = "bps"
                TextBox4.Text = "Gbps"

            ElseIf ComboBox1.Text = "bits/s" And ComboBox2.Text = "Tbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000000000000))
                TextBox3.Text = "bps"
                TextBox4.Text = "Tbps"
            ElseIf ComboBox1.Text = "bits/s" And ComboBox2.Text = "Tbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000000000000))
                TextBox3.Text = "bps"
                TextBox4.Text = "Tbps"

            ElseIf ComboBox1.Text = "Kbit/s" And ComboBox2.Text = "bits/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "Kbps"
                TextBox4.Text = "bps"
            ElseIf ComboBox1.Text = "Kbit/s" And ComboBox2.Text = "bits/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "Kbps"
                TextBox4.Text = "bps"

            ElseIf ComboBox1.Text = "Kbit/s" And ComboBox2.Text = "Kbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "Kbps"
                TextBox4.Text = "Kbps"
            ElseIf ComboBox1.Text = "Kbit/s" And ComboBox2.Text = "Kbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "Kbps"
                TextBox4.Text = "Kbps"

            ElseIf ComboBox1.Text = "Kbit/s" And ComboBox2.Text = "Mbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "Kbps"
                TextBox4.Text = "Mbps"
            ElseIf ComboBox1.Text = "Kbit/s" And ComboBox2.Text = "Mbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "Kbps"
                TextBox4.Text = "Mbps"

            ElseIf ComboBox1.Text = "Kbit/s" And ComboBox2.Text = "Gbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000000))
                TextBox3.Text = "Kbps"
                TextBox4.Text = "Gbps"
            ElseIf ComboBox1.Text = "Kbit/s" And ComboBox2.Text = "Gbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000000))
                TextBox3.Text = "Kbps"
                TextBox4.Text = "Gbps"

            ElseIf ComboBox1.Text = "Kbit/s" And ComboBox2.Text = "Tbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000000000))
                TextBox3.Text = "Kbps"
                TextBox4.Text = "Tbps"
            ElseIf ComboBox1.Text = "Kbit/s" And ComboBox2.Text = "Tbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000000000))
                TextBox3.Text = "Kbps"
                TextBox4.Text = "Tbps"

            ElseIf ComboBox1.Text = "Mbit/s" And ComboBox2.Text = "bits/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000000))
                TextBox3.Text = "Mbps"
                TextBox4.Text = "mbps"
            ElseIf ComboBox1.Text = "Mbit/s" And ComboBox2.Text = "bits/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000000))
                TextBox3.Text = "Mbps"
                TextBox4.Text = "bps"

            ElseIf ComboBox1.Text = "Mbit/s" And ComboBox2.Text = "Kbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "Mbps"
                TextBox4.Text = "Kbps"
            ElseIf ComboBox1.Text = "Mbit/s" And ComboBox2.Text = "Kbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "Mbps"
                TextBox4.Text = "Kbps"

            ElseIf ComboBox1.Text = "Mbit/s" And ComboBox2.Text = "Mbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "Mbps"
                TextBox4.Text = "Mbps"
            ElseIf ComboBox1.Text = "Mbit/s" And ComboBox2.Text = "Mbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "Mbps"
                TextBox4.Text = "Mbps"

            ElseIf ComboBox1.Text = "Mbit/s" And ComboBox2.Text = "Gbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "Mbps"
                TextBox4.Text = "Gbps"
            ElseIf ComboBox1.Text = "Mbit/s" And ComboBox2.Text = "Gbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "Mbps"
                TextBox4.Text = "Gbps"

            ElseIf ComboBox1.Text = "Mbit/s" And ComboBox2.Text = "Tbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000000))
                TextBox3.Text = "Mbps"
                TextBox4.Text = "Tbps"
            ElseIf ComboBox1.Text = "Mbit/s" And ComboBox2.Text = "Tbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000000))
                TextBox3.Text = "Mbps"
                TextBox4.Text = "Tbps"

            ElseIf ComboBox1.Text = "Gbit/s" And ComboBox2.Text = "bits/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000000000))
                TextBox3.Text = "Gbps"
                TextBox4.Text = "bps"
            ElseIf ComboBox1.Text = "Gbit/s" And ComboBox2.Text = "bits/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000000000))
                TextBox3.Text = "Gbps"
                TextBox4.Text = "bps"

            ElseIf ComboBox1.Text = "Gbit/s" And ComboBox2.Text = "Kbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000000))
                TextBox3.Text = "Gbps"
                TextBox4.Text = "Kbps"
            ElseIf ComboBox1.Text = "Gbit/s" And ComboBox2.Text = "Kbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000000))
                TextBox3.Text = "Gbps"
                TextBox4.Text = "Kbps"

            ElseIf ComboBox1.Text = "Gbit/s" And ComboBox2.Text = "Mbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "Gbps"
                TextBox4.Text = "Mbps"
            ElseIf ComboBox1.Text = "Gbit/s" And ComboBox2.Text = "Mbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "Gbps"
                TextBox4.Text = "Mbps"

            ElseIf ComboBox1.Text = "Gbit/s" And ComboBox2.Text = "Gbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "Gbps"
                TextBox4.Text = "Gbps"
            ElseIf ComboBox1.Text = "Gbit/s" And ComboBox2.Text = "Gbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "Gbps"
                TextBox4.Text = "Gbps"

            ElseIf ComboBox1.Text = "Gbit/s" And ComboBox2.Text = "Tbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "Gbps"
                TextBox4.Text = "Tbps"
            ElseIf ComboBox1.Text = "Gbit/s" And ComboBox2.Text = "Tbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "Gbps"
                TextBox4.Text = "Tbps"

            ElseIf ComboBox1.Text = "Tbit/s" And ComboBox2.Text = "bits/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000000000000))
                TextBox3.Text = "Tbps"
                TextBox4.Text = "bps"
            ElseIf ComboBox1.Text = "Tbit/s" And ComboBox2.Text = "bits/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000000000000))
                TextBox3.Text = "Tbps"
                TextBox4.Text = "bps"

            ElseIf ComboBox1.Text = "Tbit/s" And ComboBox2.Text = "Kbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000000000))
                TextBox3.Text = "Tbps"
                TextBox4.Text = "Kbps"
            ElseIf ComboBox1.Text = "Tbit/s" And ComboBox2.Text = "Kbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000000000))
                TextBox3.Text = "Tbps"
                TextBox4.Text = "Kbps"

            ElseIf ComboBox1.Text = "Tbit/s" And ComboBox2.Text = "Mbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000000))
                TextBox3.Text = "Tbps"
                TextBox4.Text = "Mbps"
            ElseIf ComboBox1.Text = "Tbit/s" And ComboBox2.Text = "Mbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000000))
                TextBox3.Text = "Tbps"
                TextBox4.Text = "Mbps"

            ElseIf ComboBox1.Text = "Tbit/s" And ComboBox2.Text = "Gbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "Tbps"
                TextBox4.Text = "Gbps"
            ElseIf ComboBox1.Text = "Tbit/s" And ComboBox2.Text = "Gbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "Tbps"
                TextBox4.Text = "Gbps"

            ElseIf ComboBox1.Text = "Tbit/s" And ComboBox2.Text = "Tbit/s" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "Tbps"
                TextBox4.Text = "Tbps"
            ElseIf ComboBox1.Text = "Tbit/s" And ComboBox2.Text = "Tbit/s" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "Tbps"
                TextBox4.Text = "Tbps"

            End If



        Catch ex As Exception
            MsgBox("Please try again -- Use numbers only. Avoid letters, spaces, blanks, or input/output that would surpass 29 digits", MsgBoxStyle.OkOnly, "Error !!!")

        End Try


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = "Choose one . . . "
        ComboBox2.Text = "Choose one . . . "

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        main.Show()
        Me.Hide()
    End Sub


End Class
