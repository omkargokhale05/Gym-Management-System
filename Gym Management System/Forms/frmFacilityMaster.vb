Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.FacilityClass
Public Class frmFacilityMaster

#Region "Declaration"

    Dim clsFacility As New FacilityClass
    Dim cntr As New Controller
    Dim clsDBFun As New DBFunction
    Dim clsCon As New DBConnection

#End Region

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        clsFacility.CheckTextFacility()
        If clsFacility.flag = True Then
            cntr.AddFacility(txtFacilityID.Text, txtFacilityName.Text, txtcharges.Text, txtFrequency.Text, cmbStatus.Text)

            cntr.DisplayDataFacility()
            cntr.ClearTextFacility()
            cntr.GenerateFacilityId()
            clsFacility.navigationFacility()
        Else
            clsFacility.flag = True
        End If
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        clsFacility.CheckTextFacility()
        If clsFacility.flag = True Then
            cntr.UpdateFacility(txtFacilityID.Text, txtFacilityName.Text, txtcharges.Text, txtFrequency.Text, cmbStatus.Text)
            cntr.DisplayDataFacility()
            cntr.ClearTextFacility()
            cntr.GenerateFacilityId()
            clsFacility.navigationFacility()

            btn_update.Enabled = False
        Else
            clsFacility.flag = True
        End If
    End Sub
    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        cntr.ClearTextFacility()
        cntr.GenerateFacilityId()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        Try
            clsFacility.currentRow = 0
            clsFacility.ShowDataFacility(clsFacility.currentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            If clsFacility.currentRow = clsFacility.ds.Tables("FM").Rows.Count - 1 Then

                MsgBox("You are on the last record!!!")
            Else
                clsFacility.currentRow += 1
                clsFacility.ShowDataFacility(clsFacility.currentRow)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Try
            If clsFacility.currentRow <> 0 Then
                clsFacility.currentRow -= 1
                clsFacility.ShowDataFacility(clsFacility.currentRow)
            Else
                MsgBox("You are on the first record!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Try
            clsFacility.currentRow = clsFacility.ds.Tables("FM").Rows.Count - 1
            clsFacility.ShowDataFacility(clsFacility.currentRow)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMemberMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnfirst.Enabled = True
        btnNext.Enabled = True
        btnPrevious.Enabled = True
        btnLast.Enabled = True

        clsFacility.navigationFacility()
        cntr.ClearTextFacility()
        cntr.GenerateFacilityId()
        cntr.DisplayDataFacility()
    End Sub

    Private Sub dgFacilityShow_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFacilityShow.CellClick
        cntr.CellClickFacility(e)
        btn_update.Enabled = True
        btn_save.Enabled = False
    End Sub

    Private Sub txtFacilityName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFacilityName.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.TextOnly(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtcharges_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcharges.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub
End Class