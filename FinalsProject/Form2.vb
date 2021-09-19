Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Choose one . . . "
        ComboBox1.Items.Add("Ounce")
        ComboBox1.Items.Add("Gram")
        ComboBox1.Items.Add("Kilogram")
        ComboBox1.Items.Add("Pound")
        ComboBox1.Items.Add("Metric ton")


        ComboBox2.Text = "Choose one . . . "
        ComboBox2.Items.Add("Ounce")
        ComboBox2.Items.Add("Gram")
        ComboBox2.Items.Add("Kilogram")
        ComboBox2.Items.Add("Pound")
        ComboBox2.Items.Add("Metric ton")

        TextBox3.Enabled = False
        TextBox4.Enabled = False

        RadioButton1.Checked = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If ComboBox1.Text = "Ounce" And ComboBox2.Text = "Ounce" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "oz"
                TextBox4.Text = "oz"
            ElseIf ComboBox1.Text = "Ounce" And ComboBox2.Text = "Ounce" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "oz"
                TextBox4.Text = "oz"

            ElseIf ComboBox1.Text = "Ounce" And ComboBox2.Text = "Gram" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 28.349523125))
                TextBox3.Text = "oz"
                TextBox4.Text = "g"
            ElseIf ComboBox1.Text = "Ounce" And ComboBox2.Text = "Gram" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 28.349523125))
                TextBox3.Text = "oz"
                TextBox4.Text = "g"

            ElseIf ComboBox1.Text = "Ounce" And ComboBox2.Text = "Kilogram" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 35.27396195))
                TextBox3.Text = "oz"
                TextBox4.Text = "kg"
            ElseIf ComboBox1.Text = "Ounce" And ComboBox2.Text = "Kilogram" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 35.27396195))
                TextBox3.Text = "oz"
                TextBox4.Text = "kg"

            ElseIf ComboBox1.Text = "Ounce" And ComboBox2.Text = "Pound" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 16))
                TextBox3.Text = "oz"
                TextBox4.Text = "lbs"
            ElseIf ComboBox1.Text = "Ounce" And ComboBox2.Text = "Pound" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 16))
                TextBox3.Text = "oz"
                TextBox4.Text = "lbs"

            ElseIf ComboBox1.Text = "Ounce" And ComboBox2.Text = "Metric ton" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 35273.96195))
                TextBox3.Text = "oz"
                TextBox4.Text = "t"
            ElseIf ComboBox1.Text = "Ounce" And ComboBox2.Text = "Metric ton" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 35273.96195))
                TextBox3.Text = "oz"
                TextBox4.Text = "t"

            ElseIf ComboBox1.Text = "Gram" And ComboBox2.Text = "Ounce" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 28.349523125))
                TextBox3.Text = "g"
                TextBox4.Text = "lbs"
            ElseIf ComboBox1.Text = "Gram" And ComboBox2.Text = "Ounce" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 28.349523125))
                TextBox3.Text = "g"
                TextBox4.Text = "lbs"

            ElseIf ComboBox1.Text = "Gram" And ComboBox2.Text = "Gram" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "g"
                TextBox4.Text = "g"
            ElseIf ComboBox1.Text = "Gram" And ComboBox2.Text = "Gram" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "g"
                TextBox4.Text = "g"

            ElseIf ComboBox1.Text = "Gram" And ComboBox2.Text = "Kilogram" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "g"
                TextBox4.Text = "kg"
            ElseIf ComboBox1.Text = "Gram" And ComboBox2.Text = "Kilogram" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "g"
                TextBox4.Text = "kg"

            ElseIf ComboBox1.Text = "Gram" And ComboBox2.Text = "Pound" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 453.59237))
                TextBox3.Text = "g"
                TextBox4.Text = "lbs"
            ElseIf ComboBox1.Text = "Gram" And ComboBox2.Text = "Pound" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 453.59237))
                TextBox3.Text = "g"
                TextBox4.Text = "lbs"

            ElseIf ComboBox1.Text = "Gram" And ComboBox2.Text = "Metric ton" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 0.000001))
                TextBox3.Text = "g"
                TextBox4.Text = "t"
            ElseIf ComboBox1.Text = "Gram" And ComboBox2.Text = "Metric ton" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000000))
                TextBox3.Text = "g"
                TextBox4.Text = "t"

            ElseIf ComboBox1.Text = "Kilogram" And ComboBox2.Text = "Ounce" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 35.27396195))
                TextBox3.Text = "kg"
                TextBox4.Text = "oz"
            ElseIf ComboBox1.Text = "Kilogram" And ComboBox2.Text = "Ounce" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 35.27396195))
                TextBox3.Text = "kg"
                TextBox4.Text = "oz"

            ElseIf ComboBox1.Text = "Kilogram" And ComboBox2.Text = "Gram" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "kg"
                TextBox4.Text = "g"
            ElseIf ComboBox1.Text = "Kilogram" And ComboBox2.Text = "Gram" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "kg"
                TextBox4.Text = "g"

            ElseIf ComboBox1.Text = "Kilogram" And ComboBox2.Text = "Kilogram" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "kg"
                TextBox4.Text = "kg"
            ElseIf ComboBox1.Text = "Kilogram" And ComboBox2.Text = "Kilogram" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "kg"
                TextBox4.Text = "kg"

            ElseIf ComboBox1.Text = "Kilogram" And ComboBox2.Text = "Pound" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 2.2046226218))
                TextBox3.Text = "kg"
                TextBox4.Text = "lbs"
            ElseIf ComboBox1.Text = "Kilogram" And ComboBox2.Text = "Pound" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 2.2046226218))
                TextBox3.Text = "kg"
                TextBox4.Text = "lbs"

            ElseIf ComboBox1.Text = "Kilogram" And ComboBox2.Text = "Metric ton" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "kg"
                TextBox4.Text = "t"
            ElseIf ComboBox1.Text = "Kilogram" And ComboBox2.Text = "Metric ton" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "kg"
                TextBox4.Text = "t"

            ElseIf ComboBox1.Text = "Pound" And ComboBox2.Text = "Ounce" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 16))
                TextBox3.Text = "lbs"
                TextBox4.Text = "oz"
            ElseIf ComboBox1.Text = "Pound" And ComboBox2.Text = "Ounce" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 16))
                TextBox3.Text = "lbs"
                TextBox4.Text = "oz"

            ElseIf ComboBox1.Text = "Pound" And ComboBox2.Text = "Gram" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 453.59237))
                TextBox3.Text = "lbs"
                TextBox4.Text = "g"
            ElseIf ComboBox1.Text = "Pound" And ComboBox2.Text = "Gram" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 453.59237))
                TextBox3.Text = "lbs"
                TextBox4.Text = "g"

            ElseIf ComboBox1.Text = "Pound" And ComboBox2.Text = "Kilogram" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 2.2046226218))
                TextBox3.Text = "lbs"
                TextBox4.Text = "kg"
            ElseIf ComboBox1.Text = "Pound" And ComboBox2.Text = "Kilogram" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 2.2046226218))
                TextBox3.Text = "lbs"
                TextBox4.Text = "kg"

            ElseIf ComboBox1.Text = "Pound" And ComboBox2.Text = "Pound" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "lbs"
                TextBox4.Text = "lbs"
            ElseIf ComboBox1.Text = "Pound" And ComboBox2.Text = "Pound" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "lbs"
                TextBox4.Text = "lbs"

            ElseIf ComboBox1.Text = "Pound" And ComboBox2.Text = "Metric ton" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 2204.6226218))
                TextBox3.Text = "lbs"
                TextBox4.Text = "t"
            ElseIf ComboBox1.Text = "Pound" And ComboBox2.Text = "Metric ton" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 2204.6226218))
                TextBox3.Text = "lbs"
                TextBox4.Text = "t"

            ElseIf ComboBox1.Text = "Metric ton" And ComboBox2.Text = "Ounce" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 35273.96195))
                TextBox3.Text = "t"
                TextBox4.Text = "oz"
            ElseIf ComboBox1.Text = "Metric ton" And ComboBox2.Text = "Ounce" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 35273.96195))
                TextBox3.Text = "t"
                TextBox4.Text = "oz"

            ElseIf ComboBox1.Text = "Metric ton" And ComboBox2.Text = "Gram" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000000))
                TextBox3.Text = "t"
                TextBox4.Text = "g"
            ElseIf ComboBox1.Text = "Metric ton" And ComboBox2.Text = "Gram" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000000))
                TextBox3.Text = "t"
                TextBox4.Text = "g"

            ElseIf ComboBox1.Text = "Metric ton" And ComboBox2.Text = "Kilogram" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "t"
                TextBox4.Text = "kg"
            ElseIf ComboBox1.Text = "Metric ton" And ComboBox2.Text = "Kilogram" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "t"
                TextBox4.Text = "kg"

            ElseIf ComboBox1.Text = "Metric ton" And ComboBox2.Text = "Pound" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 2204.6226218))
                TextBox3.Text = "t"
                TextBox4.Text = "lbs"
            ElseIf ComboBox1.Text = "Metric ton" And ComboBox2.Text = "Pound" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 2204.6226218))
                TextBox3.Text = "t"
                TextBox4.Text = "lbs"

            ElseIf ComboBox1.Text = "Metric ton" And ComboBox2.Text = "Metric ton" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "t"
                TextBox4.Text = "t"
            ElseIf ComboBox1.Text = "Metric ton" And ComboBox2.Text = "Metric ton" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "t"
                TextBox4.Text = "t"

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
