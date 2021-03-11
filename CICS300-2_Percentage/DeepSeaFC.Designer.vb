<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeepSeaFC
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
        Me.gbEnrollment = New System.Windows.Forms.GroupBox()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.txtWeeklyWage = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAccumulatedBonus = New System.Windows.Forms.TextBox()
        Me.txtCleanSheetBonus = New System.Windows.Forms.TextBox()
        Me.txtMatchBonus = New System.Windows.Forms.TextBox()
        Me.txtGoalBonus = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPerformanceSet = New System.Windows.Forms.Button()
        Me.NUDGoalCount = New System.Windows.Forms.NumericUpDown()
        Me.NUDMatchesPlayed = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.rdbYes = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtTotalPlayerBill = New System.Windows.Forms.TextBox()
        Me.txtAvgPlayerEarning = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtHighestEarning = New System.Windows.Forms.TextBox()
        Me.txtLowestEarning = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLowerExit = New System.Windows.Forms.Button()
        Me.btnUpperExit = New System.Windows.Forms.Button()
        Me.btnRemoveEntry = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnAddEntry = New System.Windows.Forms.Button()
        Me.gbEnrollment.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NUDGoalCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDMatchesPlayed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbEnrollment
        '
        Me.gbEnrollment.BackColor = System.Drawing.Color.Gray
        Me.gbEnrollment.Controls.Add(Me.cmbPosition)
        Me.gbEnrollment.Controls.Add(Me.txtWeeklyWage)
        Me.gbEnrollment.Controls.Add(Me.txtLastName)
        Me.gbEnrollment.Controls.Add(Me.txtFirstName)
        Me.gbEnrollment.Controls.Add(Me.Label4)
        Me.gbEnrollment.Controls.Add(Me.Label3)
        Me.gbEnrollment.Controls.Add(Me.Label2)
        Me.gbEnrollment.Controls.Add(Me.Label1)
        Me.gbEnrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbEnrollment.ForeColor = System.Drawing.Color.White
        Me.gbEnrollment.Location = New System.Drawing.Point(11, 13)
        Me.gbEnrollment.Margin = New System.Windows.Forms.Padding(4)
        Me.gbEnrollment.Name = "gbEnrollment"
        Me.gbEnrollment.Padding = New System.Windows.Forms.Padding(4)
        Me.gbEnrollment.Size = New System.Drawing.Size(339, 189)
        Me.gbEnrollment.TabIndex = 0
        Me.gbEnrollment.TabStop = False
        Me.gbEnrollment.Text = "Enrollment"
        '
        'cmbPosition
        '
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Items.AddRange(New Object() {"Goalkeeper", "Defender", "Right Fullback", "Left Fullback", "Center Back", "Midfielder", "Winger", "Central", "Striker", "Forward"})
        Me.cmbPosition.Location = New System.Drawing.Point(126, 97)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(207, 27)
        Me.cmbPosition.TabIndex = 8
        '
        'txtWeeklyWage
        '
        Me.txtWeeklyWage.Location = New System.Drawing.Point(126, 136)
        Me.txtWeeklyWage.Name = "txtWeeklyWage"
        Me.txtWeeklyWage.Size = New System.Drawing.Size(207, 27)
        Me.txtWeeklyWage.TabIndex = 7
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(125, 58)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(207, 27)
        Me.txtLastName.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(125, 19)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(207, 27)
        Me.txtFirstName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Weekly Wage:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Position:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.Controls.Add(Me.txtAccumulatedBonus)
        Me.GroupBox1.Controls.Add(Me.txtCleanSheetBonus)
        Me.GroupBox1.Controls.Add(Me.txtMatchBonus)
        Me.GroupBox1.Controls.Add(Me.txtGoalBonus)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(384, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 189)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Performance Bonuses"
        '
        'txtAccumulatedBonus
        '
        Me.txtAccumulatedBonus.Location = New System.Drawing.Point(217, 141)
        Me.txtAccumulatedBonus.Name = "txtAccumulatedBonus"
        Me.txtAccumulatedBonus.ReadOnly = True
        Me.txtAccumulatedBonus.Size = New System.Drawing.Size(100, 27)
        Me.txtAccumulatedBonus.TabIndex = 7
        '
        'txtCleanSheetBonus
        '
        Me.txtCleanSheetBonus.Location = New System.Drawing.Point(217, 102)
        Me.txtCleanSheetBonus.Name = "txtCleanSheetBonus"
        Me.txtCleanSheetBonus.ReadOnly = True
        Me.txtCleanSheetBonus.Size = New System.Drawing.Size(100, 27)
        Me.txtCleanSheetBonus.TabIndex = 6
        '
        'txtMatchBonus
        '
        Me.txtMatchBonus.Location = New System.Drawing.Point(217, 60)
        Me.txtMatchBonus.Name = "txtMatchBonus"
        Me.txtMatchBonus.ReadOnly = True
        Me.txtMatchBonus.Size = New System.Drawing.Size(100, 27)
        Me.txtMatchBonus.TabIndex = 5
        '
        'txtGoalBonus
        '
        Me.txtGoalBonus.Location = New System.Drawing.Point(217, 24)
        Me.txtGoalBonus.Name = "txtGoalBonus"
        Me.txtGoalBonus.ReadOnly = True
        Me.txtGoalBonus.Size = New System.Drawing.Size(100, 27)
        Me.txtGoalBonus.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 19)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Accumulated Bonuses/w:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 19)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Clean Sheet/w(7%):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Match Bonus (5%):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Goal Bonus/w:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 442)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(785, 235)
        Me.DataGridView1.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "FirstName"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "LastName"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Position"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Regular Wage/w"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "GoalBonus"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "MatchBonus"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "TotalPlayerEarning"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox2.Controls.Add(Me.btnPerformanceSet)
        Me.GroupBox2.Controls.Add(Me.NUDGoalCount)
        Me.GroupBox2.Controls.Add(Me.NUDMatchesPlayed)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.rdbNo)
        Me.GroupBox2.Controls.Add(Me.rdbYes)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 162)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Weekly Player Perfomance"
        '
        'btnPerformanceSet
        '
        Me.btnPerformanceSet.Location = New System.Drawing.Point(275, 79)
        Me.btnPerformanceSet.Name = "btnPerformanceSet"
        Me.btnPerformanceSet.Size = New System.Drawing.Size(58, 37)
        Me.btnPerformanceSet.TabIndex = 11
        Me.btnPerformanceSet.Text = "Set"
        Me.btnPerformanceSet.UseVisualStyleBackColor = True
        '
        'NUDGoalCount
        '
        Me.NUDGoalCount.Location = New System.Drawing.Point(162, 68)
        Me.NUDGoalCount.Name = "NUDGoalCount"
        Me.NUDGoalCount.Size = New System.Drawing.Size(111, 27)
        Me.NUDGoalCount.TabIndex = 10
        '
        'NUDMatchesPlayed
        '
        Me.NUDMatchesPlayed.Location = New System.Drawing.Point(165, 108)
        Me.NUDMatchesPlayed.Name = "NUDMatchesPlayed"
        Me.NUDMatchesPlayed.Size = New System.Drawing.Size(111, 27)
        Me.NUDMatchesPlayed.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 19)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Matches Played/w:"
        '
        'rdbNo
        '
        Me.rdbNo.AutoSize = True
        Me.rdbNo.Checked = True
        Me.rdbNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbNo.Location = New System.Drawing.Point(299, 33)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(52, 23)
        Me.rdbNo.TabIndex = 7
        Me.rdbNo.TabStop = True
        Me.rdbNo.Text = "No"
        Me.rdbNo.UseVisualStyleBackColor = True
        '
        'rdbYes
        '
        Me.rdbYes.AutoSize = True
        Me.rdbYes.Location = New System.Drawing.Point(237, 33)
        Me.rdbYes.Name = "rdbYes"
        Me.rdbYes.Size = New System.Drawing.Size(56, 23)
        Me.rdbYes.TabIndex = 6
        Me.rdbYes.Text = "Yes"
        Me.rdbYes.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Clean Sheet Achievement/w:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Goal Count/w:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gray
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.txtTotalPlayerBill)
        Me.GroupBox3.Controls.Add(Me.txtAvgPlayerEarning)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtHighestEarning)
        Me.GroupBox3.Controls.Add(Me.txtLowestEarning)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(384, 228)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(374, 208)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Weekly Stats"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(212, 169)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 27)
        Me.TextBox1.TabIndex = 5
        '
        'txtTotalPlayerBill
        '
        Me.txtTotalPlayerBill.Location = New System.Drawing.Point(212, 140)
        Me.txtTotalPlayerBill.Name = "txtTotalPlayerBill"
        Me.txtTotalPlayerBill.ReadOnly = True
        Me.txtTotalPlayerBill.Size = New System.Drawing.Size(100, 27)
        Me.txtTotalPlayerBill.TabIndex = 5
        '
        'txtAvgPlayerEarning
        '
        Me.txtAvgPlayerEarning.Location = New System.Drawing.Point(212, 111)
        Me.txtAvgPlayerEarning.Name = "txtAvgPlayerEarning"
        Me.txtAvgPlayerEarning.ReadOnly = True
        Me.txtAvgPlayerEarning.Size = New System.Drawing.Size(100, 27)
        Me.txtAvgPlayerEarning.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(180, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 19)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Player Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(2, 169)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(205, 19)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Total Team Weekly Wage:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(2, 144)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(210, 19)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Total Player Weekly Wage:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(2, 119)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 19)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Avg. Player Earning:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 19)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Player Name"
        '
        'txtHighestEarning
        '
        Me.txtHighestEarning.Location = New System.Drawing.Point(184, 43)
        Me.txtHighestEarning.Name = "txtHighestEarning"
        Me.txtHighestEarning.ReadOnly = True
        Me.txtHighestEarning.Size = New System.Drawing.Size(128, 27)
        Me.txtHighestEarning.TabIndex = 2
        '
        'txtLowestEarning
        '
        Me.txtLowestEarning.Location = New System.Drawing.Point(6, 43)
        Me.txtLowestEarning.Name = "txtLowestEarning"
        Me.txtLowestEarning.ReadOnly = True
        Me.txtLowestEarning.Size = New System.Drawing.Size(128, 27)
        Me.txtLowestEarning.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(188, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 19)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Highest Earning"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Lowest Earning"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnLowerExit)
        Me.Panel1.Controls.Add(Me.btnUpperExit)
        Me.Panel1.Controls.Add(Me.btnRemoveEntry)
        Me.Panel1.Controls.Add(Me.btnClearAll)
        Me.Panel1.Controls.Add(Me.btnAddEntry)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.gbEnrollment)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(813, 726)
        Me.Panel1.TabIndex = 0
        '
        'btnLowerExit
        '
        Me.btnLowerExit.Location = New System.Drawing.Point(673, 680)
        Me.btnLowerExit.Name = "btnLowerExit"
        Me.btnLowerExit.Size = New System.Drawing.Size(124, 35)
        Me.btnLowerExit.TabIndex = 14
        Me.btnLowerExit.Text = "&Exit Program"
        Me.btnLowerExit.UseVisualStyleBackColor = True
        '
        'btnUpperExit
        '
        Me.btnUpperExit.ForeColor = System.Drawing.Color.Red
        Me.btnUpperExit.Location = New System.Drawing.Point(766, 13)
        Me.btnUpperExit.Name = "btnUpperExit"
        Me.btnUpperExit.Size = New System.Drawing.Size(31, 23)
        Me.btnUpperExit.TabIndex = 13
        Me.btnUpperExit.Text = "&X"
        Me.btnUpperExit.UseVisualStyleBackColor = True
        '
        'btnRemoveEntry
        '
        Me.btnRemoveEntry.Location = New System.Drawing.Point(234, 398)
        Me.btnRemoveEntry.Name = "btnRemoveEntry"
        Me.btnRemoveEntry.Size = New System.Drawing.Size(127, 38)
        Me.btnRemoveEntry.TabIndex = 12
        Me.btnRemoveEntry.Text = "&Remove Entry"
        Me.btnRemoveEntry.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(118, 398)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(107, 38)
        Me.btnClearAll.TabIndex = 11
        Me.btnClearAll.Text = "&Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnAddEntry
        '
        Me.btnAddEntry.Location = New System.Drawing.Point(10, 396)
        Me.btnAddEntry.Name = "btnAddEntry"
        Me.btnAddEntry.Size = New System.Drawing.Size(102, 40)
        Me.btnAddEntry.TabIndex = 10
        Me.btnAddEntry.Text = "&Add Entry"
        Me.btnAddEntry.UseVisualStyleBackColor = True
        '
        'DeepSeaFC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 718)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DeepSeaFC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeepSeaFC"
        Me.gbEnrollment.ResumeLayout(False)
        Me.gbEnrollment.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NUDGoalCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDMatchesPlayed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbEnrollment As GroupBox
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents txtWeeklyWage As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAccumulatedBonus As TextBox
    Friend WithEvents txtCleanSheetBonus As TextBox
    Friend WithEvents txtMatchBonus As TextBox
    Friend WithEvents txtGoalBonus As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NUDGoalCount As NumericUpDown
    Friend WithEvents NUDMatchesPlayed As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents rdbNo As RadioButton
    Friend WithEvents rdbYes As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotalPlayerBill As TextBox
    Friend WithEvents txtAvgPlayerEarning As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtHighestEarning As TextBox
    Friend WithEvents txtLowestEarning As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRemoveEntry As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnAddEntry As Button
    Friend WithEvents btnUpperExit As Button
    Friend WithEvents btnLowerExit As Button
    Friend WithEvents btnPerformanceSet As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label18 As Label
End Class
