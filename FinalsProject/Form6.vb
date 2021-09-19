Public Class Form6


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Choose one . . . "
        ComboBox1.Items.Add("Kelvin")
        ComboBox1.Items.Add("Celsius")
        ComboBox1.Items.Add("Fahrenheit")
        ComboBox1.Items.Add("Rankine")
        ComboBox1.Items.Add("Reaumur")


        ComboBox2.Text = "Choose one . . . "
        ComboBox2.Items.Add("Kelvin")
        ComboBox2.Items.Add("Celsius")
        ComboBox2.Items.Add("Fahrenheit")
        ComboBox2.Items.Add("Rankine")
        ComboBox2.Items.Add("Reaumur")

        TextBox3.Enabled = False
        TextBox4.Enabled = False

        RadioButton1.Checked = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If ComboBox1.Text = "Kelvin" And ComboBox2.Text = "Kelvin" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "K"
                TextBox4.Text = "K"
            ElseIf ComboBox1.Text = "Kelvin" And ComboBox2.Text = "Kelvin" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "K"
                TextBox4.Text = "K"

            ElseIf ComboBox1.Text = "Kelvin" And ComboBox2.Text = "Celsius" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 274.15))
                TextBox3.Text = "K"
                TextBox4.Text = "°C"
            ElseIf ComboBox1.Text = "Kelvin" And ComboBox2.Text = "Celsius" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 274.15))
                TextBox3.Text = "K"
                TextBox4.Text = "°C"

            ElseIf ComboBox1.Text = "Kelvin" And ComboBox2.Text = "Fahrenheit" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 255.92777778))
                TextBox3.Text = "K"
                TextBox4.Text = "°F"
            ElseIf ComboBox1.Text = "Kelvin" And ComboBox2.Text = "Fahrenheit" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 255.92777778))
                TextBox3.Text = "K"
                TextBox4.Text = "°F"

            ElseIf ComboBox1.Text = "Kelvin" And ComboBox2.Text = "Rankine" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1.8))
                TextBox3.Text = "K"
                TextBox4.Text = "°R"
            ElseIf ComboBox1.Text = "Kelvin" And ComboBox2.Text = "Rankine" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1.8))
                TextBox3.Text = "K"
                TextBox4.Text = "°R"

            ElseIf ComboBox1.Text = "Kelvin" And ComboBox2.Text = "Reaumur" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 274.4))
                TextBox3.Text = "K"
                TextBox4.Text = "°r"
            ElseIf ComboBox1.Text = "Kelvin" And ComboBox2.Text = "Reaumur" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 274.4))
                TextBox3.Text = "K"
                TextBox4.Text = "°r"

            ElseIf ComboBox1.Text = "Celsius" And ComboBox2.Text = "Kelvin" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 274.15))
                TextBox3.Text = "°C"
                TextBox4.Text = "K"
            ElseIf ComboBox1.Text = "Celsius" And ComboBox2.Text = "Kelvin" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 274.15))
                TextBox3.Text = "°C"
                TextBox4.Text = "K"

            ElseIf ComboBox1.Text = "Celsius" And ComboBox2.Text = "Celsius" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "°C"
                TextBox4.Text = "°C"
            ElseIf ComboBox1.Text = "Celsius" And ComboBox2.Text = "Celsius" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "°C"
                TextBox4.Text = "°C"

            ElseIf ComboBox1.Text = "Celsius" And ComboBox2.Text = "Fahrenheit" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 33.8))
                TextBox3.Text = "°C"
                TextBox4.Text = "°F"
            ElseIf ComboBox1.Text = "Celsius" And ComboBox2.Text = "Fahrenheit" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 33.8))
                TextBox3.Text = "°C"
                TextBox4.Text = "°F"

            ElseIf ComboBox1.Text = "Celsius" And ComboBox2.Text = "Rankine" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 493.47))
                TextBox3.Text = "°C"
                TextBox4.Text = "°R"
            ElseIf ComboBox1.Text = "Celsius" And ComboBox2.Text = "Rankine" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 493.47))
                TextBox3.Text = "°C"
                TextBox4.Text = "°R"

            ElseIf ComboBox1.Text = "Celsius" And ComboBox2.Text = "Reaumur" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 0.8))
                TextBox3.Text = "°C"
                TextBox4.Text = "°r"
            ElseIf ComboBox1.Text = "Celsius" And ComboBox2.Text = "Reaumur" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 0.8))
                TextBox3.Text = "°C"
                TextBox4.Text = "°r"

            ElseIf ComboBox1.Text = "Fahrenheit" And ComboBox2.Text = "Kelvin" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 255.92777778))
                TextBox3.Text = "°F"
                TextBox4.Text = "K"
            ElseIf ComboBox1.Text = "Fahrenheit" And ComboBox2.Text = "Kelvin" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 255.92777778))
                TextBox3.Text = "°F"
                TextBox4.Text = "K"

            ElseIf ComboBox1.Text = "Fahrenheit" And ComboBox2.Text = "Celsius" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 33.8))
                TextBox3.Text = "°F"
                TextBox4.Text = "°C"
            ElseIf ComboBox1.Text = "Fahrenheit" And ComboBox2.Text = "Celsius" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 33.8))
                TextBox3.Text = "°F"
                TextBox4.Text = "°C"

            ElseIf ComboBox1.Text = "Fahrenheit" And ComboBox2.Text = "Fahrenheit" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "°F"
                TextBox4.Text = "°F"
            ElseIf ComboBox1.Text = "Fahrenheit" And ComboBox2.Text = "Fahrenheit" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "°F"
                TextBox4.Text = "°F"

            ElseIf ComboBox1.Text = "Fahrenheit" And ComboBox2.Text = "Rankine" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 460.67))
                TextBox3.Text = "°F"
                TextBox4.Text = "°R"
            ElseIf ComboBox1.Text = "Fahrenheit" And ComboBox2.Text = "Rankine" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 460.67))
                TextBox3.Text = "°F"
                TextBox4.Text = "°R"

            ElseIf ComboBox1.Text = "Fahrenheit" And ComboBox2.Text = "Reaumur" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 34.25))
                TextBox3.Text = "°F"
                TextBox4.Text = "°r"
            ElseIf ComboBox1.Text = "Fahrenheit" And ComboBox2.Text = "Reaumur" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 34.25))
                TextBox3.Text = "°F"
                TextBox4.Text = "°r"

            ElseIf ComboBox1.Text = "Rankine" And ComboBox2.Text = "Kelvin" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 0.5555555556))
                TextBox3.Text = "°R"
                TextBox4.Text = "K"
            ElseIf ComboBox1.Text = "Rankine" And ComboBox2.Text = "Kelvin" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 0.5555555556))
                TextBox3.Text = "°R"
                TextBox4.Text = "K"

            ElseIf ComboBox1.Text = "Rankine" And ComboBox2.Text = "Celsius" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 493.47))
                TextBox3.Text = "°R"
                TextBox4.Text = "°C"
            ElseIf ComboBox1.Text = "Rankine" And ComboBox2.Text = "Celsius" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 493.47))
                TextBox3.Text = "°R"
                TextBox4.Text = "°C"

            ElseIf ComboBox1.Text = "Rankine" And ComboBox2.Text = "Fahrenheit" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 460.67))
                TextBox3.Text = "°R"
                TextBox4.Text = "°F"
            ElseIf ComboBox1.Text = "Rankine" And ComboBox2.Text = "Fahrenheit" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 460.67))
                TextBox3.Text = "°R"
                TextBox4.Text = "°F"

            ElseIf ComboBox1.Text = "Rankine" And ComboBox2.Text = "Rankine" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "°R"
                TextBox4.Text = "°R"
            ElseIf ComboBox1.Text = "Rankine" And ComboBox2.Text = "Rankine" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "°R"
                TextBox4.Text = "°R"

            ElseIf ComboBox1.Text = "Rankine" And ComboBox2.Text = "Reaumur" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 493.92))
                TextBox3.Text = "°R"
                TextBox4.Text = "°r"
            ElseIf ComboBox1.Text = "Rankine" And ComboBox2.Text = "Reaumur" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 493.92))
                TextBox3.Text = "°R"
                TextBox4.Text = "°r"

            ElseIf ComboBox1.Text = "Reaumur" And ComboBox2.Text = "Kelvin" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 274.4))
                TextBox3.Text = "°r"
                TextBox4.Text = "K"
            ElseIf ComboBox1.Text = "Reaumur" And ComboBox2.Text = "Kelvin" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 274.4))
                TextBox3.Text = "°r"
                TextBox4.Text = "K"

            ElseIf ComboBox1.Text = "Reaumur" And ComboBox2.Text = "Celsius" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1.25))
                TextBox3.Text = "°r"
                TextBox4.Text = "°C"
            ElseIf ComboBox1.Text = "Reaumur" And ComboBox2.Text = "Celsius" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1.25))
                TextBox3.Text = "°r"
                TextBox4.Text = "°C"

            ElseIf ComboBox1.Text = "Reaumur" And ComboBox2.Text = "Fahrenheit" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 34.25))
                TextBox3.Text = "°r"
                TextBox4.Text = "°F"
            ElseIf ComboBox1.Text = "Reaumur" And ComboBox2.Text = "Fahrenheit" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 34.25))
                TextBox3.Text = "°r"
                TextBox4.Text = "°F"

            ElseIf ComboBox1.Text = "Reaumur" And ComboBox2.Text = "Rankine" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 493.92))
                TextBox3.Text = "°r"
                TextBox4.Text = "°R"
            ElseIf ComboBox1.Text = "Reaumur" And ComboBox2.Text = "Rankine" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 493.92))
                TextBox3.Text = "°r"
                TextBox4.Text = "°R"

            ElseIf ComboBox1.Text = "Reaumur" And ComboBox2.Text = "Reaumur" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "°r"
                TextBox4.Text = "°r"
            ElseIf ComboBox1.Text = "Reaumur" And ComboBox2.Text = "Reaumur" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "°r"
                TextBox4.Text = "°r"

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
