<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resortTicket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ctrlConfig = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIBoat = New System.Windows.Forms.TextBox()
        Me.txtVball = New System.Windows.Forms.TextBox()
        Me.txtFBall = New System.Windows.Forms.TextBox()
        Me.txtBicycle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ctrlResults = New System.Windows.Forms.GroupBox()
        Me.txtAmountPayable = New System.Windows.Forms.TextBox()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.txtTaxAmount = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ctrlTransaction = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnRadio2 = New System.Windows.Forms.RadioButton()
        Me.btnRadio1 = New System.Windows.Forms.RadioButton()
        Me.btnAdItem = New System.Windows.Forms.Button()
        Me.nduNumOfDays = New System.Windows.Forms.NumericUpDown()
        Me.nduQuantity = New System.Windows.Forms.NumericUpDown()
        Me.cmbitemName = New System.Windows.Forms.ComboBox()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ctrlConfig.SuspendLayout()
        Me.ctrlResults.SuspendLayout()
        Me.ctrlTransaction.SuspendLayout()
        CType(Me.nduNumOfDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nduQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ctrlConfig
        '
        Me.ctrlConfig.Controls.Add(Me.btnAdd)
        Me.ctrlConfig.Controls.Add(Me.Label8)
        Me.ctrlConfig.Controls.Add(Me.txtIBoat)
        Me.ctrlConfig.Controls.Add(Me.txtVball)
        Me.ctrlConfig.Controls.Add(Me.txtFBall)
        Me.ctrlConfig.Controls.Add(Me.txtBicycle)
        Me.ctrlConfig.Controls.Add(Me.Label4)
        Me.ctrlConfig.Controls.Add(Me.Label3)
        Me.ctrlConfig.Controls.Add(Me.Label2)
        Me.ctrlConfig.Controls.Add(Me.Label1)
        Me.ctrlConfig.Location = New System.Drawing.Point(43, 58)
        Me.ctrlConfig.Name = "ctrlConfig"
        Me.ctrlConfig.Size = New System.Drawing.Size(404, 206)
        Me.ctrlConfig.TabIndex = 0
        Me.ctrlConfig.TabStop = False
        Me.ctrlConfig.Text = "Configuration"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(274, 102)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 33)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Set"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(101, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(221, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Enter The Rental Price Per Day"
        '
        'txtIBoat
        '
        Me.txtIBoat.Location = New System.Drawing.Point(130, 141)
        Me.txtIBoat.Name = "txtIBoat"
        Me.txtIBoat.Size = New System.Drawing.Size(138, 22)
        Me.txtIBoat.TabIndex = 7
        '
        'txtVball
        '
        Me.txtVball.Location = New System.Drawing.Point(130, 107)
        Me.txtVball.Name = "txtVball"
        Me.txtVball.Size = New System.Drawing.Size(138, 22)
        Me.txtVball.TabIndex = 6
        '
        'txtFBall
        '
        Me.txtFBall.Location = New System.Drawing.Point(130, 73)
        Me.txtFBall.Name = "txtFBall"
        Me.txtFBall.Size = New System.Drawing.Size(138, 22)
        Me.txtFBall.TabIndex = 5
        '
        'txtBicycle
        '
        Me.txtBicycle.Location = New System.Drawing.Point(130, 39)
        Me.txtBicycle.Name = "txtBicycle"
        Me.txtBicycle.Size = New System.Drawing.Size(138, 22)
        Me.txtBicycle.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Inflatable Boat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Football"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Volley Ball"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bicycle"
        '
        'ctrlResults
        '
        Me.ctrlResults.Controls.Add(Me.txtAmountPayable)
        Me.ctrlResults.Controls.Add(Me.txtVAT)
        Me.ctrlResults.Controls.Add(Me.txtTaxAmount)
        Me.ctrlResults.Controls.Add(Me.txtDiscount)
        Me.ctrlResults.Controls.Add(Me.txtTotal)
        Me.ctrlResults.Controls.Add(Me.Label13)
        Me.ctrlResults.Controls.Add(Me.Label12)
        Me.ctrlResults.Controls.Add(Me.Label11)
        Me.ctrlResults.Controls.Add(Me.Label10)
        Me.ctrlResults.Controls.Add(Me.Label9)
        Me.ctrlResults.Location = New System.Drawing.Point(453, 58)
        Me.ctrlResults.Name = "ctrlResults"
        Me.ctrlResults.Size = New System.Drawing.Size(311, 207)
        Me.ctrlResults.TabIndex = 1
        Me.ctrlResults.TabStop = False
        Me.ctrlResults.Text = "Results"
        '
        'txtAmountPayable
        '
        Me.txtAmountPayable.Location = New System.Drawing.Point(132, 158)
        Me.txtAmountPayable.Name = "txtAmountPayable"
        Me.txtAmountPayable.ReadOnly = True
        Me.txtAmountPayable.Size = New System.Drawing.Size(153, 22)
        Me.txtAmountPayable.TabIndex = 11
        '
        'txtVAT
        '
        Me.txtVAT.Location = New System.Drawing.Point(130, 127)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.ReadOnly = True
        Me.txtVAT.Size = New System.Drawing.Size(153, 22)
        Me.txtVAT.TabIndex = 10
        '
        'txtTaxAmount
        '
        Me.txtTaxAmount.Location = New System.Drawing.Point(132, 96)
        Me.txtTaxAmount.Name = "txtTaxAmount"
        Me.txtTaxAmount.ReadOnly = True
        Me.txtTaxAmount.Size = New System.Drawing.Size(153, 22)
        Me.txtTaxAmount.TabIndex = 9
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(132, 65)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(153, 22)
        Me.txtDiscount.TabIndex = 8
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(130, 34)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(153, 22)
        Me.txtTotal.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 163)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 17)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Amount Payable"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "VAT(12%)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Taxable Amount"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(61, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Discount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(84, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total"
        '
        'ctrlTransaction
        '
        Me.ctrlTransaction.Controls.Add(Me.Label14)
        Me.ctrlTransaction.Controls.Add(Me.btnClear)
        Me.ctrlTransaction.Controls.Add(Me.btnRemove)
        Me.ctrlTransaction.Controls.Add(Me.Button3)
        Me.ctrlTransaction.Controls.Add(Me.btnRadio2)
        Me.ctrlTransaction.Controls.Add(Me.btnRadio1)
        Me.ctrlTransaction.Controls.Add(Me.btnAdItem)
        Me.ctrlTransaction.Controls.Add(Me.nduNumOfDays)
        Me.ctrlTransaction.Controls.Add(Me.nduQuantity)
        Me.ctrlTransaction.Controls.Add(Me.cmbitemName)
        Me.ctrlTransaction.Controls.Add(Me.lstReceipt)
        Me.ctrlTransaction.Controls.Add(Me.Label7)
        Me.ctrlTransaction.Controls.Add(Me.Label6)
        Me.ctrlTransaction.Controls.Add(Me.Label5)
        Me.ctrlTransaction.Location = New System.Drawing.Point(43, 282)
        Me.ctrlTransaction.Name = "ctrlTransaction"
        Me.ctrlTransaction.Size = New System.Drawing.Size(721, 253)
        Me.ctrlTransaction.TabIndex = 2
        Me.ctrlTransaction.TabStop = False
        Me.ctrlTransaction.Text = "Transaction"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(564, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Membership Status"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(542, 179)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 33)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(542, 145)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(105, 33)
        Me.btnRemove.TabIndex = 11
        Me.btnRemove.Text = "Remove Item"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(542, 213)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 33)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnRadio2
        '
        Me.btnRadio2.AutoSize = True
        Me.btnRadio2.Checked = True
        Me.btnRadio2.Location = New System.Drawing.Point(567, 74)
        Me.btnRadio2.Name = "btnRadio2"
        Me.btnRadio2.Size = New System.Drawing.Size(111, 21)
        Me.btnRadio2.TabIndex = 9
        Me.btnRadio2.TabStop = True
        Me.btnRadio2.Text = "Non-Member"
        Me.btnRadio2.UseVisualStyleBackColor = True
        '
        'btnRadio1
        '
        Me.btnRadio1.AutoSize = True
        Me.btnRadio1.Location = New System.Drawing.Point(567, 47)
        Me.btnRadio1.Name = "btnRadio1"
        Me.btnRadio1.Size = New System.Drawing.Size(80, 21)
        Me.btnRadio1.TabIndex = 8
        Me.btnRadio1.Text = "Member"
        Me.btnRadio1.UseVisualStyleBackColor = True
        '
        'btnAdItem
        '
        Me.btnAdItem.Location = New System.Drawing.Point(308, 71)
        Me.btnAdItem.Name = "btnAdItem"
        Me.btnAdItem.Size = New System.Drawing.Size(105, 33)
        Me.btnAdItem.TabIndex = 7
        Me.btnAdItem.Text = "Add Item"
        Me.btnAdItem.UseVisualStyleBackColor = True
        '
        'nduNumOfDays
        '
        Me.nduNumOfDays.Location = New System.Drawing.Point(141, 109)
        Me.nduNumOfDays.Name = "nduNumOfDays"
        Me.nduNumOfDays.Size = New System.Drawing.Size(151, 22)
        Me.nduNumOfDays.TabIndex = 6
        Me.nduNumOfDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nduQuantity
        '
        Me.nduQuantity.Location = New System.Drawing.Point(141, 71)
        Me.nduQuantity.Name = "nduQuantity"
        Me.nduQuantity.Size = New System.Drawing.Size(151, 22)
        Me.nduQuantity.TabIndex = 5
        Me.nduQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbitemName
        '
        Me.cmbitemName.FormattingEnabled = True
        Me.cmbitemName.Items.AddRange(New Object() {"Bicycle", "Football", "Volley Ball", "Inflatable Boat"})
        Me.cmbitemName.Location = New System.Drawing.Point(141, 31)
        Me.cmbitemName.Name = "cmbitemName"
        Me.cmbitemName.Size = New System.Drawing.Size(152, 24)
        Me.cmbitemName.TabIndex = 4
        Me.cmbitemName.Text = "Bicycle"
        '
        'lstReceipt
        '
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.ItemHeight = 16
        Me.lstReceipt.Location = New System.Drawing.Point(54, 144)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(480, 100)
        Me.lstReceipt.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Num of Days"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Select Item"
        '
        'resortTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 550)
        Me.Controls.Add(Me.ctrlTransaction)
        Me.Controls.Add(Me.ctrlResults)
        Me.Controls.Add(Me.ctrlConfig)
        Me.Name = "resortTicket"
        Me.Text = "resortTicket"
        Me.ctrlConfig.ResumeLayout(False)
        Me.ctrlConfig.PerformLayout()
        Me.ctrlResults.ResumeLayout(False)
        Me.ctrlResults.PerformLayout()
        Me.ctrlTransaction.ResumeLayout(False)
        Me.ctrlTransaction.PerformLayout()
        CType(Me.nduNumOfDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nduQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ctrlConfig As GroupBox
    Friend WithEvents ctrlResults As GroupBox
    Friend WithEvents ctrlTransaction As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIBoat As TextBox
    Friend WithEvents txtVball As TextBox
    Friend WithEvents txtFBall As TextBox
    Friend WithEvents txtBicycle As TextBox
    Friend WithEvents txtAmountPayable As TextBox
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents txtTaxAmount As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnRadio2 As RadioButton
    Friend WithEvents btnRadio1 As RadioButton
    Friend WithEvents btnAdItem As Button
    Friend WithEvents nduNumOfDays As NumericUpDown
    Friend WithEvents nduQuantity As NumericUpDown
    Friend WithEvents cmbitemName As ComboBox
    Friend WithEvents lstReceipt As ListBox
    Friend WithEvents Label14 As Label
End Class
