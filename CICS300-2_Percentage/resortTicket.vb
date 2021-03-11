Public Class resortTicket
    Private costOfBicycle, costOfFootBall, costOfVball, costOfIBoat, totalAmount, discountAmount As Double
    Private taxableAmount, taxAmount, payableAmount As Double
    Dim costDiscount, membershipDiscount As Double
    Private receiptDetails As String = "{0, -20}{1, -25}{2, -15}{3, -20}{4, -15}"
    Private Sub resortTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstReceipt.Items.Add(String.Format(receiptDetails, "ITEM", "QUANTITY", "NUM OF DAYS", "UNIT COST", "TOTAL COST"))

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        receiptDetails = lstReceipt.SelectedItem
        Dim newTotalAmount As Double = CDbl(receiptDetails.Remove(0, 84))
        lstReceipt.Items.RemoveAt(lstReceipt.SelectedIndex)
        totalAmount -= newTotalAmount

        txtTotal.Text = totalAmount.ToString("C2")
        txtDiscount.Text = FormatCurrency(discountAmount, 3)
        txtTaxAmount.Text = taxableAmount.ToString("C2")
        txtVAT.Text = taxableAmount.ToString("C2")
        txtTaxAmount.Text = payableAmount.ToString("C2")
    End Sub

    Private Sub resortTicket_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim mydialogResult As DialogResult
        mydialogResult = MessageBox.Show("Do you really want to Exit??", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If mydialogResult = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstReceipt.Items.Clear()
        lstReceipt.Items.Add(String.Format(receiptDetails, "ITEM", "QUANTITY", "NUM OF DAYS", "UNIT COST", "TOTAL COST"))
        txtTotal.Clear()
        txtDiscount.Clear()
        txtTaxAmount.Clear()
        txtVAT.Clear()
        txtAmountPayable.Clear()
        txtIBoat.Clear()
        txtBicycle.Clear()
        txtFBall.Clear()
        txtVball.Clear()
    End Sub


    Private Sub btnAdItem_Click(sender As Object, e As EventArgs) Handles btnAdItem.Click
        Dim itemName As String
        Static itemQuantity, numOfDays As Integer
        Dim itemRentCost, totalItemRentCost As Double
        'Assigning values to the variables
        itemName = cmbitemName.SelectedItem
        itemQuantity = nduQuantity.Value
        numOfDays = nduNumOfDays.Value

        'using the control statements
        If itemName = "Bicycle" Then
            itemRentCost = costOfBicycle
        ElseIf itemName = "Football" Then
            itemRentCost = costOfFootBall
        ElseIf itemName = "Volley Ball" Then
            itemRentCost = costOfVball
        Else
            itemRentCost = costOfIBoat
        End If

        'calculting the item rent cost
        totalItemRentCost = itemRentCost * itemQuantity * numOfDays
        totalAmount = totalItemRentCost

        'calculating the Discount
        Select Case totalAmount
            Case < 200
                costDiscount = 0.02 * totalAmount
            Case <= 1000
                costDiscount = 0.05 * totalAmount
            Case Else
                costDiscount = 0.1 * totalAmount
        End Select

        'discount on memberships
        If btnRadio1.Checked = True Then
            membershipDiscount = 0.05 * totalAmount
        End If

        'discount amount
        discountAmount = costDiscount + membershipDiscount

        'taxable amount
        taxableAmount = totalAmount - discountAmount

        'tax rate (12%)
        taxAmount = 0.12 * taxableAmount

        'payable amount
        payableAmount = taxableAmount + taxableAmount

        'binding results on interface
        lstReceipt.Items.Add(String.Format(receiptDetails, itemName, itemQuantity.ToString, numOfDays.ToString, itemRentCost.ToString("C2"), totalItemRentCost.ToString("C2")))
        txtTotal.Text = totalAmount.ToString("C2")
        txtDiscount.Text = FormatCurrency(discountAmount, 2)
        txtTaxAmount.Text = taxableAmount.ToString("C2")
        txtVAT.Text = taxAmount.ToString("C2")
        txtAmountPayable.Text = payableAmount.ToString("C2")

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' converting user input
        Double.TryParse(txtBicycle.Text, costOfBicycle)
        Double.TryParse(txtFBall.Text, costOfFootBall)
        Double.TryParse(txtFBall.Text, costOfFootBall)
        Double.TryParse(txtVball.Text, costOfVball)
        Double.TryParse(txtIBoat.Text, costOfIBoat)

        MessageBox.Show("Program Setup Completed Successfully!")
    End Sub
End Class