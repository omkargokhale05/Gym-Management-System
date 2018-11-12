<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GymManagementSplashForm
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
        Me.components = New System.ComponentModel.Container
        Me.prglbl = New System.Windows.Forms.Label
        Me.timer_splash = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Splash_prog = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'prglbl
        '
        Me.prglbl.AutoSize = True
        Me.prglbl.BackColor = System.Drawing.Color.Transparent
        Me.prglbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prglbl.Location = New System.Drawing.Point(674, 384)
        Me.prglbl.Name = "prglbl"
        Me.prglbl.Size = New System.Drawing.Size(30, 24)
        Me.prglbl.TabIndex = 30
        Me.prglbl.Text = "00"
        '
        'timer_splash
        '
        Me.timer_splash.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(707, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 24)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "%"
        '
        'Splash_prog
        '
        Me.Splash_prog.Location = New System.Drawing.Point(427, 427)
        Me.Splash_prog.Name = "Splash_prog"
        Me.Splash_prog.Size = New System.Drawing.Size(185, 24)
        Me.Splash_prog.TabIndex = 29
        '
        'GymManagementSplashForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.BackgroundImage = Global.Gym_Management_System.My.Resources.Resources.gym_management_software1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(624, 491)
        Me.Controls.Add(Me.Splash_prog)
        Me.Controls.Add(Me.prglbl)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GymManagementSplashForm"
        Me.Opacity = 0.8
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gym Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents prglbl As System.Windows.Forms.Label
    Friend WithEvents timer_splash As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Splash_prog As System.Windows.Forms.ProgressBar
End Class
