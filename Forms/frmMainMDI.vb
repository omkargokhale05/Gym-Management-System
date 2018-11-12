Imports System.Windows.Forms
Imports Gym_Management_System.frmLogin

Public Class frmMainMDI
    Private m_ChildFormNumber As Integer
    Dim o As frmLogin
    'Private Sub frmMainMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Dim a As String
    '    a = o.txtUserName.Text
    '    MsgBox("Welcome", a)
    'End Sub
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber
        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad")
    End Sub
    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Calc")
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub
    Private Sub AboutUsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem1.Click
        frmAbout.Show()
    End Sub
    Private Sub MemberDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberDetails.Click
        frmMemberMaster.MdiParent = Me
        frmMemberMaster.Show()
    End Sub

    Private Sub InstuctorDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstuctorDetails.Click
        frmInstructorMaster.MdiParent = Me
        frmInstructorMaster.Show()
    End Sub

    Private Sub HealthCheckUpDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HealthCheckUpDetails.Click
        frmHealthCheckUp.MdiParent = Me
        frmHealthCheckUp.Show()
    End Sub

    Private Sub HealthDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HealthDetails.Click
        frmHealthDetails.MdiParent = Me
        frmHealthDetails.Show()
    End Sub

    Private Sub PackageDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PackageDetails.Click
        frmPackageMaster.MdiParent = Me
        frmPackageMaster.Show()
    End Sub

    Private Sub FacilityDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacilityDetails.Click
        frmFacilityMaster.MdiParent = Me
        frmFacilityMaster.Show()
    End Sub

    Private Sub AttendenceDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendenceDetails.Click
        frmAttendence.MdiParent = Me
        frmAttendence.Show()
    End Sub
    Private Sub MembershipDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MembershipDetailsToolStripMenuItem.Click
        frmMembershipDetails.MdiParent = Me
        frmMembershipDetails.Show()
    End Sub

    Private Sub MembershipRenewalDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MembershipRenewalDetailsToolStripMenuItem.Click
        frmMembershipRenewal.MdiParent = Me
        frmMembershipRenewal.Show()
    End Sub

    Private Sub RequestRenewalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequestRenewalToolStripMenuItem.Click
        frmReservationRequest.MdiParent = Me
        frmReservationRequest.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frmCheckupRepot.MdiParent = Me
        frmCheckupRepot.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmDailyAttendance.MdiParent = Me
        frmDailyAttendance.Show()
    End Sub

    Private Sub TransactionsReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionsReportToolStripMenuItem.Click
        'TransactionsReport.Show()
    End Sub
End Class
