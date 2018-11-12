<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructorMaster
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnfirst = New System.Windows.Forms.Button
        Me.txtMobileNo = New System.Windows.Forms.TextBox
        Me.dgInstructorShow = New System.Windows.Forms.DataGridView
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_Delete = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnsearch = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.rtbInstructorAddress = New System.Windows.Forms.RichTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btn_save = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbExperts = New System.Windows.Forms.ComboBox
        Me.DTPDateOfJoin = New System.Windows.Forms.DateTimePicker
        Me.cmbGender = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.rbtName = New System.Windows.Forms.RadioButton
        Me.rbtID = New System.Windows.Forms.RadioButton
        Me.txtInstructorName = New System.Windows.Forms.TextBox
        Me.txtInstructorID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        CType(Me.dgInstructorShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnfirst
        '
        Me.btnfirst.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfirst.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.Location = New System.Drawing.Point(15, 32)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(90, 31)
        Me.btnfirst.TabIndex = 95
        Me.btnfirst.Text = "First"
        Me.btnfirst.UseVisualStyleBackColor = False
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.Location = New System.Drawing.Point(171, 220)
        Me.txtMobileNo.MaxLength = 10
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(244, 25)
        Me.txtMobileNo.TabIndex = 10
        '
        'dgInstructorShow
        '
        Me.dgInstructorShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInstructorShow.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgInstructorShow.Location = New System.Drawing.Point(15, 461)
        Me.dgInstructorShow.Name = "dgInstructorShow"
        Me.dgInstructorShow.Size = New System.Drawing.Size(737, 221)
        Me.dgInstructorShow.TabIndex = 108
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(81, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Expert Of :-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(15, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Instructor Address :-"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(15, 255)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(90, 31)
        Me.btn_close.TabIndex = 4
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(15, 197)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(90, 31)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(33, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Instructor Name :-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Instructor ID :-"
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Delete.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.Location = New System.Drawing.Point(15, 139)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(90, 31)
        Me.btn_Delete.TabIndex = 5
        Me.btn_Delete.Text = "Delete"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLast.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(15, 197)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(90, 31)
        Me.btnLast.TabIndex = 97
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(103, 172)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(77, 30)
        Me.btnsearch.TabIndex = 9
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btn_update.Enabled = False
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_update.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(15, 81)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(90, 31)
        Me.btn_update.TabIndex = 1
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'rtbInstructorAddress
        '
        Me.rtbInstructorAddress.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.rtbInstructorAddress.Location = New System.Drawing.Point(171, 117)
        Me.rtbInstructorAddress.Name = "rtbInstructorAddress"
        Me.rtbInstructorAddress.Size = New System.Drawing.Size(244, 85)
        Me.rtbInstructorAddress.TabIndex = 95
        Me.rtbInstructorAddress.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(69, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 17)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Enter ID or Name  :-"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(15, 23)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(90, 31)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btn_Delete)
        Me.GroupBox1.Controls.Add(Me.btn_close)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(774, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 307)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbExperts)
        Me.GroupBox2.Controls.Add(Me.DTPDateOfJoin)
        Me.GroupBox2.Controls.Add(Me.cmbGender)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.rtbInstructorAddress)
        Me.GroupBox2.Controls.Add(Me.txtMobileNo)
        Me.GroupBox2.Controls.Add(Me.txtInstructorName)
        Me.GroupBox2.Controls.Add(Me.txtInstructorID)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(737, 390)
        Me.GroupBox2.TabIndex = 106
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Instructor Details"
        '
        'cmbExperts
        '
        Me.cmbExperts.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.cmbExperts.FormattingEnabled = True
        Me.cmbExperts.Items.AddRange(New Object() {"Gym ", "Yoga ", "Cardiac", "Swimming"})
        Me.cmbExperts.Location = New System.Drawing.Point(171, 263)
        Me.cmbExperts.Name = "cmbExperts"
        Me.cmbExperts.Size = New System.Drawing.Size(143, 25)
        Me.cmbExperts.TabIndex = 105
        '
        'DTPDateOfJoin
        '
        Me.DTPDateOfJoin.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPDateOfJoin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDateOfJoin.Location = New System.Drawing.Point(171, 306)
        Me.DTPDateOfJoin.Name = "DTPDateOfJoin"
        Me.DTPDateOfJoin.Size = New System.Drawing.Size(244, 25)
        Me.DTPDateOfJoin.TabIndex = 104
        '
        'cmbGender
        '
        Me.cmbGender.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(171, 349)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(143, 25)
        Me.cmbGender.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(94, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Gender :-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(43, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 17)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Date of Joining :-"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnsearch)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtSearch)
        Me.GroupBox4.Controls.Add(Me.rbtName)
        Me.GroupBox4.Controls.Add(Me.rbtID)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(436, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(282, 250)
        Me.GroupBox4.TabIndex = 97
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Instructor Search"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.txtSearch.Location = New System.Drawing.Point(29, 123)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(234, 25)
        Me.txtSearch.TabIndex = 9
        '
        'rbtName
        '
        Me.rbtName.AutoSize = True
        Me.rbtName.BackColor = System.Drawing.Color.Transparent
        Me.rbtName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbtName.Location = New System.Drawing.Point(148, 35)
        Me.rbtName.Name = "rbtName"
        Me.rbtName.Size = New System.Drawing.Size(86, 21)
        Me.rbtName.TabIndex = 6
        Me.rbtName.TabStop = True
        Me.rbtName.Text = "By Name"
        Me.rbtName.UseVisualStyleBackColor = False
        '
        'rbtID
        '
        Me.rbtID.AutoSize = True
        Me.rbtID.BackColor = System.Drawing.Color.Transparent
        Me.rbtID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbtID.Location = New System.Drawing.Point(56, 35)
        Me.rbtID.Name = "rbtID"
        Me.rbtID.Size = New System.Drawing.Size(63, 21)
        Me.rbtID.TabIndex = 5
        Me.rbtID.TabStop = True
        Me.rbtID.Text = "By ID"
        Me.rbtID.UseVisualStyleBackColor = False
        '
        'txtInstructorName
        '
        Me.txtInstructorName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructorName.Location = New System.Drawing.Point(171, 74)
        Me.txtInstructorName.Name = "txtInstructorName"
        Me.txtInstructorName.Size = New System.Drawing.Size(244, 25)
        Me.txtInstructorName.TabIndex = 7
        '
        'txtInstructorID
        '
        Me.txtInstructorID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructorID.Location = New System.Drawing.Point(171, 31)
        Me.txtInstructorID.Name = "txtInstructorID"
        Me.txtInstructorID.ReadOnly = True
        Me.txtInstructorID.Size = New System.Drawing.Size(244, 25)
        Me.txtInstructorID.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(74, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Mobile No :-"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(15, 142)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(90, 31)
        Me.btnPrevious.TabIndex = 98
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnNext.Enabled = False
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(15, 87)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 31)
        Me.btnNext.TabIndex = 96
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(302, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 37)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "INSTRUCTOR MASTER"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnfirst)
        Me.GroupBox3.Controls.Add(Me.btnLast)
        Me.GroupBox3.Controls.Add(Me.btnPrevious)
        Me.GroupBox3.Controls.Add(Me.btnNext)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(774, 430)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(127, 252)
        Me.GroupBox3.TabIndex = 109
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Navigation"
        '
        'frmInstructorMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gym_Management_System.My.Resources.Resources.simple1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 742)
        Me.Controls.Add(Me.dgInstructorShow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmInstructorMaster"
        Me.Text = "frmInstructorMaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgInstructorShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents dgInstructorShow As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents rtbInstructorAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DTPDateOfJoin As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents rbtName As System.Windows.Forms.RadioButton
    Friend WithEvents rbtID As System.Windows.Forms.RadioButton
    Friend WithEvents txtInstructorName As System.Windows.Forms.TextBox
    Friend WithEvents txtInstructorID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbExperts As System.Windows.Forms.ComboBox
End Class
