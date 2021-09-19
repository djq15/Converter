Public Class Form5


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Choose one . . . "
        ComboBox1.Items.Add("Exawatt")
        ComboBox1.Items.Add("Petawatt")
        ComboBox1.Items.Add("Terawatt")
        ComboBox1.Items.Add("Gigawatt")
        ComboBox1.Items.Add("Megawatt")


        ComboBox2.Text = "Choose one . . . "
        ComboBox2.Items.Add("Exawatt")
        ComboBox2.Items.Add("Petawatt")
        ComboBox2.Items.Add("Terawatt")
        ComboBox2.Items.Add("Gigawatt")
        ComboBox2.Items.Add("Megawatt")

        TextBox3.Enabled = False
        TextBox4.Enabled = False

        RadioButton1.Checked = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If ComboBox1.Text = "Exawatt" And ComboBox2.Text = "Exawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "EW"
                TextBox4.Text = "EW"
            ElseIf ComboBox1.Text = "Exawatt" And ComboBox2.Text = "Exawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "EW"
                TextBox4.Text = "EW"

            ElseIf ComboBox1.Text = "Exawatt" And ComboBox2.Text = "Petawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "EW"
                TextBox4.Text = "PW"
            ElseIf ComboBox1.Text = "Exawatt" And ComboBox2.Text = "Petawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "EW"
                TextBox4.Text = "PW"

            ElseIf ComboBox1.Text = "Exawatt" And ComboBox2.Text = "Terawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000000))
                TextBox3.Text = "EW"
                TextBox4.Text = "TW"
            ElseIf ComboBox1.Text = "Exawatt" And ComboBox2.Text = "Terawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000000))
                TextBox3.Text = "EW"
                TextBox4.Text = "TW"

            ElseIf ComboBox1.Text = "Exawatt" And ComboBox2.Text = "Gigawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000000000))
                TextBox3.Text = "EW"
                TextBox4.Text = "GW"
            ElseIf ComboBox1.Text = "Exawatt" And ComboBox2.Text = "Gigawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000000000))
                TextBox3.Text = "EW"
                TextBox4.Text = "GW"

            ElseIf ComboBox1.Text = "Exawatt" And ComboBox2.Text = "Megawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000000000000))
                TextBox3.Text = "EW"
                TextBox4.Text = "MW"
            ElseIf ComboBox1.Text = "Exawatt" And ComboBox2.Text = "Megawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000000000000))
                TextBox3.Text = "EW"
                TextBox4.Text = "MW"

            ElseIf ComboBox1.Text = "Petawatt" And ComboBox2.Text = "Exawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "PW"
                TextBox4.Text = "EW"
            ElseIf ComboBox1.Text = "Petawatt" And ComboBox2.Text = "Exawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "PW"
                TextBox4.Text = "EW"

            ElseIf ComboBox1.Text = "Petawatt" And ComboBox2.Text = "Petawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "PW"
                TextBox4.Text = "PW"
            ElseIf ComboBox1.Text = "Petawatt" And ComboBox2.Text = "Petawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "PW"
                TextBox4.Text = "PW"

            ElseIf ComboBox1.Text = "Petawatt" And ComboBox2.Text = "Terawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "PW"
                TextBox4.Text = "TW"
            ElseIf ComboBox1.Text = "Petawatt" And ComboBox2.Text = "Terawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "PW"
                TextBox4.Text = "TW"

            ElseIf ComboBox1.Text = "Petawatt" And ComboBox2.Text = "Gigawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000000))
                TextBox3.Text = "PW"
                TextBox4.Text = "GW"
            ElseIf ComboBox1.Text = "Petawatt" And ComboBox2.Text = "Gigawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000000))
                TextBox3.Text = "PW"
                TextBox4.Text = "GW"

            ElseIf ComboBox1.Text = "Petawatt" And ComboBox2.Text = "Megawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000000000))
                TextBox3.Text = "PW"
                TextBox4.Text = "MW"
            ElseIf ComboBox1.Text = "Petawatt" And ComboBox2.Text = "Megawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000000000))
                TextBox3.Text = "PW"
                TextBox4.Text = "MW"

            ElseIf ComboBox1.Text = "Terawatt" And ComboBox2.Text = "Exawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000000))
                TextBox3.Text = "TW"
                TextBox4.Text = "EW"
            ElseIf ComboBox1.Text = "Terawatt" And ComboBox2.Text = "Exawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000000))
                TextBox3.Text = "TW"
                TextBox4.Text = "EW"

            ElseIf ComboBox1.Text = "Terawatt" And ComboBox2.Text = "Petawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "TW"
                TextBox4.Text = "PW"
            ElseIf ComboBox1.Text = "Terawatt" And ComboBox2.Text = "Petawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "TW"
                TextBox4.Text = "PW"

            ElseIf ComboBox1.Text = "Terawatt" And ComboBox2.Text = "Terawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "TW"
                TextBox4.Text = "TW"
            ElseIf ComboBox1.Text = "Terawatt" And ComboBox2.Text = "Terawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "TW"
                TextBox4.Text = "TW"

            ElseIf ComboBox1.Text = "Terawatt" And ComboBox2.Text = "Gigawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "TW"
                TextBox4.Text = "GW"
            ElseIf ComboBox1.Text = "Terawatt" And ComboBox2.Text = "Gigawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "TW"
                TextBox4.Text = "GW"

            ElseIf ComboBox1.Text = "Terawatt" And ComboBox2.Text = "Megawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000000))
                TextBox3.Text = "TW"
                TextBox4.Text = "MW"
            ElseIf ComboBox1.Text = "Terawatt" And ComboBox2.Text = "Megawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000000))
                TextBox3.Text = "TW"
                TextBox4.Text = "MW"
                ''
            ElseIf ComboBox1.Text = "Gigawatt" And ComboBox2.Text = "Exawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000000000))
                TextBox3.Text = "GW"
                TextBox4.Text = "EW"
            ElseIf ComboBox1.Text = "Gigawatt" And ComboBox2.Text = "Exawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000000000))
                TextBox3.Text = "GW"
                TextBox4.Text = "EW"

            ElseIf ComboBox1.Text = "Gigawatt" And ComboBox2.Text = "Petawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000000))
                TextBox3.Text = "GW"
                TextBox4.Text = "PW"
            ElseIf ComboBox1.Text = "Gigawatt" And ComboBox2.Text = "Petawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000000))
                TextBox3.Text = "GW"
                TextBox4.Text = "PW"

            ElseIf ComboBox1.Text = "Gigawatt" And ComboBox2.Text = "Terawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "GW"
                TextBox4.Text = "TW"
            ElseIf ComboBox1.Text = "Gigawatt" And ComboBox2.Text = "Terawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "GW"
                TextBox4.Text = "TW"

            ElseIf ComboBox1.Text = "Gigawatt" And ComboBox2.Text = "Gigawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "GW"
                TextBox4.Text = "GW"
            ElseIf ComboBox1.Text = "Gigawatt" And ComboBox2.Text = "Gigawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "GW"
                TextBox4.Text = "GW"

            ElseIf ComboBox1.Text = "Gigawatt" And ComboBox2.Text = "Megawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "GW"
                TextBox4.Text = "MW"
            ElseIf ComboBox1.Text = "Gigawatt" And ComboBox2.Text = "Megawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "GW"
                TextBox4.Text = "MW"

            ElseIf ComboBox1.Text = "Megawatt" And ComboBox2.Text = "Exawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000000000000))
                TextBox3.Text = "MW"
                TextBox4.Text = "EW"
            ElseIf ComboBox1.Text = "Megawatt" And ComboBox2.Text = "Exawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000000000000))
                TextBox3.Text = "MW"
                TextBox4.Text = "EW"

            ElseIf ComboBox1.Text = "Megawatt" And ComboBox2.Text = "Petawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000000000))
                TextBox3.Text = "MW"
                TextBox4.Text = "PW"
            ElseIf ComboBox1.Text = "Megawatt" And ComboBox2.Text = "Petawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000000000))
                TextBox3.Text = "MW"
                TextBox4.Text = "PW"

            ElseIf ComboBox1.Text = "Megawatt" And ComboBox2.Text = "Terawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000000))
                TextBox3.Text = "MW"
                TextBox4.Text = "TW"
            ElseIf ComboBox1.Text = "Megawatt" And ComboBox2.Text = "Terawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000000))
                TextBox3.Text = "MW"
                TextBox4.Text = "TW"

            ElseIf ComboBox1.Text = "Megawatt" And ComboBox2.Text = "Gigawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "MW"
                TextBox4.Text = "GW"
            ElseIf ComboBox1.Text = "Megawatt" And ComboBox2.Text = "Gigawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "MW"
                TextBox4.Text = "GW"

            ElseIf ComboBox1.Text = "Megawatt" And ComboBox2.Text = "Megawatt" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "MW"
                TextBox4.Text = "MW"
            ElseIf ComboBox1.Text = "Megawatt" And ComboBox2.Text = "Megawatt" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "MW"
                TextBox4.Text = "MW"

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
