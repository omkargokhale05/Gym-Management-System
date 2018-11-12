<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembershipDetails
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotalFee = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMembershipID = New System.Windows.Forms.TextBox()
        Me.txtBalanceAmount = New System.Windows.Forms.TextBox()
        Me.cmbPackageID = New System.Windows.Forms.ComboBox()
        Me.DTPMembershipDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbPaymentMode = New System.Windows.Forms.ComboBox()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.txtCheqckNo = New System.Windows.Forms.TextBox()
        Me.dgMembershipDetails = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNoOfInstallments = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtActiveStatus = New System.Windows.Forms.TextBox()
        Me.rtbPackageTerms = New System.Windows.Forms.RichTextBox()
        Me.txtPackageAmount = New System.Windows.Forms.TextBox()
        Me.txtPackageName = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPaidFee = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DTPDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.rtbMemberAddress = New System.Windows.Forms.RichTextBox()
        Me.txtResidentNo = New System.Windows.Forms.TextBox()
        Me.txtMemberName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbMemberID = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.DTPValidOut = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgMembershipDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.GroupBox1.BackgroundImage = Global.Gym_Management_System.My.Resources.Resources.Blue_Gold_Wallpapers__Blue_Gold_Backgrounds1
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txtTotalFee)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtMembershipID)
        Me.GroupBox1.Controls.Add(Me.txtBalanceAmount)
        Me.GroupBox1.Controls.Add(Me.cmbPackageID)
        Me.GroupBox1.Controls.Add(Me.DTPMembershipDate)
        Me.GroupBox1.Controls.Add(Me.cmbPaymentMode)
        Me.GroupBox1.Controls.Add(Me.txtBankName)
        Me.GroupBox1.Controls.Add(Me.txtCheqckNo)
        Me.GroupBox1.Controls.Add(Me.dgMembershipDetails)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtPaidFee)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPurpose)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cmbMemberID)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.DTPValidOut)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(15, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1276, 778)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Membership Profile"
        '
        'txtTotalFee
        '
        Me.txtTotalFee.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTotalFee.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFee.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTotalFee.Location = New System.Drawing.Point(191, 277)
        Me.txtTotalFee.Name = "txtTotalFee"
        Me.txtTotalFee.Size = New System.Drawing.Size(229, 25)
        Me.txtTotalFee.TabIndex = 213
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(102, 279)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 17)
        Me.Label12.TabIndex = 214
        Me.Label12.Text = "Total  Fee :-"
        '
        'txtMembershipID
        '
        Me.txtMembershipID.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtMembershipID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMembershipID.ForeColor = System.Drawing.SystemColors.Window
        Me.txtMembershipID.Location = New System.Drawing.Point(192, 25)
        Me.txtMembershipID.Name = "txtMembershipID"
        Me.txtMembershipID.Size = New System.Drawing.Size(227, 25)
        Me.txtMembershipID.TabIndex = 212
        '
        'txtBalanceAmount
        '
        Me.txtBalanceAmount.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtBalanceAmount.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalanceAmount.ForeColor = System.Drawing.SystemColors.Window
        Me.txtBalanceAmount.Location = New System.Drawing.Point(193, 361)
        Me.txtBalanceAmount.Name = "txtBalanceAmount"
        Me.txtBalanceAmount.Size = New System.Drawing.Size(227, 25)
        Me.txtBalanceAmount.TabIndex = 211
        '
        'cmbPackageID
        '
        Me.cmbPackageID.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cmbPackageID.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.cmbPackageID.ForeColor = System.Drawing.SystemColors.Window
        Me.cmbPackageID.FormattingEnabled = True
        Me.cmbPackageID.Location = New System.Drawing.Point(193, 193)
        Me.cmbPackageID.Name = "cmbPackageID"
        Me.cmbPackageID.Size = New System.Drawing.Size(227, 25)
        Me.cmbPackageID.TabIndex = 210
        '
        'DTPMembershipDate
        '
        Me.DTPMembershipDate.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.DTPMembershipDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPMembershipDate.Location = New System.Drawing.Point(192, 109)
        Me.DTPMembershipDate.Name = "DTPMembershipDate"
        Me.DTPMembershipDate.Size = New System.Drawing.Size(227, 25)
        Me.DTPMembershipDate.TabIndex = 209
        '
        'cmbPaymentMode
        '
        Me.cmbPaymentMode.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cmbPaymentMode.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.cmbPaymentMode.ForeColor = System.Drawing.SystemColors.Window
        Me.cmbPaymentMode.FormattingEnabled = True
        Me.cmbPaymentMode.Items.AddRange(New Object() {"Cash", "Cheqec"})
        Me.cmbPaymentMode.Location = New System.Drawing.Point(191, 403)
        Me.cmbPaymentMode.Name = "cmbPaymentMode"
        Me.cmbPaymentMode.Size = New System.Drawing.Size(227, 25)
        Me.cmbPaymentMode.TabIndex = 208
        '
        'txtBankName
        '
        Me.txtBankName.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtBankName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.ForeColor = System.Drawing.SystemColors.Window
        Me.txtBankName.Location = New System.Drawing.Point(191, 445)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(227, 25)
        Me.txtBankName.TabIndex = 207
        '
        'txtCheqckNo
        '
        Me.txtCheqckNo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtCheqckNo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheqckNo.ForeColor = System.Drawing.SystemColors.Window
        Me.txtCheqckNo.Location = New System.Drawing.Point(191, 487)
        Me.txtCheqckNo.Name = "txtCheqckNo"
        Me.txtCheqckNo.Size = New System.Drawing.Size(227, 25)
        Me.txtCheqckNo.TabIndex = 206
        '
        'dgMembershipDetails
        '
        Me.dgMembershipDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMembershipDetails.Location = New System.Drawing.Point(466, 455)
        Me.dgMembershipDetails.Name = "dgMembershipDetails"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMembershipDetails.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMembershipDetails.Size = New System.Drawing.Size(804, 245)
        Me.dgMembershipDetails.TabIndex = 205
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.txtNoOfInstallments)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtActiveStatus)
        Me.GroupBox2.Controls.Add(Me.rtbPackageTerms)
        Me.GroupBox2.Controls.Add(Me.txtPackageAmount)
        Me.GroupBox2.Controls.Add(Me.txtPackageName)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox2.Location = New System.Drawing.Point(861, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 370)
        Me.GroupBox2.TabIndex = 190
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Package Details "
        '
        'txtNoOfInstallments
        '
        Me.txtNoOfInstallments.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNoOfInstallments.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfInstallments.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNoOfInstallments.Location = New System.Drawing.Point(161, 323)
        Me.txtNoOfInstallments.Name = "txtNoOfInstallments"
        Me.txtNoOfInstallments.Size = New System.Drawing.Size(201, 25)
        Me.txtNoOfInstallments.TabIndex = 114
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Black
        Me.Label19.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(9, 328)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(146, 17)
        Me.Label19.TabIndex = 113
        Me.Label19.Text = "No Of Installments :-"
        '
        'txtActiveStatus
        '
        Me.txtActiveStatus.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtActiveStatus.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActiveStatus.ForeColor = System.Drawing.SystemColors.Window
        Me.txtActiveStatus.Location = New System.Drawing.Point(161, 278)
        Me.txtActiveStatus.Name = "txtActiveStatus"
        Me.txtActiveStatus.Size = New System.Drawing.Size(201, 25)
        Me.txtActiveStatus.TabIndex = 112
        '
        'rtbPackageTerms
        '
        Me.rtbPackageTerms.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rtbPackageTerms.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.rtbPackageTerms.ForeColor = System.Drawing.SystemColors.Window
        Me.rtbPackageTerms.Location = New System.Drawing.Point(161, 129)
        Me.rtbPackageTerms.Name = "rtbPackageTerms"
        Me.rtbPackageTerms.Size = New System.Drawing.Size(201, 112)
        Me.rtbPackageTerms.TabIndex = 111
        Me.rtbPackageTerms.Text = ""
        '
        'txtPackageAmount
        '
        Me.txtPackageAmount.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPackageAmount.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackageAmount.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPackageAmount.Location = New System.Drawing.Point(161, 84)
        Me.txtPackageAmount.Name = "txtPackageAmount"
        Me.txtPackageAmount.Size = New System.Drawing.Size(201, 25)
        Me.txtPackageAmount.TabIndex = 110
        '
        'txtPackageName
        '
        Me.txtPackageName.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPackageName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackageName.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPackageName.Location = New System.Drawing.Point(161, 39)
        Me.txtPackageName.Name = "txtPackageName"
        Me.txtPackageName.Size = New System.Drawing.Size(201, 25)
        Me.txtPackageName.TabIndex = 109
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Black
        Me.Label20.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(47, 287)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 17)
        Me.Label20.TabIndex = 108
        Me.Label20.Text = "Active Status :-"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Black
        Me.Label21.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(31, 132)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 17)
        Me.Label21.TabIndex = 107
        Me.Label21.Text = "Package Terms :-"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Black
        Me.Label22.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(20, 90)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(135, 17)
        Me.Label22.TabIndex = 106
        Me.Label22.Text = "Package Amount :-"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Black
        Me.Label23.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(36, 44)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(119, 17)
        Me.Label23.TabIndex = 105
        Me.Label23.Text = "Package Name :-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(95, 489)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 17)
        Me.Label11.TabIndex = 203
        Me.Label11.Text = "Cheqec No :-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(89, 447)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 17)
        Me.Label10.TabIndex = 201
        Me.Label10.Text = "Bank Name :-"
        '
        'txtPaidFee
        '
        Me.txtPaidFee.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPaidFee.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidFee.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPaidFee.Location = New System.Drawing.Point(193, 319)
        Me.txtPaidFee.Name = "txtPaidFee"
        Me.txtPaidFee.Size = New System.Drawing.Size(227, 25)
        Me.txtPaidFee.TabIndex = 195
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(116, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 199
        Me.Label6.Text = "Pay Fee :-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(65, 405)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 17)
        Me.Label8.TabIndex = 197
        Me.Label8.Text = "Payment Mode :-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(54, 363)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 17)
        Me.Label9.TabIndex = 196
        Me.Label9.Text = "Balance Amount :-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(57, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 17)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = "Membership  ID :-"
        '
        'txtPurpose
        '
        Me.txtPurpose.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPurpose.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPurpose.Location = New System.Drawing.Point(193, 151)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(227, 25)
        Me.txtPurpose.TabIndex = 180
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(109, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "Purpose :-"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.GroupBox3.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox3.Location = New System.Drawing.Point(466, 47)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(377, 370)
        Me.GroupBox3.TabIndex = 189
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
        Me.cmbGender.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cmbGender.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.cmbGender.ForeColor = System.Drawing.SystemColors.Window
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
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(58, 326)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "Gender :-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(21, 280)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 17)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "Date of Birth :-"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtMobileNo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.ForeColor = System.Drawing.SystemColors.Window
        Me.txtMobileNo.Location = New System.Drawing.Point(135, 231)
        Me.txtMobileNo.MaxLength = 10
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(201, 25)
        Me.txtMobileNo.TabIndex = 112
        '
        'rtbMemberAddress
        '
        Me.rtbMemberAddress.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rtbMemberAddress.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.rtbMemberAddress.ForeColor = System.Drawing.SystemColors.Window
        Me.rtbMemberAddress.Location = New System.Drawing.Point(135, 86)
        Me.rtbMemberAddress.Name = "rtbMemberAddress"
        Me.rtbMemberAddress.Size = New System.Drawing.Size(201, 78)
        Me.rtbMemberAddress.TabIndex = 111
        Me.rtbMemberAddress.Text = ""
        '
        'txtResidentNo
        '
        Me.txtResidentNo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtResidentNo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResidentNo.ForeColor = System.Drawing.SystemColors.Window
        Me.txtResidentNo.Location = New System.Drawing.Point(135, 188)
        Me.txtResidentNo.Name = "txtResidentNo"
        Me.txtResidentNo.Size = New System.Drawing.Size(201, 25)
        Me.txtResidentNo.TabIndex = 110
        '
        'txtMemberName
        '
        Me.txtMemberName.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtMemberName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberName.ForeColor = System.Drawing.SystemColors.Window
        Me.txtMemberName.Location = New System.Drawing.Point(135, 42)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(201, 25)
        Me.txtMemberName.TabIndex = 109
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Black
        Me.Label15.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(38, 239)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 17)
        Me.Label15.TabIndex = 108
        Me.Label15.Text = "Mobile No :-"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Black
        Me.Label16.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(26, 193)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 17)
        Me.Label16.TabIndex = 107
        Me.Label16.Text = "Resident No :-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Black
        Me.Label17.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(46, 93)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 34)
        Me.Label17.TabIndex = 106
        Me.Label17.Text = "Member " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Address   :-"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Black
        Me.Label18.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(9, 47)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 17)
        Me.Label18.TabIndex = 105
        Me.Label18.Text = "Member Name :-"
        '
        'cmbMemberID
        '
        Me.cmbMemberID.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cmbMemberID.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.cmbMemberID.ForeColor = System.Drawing.SystemColors.Window
        Me.cmbMemberID.FormattingEnabled = True
        Me.cmbMemberID.Location = New System.Drawing.Point(193, 67)
        Me.cmbMemberID.Name = "cmbMemberID"
        Me.cmbMemberID.Size = New System.Drawing.Size(227, 25)
        Me.cmbMemberID.TabIndex = 188
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btn_cancel)
        Me.GroupBox4.Controls.Add(Me.btn_close)
        Me.GroupBox4.Controls.Add(Me.btn_update)
        Me.GroupBox4.Controls.Add(Me.btn_save)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox4.Location = New System.Drawing.Point(17, 535)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(428, 70)
        Me.GroupBox4.TabIndex = 186
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Action"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Black
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Red
        Me.btn_cancel.Location = New System.Drawing.Point(225, 24)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(90, 31)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Black
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Red
        Me.btn_close.Location = New System.Drawing.Point(330, 23)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(90, 31)
        Me.btn_close.TabIndex = 4
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Black
        Me.btn_update.Enabled = False
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_update.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Red
        Me.btn_update.Location = New System.Drawing.Point(120, 24)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(90, 31)
        Me.btn_update.TabIndex = 1
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Black
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Red
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
        Me.GroupBox5.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox5.Location = New System.Drawing.Point(17, 632)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(428, 67)
        Me.GroupBox5.TabIndex = 187
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Navigation"
        '
        'btnfirst
        '
        Me.btnfirst.BackColor = System.Drawing.Color.Black
        Me.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfirst.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.ForeColor = System.Drawing.Color.Red
        Me.btnfirst.Location = New System.Drawing.Point(15, 24)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(90, 31)
        Me.btnfirst.TabIndex = 95
        Me.btnfirst.Text = "First"
        Me.btnfirst.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.Black
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLast.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.Red
        Me.btnLast.Location = New System.Drawing.Point(321, 24)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(90, 31)
        Me.btnLast.TabIndex = 97
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Black
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.Red
        Me.btnPrevious.Location = New System.Drawing.Point(225, 24)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(90, 31)
        Me.btnPrevious.TabIndex = 98
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Black
        Me.btnNext.Enabled = False
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Red
        Me.btnNext.Location = New System.Drawing.Point(115, 24)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 31)
        Me.btnNext.TabIndex = 96
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'DTPValidOut
        '
        Me.DTPValidOut.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.DTPValidOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPValidOut.Location = New System.Drawing.Point(193, 235)
        Me.DTPValidOut.Name = "DTPValidOut"
        Me.DTPValidOut.Size = New System.Drawing.Size(227, 25)
        Me.DTPValidOut.TabIndex = 185
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(95, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Valid Upto :-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(91, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Package ID :-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(44, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 17)
        Me.Label5.TabIndex = 182
        Me.Label5.Text = "Membership Date :-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(90, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Member ID :-"
        '
        'frmMembershipDetails
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.Gym_Management_System.My.Resources.Resources.Blue_Gold_Wallpapers__Blue_Gold_Backgrounds1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1297, 741)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMembershipDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMembershipDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgMembershipDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents cmbMemberID As System.Windows.Forms.ComboBox
    Friend WithEvents DTPValidOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPaidFee As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgMembershipDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtActiveStatus As System.Windows.Forms.TextBox
    Friend WithEvents rtbPackageTerms As System.Windows.Forms.RichTextBox
    Friend WithEvents txtPackageAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtPackageName As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBankName As System.Windows.Forms.TextBox
    Friend WithEvents txtCheqckNo As System.Windows.Forms.TextBox
    Friend WithEvents txtBalanceAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmbPackageID As System.Windows.Forms.ComboBox
    Friend WithEvents DTPMembershipDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbPaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents txtNoOfInstallments As System.Windows.Forms.TextBox
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
    Friend WithEvents txtMembershipID As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalFee As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
