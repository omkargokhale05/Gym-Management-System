<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembershipRenewal
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTotalFee = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtBalanceAmount = New System.Windows.Forms.TextBox
        Me.cmbPaymentMode = New System.Windows.Forms.ComboBox
        Me.txtBankName = New System.Windows.Forms.TextBox
        Me.txtCheqckNo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPaidFee = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
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
        Me.cmbPackageID = New System.Windows.Forms.ComboBox
        Me.DTPRenewalDate = New System.Windows.Forms.DateTimePicker
        Me.dgMembershipRenewalDetails = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtNoOfInstallments = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtActiveStatus = New System.Windows.Forms.TextBox
        Me.rtbTerms = New System.Windows.Forms.RichTextBox
        Me.txtPackageAmount = New System.Windows.Forms.TextBox
        Me.txtPackageName = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbMembershipID = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DTPValidUpto = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgMembershipRenewalDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotalFee)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtBalanceAmount)
        Me.GroupBox1.Controls.Add(Me.cmbPaymentMode)
        Me.GroupBox1.Controls.Add(Me.txtBankName)
        Me.GroupBox1.Controls.Add(Me.txtCheqckNo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtPaidFee)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.cmbPackageID)
        Me.GroupBox1.Controls.Add(Me.DTPRenewalDate)
        Me.GroupBox1.Controls.Add(Me.dgMembershipRenewalDetails)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmbMembershipID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DTPValidUpto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1052, 778)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Membership Renewal Profile"
        '
        'txtTotalFee
        '
        Me.txtTotalFee.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFee.Location = New System.Drawing.Point(181, 213)
        Me.txtTotalFee.Name = "txtTotalFee"
        Me.txtTotalFee.Size = New System.Drawing.Size(229, 25)
        Me.txtTotalFee.TabIndex = 225
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(77, 212)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 17)
        Me.Label12.TabIndex = 226
        Me.Label12.Text = "Total  Fee :-"
        '
        'txtBalanceAmount
        '
        Me.txtBalanceAmount.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalanceAmount.Location = New System.Drawing.Point(183, 297)
        Me.txtBalanceAmount.Name = "txtBalanceAmount"
        Me.txtBalanceAmount.Size = New System.Drawing.Size(227, 25)
        Me.txtBalanceAmount.TabIndex = 224
        '
        'cmbPaymentMode
        '
        Me.cmbPaymentMode.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.cmbPaymentMode.FormattingEnabled = True
        Me.cmbPaymentMode.Items.AddRange(New Object() {"CASH", "Cheqec"})
        Me.cmbPaymentMode.Location = New System.Drawing.Point(181, 339)
        Me.cmbPaymentMode.Name = "cmbPaymentMode"
        Me.cmbPaymentMode.Size = New System.Drawing.Size(227, 25)
        Me.cmbPaymentMode.TabIndex = 223
        '
        'txtBankName
        '
        Me.txtBankName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.Location = New System.Drawing.Point(181, 381)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(227, 25)
        Me.txtBankName.TabIndex = 222
        '
        'txtCheqckNo
        '
        Me.txtCheqckNo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheqckNo.Location = New System.Drawing.Point(181, 423)
        Me.txtCheqckNo.Name = "txtCheqckNo"
        Me.txtCheqckNo.Size = New System.Drawing.Size(227, 25)
        Me.txtCheqckNo.TabIndex = 221
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(70, 422)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 17)
        Me.Label11.TabIndex = 220
        Me.Label11.Text = "Cheqec No :-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(64, 380)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 17)
        Me.Label10.TabIndex = 219
        Me.Label10.Text = "Bank Name :-"
        '
        'txtPaidFee
        '
        Me.txtPaidFee.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidFee.Location = New System.Drawing.Point(183, 255)
        Me.txtPaidFee.Name = "txtPaidFee"
        Me.txtPaidFee.Size = New System.Drawing.Size(227, 25)
        Me.txtPaidFee.TabIndex = 215
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(91, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 218
        Me.Label6.Text = "Paid Fee :-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(40, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 17)
        Me.Label8.TabIndex = 217
        Me.Label8.Text = "Payment Mode :-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(29, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 17)
        Me.Label9.TabIndex = 216
        Me.Label9.Text = "Balance Amount :-"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btn_cancel)
        Me.GroupBox4.Controls.Add(Me.btn_close)
        Me.GroupBox4.Controls.Add(Me.btn_update)
        Me.GroupBox4.Controls.Add(Me.btn_save)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(903, 53)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(117, 234)
        Me.GroupBox4.TabIndex = 212
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Action"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(15, 120)
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
        Me.btn_close.Location = New System.Drawing.Point(15, 174)
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
        Me.btn_update.Location = New System.Drawing.Point(15, 72)
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
        Me.GroupBox5.Location = New System.Drawing.Point(903, 473)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(117, 245)
        Me.GroupBox5.TabIndex = 213
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Navigation"
        '
        'btnfirst
        '
        Me.btnfirst.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfirst.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.Location = New System.Drawing.Point(15, 30)
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
        Me.btnLast.Location = New System.Drawing.Point(15, 191)
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
        Me.btnPrevious.Location = New System.Drawing.Point(15, 138)
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
        Me.btnNext.Location = New System.Drawing.Point(15, 79)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 31)
        Me.btnNext.TabIndex = 96
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'cmbPackageID
        '
        Me.cmbPackageID.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.cmbPackageID.FormattingEnabled = True
        Me.cmbPackageID.Items.AddRange(New Object() {"Januaray", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbPackageID.Location = New System.Drawing.Point(185, 130)
        Me.cmbPackageID.Name = "cmbPackageID"
        Me.cmbPackageID.Size = New System.Drawing.Size(227, 25)
        Me.cmbPackageID.TabIndex = 210
        '
        'DTPRenewalDate
        '
        Me.DTPRenewalDate.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.DTPRenewalDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPRenewalDate.Location = New System.Drawing.Point(183, 88)
        Me.DTPRenewalDate.Name = "DTPRenewalDate"
        Me.DTPRenewalDate.Size = New System.Drawing.Size(227, 25)
        Me.DTPRenewalDate.TabIndex = 209
        '
        'dgMembershipRenewalDetails
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMembershipRenewalDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMembershipRenewalDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMembershipRenewalDetails.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgMembershipRenewalDetails.Location = New System.Drawing.Point(43, 473)
        Me.dgMembershipRenewalDetails.Name = "dgMembershipRenewalDetails"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMembershipRenewalDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgMembershipRenewalDetails.Size = New System.Drawing.Size(817, 245)
        Me.dgMembershipRenewalDetails.TabIndex = 205
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNoOfInstallments)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtActiveStatus)
        Me.GroupBox2.Controls.Add(Me.rtbTerms)
        Me.GroupBox2.Controls.Add(Me.txtPackageAmount)
        Me.GroupBox2.Controls.Add(Me.txtPackageName)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(473, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 402)
        Me.GroupBox2.TabIndex = 190
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Package Details "
        '
        'txtNoOfInstallments
        '
        Me.txtNoOfInstallments.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfInstallments.Location = New System.Drawing.Point(161, 346)
        Me.txtNoOfInstallments.MaxLength = 10
        Me.txtNoOfInstallments.Name = "txtNoOfInstallments"
        Me.txtNoOfInstallments.Size = New System.Drawing.Size(201, 25)
        Me.txtNoOfInstallments.TabIndex = 114
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(9, 351)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(146, 17)
        Me.Label19.TabIndex = 113
        Me.Label19.Text = "No Of Installments :-"
        '
        'txtActiveStatus
        '
        Me.txtActiveStatus.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActiveStatus.Location = New System.Drawing.Point(161, 292)
        Me.txtActiveStatus.MaxLength = 10
        Me.txtActiveStatus.Name = "txtActiveStatus"
        Me.txtActiveStatus.Size = New System.Drawing.Size(201, 25)
        Me.txtActiveStatus.TabIndex = 112
        '
        'rtbTerms
        '
        Me.rtbTerms.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.rtbTerms.Location = New System.Drawing.Point(161, 146)
        Me.rtbTerms.Name = "rtbTerms"
        Me.rtbTerms.Size = New System.Drawing.Size(201, 112)
        Me.rtbTerms.TabIndex = 111
        Me.rtbTerms.Text = ""
        '
        'txtPackageAmount
        '
        Me.txtPackageAmount.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackageAmount.Location = New System.Drawing.Point(161, 87)
        Me.txtPackageAmount.MaxLength = 10
        Me.txtPackageAmount.Name = "txtPackageAmount"
        Me.txtPackageAmount.Size = New System.Drawing.Size(201, 25)
        Me.txtPackageAmount.TabIndex = 110
        '
        'txtPackageName
        '
        Me.txtPackageName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackageName.Location = New System.Drawing.Point(161, 39)
        Me.txtPackageName.Name = "txtPackageName"
        Me.txtPackageName.Size = New System.Drawing.Size(201, 25)
        Me.txtPackageName.TabIndex = 109
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(47, 301)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 17)
        Me.Label20.TabIndex = 108
        Me.Label20.Text = "Active Status :-"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(31, 149)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 17)
        Me.Label21.TabIndex = 107
        Me.Label21.Text = "Package Terms :-"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label22.Location = New System.Drawing.Point(20, 93)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(135, 17)
        Me.Label22.TabIndex = 106
        Me.Label22.Text = "Package Amount :-"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(36, 44)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(119, 17)
        Me.Label23.TabIndex = 105
        Me.Label23.Text = "Package Name :-"
        '
        'cmbMembershipID
        '
        Me.cmbMembershipID.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.cmbMembershipID.FormattingEnabled = True
        Me.cmbMembershipID.Location = New System.Drawing.Point(182, 46)
        Me.cmbMembershipID.Name = "cmbMembershipID"
        Me.cmbMembershipID.Size = New System.Drawing.Size(227, 25)
        Me.cmbMembershipID.TabIndex = 194
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(32, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 17)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = "Membership  ID :-"
        '
        'DTPValidUpto
        '
        Me.DTPValidUpto.Font = New System.Drawing.Font("Cambria", 11.25!)
        Me.DTPValidUpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPValidUpto.Location = New System.Drawing.Point(185, 172)
        Me.DTPValidUpto.Name = "DTPValidUpto"
        Me.DTPValidUpto.Size = New System.Drawing.Size(227, 25)
        Me.DTPValidUpto.TabIndex = 185
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(70, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Valid Upto :-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(66, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Package ID :-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(47, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 17)
        Me.Label5.TabIndex = 182
        Me.Label5.Text = "Renewal Date :-"
        '
        'frmMembershipRenewal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 746)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMembershipRenewal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                            "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgMembershipRenewalDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPackageID As System.Windows.Forms.ComboBox
    Friend WithEvents DTPRenewalDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgMembershipRenewalDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoOfInstallments As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtActiveStatus As System.Windows.Forms.TextBox
    Friend WithEvents rtbTerms As System.Windows.Forms.RichTextBox
    Friend WithEvents txtPackageAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtPackageName As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbMembershipID As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTPValidUpto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    Friend WithEvents txtTotalFee As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBalanceAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmbPaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents txtBankName As System.Windows.Forms.TextBox
    Friend WithEvents txtCheqckNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPaidFee As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
