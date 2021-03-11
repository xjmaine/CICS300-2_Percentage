Public Class Form1
    Private Sub btnCalc_MouseEnter(sender As Object, e As EventArgs) Handles btnCalc.MouseEnter
        btnCalc.BackColor = Color.Orange
    End Sub

    Private Sub btnCalc_MouseLeave(sender As Object, e As EventArgs) Handles btnCalc.MouseLeave
        btnCalc.BackColor = Color.MediumVioletRed
    End Sub

    Private Sub btnReset_MouseEnter(sender As Object, e As EventArgs) Handles btnReset.MouseEnter
        btnReset.BackColor = Color.Orange
    End Sub

    Private Sub btnReset_MouseLeave(sender As Object, e As EventArgs) Handles btnReset.MouseLeave
        btnReset.BackColor = Color.MediumVioletRed
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim wage = txbWage.Text.Trim().ToString()
        Dim percentValue = txbPercentage.Text.Trim().ToString()

        If Not String.IsNullOrEmpty(wage) And
           Not String.IsNullOrEmpty(percentValue) Then

            'local variables 
            Dim intPercent As Integer = 0
            Dim pValue As Double = 0.0

            'nested if-else
            If Integer.TryParse(wage, intPercent) And
                Double.TryParse(percentValue, pValue) Then

                Dim resultCheck As Double = (pValue * intPercent) / 100
                lblDisplay.Text = resultCheck.ToString() & "%"

                Dim finalWage As Double = resultCheck + wage
                lblNewWage.Text = "Ghc" & finalWage.ToString("#, #00.00")

            Else
                MessageBox.Show("Try conversion again! " & wage & " or " & percentValue & " is incorrect", "Head's up!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    'event to clear all fields when clicked
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txbWage.Text = ""
        txbPercentage.Text = ""
        lblDisplay.Text = "--"
        lblNewWage.Text = "--"
    End Sub

    Private Sub lblExit_MouseEnter(sender As Object, e As EventArgs) Handles lblExit.MouseEnter
        lblExit.ForeColor = Color.Orange
    End Sub

    Private Sub lblExit_MouseLeave(sender As Object, e As EventArgs) Handles lblExit.MouseLeave
        lblExit.ForeColor = Color.Orchid
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub
End Class
