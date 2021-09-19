Public Class Form1





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Choose one . . . "
        ComboBox1.Items.Add("US Dollar")
        ComboBox1.Items.Add("Philippine Peso")
        ComboBox1.Items.Add("Japanese Yen")
        ComboBox1.Items.Add("Korean Won")
        ComboBox1.Items.Add("UK Pound Sterling")


        ComboBox2.Text = "Choose one . . . "
        ComboBox2.Items.Add("US Dollar")
        ComboBox2.Items.Add("Philippine Peso")
        ComboBox2.Items.Add("Japanese Yen")
        ComboBox2.Items.Add("Korean Won")
        ComboBox2.Items.Add("UK Pound Sterling")

        TextBox3.Enabled = False
        TextBox4.Enabled = False

        RadioButton1.Checked = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If ComboBox1.Text = "US Dollar" And ComboBox2.Text = "US Dollar" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1)
                TextBox3.Text = "$"
                TextBox4.Text = "$"
            ElseIf ComboBox1.Text = "US Dollar" And ComboBox2.Text = "US Dollar" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "$"
                TextBox4.Text = "$"

            ElseIf ComboBox1.Text = "US Dollar" And ComboBox2.Text = "Philippine Peso" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 51.19)
                TextBox3.Text = "$"
                TextBox4.Text = "₱"
            ElseIf ComboBox1.Text = "US Dollar" And ComboBox2.Text = "Philippine Peso" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1 / 51.19)
                TextBox3.Text = "$"
                TextBox4.Text = "₱"

            ElseIf ComboBox1.Text = "US Dollar" And ComboBox2.Text = "Japanese Yen" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 108.67)
                TextBox3.Text = "$"
                TextBox4.Text = "¥"
            ElseIf ComboBox1.Text = "US Dollar" And ComboBox2.Text = "Japanese Yen" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1 / 108.67)
                TextBox3.Text = "$"
                TextBox4.Text = "¥"

            ElseIf ComboBox1.Text = "US Dollar" And ComboBox2.Text = "Korean Won" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1171.82)
                TextBox3.Text = "$"
                TextBox4.Text = "₩"
            ElseIf ComboBox1.Text = "US Dollar" And ComboBox2.Text = "Korean Won" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1 / 1171.82)
                TextBox3.Text = "$"
                TextBox4.Text = "₩"

            ElseIf ComboBox1.Text = "US Dollar" And ComboBox2.Text = "UK Pound Sterling" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1 / 1.28)
                TextBox3.Text = "$"
                TextBox4.Text = "£"
            ElseIf ComboBox1.Text = "US Dollar" And ComboBox2.Text = "UK Pound Sterling" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1.28)
                TextBox3.Text = "$"
                TextBox4.Text = "£"

            ElseIf ComboBox1.Text = "Philippine Peso" And ComboBox2.Text = "US Dollar" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1 / 51.19)
                TextBox3.Text = "₱"
                TextBox4.Text = "$"
            ElseIf ComboBox1.Text = "Philippine Peso" And ComboBox2.Text = "US Dollar" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 51.19)
                TextBox3.Text = "₱"
                TextBox4.Text = "$"

            ElseIf ComboBox1.Text = "Philippine Peso" And ComboBox2.Text = "Philippine Peso" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1)
                TextBox3.Text = "₱"
                TextBox4.Text = "₱"
            ElseIf ComboBox1.Text = "Philippine Peso" And ComboBox2.Text = "Philippine Peso" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "₱"
                TextBox4.Text = "₱"

            ElseIf ComboBox1.Text = "Philippine Peso" And ComboBox2.Text = "Japanese Yen" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 2.12)
                TextBox3.Text = "₱"
                TextBox4.Text = "¥"
            ElseIf ComboBox1.Text = "Philippine Peso" And ComboBox2.Text = "Japanese Yen" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1 / 2.12)
                TextBox3.Text = "₱"
                TextBox4.Text = "¥"

            ElseIf ComboBox1.Text = "Philippine Peso" And ComboBox2.Text = "Korean Won" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 22.89)
                TextBox3.Text = "₱"
                TextBox4.Text = "₩"
            ElseIf ComboBox1.Text = "Philippine Peso" And ComboBox2.Text = "Korean Won" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1 / 22.89)
                TextBox3.Text = "₱"
                TextBox4.Text = "₩"

            ElseIf ComboBox1.Text = "Philippine Peso" And ComboBox2.Text = "UK Pound Sterling" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1 / 65.66)
                TextBox3.Text = "₱"
                TextBox4.Text = "£"
            ElseIf ComboBox1.Text = "Philippine Peso" And ComboBox2.Text = "UK Pound Sterling" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 65.66)
                TextBox3.Text = "₱"
                TextBox4.Text = "£"

            ElseIf ComboBox1.Text = "Japanese Yen" And ComboBox2.Text = "US Dollar" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1 / 108.67)
                TextBox3.Text = "¥"
                TextBox4.Text = "$"
            ElseIf ComboBox1.Text = "Japanese Yen" And ComboBox2.Text = "US Dollar" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 108.67)
                TextBox3.Text = "¥"
                TextBox4.Text = "$"

            ElseIf ComboBox1.Text = "Japanese Yen" And ComboBox2.Text = "Philippine Peso" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1 / 2.12)
                TextBox3.Text = "¥"
                TextBox4.Text = "₱"
            ElseIf ComboBox1.Text = "Japanese Yen" And ComboBox2.Text = "Philippine Peso" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 2.12)
                TextBox3.Text = "¥"
                TextBox4.Text = "₱"

            ElseIf ComboBox1.Text = "Japanese Yen" And ComboBox2.Text = "Japanese Yen" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1)
                TextBox3.Text = "¥"
                TextBox4.Text = "¥"
            ElseIf ComboBox1.Text = "Japanese Yen" And ComboBox2.Text = "Japanese Yen" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "¥"
                TextBox4.Text = "¥"

            ElseIf ComboBox1.Text = "Japanese Yen" And ComboBox2.Text = "Korean Won" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 10.78)
                TextBox3.Text = "¥"
                TextBox4.Text = "₩"
            ElseIf ComboBox1.Text = "Japanese Yen" And ComboBox2.Text = "Korean Won" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1 / 10.78)
                TextBox3.Text = "¥"
                TextBox4.Text = "₩"

            ElseIf ComboBox1.Text = "Japanese Yen" And ComboBox2.Text = "UK Pound Sterling" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1 / 139.38)
                TextBox3.Text = "¥"
                TextBox4.Text = "£"
            ElseIf ComboBox1.Text = "Japanese Yen" And ComboBox2.Text = "UK Pound Sterling" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 139.38)
                TextBox3.Text = "¥"
                TextBox4.Text = "£"

            ElseIf ComboBox1.Text = "Korean Won" And ComboBox2.Text = "US Dollar" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1 / 1171.82)
                TextBox3.Text = "₩"
                TextBox4.Text = "$"
            ElseIf ComboBox1.Text = "Korean Won" And ComboBox2.Text = "US Dollar" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1171.82)
                TextBox3.Text = "₩"
                TextBox4.Text = "$"

            ElseIf ComboBox1.Text = "Korean Won" And ComboBox2.Text = "Philippine Peso" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1 / 22.89)
                TextBox3.Text = "₩"
                TextBox4.Text = "₱"
            ElseIf ComboBox1.Text = "Korean Won" And ComboBox2.Text = "Philippine Peso" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 22.89)
                TextBox3.Text = "₩"
                TextBox4.Text = "₱"

            ElseIf ComboBox1.Text = "Korean Won" And ComboBox2.Text = "Japanese Yen" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1 / 10.78)
                TextBox3.Text = "₩"
                TextBox4.Text = "¥"
            ElseIf ComboBox1.Text = "Korean Won" And ComboBox2.Text = "Japanese Yen" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 10.78)
                TextBox3.Text = "₩"
                TextBox4.Text = "¥"

            ElseIf ComboBox1.Text = "Korean Won" And ComboBox2.Text = "Korean Won" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1)
                TextBox3.Text = "₩"
                TextBox4.Text = "₩"
            ElseIf ComboBox1.Text = "Korean Won" And ComboBox2.Text = "Korean Won" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "₩"
                TextBox4.Text = "₩"

            ElseIf ComboBox1.Text = "Korean Won" And ComboBox2.Text = "UK Pound Sterling" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1 / 1503.09)
                TextBox3.Text = "₩"
                TextBox4.Text = "£"
            ElseIf ComboBox1.Text = "Korean Won" And ComboBox2.Text = "UK Pound Sterling" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1503.09)
                TextBox3.Text = "₩"
                TextBox4.Text = "£"

            ElseIf ComboBox1.Text = "UK Pound Sterling" And ComboBox2.Text = "US Dollar" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1.28)
                TextBox3.Text = "£"
                TextBox4.Text = "$"
            ElseIf ComboBox1.Text = "UK Pound Sterling" And ComboBox2.Text = "US Dollar" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1 / 1.28)
                TextBox3.Text = "£"
                TextBox4.Text = "$"

            ElseIf ComboBox1.Text = "UK Pound Sterling" And ComboBox2.Text = "Philippine Peso" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 65.66)
                TextBox3.Text = "£"
                TextBox4.Text = "₱"
            ElseIf ComboBox1.Text = "UK Pound Sterling" And ComboBox2.Text = "Philippine Peso" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1 / 65.66)
                TextBox3.Text = "£"
                TextBox4.Text = "₱"

            ElseIf ComboBox1.Text = "UK Pound Sterling" And ComboBox2.Text = "Japanese Yen" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 139.38)
                TextBox3.Text = "£"
                TextBox4.Text = "¥"
            ElseIf ComboBox1.Text = "UK Pound Sterling" And ComboBox2.Text = "Japanese Yen" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1 / 139.38)
                TextBox3.Text = "£"
                TextBox4.Text = "¥"

            ElseIf ComboBox1.Text = "UK Pound Sterling" And ComboBox2.Text = "Korean Won" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1503.09)
                TextBox3.Text = "£"
                TextBox4.Text = "₩"
            ElseIf ComboBox1.Text = "UK Pound Sterling" And ComboBox2.Text = "Korean Won" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1 / 1503.09)
                TextBox3.Text = "£"
                TextBox4.Text = "₩"

            ElseIf ComboBox1.Text = "UK Pound Sterling" And ComboBox2.Text = "UK Pound Sterling" And RadioButton1.Checked = True Then
                TextBox2.Text = Val(TextBox1.Text * 1)
                TextBox3.Text = "£"
                TextBox4.Text = "£"
            ElseIf ComboBox1.Text = "UK Pound Sterling" And ComboBox2.Text = "UK Pound Sterling" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "£"
                TextBox4.Text = "£"

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
