Public Class Form3


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Choose one . . . "
        ComboBox1.Items.Add("Meter")
        ComboBox1.Items.Add("Kilometer")
        ComboBox1.Items.Add("Yard")
        ComboBox1.Items.Add("Mile")
        ComboBox1.Items.Add("Foot")


        ComboBox2.Text = "Choose one . . . "
        ComboBox2.Items.Add("Meter")
        ComboBox2.Items.Add("Kilometer")
        ComboBox2.Items.Add("Yard")
        ComboBox2.Items.Add("Mile")
        ComboBox2.Items.Add("Foot")

        TextBox3.Enabled = False
        TextBox4.Enabled = False

        RadioButton1.Checked = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If ComboBox1.Text = "Meter" And ComboBox2.Text = "Meter" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "m"
                TextBox4.Text = "m"
            ElseIf ComboBox1.Text = "Meter" And ComboBox2.Text = "Meter" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "m"
                TextBox4.Text = "m"

            ElseIf ComboBox1.Text = "Meter" And ComboBox2.Text = "Kilometer" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "m"
                TextBox4.Text = "km"
            ElseIf ComboBox1.Text = "Meter" And ComboBox2.Text = "Kilometer" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "m"
                TextBox4.Text = "km"

            ElseIf ComboBox1.Text = "Meter" And ComboBox2.Text = "Yard" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1.0936132983))
                TextBox3.Text = "m"
                TextBox4.Text = "yd"
            ElseIf ComboBox1.Text = "Meter" And ComboBox2.Text = "Yard" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1.0936132983))
                TextBox3.Text = "m"
                TextBox4.Text = "yd"

            ElseIf ComboBox1.Text = "Meter" And ComboBox2.Text = "Mile" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1609.344))
                TextBox3.Text = "m"
                TextBox4.Text = "mi"
            ElseIf ComboBox1.Text = "Meter" And ComboBox2.Text = "Mile" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1609.344))
                TextBox3.Text = "m"
                TextBox4.Text = "mi"

            ElseIf ComboBox1.Text = "Meter" And ComboBox2.Text = "Foot" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 3.2808398955))
                TextBox3.Text = "m"
                TextBox4.Text = "ft"
            ElseIf ComboBox1.Text = "Meter" And ComboBox2.Text = "Foot" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 3.280839895))
                TextBox3.Text = "m"
                TextBox4.Text = "ft"

            ElseIf ComboBox1.Text = "Kilometer" And ComboBox2.Text = "Meter" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "km"
                TextBox4.Text = "m"
            ElseIf ComboBox1.Text = "Kilometer" And ComboBox2.Text = "Meter" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "km"
                TextBox4.Text = "m"

            ElseIf ComboBox1.Text = "Kilometer" And ComboBox2.Text = "Kilometer" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "km"
                TextBox4.Text = "km"
            ElseIf ComboBox1.Text = "Kilometer" And ComboBox2.Text = "Kilometer" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "km"
                TextBox4.Text = "km"

            ElseIf ComboBox1.Text = "Kilometer" And ComboBox2.Text = "Yard" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1093.6132983))
                TextBox3.Text = "km"
                TextBox4.Text = "yd"
            ElseIf ComboBox1.Text = "Kilometer" And ComboBox2.Text = "Yard" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1093.6132983))
                TextBox3.Text = "km"
                TextBox4.Text = "yd"

            ElseIf ComboBox1.Text = "Kilometer" And ComboBox2.Text = "Mile" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1.609344))
                TextBox3.Text = "km"
                TextBox4.Text = "mi"
            ElseIf ComboBox1.Text = "Kilometer" And ComboBox2.Text = "Mile" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1.609344))
                TextBox3.Text = "km"
                TextBox4.Text = "mi"

            ElseIf ComboBox1.Text = "Kilometer" And ComboBox2.Text = "Foot" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 3280.839895))
                TextBox3.Text = "km"
                TextBox4.Text = "ft"
            ElseIf ComboBox1.Text = "Kilometer" And ComboBox2.Text = "Foot" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 3280.839895))
                TextBox3.Text = "km"
                TextBox4.Text = "ft"

            ElseIf ComboBox1.Text = "Yard" And ComboBox2.Text = "Meter" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1.0936132983))
                TextBox3.Text = "yd"
                TextBox4.Text = "m"
            ElseIf ComboBox1.Text = "Yard" And ComboBox2.Text = "Meter" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1.0936132983))
                TextBox3.Text = "yd"
                TextBox4.Text = "m"

            ElseIf ComboBox1.Text = "Yard" And ComboBox2.Text = "Kilometer" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1093.6132983))
                TextBox3.Text = "yd"
                TextBox4.Text = "km"
            ElseIf ComboBox1.Text = "Yard" And ComboBox2.Text = "Kilometer" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1093.6132983))
                TextBox3.Text = "yd"
                TextBox4.Text = "km"

            ElseIf ComboBox1.Text = "Yard" And ComboBox2.Text = "Yard" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "yd"
                TextBox4.Text = "yd"
            ElseIf ComboBox1.Text = "Yard" And ComboBox2.Text = "Yard" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "yd"
                TextBox4.Text = "yd"

            ElseIf ComboBox1.Text = "Yard" And ComboBox2.Text = "Mile" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1760))
                TextBox3.Text = "yd"
                TextBox4.Text = "mi"
            ElseIf ComboBox1.Text = "Yard" And ComboBox2.Text = "Mile" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1760))
                TextBox3.Text = "yd"
                TextBox4.Text = "mi"

            ElseIf ComboBox1.Text = "Yard" And ComboBox2.Text = "Foot" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 3))
                TextBox3.Text = "yd"
                TextBox4.Text = "ft"
            ElseIf ComboBox1.Text = "Yard" And ComboBox2.Text = "Foot" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 3))
                TextBox3.Text = "yd"
                TextBox4.Text = "ft"

            ElseIf ComboBox1.Text = "Mile" And ComboBox2.Text = "Meter" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1609.344))
                TextBox3.Text = "mi"
                TextBox4.Text = "m"
            ElseIf ComboBox1.Text = "Mile" And ComboBox2.Text = "Meter" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1609.344))
                TextBox3.Text = "mi"
                TextBox4.Text = "m"

            ElseIf ComboBox1.Text = "Mile" And ComboBox2.Text = "Kilometer" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1.609344))
                TextBox3.Text = "mi"
                TextBox4.Text = "km"
            ElseIf ComboBox1.Text = "Mile" And ComboBox2.Text = "Kilometer" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1.609344))
                TextBox3.Text = "mi"
                TextBox4.Text = "km"

            ElseIf ComboBox1.Text = "Mile" And ComboBox2.Text = "Yard" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1760))
                TextBox3.Text = "mi"
                TextBox4.Text = "yd"
            ElseIf ComboBox1.Text = "Mile" And ComboBox2.Text = "Yard" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1760))
                TextBox3.Text = "mi"
                TextBox4.Text = "yd"

            ElseIf ComboBox1.Text = "Mile" And ComboBox2.Text = "Mile" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "mi"
                TextBox4.Text = "mi"
            ElseIf ComboBox1.Text = "Mile" And ComboBox2.Text = "Mile" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "mi"
                TextBox4.Text = "mi"

            ElseIf ComboBox1.Text = "Mile" And ComboBox2.Text = "Foot" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 5280))
                TextBox3.Text = "mi"
                TextBox4.Text = "ft"
            ElseIf ComboBox1.Text = "Mile" And ComboBox2.Text = "Foot" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 5280))
                TextBox3.Text = "mi"
                TextBox4.Text = "ft"

            ElseIf ComboBox1.Text = "Foot" And ComboBox2.Text = "Meter" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 3.280839895))
                TextBox3.Text = "ft"
                TextBox4.Text = "m"
            ElseIf ComboBox1.Text = "Foot" And ComboBox2.Text = "Meter" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 3.280839895))
                TextBox3.Text = "ft"
                TextBox4.Text = "m"

            ElseIf ComboBox1.Text = "Foot" And ComboBox2.Text = "Kilometer" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 3280.839895))
                TextBox3.Text = "ft"
                TextBox4.Text = "km"
            ElseIf ComboBox1.Text = "Foot" And ComboBox2.Text = "Kilometer" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 3280.839895))
                TextBox3.Text = "ft"
                TextBox4.Text = "km"

            ElseIf ComboBox1.Text = "Foot" And ComboBox2.Text = "Yard" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 3))
                TextBox3.Text = "ft"
                TextBox4.Text = "yd"
            ElseIf ComboBox1.Text = "Foot" And ComboBox2.Text = "Yard" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 3))
                TextBox3.Text = "ft"
                TextBox4.Text = "yd"

            ElseIf ComboBox1.Text = "Foot" And ComboBox2.Text = "Mile" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 5280))
                TextBox3.Text = "ft"
                TextBox4.Text = "mi"
            ElseIf ComboBox1.Text = "Foot" And ComboBox2.Text = "Mile" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 5280))
                TextBox3.Text = "ft"
                TextBox4.Text = "mi"

            ElseIf ComboBox1.Text = "Foot" And ComboBox2.Text = "Foot" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "ft"
                TextBox4.Text = "ft"
            ElseIf ComboBox1.Text = "Foot" And ComboBox2.Text = "Foot" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "ft"
                TextBox4.Text = "ft"

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
