Public Class frmTaxCalc
    Private sale As Double
    Private Sub btnTax2_Click(sender As Object, e As EventArgs) Handles btnTax2.Click
        Dim sale As Double
        Dim tax2 As Double
        sale = CDbl(txbSale.Text)
        tax2 = 2 / 100 * sale
        txbTaxDisplay.Text = tax2.ToString("C2")
    End Sub

    Private Sub btnTax5_Click(sender As Object, e As EventArgs) Handles btnTax5.Click
        Dim sale As Double
        Dim tax5 As Double
        sale = CDbl(txbSale.Text)
        tax5 = 5 / 100 * sale
        txbTaxDisplay.Text = tax5.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Double.TryParse(txbSale.Text, sale)
        txbTotalSale.Text += sale
        txbTotalSale.Text = txbTotalSale.ToString("C2")
        Static min, max, saleCount As Integer
        saleCount += 1
        If saleCount <= 1 Then
            min = sale
            max = sale
        Else
            If sale > max Then
                max = sale
            ElseIf sale < min Then
                min = sale
            End If
        End If
        txbHighestSale.Text = max.ToString("C2")
        txbLowestSale.Text = min.ToString("C2")
    End Sub
End Class