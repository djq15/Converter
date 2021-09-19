Public Class Form10


    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Choose one . . . "
        ComboBox1.Items.Add("Pascal")
        ComboBox1.Items.Add("KiloPascal")
        ComboBox1.Items.Add("Bar")
        ComboBox1.Items.Add("PSI")
        ComboBox1.Items.Add("KSI")


        ComboBox2.Text = "Choose one . . . "
        ComboBox2.Items.Add("Pascal")
        ComboBox2.Items.Add("KiloPascal")
        ComboBox2.Items.Add("Bar")
        ComboBox2.Items.Add("PSI")
        ComboBox2.Items.Add("KSI")

        TextBox3.Enabled = False
        TextBox4.Enabled = False

        RadioButton1.Checked = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If ComboBox1.Text = "Pascal" And ComboBox2.Text = "Pascal" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "pa"
                TextBox4.Text = "pa"
            ElseIf ComboBox1.Text = "Pascal" And ComboBox2.Text = "Pascal" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "pa"
                TextBox4.Text = "pa"

            ElseIf ComboBox1.Text = "Pascal" And ComboBox2.Text = "KiloPascal" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "pa"
                TextBox4.Text = "kPa"
            ElseIf ComboBox1.Text = "Pascal" And ComboBox2.Text = "KiloPascal" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "pa"
                TextBox4.Text = "kPa"

            ElseIf ComboBox1.Text = "Pascal" And ComboBox2.Text = "Bar" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 100000))
                TextBox3.Text = "pa"
                TextBox4.Text = "br"
            ElseIf ComboBox1.Text = "Pascal" And ComboBox2.Text = "Bar" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 100000))
                TextBox3.Text = "pa"
                TextBox4.Text = "br"

            ElseIf ComboBox1.Text = "Pascal" And ComboBox2.Text = "PSI" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 6894.7572932))
                TextBox3.Text = "pa"
                TextBox4.Text = "psi"
            ElseIf ComboBox1.Text = "Pascal" And ComboBox2.Text = "PSI" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 6894.7572932))
                TextBox3.Text = "pa"
                TextBox4.Text = "psi"

            ElseIf ComboBox1.Text = "Pascal" And ComboBox2.Text = "KSI" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 6894757.2932))
                TextBox3.Text = "pa"
                TextBox4.Text = "ksi"
            ElseIf ComboBox1.Text = "Pascal" And ComboBox2.Text = "KSI" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 6894757.2932))
                TextBox3.Text = "pa"
                TextBox4.Text = "ksi"

            ElseIf ComboBox1.Text = "KiloPascal" And ComboBox2.Text = "Pascal" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "kPa"
                TextBox4.Text = "pa"
            ElseIf ComboBox1.Text = "KiloPascal" And ComboBox2.Text = "Pascal" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "kPa"
                TextBox4.Text = "pa"

            ElseIf ComboBox1.Text = "KiloPascal" And ComboBox2.Text = "KiloPascal" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "kPa"
                TextBox4.Text = "kPa"
            ElseIf ComboBox1.Text = "KiloPascal" And ComboBox2.Text = "KiloPascal" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "kPa"
                TextBox4.Text = "kPa"

            ElseIf ComboBox1.Text = "KiloPascal" And ComboBox2.Text = "Bar" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 100))
                TextBox3.Text = "kPa"
                TextBox4.Text = "br"
            ElseIf ComboBox1.Text = "KiloPascal" And ComboBox2.Text = "Bar" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 100))
                TextBox3.Text = "kPa"
                TextBox4.Text = "br"

            ElseIf ComboBox1.Text = "KiloPascal" And ComboBox2.Text = "PSI" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 6.8947572932))
                TextBox3.Text = "kPa"
                TextBox4.Text = "psi"
            ElseIf ComboBox1.Text = "KiloPascal" And ComboBox2.Text = "PSI" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 6.8947572932))
                TextBox3.Text = "kPa"
                TextBox4.Text = "psi"

            ElseIf ComboBox1.Text = "KiloPascal" And ComboBox2.Text = "KSI" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 6894.7572932))
                TextBox3.Text = "kPa"
                TextBox4.Text = "ksi"
            ElseIf ComboBox1.Text = "KiloPascal" And ComboBox2.Text = "KSI" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 6894.7572932))
                TextBox3.Text = "kPa"
                TextBox4.Text = "ksi"

            ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "Pascal" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 100000))
                TextBox3.Text = "br"
                TextBox4.Text = "pa"
            ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "Pascal" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 100000))
                TextBox3.Text = "br"
                TextBox4.Text = "pa"

            ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "KiloPascal" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 100))
                TextBox3.Text = "br"
                TextBox4.Text = "kPa"
            ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "KiloPascal" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 100))
                TextBox3.Text = "br"
                TextBox4.Text = "kPa"

            ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "Bar" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "br"
                TextBox4.Text = "br"
            ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "Bar" And RadioButton2.Checked = True Then
                TextBox1.Text = Val(TextBox2.Text * 1)
                TextBox3.Text = "br"
                TextBox4.Text = "br"

            ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "PSI" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 14.503773773))
                TextBox3.Text = "br"
                TextBox4.Text = "psi"
            ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "PSI" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 14.503773773))
                TextBox3.Text = "br"
                TextBox4.Text = "psi"

            ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "KSI" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 68.947572932))
                TextBox3.Text = "br"
                TextBox4.Text = "ksi"
            ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "KSI" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 68.947572932))
                TextBox3.Text = "br"
                TextBox4.Text = "ksi"
                ''
            ElseIf ComboBox1.Text = "PSI" And ComboBox2.Text = "Pascal" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 6894.7572932))
                TextBox3.Text = "psi"
                TextBox4.Text = "pa"
            ElseIf ComboBox1.Text = "PSI" And ComboBox2.Text = "Pascal" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 6894.7572932))
                TextBox3.Text = "psi"
                TextBox4.Text = "pa"

            ElseIf ComboBox1.Text = "PSI" And ComboBox2.Text = "KiloPascal" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 6.8947572932))
                TextBox3.Text = "psi"
                TextBox4.Text = "kPa"
            ElseIf ComboBox1.Text = "PSI" And ComboBox2.Text = "KiloPascal" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 6.8947572932))
                TextBox3.Text = "psi"
                TextBox4.Text = "kPa"

            ElseIf ComboBox1.Text = "PSI" And ComboBox2.Text = "Bar" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 14.503773773))
                TextBox3.Text = "psi"
                TextBox4.Text = "br"
            ElseIf ComboBox1.Text = "PSI" And ComboBox2.Text = "Bar" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 14.503773773))
                TextBox3.Text = "psi"
                TextBox4.Text = "br"

            ElseIf ComboBox1.Text = "PSI" And ComboBox2.Text = "PSI" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "psi"
                TextBox4.Text = "psi"
            ElseIf ComboBox1.Text = "PSI" And ComboBox2.Text = "PSI" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "psi"
                TextBox4.Text = "psi"

            ElseIf ComboBox1.Text = "PSI" And ComboBox2.Text = "KSI" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1 / 1000))
                TextBox3.Text = "psi"
                TextBox4.Text = "ksi"
            ElseIf ComboBox1.Text = "PSI" And ComboBox2.Text = "KSI" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1000))
                TextBox3.Text = "psi"
                TextBox4.Text = "ksi"

            ElseIf ComboBox1.Text = "KSI" And ComboBox2.Text = "Pascal" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 6894757.2932))
                TextBox3.Text = "ksi"
                TextBox4.Text = "pa"
            ElseIf ComboBox1.Text = "KSI" And ComboBox2.Text = "Pascal" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 6894757.2932))
                TextBox3.Text = "ksi"
                TextBox4.Text = "pa"

            ElseIf ComboBox1.Text = "KSI" And ComboBox2.Text = "KiloPascal" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 6894.7572932))
                TextBox3.Text = "ksi"
                TextBox4.Text = "kPa"
            ElseIf ComboBox1.Text = "KSI" And ComboBox2.Text = "KiloPascal" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 6894.7572932))
                TextBox3.Text = "ksi"
                TextBox4.Text = "kPa"

            ElseIf ComboBox1.Text = "KSI" And ComboBox2.Text = "Bar" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 68.947572932))
                TextBox3.Text = "ksi"
                TextBox4.Text = "br"
            ElseIf ComboBox1.Text = "KSI" And ComboBox2.Text = "Bar" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 68.947572932))
                TextBox3.Text = "ksi"
                TextBox4.Text = "br"

            ElseIf ComboBox1.Text = "KSI" And ComboBox2.Text = "PSI" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1000))
                TextBox3.Text = "ksi"
                TextBox4.Text = "psi"
            ElseIf ComboBox1.Text = "KSI" And ComboBox2.Text = "PSI" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1 / 1000))
                TextBox3.Text = "ksi"
                TextBox4.Text = "psi"

            ElseIf ComboBox1.Text = "KSI" And ComboBox2.Text = "KSI" And RadioButton1.Checked = True Then
                TextBox2.Text = CDec(Val(TextBox1.Text * 1))
                TextBox3.Text = "ksi"
                TextBox4.Text = "ksi"
            ElseIf ComboBox1.Text = "KSI" And ComboBox2.Text = "KSI" And RadioButton2.Checked = True Then
                TextBox1.Text = CDec(Val(TextBox2.Text * 1))
                TextBox3.Text = "ksi"
                TextBox4.Text = "ksi"

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
