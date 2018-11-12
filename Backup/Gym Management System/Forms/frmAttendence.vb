Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.Attendence
Public Class frmAttendence
#Region "Declaration"

    Dim clsAttendence As New Attendence
    Dim cntr As New Controller
    Dim clsDBFun As New DBFunction
    Dim clsCon As New DBConnection

#End Region

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        clsAttendence.CheckTextAttendence()
        If clsAttendence.flag = True Then
            Dim intime As String
            Dim outtime As String
            If cmbStatus.Text = "P" Then
                intime = DTPInTime.Text
                outtime = DTPOutTime.Text
                cntr.AddAttendence(cmbMemberID.SelectedValue, dtpDate.Text, cmbStatus.Text, intime, outtime)
            Else
                intime = ""
                outtime = ""
                cntr.AddAttendence(cmbMemberID.SelectedValue, dtpDate.Text, cmbStatus.Text, intime, outtime)
            End If
            '  cntr.AddAttendence(cmbMemberID.SelectedValue, dtpDate.Text, cmbStatus.Text, DTPInTime.Text, DTPOutTime.Text)
            cntr.DisplayDataAttendence()
            cntr.ClearTextAttendence()
            clsAttendence.navigationAttendence()
        Else
            clsAttendence.flag = True
        End If
    End Sub
    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        clsAttendence.CheckTextAttendence()
        If clsAttendence.flag = True Then
            cntr.UpdateAttendence(cmbMemberID.SelectedValue, dtpDate.Text, cmbStatus.Text, DTPInTime.Text, DTPOutTime.Text)
            cntr.DisplayDataAttendence()
            cntr.ClearTextAttendence()
            clsAttendence.navigationAttendence()

            btn_update.Enabled = False
        Else
            clsAttendence.flag = True
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        cntr.ClearTextAttendence()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        Try
            clsAttendence.currentRow = 0
            clsAttendence.ShowDataAttendence(clsAttendence.currentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            If clsAttendence.currentRow = clsAttendence.ds.Tables("AD").Rows.Count - 1 Then

                MsgBox("You are on the last record!!!")
            Else
                clsAttendence.currentRow += 1
                clsAttendence.ShowDataAttendence(clsAttendence.currentRow)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Try
            If clsAttendence.currentRow <> 0 Then
                clsAttendence.currentRow -= 1
                clsAttendence.ShowDataAttendence(clsAttendence.currentRow)
            Else
                MsgBox("You are on the first record!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Try
            clsAttendence.currentRow = clsAttendence.ds.Tables("AD").Rows.Count - 1
            clsAttendence.ShowDataAttendence(clsAttendence.currentRow)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmbMemberID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMemberID.SelectedIndexChanged
        Try
            clsAttendence.DisplayMemberDetails(cmbMemberID.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmAttendence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnfirst.Enabled = True
        btnNext.Enabled = True
        btnPrevious.Enabled = True
        btnLast.Enabled = True

        clsDBFun.BindCombo("exec BindMemberID", cmbMemberID)


        clsAttendence.navigationAttendence()
        cntr.ClearTextAttendence()
        cntr.DisplayDataAttendence()
    End Sub

    Private Sub dgAttendenceShow_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgAttendenceShow.CellClick
        cntr.CellClickAttendence(e)
        btn_update.Enabled = True
        btn_save.Enabled = False
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged
        If Me.cmbStatus.Text = "A" Then
            DTPInTime.Enabled = False
            DTPOutTime.Enabled = False
        Else
            DTPInTime.Enabled = True
            DTPOutTime.Enabled = True
        End If
    End Sub

    Private Sub txtMemberName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMemberName.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.TextOnly(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtMobileNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobileNo.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtResidentNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResidentNo.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    
End Class