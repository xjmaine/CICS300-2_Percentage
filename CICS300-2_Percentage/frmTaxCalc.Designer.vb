<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaxCalc
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbHighestSale = New System.Windows.Forms.TextBox()
        Me.txbLowestSale = New System.Windows.Forms.TextBox()
        Me.txbTaxDisplay = New System.Windows.Forms.TextBox()
        Me.txbTotalSale = New System.Windows.Forms.TextBox()
        Me.txbSale = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnTax5 = New System.Windows.Forms.Button()
        Me.btnTax2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sale:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Sale:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tax:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lowest Sale:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Highest Sale:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txbHighestSale)
        Me.GroupBox1.Controls.Add(Me.txbLowestSale)
        Me.GroupBox1.Controls.Add(Me.txbTaxDisplay)
        Me.GroupBox1.Controls.Add(Me.txbTotalSale)
        Me.GroupBox1.Controls.Add(Me.txbSale)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnTax5)
        Me.GroupBox1.Controls.Add(Me.btnTax2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(669, 362)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txbHighestSale
        '
        Me.txbHighestSale.Location = New System.Drawing.Point(149, 317)
        Me.txbHighestSale.Name = "txbHighestSale"
        Me.txbHighestSale.Size = New System.Drawing.Size(189, 22)
        Me.txbHighestSale.TabIndex = 6
        '
        'txbLowestSale
        '
        Me.txbLowestSale.Location = New System.Drawing.Point(149, 267)
        Me.txbLowestSale.Name = "txbLowestSale"
        Me.txbLowestSale.Size = New System.Drawing.Size(189, 22)
        Me.txbLowestSale.TabIndex = 6
        '
        'txbTaxDisplay
        '
        Me.txbTaxDisplay.Location = New System.Drawing.Point(149, 159)
        Me.txbTaxDisplay.Name = "txbTaxDisplay"
        Me.txbTaxDisplay.Size = New System.Drawing.Size(189, 22)
        Me.txbTaxDisplay.TabIndex = 6
        '
        'txbTotalSale
        '
        Me.txbTotalSale.Location = New System.Drawing.Point(149, 109)
        Me.txbTotalSale.Name = "txbTotalSale"
        Me.txbTotalSale.Size = New System.Drawing.Size(189, 22)
        Me.txbTotalSale.TabIndex = 6
        '
        'txbSale
        '
        Me.txbSale.Location = New System.Drawing.Point(149, 72)
        Me.txbSale.Name = "txbSale"
        Me.txbSale.Size = New System.Drawing.Size(189, 22)
        Me.txbSale.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(462, 296)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(157, 46)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTax5
        '
        Me.btnTax5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTax5.Location = New System.Drawing.Point(462, 135)
        Me.btnTax5.Name = "btnTax5"
        Me.btnTax5.Size = New System.Drawing.Size(157, 46)
        Me.btnTax5.TabIndex = 5
        Me.btnTax5.Text = "5% Tax"
        Me.btnTax5.UseVisualStyleBackColor = True
        '
        'btnTax2
        '
        Me.btnTax2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTax2.Location = New System.Drawing.Point(462, 89)
        Me.btnTax2.Name = "btnTax2"
        Me.btnTax2.Size = New System.Drawing.Size(157, 46)
        Me.btnTax2.TabIndex = 5
        Me.btnTax2.Text = "2% Tax"
        Me.btnTax2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aqua
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(462, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 46)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmTaxCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 596)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTaxCalc"
        Me.Text = "frmTaxCalc"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txbHighestSale As TextBox
    Friend WithEvents txbLowestSale As TextBox
    Friend WithEvents txbTaxDisplay As TextBox
    Friend WithEvents txbTotalSale As TextBox
    Friend WithEvents txbSale As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnTax5 As Button
    Friend WithEvents btnTax2 As Button
    Friend WithEvents Button1 As Button
End Class
