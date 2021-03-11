Public Class DeepSeaFC
    Private weeklyWage, weeklyGoalBonus, matchBonus, cleanSheetBonus, totalPlayerEarning As Double
    Private fixedBonus As Double

    Private Sub DeepSeaFC_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim mydialogResult As DialogResult
        mydialogResult = MessageBox.Show("Do you want to Exit??", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If mydialogResult = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnUpperExit_Click(sender As Object, e As EventArgs) Handles btnUpperExit.Click
        Application.Exit()
    End Sub

    Private Sub btnAddEntry_Click(sender As Object, e As EventArgs) Handles btnAddEntry.Click
        'Variables to bind with gridbox
        Dim firstName, lastName, Position As String

        'Binding variables to datagrid
        firstName = txtFirstName.Text
        lastName = txtLastName.Text
        Position = cmbPosition.Text
        Double.TryParse(txtWeeklyWage.Text, weeklyWage)
        Double.TryParse(txtMatchBonus.Text, matchBonus)
        Double.TryParse(txtCleanSheetBonus.Text, cleanSheetBonus)
        Double.TryParse(txtTotalPlayerBill.Text, totalPlayerEarning)

        'Add data to datagrid
        Me.DataGridView1.Rows.Add(
            firstName, lastName, Position, weeklyWage, weeklyGoalBonus,
            matchBonus, cleanSheetBonus
)
    End Sub

    Private Sub btnLowerExit_Click(sender As Object, e As EventArgs) Handles btnLowerExit.Click

        Application.Exit()
    End Sub

    Private Sub btnPerformanceSet_Click(sender As Object, e As EventArgs) Handles btnPerformanceSet.Click
        Dim goalCount, matchesCount As Double
        Dim fivePercent, sevenPercent As Double
        fixedBonus = 2000
        fivePercent = 0.05
        sevenPercent = 0.07

        goalCount =  NUDGoalCount.Value
        matchesCount = NUDMatchesPlayed.Value

        Double.TryParse(NUDGoalCount.Value, goalCount)
        Double.TryParse(NUDMatchesPlayed.Value, matchesCount)
        Double.TryParse(txtWeeklyWage.Text, weeklyWage)
        Double.TryParse(txtCleanSheetBonus.Text, cleanSheetBonus)

        txtGoalBonus.Text = fixedBonus * goalCount
        txtMatchBonus.Text = fivePercent * matchesCount
        txtCleanSheetBonus.Text = sevenPercent * weeklyWage

        Dim take As Double = txtCleanSheetBonus.Text
        'calculating cleansheet
        If rdbYes.Checked Then
            take.ToString("C")

        Else
            txtCleanSheetBonus.Text = "0"
        End If

        MessageBox.Show("Value Successfully Set!")
    End Sub
End Class