Public Class Form7


    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Choose one . . . "
        ComboBox1.Items.Add("MeterPerSecond")
        ComboBox1.Items.Add("KilometerPerHour")
        ComboBox1.Items.Add("MilePerHour")
        ComboBox1.Items.Add("MeterPerHour")
        ComboBox1.Items.Add("MeterPerMinute")


        ComboBox2.Text = "Choose one . . . "
        ComboBox2.Items.Add("MeterPerSecond")
        ComboBox2.Items.Add("KilometerPerHour")
        ComboBox2.Items.Add("MilePerHour")
        ComboBox2.Items.Add("MeterPerHour")
        ComboBox2.Items.Add("MeterPerMinute")

        TextBox3.Enabled = False
        TextBox4.Enabled = False

        RadioButton1.Checked = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If ComboBox1.Text = "MeterPerSecond" And ComboBox2.Text = "MeterPerSecond" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "m/s"
                TextBox4.Text = "m/s"
            ElseIf ComboBox1.Text = "MeterPerSecond" And ComboBox2.Text = "MeterPerSecond" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "m/s"
                TextBox4.Text = "m/s"

            ElseIf ComboBox1.Text = "MeterPerSecond" And ComboBox2.Text = "KilometerPerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 3.6))
                TextBox3.Text = "m/s"
                TextBox4.Text = "km/h"
            ElseIf ComboBox1.Text = "MeterPerSecond" And ComboBox2.Text = "KilometerPerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 3.6))
                TextBox3.Text = "m/s"
                TextBox4.Text = "km/h"

            ElseIf ComboBox1.Text = "MeterPerSecond" And ComboBox2.Text = "MilePerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 2.2369362921))
                TextBox3.Text = "m/s"
                TextBox4.Text = "mi/h"
            ElseIf ComboBox1.Text = "MeterPerSecond" And ComboBox2.Text = "MilePerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 2.2369362921))
                TextBox3.Text = "m/s"
                TextBox4.Text = "mi/h"

            ElseIf ComboBox1.Text = "MeterPerSecond" And ComboBox2.Text = "MeterPerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 3600))
                TextBox3.Text = "m/s"
                TextBox4.Text = "m/h"
            ElseIf ComboBox1.Text = "MeterPerSecond" And ComboBox2.Text = "MeterPerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 3600))
                TextBox3.Text = "m/s"
                TextBox4.Text = "m/h"

            ElseIf ComboBox1.Text = "MeterPerSecond" And ComboBox2.Text = "MeterPerMinute" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 60))
                TextBox3.Text = "m/s"
                TextBox4.Text = "m/min"
            ElseIf ComboBox1.Text = "MeterPerSecond" And ComboBox2.Text = "MeterPerMinute" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 60))
                TextBox3.Text = "m/s"
                TextBox4.Text = "m/min"

            ElseIf ComboBox1.Text = "KilometerPerHour" And ComboBox2.Text = "MeterPerSecond" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 0.2777777778))
                TextBox3.Text = "km/h"
                TextBox4.Text = "m/s"
            ElseIf ComboBox1.Text = "KilometerPerHour" And ComboBox2.Text = "MeterPerSecond" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 0.2777777778))
                TextBox3.Text = "km/h"
                TextBox4.Text = "m/s"

            ElseIf ComboBox1.Text = "KilometerPerHour" And ComboBox2.Text = "KilometerPerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "km/h"
                TextBox4.Text = "km/h"
            ElseIf ComboBox1.Text = "KilometerPerHour" And ComboBox2.Text = "KilometerPerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "km/h"
                TextBox4.Text = "km/h"

            ElseIf ComboBox1.Text = "KilometerPerHour" And ComboBox2.Text = "MilePerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1.609344))
                TextBox3.Text = "km/h"
                TextBox4.Text = "mi/h"
            ElseIf ComboBox1.Text = "KilometerPerHour" And ComboBox2.Text = "MilePerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1.609344))
                TextBox3.Text = "km/h"
                TextBox4.Text = "mi/h"

            ElseIf ComboBox1.Text = "KilometerPerHour" And ComboBox2.Text = "MeterPerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "km/h"
                TextBox4.Text = "m/h"
            ElseIf ComboBox1.Text = "KilometerPerHour" And ComboBox2.Text = "MeterPerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "km/h"
                TextBox4.Text = "m/h"

            ElseIf ComboBox1.Text = "KilometerPerHour" And ComboBox2.Text = "MeterPerMinute" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 16.666666667))
                TextBox3.Text = "km/h"
                TextBox4.Text = "m/min"
            ElseIf ComboBox1.Text = "KilometerPerHour" And ComboBox2.Text = "MeterPerMinute" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 16.666666667))
                TextBox3.Text = "km/h"
                TextBox4.Text = "m/min"

            ElseIf ComboBox1.Text = "MilePerHour" And ComboBox2.Text = "MeterPerSecond" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 2.2369362921))
                TextBox3.Text = "mi/h"
                TextBox4.Text = "m/s"
            ElseIf ComboBox1.Text = "MilePerHour" And ComboBox2.Text = "MeterPerSecond" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 2.2369362921))
                TextBox3.Text = "mi/h"
                TextBox4.Text = "m/s"

            ElseIf ComboBox1.Text = "MilePerHour" And ComboBox2.Text = "KilometerPerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1.609344))
                TextBox3.Text = "mi/h"
                TextBox4.Text = "km/h"
            ElseIf ComboBox1.Text = "MilePerHour" And ComboBox2.Text = "KilometerPerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1.609344))
                TextBox3.Text = "mi/h"
                TextBox4.Text = "km/h"

            ElseIf ComboBox1.Text = "MilePerHour" And ComboBox2.Text = "MilePerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "mi/h"
                TextBox4.Text = "mi/h"
            ElseIf ComboBox1.Text = "MilePerHour" And ComboBox2.Text = "MilePerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "mi/h"
                TextBox4.Text = "mi/h"

            ElseIf ComboBox1.Text = "MilePerHour" And ComboBox2.Text = "MeterPerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1609.344))
                TextBox3.Text = "mi/h"
                TextBox4.Text = "m/h"
            ElseIf ComboBox1.Text = "MilePerHour" And ComboBox2.Text = "MeterPerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1609.344))
                TextBox3.Text = "mi/h"
                TextBox4.Text = "m/h"

            ElseIf ComboBox1.Text = "MilePerHour" And ComboBox2.Text = "MeterPerMinute" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 26.8224))
                TextBox3.Text = "mi/h"
                TextBox4.Text = "m/min"
            ElseIf ComboBox1.Text = "MilePerHour" And ComboBox2.Text = "MeterPerMinute" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 26.8224))
                TextBox3.Text = "mi/h"
                TextBox4.Text = "m/min"
                ''
            ElseIf ComboBox1.Text = "MeterPerHour" And ComboBox2.Text = "MeterPerSecond" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 3600))
                TextBox3.Text = "m/h"
                TextBox4.Text = "m/s"
            ElseIf ComboBox1.Text = "MeterPerHour" And ComboBox2.Text = "MeterPerSecond" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 3600))
                TextBox3.Text = "m/h"
                TextBox4.Text = "m/s"

            ElseIf ComboBox1.Text = "MeterPerHour" And ComboBox2.Text = "KilometerPerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "m/h"
                TextBox4.Text = "km/h"
            ElseIf ComboBox1.Text = "MeterPerHour" And ComboBox2.Text = "KilometerPerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "m/h"
                TextBox4.Text = "km/h"

            ElseIf ComboBox1.Text = "MeterPerHour" And ComboBox2.Text = "MilePerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1609.344))
                TextBox3.Text = "m/h"
                TextBox4.Text = "mi/h"
            ElseIf ComboBox1.Text = "MeterPerHour" And ComboBox2.Text = "MilePerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1609.344))
                TextBox3.Text = "m/h"
                TextBox4.Text = "mi/h"

            ElseIf ComboBox1.Text = "MeterPerHour" And ComboBox2.Text = "MeterPerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "m/h"
                TextBox4.Text = "m/h"
            ElseIf ComboBox1.Text = "MeterPerHour" And ComboBox2.Text = "MeterPerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "m/h"
                TextBox4.Text = "m/h"

            ElseIf ComboBox1.Text = "MeterPerHour" And ComboBox2.Text = "MeterPerMinute" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 60))
                TextBox3.Text = "m/h"
                TextBox4.Text = "m/min"
            ElseIf ComboBox1.Text = "MeterPerHour" And ComboBox2.Text = "MeterPerMinute" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 60))
                TextBox3.Text = "m/h"
                TextBox4.Text = "m/min"

            ElseIf ComboBox1.Text = "MeterPerMinute" And ComboBox2.Text = "MeterPerSecond" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 60))
                TextBox3.Text = "m/min"
                TextBox4.Text = "m/s"
            ElseIf ComboBox1.Text = "MeterPerMinute" And ComboBox2.Text = "MeterPerSecond" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 60))
                TextBox3.Text = "m/min"
                TextBox4.Text = "m/s"

            ElseIf ComboBox1.Text = "MeterPerMinute" And ComboBox2.Text = "KilometerPerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 16.666666667))
                TextBox3.Text = "m/min"
                TextBox4.Text = "km/h"
            ElseIf ComboBox1.Text = "MeterPerMinute" And ComboBox2.Text = "KilometerPerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 16.666666667))
                TextBox3.Text = "m/min"
                TextBox4.Text = "km/h"

            ElseIf ComboBox1.Text = "MeterPerMinute" And ComboBox2.Text = "MilePerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 26.8224))
                TextBox3.Text = "m/min"
                TextBox4.Text = "mi/h"
            ElseIf ComboBox1.Text = "MeterPerMinute" And ComboBox2.Text = "MilePerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 26.8224))
                TextBox3.Text = "m/min"
                TextBox4.Text = "mi/h"

            ElseIf ComboBox1.Text = "MeterPerMinute" And ComboBox2.Text = "MeterPerHour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 60))
                TextBox3.Text = "m/min"
                TextBox4.Text = "m/h"
            ElseIf ComboBox1.Text = "MeterPerMinute" And ComboBox2.Text = "MeterPerHour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 60))
                TextBox3.Text = "m/min"
                TextBox4.Text = "m/h"

            ElseIf ComboBox1.Text = "MeterPerMinute" And ComboBox2.Text = "MeterPerMinute" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "m/min"
                TextBox4.Text = "m/min"
            ElseIf ComboBox1.Text = "MeterPerMinute" And ComboBox2.Text = "MeterPerMinute" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "m/min"
                TextBox4.Text = "m/min"

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
