﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservationRequest
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DTPUtilisationDate = New System.Windows.Forms.DateTimePicker
        Me.txtRequestID = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnfirst = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtFrequency = New System.Windows.Forms.TextBox
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.txtCharges = New System.Windows.Forms.TextBox
        Me.txtFacilityName = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DTPDateOfBirth = New System.Windows.Forms.DateTimePicker
        Me.cmbGender = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtMobileNo = New System.Windows.Forms.TextBox
        Me.rtbMemberAddress = New System.Windows.Forms.RichTextBox
        Me.txtResidentNo = New System.Windows.Forms.TextBox
        Me.txtMemberName = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmbMemberID = New System.Windows.Forms.ComboBox
        Me.cmbFacilityID = New System.Windows.Forms.ComboBox
        Me.dgReservationRequest = New System.Windows.Forms.DataGridView
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DTPRequestDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgReservationRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Gym_Management_System.My.Resources.Resources.simple1
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.DTPUtilisationDate)
        Me.GroupBox1.Controls.Add(Me.txtRequestID)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cmbMemberID)
        Me.GroupBox1.Controls.Add(Me.cmbFacilityID)
        Me.GroupBox1.Controls.Add(Me.dgReservationRequest)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DTPRequestDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1254, 708)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reservation Request Profile"
        '
        'DTPUtilisationDate
        '
        Me.DTPUtilisationDate.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.DTPUtilisationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPUtilisationDate.Location = New System.Drawing.Point(170, 187)
        Me.DTPUtilisationDate.Name = "DTPUtilisationDate"
        Me.DTPUtilisationDate.Size = New System.Drawing.Size(227, 25)
        Me.DTPUtilisationDate.TabIndex = 219
        '
        'txtRequestID
        '
        Me.txtRequestID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestID.Location = New System.Drawing.Point(170, 55)
        Me.txtRequestID.MaxLength = 10
        Me.txtRequestID.Name = "txtRequestID"
        Me.txtRequestID.Size = New System.Drawing.Size(227, 25)
        Me.txtRequestID.TabIndex = 218
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btn_cancel)
        Me.GroupBox4.Controls.Add(Me.btn_close)
        Me.GroupBox4.Controls.Add(Me.btn_update)
        Me.GroupBox4.Controls.Add(Me.btn_save)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(26, 276)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(428, 70)
        Me.GroupBox4.TabIndex = 216
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Action"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(225, 24)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(90, 31)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(330, 23)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(90, 31)
        Me.btn_close.TabIndex = 4
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btn_update.Enabled = False
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_update.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(120, 24)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(90, 31)
        Me.btn_update.TabIndex = 1
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
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
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.btnfirst)
        Me.GroupBox5.Controls.Add(Me.btnLast)
        Me.GroupBox5.Controls.Add(Me.btnPrevious)
        Me.GroupBox5.Controls.Add(Me.btnNext)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(26, 369)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(428, 67)
        Me.GroupBox5.TabIndex = 217
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Navigation"
        '
        'btnfirst
        '
        Me.btnfirst.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfirst.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.Location = New System.Drawing.Point(15, 24)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(90, 31)
        Me.btnfirst.TabIndex = 95
        Me.btnfirst.Text = "First"
        Me.btnfirst.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLast.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(321, 24)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(90, 31)
        Me.btnLast.TabIndex = 97
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(225, 24)
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
        Me.btnNext.Location = New System.Drawing.Point(115, 24)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 31)
        Me.btnNext.TabIndex = 96
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtFrequency)
        Me.GroupBox2.Controls.Add(Me.txtStatus)
        Me.GroupBox2.Controls.Add(Me.txtCharges)
        Me.GroupBox2.Controls.Add(Me.txtFacilityName)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(864, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 240)
        Me.GroupBox2.TabIndex = 213
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facility Details "
        '
        'txtFrequency
        '
        Me.txtFrequency.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrequency.Location = New System.Drawing.Point(135, 138)
        Me.txtFrequency.MaxLength = 10
        Me.txtFrequency.Name = "txtFrequency"
        Me.txtFrequency.Size = New System.Drawing.Size(201, 25)
        Me.txtFrequency.TabIndex = 113
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(135, 187)
        Me.txtStatus.MaxLength = 10
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(201, 25)
        Me.txtStatus.TabIndex = 112
        '
        'txtCharges
        '
        Me.txtCharges.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharges.Location = New System.Drawing.Point(135, 89)
        Me.txtCharges.MaxLength = 10
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.Size = New System.Drawing.Size(201, 25)
        Me.txtCharges.TabIndex = 110
        '
        'txtFacilityName
        '
        Me.txtFacilityName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacilityName.Location = New System.Drawing.Point(135, 40)
        Me.txtFacilityName.Name = "txtFacilityName"
        Me.txtFacilityName.Size = New System.Drawing.Size(201, 25)
        Me.txtFacilityName.TabIndex = 109
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(67, 190)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 17)
        Me.Label20.TabIndex = 108
        Me.Label20.Text = "Status :-"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(36, 138)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 17)
        Me.Label21.TabIndex = 107
        Me.Label21.Text = "Frequency :-"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label22.Location = New System.Drawing.Point(53, 92)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 17)
        Me.Label22.TabIndex = 106
        Me.Label22.Text = "Charges :-"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(17, 44)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(112, 17)
        Me.Label23.TabIndex = 105
        Me.Label23.Text = "Facility Name :-"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.DTPDateOfBirth)
        Me.GroupBox3.Controls.Add(Me.cmbGender)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtMobileNo)
        Me.GroupBox3.Controls.Add(Me.rtbMemberAddress)
        Me.GroupBox3.Controls.Add(Me.txtResidentNo)
        Me.GroupBox3.Controls.Add(Me.txtMemberName)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(472, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(377, 387)
        Me.GroupBox3.TabIndex = 212
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Member Details"
        '
        'DTPDateOfBirth
        '
        Me.DTPDateOfBirth.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDateOfBirth.Location = New System.Drawing.Point(135, 274)
        Me.DTPDateOfBirth.Name = "DTPDateOfBirth"
        Me.DTPDateOfBirth.Size = New System.Drawing.Size(201, 25)
        Me.DTPDateOfBirth.TabIndex = 116
        '
        'cmbGender
        '
        Me.cmbGender.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(135, 318)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(143, 25)
        Me.cmbGender.TabIndex = 115
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(58, 326)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "Gender :-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(21, 280)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 17)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "Date of Birth :-"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.Location = New System.Drawing.Point(135, 231)
        Me.txtMobileNo.MaxLength = 10
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(201, 25)
        Me.txtMobileNo.TabIndex = 112
        '
        'rtbMemberAddress
        '
        Me.rtbMemberAddress.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.rtbMemberAddress.Location = New System.Drawing.Point(135, 86)
        Me.rtbMemberAddress.Name = "rtbMemberAddress"
        Me.rtbMemberAddress.Size = New System.Drawing.Size(201, 78)
        Me.rtbMemberAddress.TabIndex = 111
        Me.rtbMemberAddress.Text = ""
        '
        'txtResidentNo
        '
        Me.txtResidentNo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResidentNo.Location = New System.Drawing.Point(135, 188)
        Me.txtResidentNo.MaxLength = 10
        Me.txtResidentNo.Name = "txtResidentNo"
        Me.txtResidentNo.Size = New System.Drawing.Size(201, 25)
        Me.txtResidentNo.TabIndex = 110
        '
        'txtMemberName
        '
        Me.txtMemberName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberName.Location = New System.Drawing.Point(135, 42)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(201, 25)
        Me.txtMemberName.TabIndex = 109
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(38, 239)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 17)
        Me.Label15.TabIndex = 108
        Me.Label15.Text = "Mobile No :-"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(26, 193)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 17)
        Me.Label16.TabIndex = 107
        Me.Label16.Text = "Resident No :-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(46, 93)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 34)
        Me.Label17.TabIndex = 106
        Me.Label17.Text = "Member " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Address   :-"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(9, 47)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 17)
        Me.Label18.TabIndex = 105
        Me.Label18.Text = "Member Name :-"
        '
        'cmbMemberID
        '
        Me.cmbMemberID.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.cmbMemberID.FormattingEnabled = True
        Me.cmbMemberID.Items.AddRange(New Object() {"Januaray", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMemberID.Location = New System.Drawing.Point(170, 99)
        Me.cmbMemberID.Name = "cmbMemberID"
        Me.cmbMemberID.Size = New System.Drawing.Size(227, 25)
        Me.cmbMemberID.TabIndex = 210
        '
        'cmbFacilityID
        '
        Me.cmbFacilityID.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.cmbFacilityID.FormattingEnabled = True
        Me.cmbFacilityID.Location = New System.Drawing.Point(170, 231)
        Me.cmbFacilityID.Name = "cmbFacilityID"
        Me.cmbFacilityID.Size = New System.Drawing.Size(227, 25)
        Me.cmbFacilityID.TabIndex = 208
        '
        'dgReservationRequest
        '
        Me.dgReservationRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReservationRequest.Location = New System.Drawing.Point(26, 457)
        Me.dgReservationRequest.Name = "dgReservationRequest"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgReservationRequest.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgReservationRequest.Size = New System.Drawing.Size(899, 225)
        Me.dgReservationRequest.TabIndex = 205
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(36, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 17)
        Me.Label6.TabIndex = 199
        Me.Label6.Text = "Utilisation Date :-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(75, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 196
        Me.Label9.Text = "Facility ID :-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(66, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = "Request  ID :-"
        '
        'DTPRequestDate
        '
        Me.DTPRequestDate.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.DTPRequestDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPRequestDate.Location = New System.Drawing.Point(170, 143)
        Me.DTPRequestDate.Name = "DTPRequestDate"
        Me.DTPRequestDate.Size = New System.Drawing.Size(227, 25)
        Me.DTPRequestDate.TabIndex = 185
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(53, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Request Date :-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(67, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 182
        Me.Label5.Text = "Member ID :-"
        '
        'frmReservationRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gym_Management_System.My.Resources.Resources.simple1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1360, 746)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReservationRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReservationRequest"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgReservationRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMemberID As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFacilityID As System.Windows.Forms.ComboBox
    Friend WithEvents dgReservationRequest As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTPRequestDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtFacilityName As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DTPDateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents rtbMemberAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents txtResidentNo As System.Windows.Forms.TextBox
    Friend WithEvents txtMemberName As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents DTPUtilisationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRequestID As System.Windows.Forms.TextBox
    Friend WithEvents txtFrequency As System.Windows.Forms.TextBox
End Class