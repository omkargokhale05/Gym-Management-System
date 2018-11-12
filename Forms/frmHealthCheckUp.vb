Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.HealthCheckUpClass
Public Class frmHealthCheckUp
#Region "Declaration"

    Dim clsHealthCheckUp As New HealthCheckUpClass
    Dim cntr As New Controller
    Dim clsDBFun As New DBFunction
    Dim clsCon As New DBConnection

#End Region
    Private Sub btnAddMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMember.Click
        frmMemberMaster.Show()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        clsHealthCheckUp.CheckTextHealthCheckUp()
        If clsHealthCheckUp.flag = True Then
            cntr.AddHealthCheckUpDtls(cmbHealthID.SelectedValue, cmbMemberID.SelectedValue, cmbMonth.Text, txtMonthCount.Text, DTPCheckUp.Text)
            cntr.DisplayDataHealthCheckUp()
            cntr.ClearTextHealthCheckUp()
        Else
            clsHealthCheckUp.flag = True
        End If
    End Sub

    Private Sub frmHealthCheckUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnfirst.Enabled = True
        btnNext.Enabled = True
        btnPrevious.Enabled = True
        btnLast.Enabled = True

        clsDBFun.BindCombo("exec BindHealthID", cmbHealthID)
        clsDBFun.BindCombo("exec BindMemberID", cmbMemberID)

        clsHealthCheckUp.navigationHealthCheckUp()
        cntr.ClearTextHealthCheckUp()
        cntr.DisplayDataHealthCheckUp()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        clsHealthCheckUp.CheckTextHealthCheckUp()
        If clsHealthCheckUp.flag = True Then
            cntr.UpdateHealthCheckUpDtls(cmbHealthID.SelectedValue, cmbMemberID.SelectedValue, cmbMonth.Text, txtMonthCount.Text, DTPCheckUp.Text)
            cntr.DisplayDataHealthCheckUp()
            cntr.ClearTextHealthCheckUp()
            clsHealthCheckUp.navigationHealthCheckUp()

            btn_update.Enabled = False
        Else
            clsHealthCheckUp.flag = True
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        cntr.ClearTextHealth()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        Try
            clsHealthCheckUp.currentRow = 0
            clsHealthCheckUp.ShowDataHealthCheckUp(clsHealthCheckUp.currentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            If clsHealthCheckUp.currentRow = clsHealthCheckUp.ds.Tables("HCD").Rows.Count - 1 Then

                MsgBox("You are on the last record!!!")
            Else
                clsHealthCheckUp.currentRow += 1
                clsHealthCheckUp.ShowDataHealthCheckUp(clsHealthCheckUp.currentRow)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Try
            If clsHealthCheckUp.currentRow <> 0 Then
                clsHealthCheckUp.currentRow -= 1
                clsHealthCheckUp.ShowDataHealthCheckUp(clsHealthCheckUp.currentRow)
            Else
                MsgBox("You are on the first record!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Try
            clsHealthCheckUp.currentRow = clsHealthCheckUp.ds.Tables("HCD").Rows.Count - 1
            clsHealthCheckUp.ShowDataHealthCheckUp(clsHealthCheckUp.currentRow)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgHealthCheckUpShow_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgHealthCheckUpShow.CellClick
        cntr.CellClickHealthCheckUp(e)
        btn_update.Enabled = True
        btn_save.Enabled = False
    End Sub

    Private Sub cmbHealthID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHealthID.SelectedIndexChanged
        Try
            clsHealthCheckUp.DisplayHealthCheckUp(cmbHealthID.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbMemberID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMemberID.SelectedIndexChanged
        Try
            clsHealthCheckUp.DisplayMemberDetails(cmbMemberID.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtMonthCount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonthCount.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtHeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHeight.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
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

    Private Sub txtWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeight.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtWaistSize_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWaistSize.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBMI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBMI.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtHeartBeat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHeartBeat.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtChestSize_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChestSize.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

End Class