<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAccount
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtLoginID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(540, 447)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 30)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(324, 448)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 30)
        Me.btnClear.TabIndex = 28
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtLoginID
        '
        Me.txtLoginID.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtLoginID.ForeColor = System.Drawing.SystemColors.Window
        Me.txtLoginID.Location = New System.Drawing.Point(365, 44)
        Me.txtLoginID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLoginID.Name = "txtLoginID"
        Me.txtLoginID.ReadOnly = True
        Me.txtLoginID.Size = New System.Drawing.Size(217, 25)
        Me.txtLoginID.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(49, 52)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "User ID:"
        '
        'btnSubmit
        '
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.Location = New System.Drawing.Point(108, 448)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(112, 30)
        Me.btnSubmit.TabIndex = 25
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtAnswer.ForeColor = System.Drawing.SystemColors.Window
        Me.txtAnswer.Location = New System.Drawing.Point(365, 345)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(217, 25)
        Me.txtAnswer.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(45, 353)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Answer:"
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtQuestion.ForeColor = System.Drawing.SystemColors.Window
        Me.txtQuestion.Location = New System.Drawing.Point(365, 285)
        Me.txtQuestion.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(217, 25)
        Me.txtQuestion.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(45, 293)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Enter Security Question:"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtConfirmPassword.ForeColor = System.Drawing.SystemColors.Window
        Me.txtConfirmPassword.Location = New System.Drawing.Point(365, 225)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(217, 25)
        Me.txtConfirmPassword.TabIndex = 20
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Location = New System.Drawing.Point(365, 165)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(217, 25)
        Me.txtPassword.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(45, 232)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Confirm Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 172)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Enter Password:"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtUserName.ForeColor = System.Drawing.SystemColors.Window
        Me.txtUserName.Location = New System.Drawing.Point(365, 105)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(217, 25)
        Me.txtUserName.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(45, 112)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Enter User Name:"
        '
        'frmCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gym_Management_System.My.Resources.Resources.gym2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(706, 523)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtLoginID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCreateAccount"
        Me.Text = "frmCreateAccount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtLoginID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label1 As Label
End Class
