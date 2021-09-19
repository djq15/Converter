Public Class Form8


    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Choose one . . . "
        ComboBox1.Items.Add("Joule")
        ComboBox1.Items.Add("Kilojoule")
        ComboBox1.Items.Add("Kilowatt-hour")
        ComboBox1.Items.Add("Watt-hour")
        ComboBox1.Items.Add("Calorie")


        ComboBox2.Text = "Choose one . . . "
        ComboBox2.Items.Add("Joule")
        ComboBox2.Items.Add("Kilojoule")
        ComboBox2.Items.Add("Kilowatt-hour")
        ComboBox2.Items.Add("Watt-hour")
        ComboBox2.Items.Add("Calorie")

        TextBox3.Enabled = False
        TextBox4.Enabled = False

        RadioButton1.Checked = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If ComboBox1.Text = "Joule" And ComboBox2.Text = "Joule" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "J"
                TextBox4.Text = "J"
            ElseIf ComboBox1.Text = "Joule" And ComboBox2.Text = "Joule" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "J"
                TextBox4.Text = "J"

            ElseIf ComboBox1.Text = "Joule" And ComboBox2.Text = "Kilojoule" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "J"
                TextBox4.Text = "kJ"
            ElseIf ComboBox1.Text = "Joule" And ComboBox2.Text = "Kilojoule" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "J"
                TextBox4.Text = "kJ"

            ElseIf ComboBox1.Text = "Joule" And ComboBox2.Text = "Kilowatt-hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 3600000))
                TextBox3.Text = "J"
                TextBox4.Text = "kW*h"
            ElseIf ComboBox1.Text = "Joule" And ComboBox2.Text = "Kilowatt-hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 3600000))
                TextBox3.Text = "J"
                TextBox4.Text = "kW*h"

            ElseIf ComboBox1.Text = "Joule" And ComboBox2.Text = "Watt-hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 3600))
                TextBox3.Text = "J"
                TextBox4.Text = "W*h"
            ElseIf ComboBox1.Text = "Joule" And ComboBox2.Text = "Watt-hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 3600))
                TextBox3.Text = "J"
                TextBox4.Text = "W*h"

            ElseIf ComboBox1.Text = "Joule" And ComboBox2.Text = "Calorie" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 4186.8))
                TextBox3.Text = "J"
                TextBox4.Text = "cal"
            ElseIf ComboBox1.Text = "Joule" And ComboBox2.Text = "Calorie" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 4186.8))
                TextBox3.Text = "J"
                TextBox4.Text = "cal"

            ElseIf ComboBox1.Text = "Kilojoule" And ComboBox2.Text = "Joule" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "kJ"
                TextBox4.Text = "J"
            ElseIf ComboBox1.Text = "Kilojoule" And ComboBox2.Text = "Joule" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "kJ"
                TextBox4.Text = "J"

            ElseIf ComboBox1.Text = "Kilojoule" And ComboBox2.Text = "Kilojoule" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "kJ"
                TextBox4.Text = "kJ"
            ElseIf ComboBox1.Text = "Kilojoule" And ComboBox2.Text = "Kilojoule" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "kJ"
                TextBox4.Text = "kJ"

            ElseIf ComboBox1.Text = "Kilojoule" And ComboBox2.Text = "Kilowatt-hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 3600))
                TextBox3.Text = "kJ"
                TextBox4.Text = "kW*h"
            ElseIf ComboBox1.Text = "Kilojoule" And ComboBox2.Text = "Kilowatt-hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 3600))
                TextBox3.Text = "kJ"
                TextBox4.Text = "kW*h"

            ElseIf ComboBox1.Text = "Kilojoule" And ComboBox2.Text = "Watt-hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 3.6))
                TextBox3.Text = "kJ"
                TextBox4.Text = "W*h"
            ElseIf ComboBox1.Text = "Kilojoule" And ComboBox2.Text = "Watt-hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 3.6))
                TextBox3.Text = "kJ"
                TextBox4.Text = "W*h"

            ElseIf ComboBox1.Text = "Kilojoule" And ComboBox2.Text = "Calorie" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 4.1868))
                TextBox3.Text = "kJ"
                TextBox4.Text = "cal"
            ElseIf ComboBox1.Text = "Kilojoule" And ComboBox2.Text = "Calorie" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 4.1868))
                TextBox3.Text = "kJ"
                TextBox4.Text = "cal"

            ElseIf ComboBox1.Text = "Kilowatt-hour" And ComboBox2.Text = "Joule" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 3600000))
                TextBox3.Text = "kW*h"
                TextBox4.Text = "kW*h"
            ElseIf ComboBox1.Text = "Kilowatt-hour" And ComboBox2.Text = "Joule" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 3600000))
                TextBox3.Text = "kW*h"
                TextBox4.Text = "kW*h"

            ElseIf ComboBox1.Text = "Kilowatt-hour" And ComboBox2.Text = "Kilojoule" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 3600))
                TextBox3.Text = "kW*h"
                TextBox4.Text = "PW"
            ElseIf ComboBox1.Text = "Kilowatt-hour" And ComboBox2.Text = "Kilojoule" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 3600))
                TextBox3.Text = "kW*h"
                TextBox4.Text = "kJ"

            ElseIf ComboBox1.Text = "Kilowatt-hour" And ComboBox2.Text = "Kilowatt-hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "kW*h"
                TextBox4.Text = "kW*h"
            ElseIf ComboBox1.Text = "Kilowatt-hour" And ComboBox2.Text = "Kilowatt-hour" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "kW*h"
                TextBox4.Text = "kW*h"

            ElseIf ComboBox1.Text = "Kilowatt-hour" And ComboBox2.Text = "Watt-hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "kW*h"
                TextBox4.Text = "W*h"
            ElseIf ComboBox1.Text = "Kilowatt-hour" And ComboBox2.Text = "Watt-hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "kW*h"
                TextBox4.Text = "W*h"

            ElseIf ComboBox1.Text = "Kilowatt-hour" And ComboBox2.Text = "Calorie" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 859.84522786))
                TextBox3.Text = "kW*h"
                TextBox4.Text = "cal"
            ElseIf ComboBox1.Text = "Kilowatt-hour" And ComboBox2.Text = "Calorie" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 859.84522786))
                TextBox3.Text = "kW*h"
                TextBox4.Text = "cal"

            ElseIf ComboBox1.Text = "Watt-hour" And ComboBox2.Text = "Joule" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 3600))
                TextBox3.Text = "W*h"
                TextBox4.Text = "J"
            ElseIf ComboBox1.Text = "Watt-hour" And ComboBox2.Text = "Joule" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 3600))
                TextBox3.Text = "W*h"
                TextBox4.Text = "J"

            ElseIf ComboBox1.Text = "Watt-hour" And ComboBox2.Text = "Kilojoule" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 3.6))
                TextBox3.Text = "W*h"
                TextBox4.Text = "kJ"
            ElseIf ComboBox1.Text = "Watt-hour" And ComboBox2.Text = "Kilojoule" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 3.6))
                TextBox3.Text = "W*h"
                TextBox4.Text = "kJ"

            ElseIf ComboBox1.Text = "Watt-hour" And ComboBox2.Text = "Kilowatt-hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "W*h"
                TextBox4.Text = "kW*h"
            ElseIf ComboBox1.Text = "Watt-hour" And ComboBox2.Text = "Kilowatt-hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "W*h"
                TextBox4.Text = "kW*h"

            ElseIf ComboBox1.Text = "Watt-hour" And ComboBox2.Text = "Watt-hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "W*h"
                TextBox4.Text = "W*h"
            ElseIf ComboBox1.Text = "Watt-hour" And ComboBox2.Text = "Watt-hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "W*h"
                TextBox4.Text = "W*h"

            ElseIf ComboBox1.Text = "Watt-hour" And ComboBox2.Text = "Calorie" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1.163))
                TextBox3.Text = "W*h"
                TextBox4.Text = "cal"
            ElseIf ComboBox1.Text = "Watt-hour" And ComboBox2.Text = "Calorie" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1.163))
                TextBox3.Text = "W*h"
                TextBox4.Text = "cal"

            ElseIf ComboBox1.Text = "Calorie" And ComboBox2.Text = "Joule" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 4186.8))
                TextBox3.Text = "cal"
                TextBox4.Text = "J"
            ElseIf ComboBox1.Text = "Calorie" And ComboBox2.Text = "Joule" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 4186.8))
                TextBox3.Text = "cal"
                TextBox4.Text = "J"

            ElseIf ComboBox1.Text = "Calorie" And ComboBox2.Text = "Kilojoule" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 4.1868))
                TextBox3.Text = "cal"
                TextBox4.Text = "kJ"
            ElseIf ComboBox1.Text = "Calorie" And ComboBox2.Text = "Kilojoule" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 4.1868))
                TextBox3.Text = "cal"
                TextBox4.Text = "kJ"

            ElseIf ComboBox1.Text = "Calorie" And ComboBox2.Text = "Kilowatt-hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 859.84522786))
                TextBox3.Text = "cal"
                TextBox4.Text = "kW*h"
            ElseIf ComboBox1.Text = "Calorie" And ComboBox2.Text = "Kilowatt-hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 859.84522786))
                TextBox3.Text = "cal"
                TextBox4.Text = "kW*h"

            ElseIf ComboBox1.Text = "Calorie" And ComboBox2.Text = "Watt-hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1.163))
                TextBox3.Text = "cal"
                TextBox4.Text = "W*h"
            ElseIf ComboBox1.Text = "Calorie" And ComboBox2.Text = "Watt-hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1.163))
                TextBox3.Text = "cal"
                TextBox4.Text = "W*h"

            ElseIf ComboBox1.Text = "Calorie" And ComboBox2.Text = "Calorie" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "cal"
                TextBox4.Text = "cal"
            ElseIf ComboBox1.Text = "Calorie" And ComboBox2.Text = "Calorie" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "cal"
                TextBox4.Text = "cal"

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
