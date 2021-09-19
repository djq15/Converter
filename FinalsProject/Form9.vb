Public Class Form9


    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Choose one . . . "
        ComboBox1.Items.Add("Minute")
        ComboBox1.Items.Add("Hour")
        ComboBox1.Items.Add("Day")
        ComboBox1.Items.Add("Week")
        ComboBox1.Items.Add("Month")


        ComboBox2.Text = "Choose one . . . "
        ComboBox2.Items.Add("Minute")
        ComboBox2.Items.Add("Hour")
        ComboBox2.Items.Add("Day")
        ComboBox2.Items.Add("Week")
        ComboBox2.Items.Add("Month")

        TextBox3.Enabled = False
        TextBox4.Enabled = False

        RadioButton1.Checked = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If ComboBox1.Text = "Minute" And ComboBox2.Text = "Minute" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "min"
                TextBox4.Text = "min"
            ElseIf ComboBox1.Text = "Minute" And ComboBox2.Text = "Minute" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "min"
                TextBox4.Text = "min"

            ElseIf ComboBox1.Text = "Minute" And ComboBox2.Text = "Hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 60))
                TextBox3.Text = "min"
                TextBox4.Text = "h"
            ElseIf ComboBox1.Text = "Minute" And ComboBox2.Text = "Hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 60))
                TextBox3.Text = "min"
                TextBox4.Text = "h"

            ElseIf ComboBox1.Text = "Minute" And ComboBox2.Text = "Day" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1440))
                TextBox3.Text = "min"
                TextBox4.Text = "d"
            ElseIf ComboBox1.Text = "Minute" And ComboBox2.Text = "Day" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1440))
                TextBox3.Text = "min"
                TextBox4.Text = "d"

            ElseIf ComboBox1.Text = "Minute" And ComboBox2.Text = "Week" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 10080))
                TextBox3.Text = "min"
                TextBox4.Text = "wk"
            ElseIf ComboBox1.Text = "Minute" And ComboBox2.Text = "Week" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 10080))
                TextBox3.Text = "min"
                TextBox4.Text = "wk"

            ElseIf ComboBox1.Text = "Minute" And ComboBox2.Text = "Month" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 43800))
                TextBox3.Text = "min"
                TextBox4.Text = "mth"
            ElseIf ComboBox1.Text = "Minute" And ComboBox2.Text = "Month" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 43800))
                TextBox3.Text = "min"
                TextBox4.Text = "mth"

            ElseIf ComboBox1.Text = "Hour" And ComboBox2.Text = "Minute" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 60))
                TextBox3.Text = "h"
                TextBox4.Text = "min"
            ElseIf ComboBox1.Text = "Hour" And ComboBox2.Text = "Minute" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 60))
                TextBox3.Text = "h"
                TextBox4.Text = "min"

            ElseIf ComboBox1.Text = "Hour" And ComboBox2.Text = "Hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "h"
                TextBox4.Text = "h"
            ElseIf ComboBox1.Text = "Hour" And ComboBox2.Text = "Hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "h"
                TextBox4.Text = "h"

            ElseIf ComboBox1.Text = "Hour" And ComboBox2.Text = "Day" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 24))
                TextBox3.Text = "h"
                TextBox4.Text = "d"
            ElseIf ComboBox1.Text = "Hour" And ComboBox2.Text = "Day" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 24))
                TextBox3.Text = "h"
                TextBox4.Text = "d"

            ElseIf ComboBox1.Text = "Hour" And ComboBox2.Text = "Week" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 168))
                TextBox3.Text = "h"
                TextBox4.Text = "wk"
            ElseIf ComboBox1.Text = "Hour" And ComboBox2.Text = "Week" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 168))
                TextBox3.Text = "h"
                TextBox4.Text = "wk"

            ElseIf ComboBox1.Text = "Hour" And ComboBox2.Text = "Month" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 730))
                TextBox3.Text = "h"
                TextBox4.Text = "mth"
            ElseIf ComboBox1.Text = "Hour" And ComboBox2.Text = "Month" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 730))
                TextBox3.Text = "h"
                TextBox4.Text = "mth"

            ElseIf ComboBox1.Text = "Day" And ComboBox2.Text = "Minute" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1440))
                TextBox3.Text = "d"
                TextBox4.Text = "min"
            ElseIf ComboBox1.Text = "Day" And ComboBox2.Text = "Minute" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1440))
                TextBox3.Text = "d"
                TextBox4.Text = "min"

            ElseIf ComboBox1.Text = "Day" And ComboBox2.Text = "Hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 24))
                TextBox3.Text = "d"
                TextBox4.Text = "h"
            ElseIf ComboBox1.Text = "Day" And ComboBox2.Text = "Hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 24))
                TextBox3.Text = "d"
                TextBox4.Text = "h"

            ElseIf ComboBox1.Text = "Day" And ComboBox2.Text = "Day" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "d"
                TextBox4.Text = "d"
            ElseIf ComboBox1.Text = "Day" And ComboBox2.Text = "Day" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "d"
                TextBox4.Text = "d"

            ElseIf ComboBox1.Text = "Day" And ComboBox2.Text = "Week" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 7))
                TextBox3.Text = "d"
                TextBox4.Text = "wk"
            ElseIf ComboBox1.Text = "Day" And ComboBox2.Text = "Week" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 7))
                TextBox3.Text = "d"
                TextBox4.Text = "wk"

            ElseIf ComboBox1.Text = "Day" And ComboBox2.Text = "Month" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 30.416666667))
                TextBox3.Text = "d"
                TextBox4.Text = "mth"
            ElseIf ComboBox1.Text = "Day" And ComboBox2.Text = "Month" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 30.416666667))
                TextBox3.Text = "d"
                TextBox4.Text = "mth"

            ElseIf ComboBox1.Text = "Week" And ComboBox2.Text = "Minute" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 10080))
                TextBox3.Text = "wk"
                TextBox4.Text = "min"
            ElseIf ComboBox1.Text = "Week" And ComboBox2.Text = "Minute" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 10080))
                TextBox3.Text = "wk"
                TextBox4.Text = "min"

            ElseIf ComboBox1.Text = "Week" And ComboBox2.Text = "Hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 168))
                TextBox3.Text = "wk"
                TextBox4.Text = "h"
            ElseIf ComboBox1.Text = "Week" And ComboBox2.Text = "Hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 168))
                TextBox3.Text = "wk"
                TextBox4.Text = "h"

            ElseIf ComboBox1.Text = "Week" And ComboBox2.Text = "Day" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 7))
                TextBox3.Text = "wk"
                TextBox4.Text = "d"
            ElseIf ComboBox1.Text = "Week" And ComboBox2.Text = "Day" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 7))
                TextBox3.Text = "wk"
                TextBox4.Text = "d"

            ElseIf ComboBox1.Text = "Week" And ComboBox2.Text = "Week" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "wk"
                TextBox4.Text = "wk"
            ElseIf ComboBox1.Text = "Week" And ComboBox2.Text = "Week" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "wk"
                TextBox4.Text = "wk"

            ElseIf ComboBox1.Text = "Week" And ComboBox2.Text = "Month" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 4.3452380952))
                TextBox3.Text = "wk"
                TextBox4.Text = "mth"
            ElseIf ComboBox1.Text = "Week" And ComboBox2.Text = "Month" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 4.3452380952))
                TextBox3.Text = "wk"
                TextBox4.Text = "mth"

            ElseIf ComboBox1.Text = "Month" And ComboBox2.Text = "Minute" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 43800))
                TextBox3.Text = "mth"
                TextBox4.Text = "min"
            ElseIf ComboBox1.Text = "Month" And ComboBox2.Text = "Minute" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 43800))
                TextBox3.Text = "mth"
                TextBox4.Text = "min"

            ElseIf ComboBox1.Text = "Month" And ComboBox2.Text = "Hour" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 730))
                TextBox3.Text = "mth"
                TextBox4.Text = "h"
            ElseIf ComboBox1.Text = "Month" And ComboBox2.Text = "Hour" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 730))
                TextBox3.Text = "mth"
                TextBox4.Text = "h"

            ElseIf ComboBox1.Text = "Month" And ComboBox2.Text = "Day" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 30.416666667))
                TextBox3.Text = "mth"
                TextBox4.Text = "d"
            ElseIf ComboBox1.Text = "Month" And ComboBox2.Text = "Day" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 30.416666667))
                TextBox3.Text = "mth"
                TextBox4.Text = "d"

            ElseIf ComboBox1.Text = "Month" And ComboBox2.Text = "Week" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 4.3452380952))
                TextBox3.Text = "mth"
                TextBox4.Text = "wk"
            ElseIf ComboBox1.Text = "Month" And ComboBox2.Text = "Week" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 4.3452380952))
                TextBox3.Text = "mth"
                TextBox4.Text = "wk"

            ElseIf ComboBox1.Text = "Month" And ComboBox2.Text = "Month" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "mth"
                TextBox4.Text = "mth"
            ElseIf ComboBox1.Text = "Month" And ComboBox2.Text = "Month" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "mth"
                TextBox4.Text = "mth"

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
