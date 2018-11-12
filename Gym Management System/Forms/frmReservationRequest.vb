Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.ReservationRequestClass
Public Class frmReservationRequest

#Region "Declaration"

    Dim clsReservationRequest As New ReservationRequestClass
    Dim cntr As New Controller
    Dim clsDBFun As New DBFunction
    Dim clsCon As New DBConnection

#End Region

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        clsReservationRequest.CheckTextReservationRequest()

        If clsReservationRequest.flag = True Then

            cntr.AddReservationRequestDtls(txtRequestID.Text, cmbMemberID.SelectedValue, DTPRequestDate.Text, DTPUtilisationDate.Text, cmbFacilityID.SelectedValue)
            cntr.DisplayDataReservationRequest()
            cntr.ClearTextReservationRequest()
            clsReservationRequest.navigationReservationRequest()
        Else
            clsReservationRequest.flag = True
        End If
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        clsReservationRequest.CheckTextReservationRequest()
        If clsReservationRequest.flag = True Then
            cntr.UpdateReservationRequestDtls(txtRequestID.Text, cmbMemberID.SelectedValue, DTPRequestDate.Text, DTPUtilisationDate.Text, cmbFacilityID.SelectedValue)
            cntr.DisplayDataReservationRequest()
            cntr.ClearTextMembershipRenewal()
            clsReservationRequest.navigationReservationRequest()

            btn_update.Enabled = False
        Else
            clsReservationRequest.flag = True
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        cntr.ClearTextReservationRequest()
        cntr.GenerateRequestID()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        Try
            clsReservationRequest.currentRow = 0
            clsReservationRequest.ShowDataReservationRequest(clsReservationRequest.currentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            If clsReservationRequest.currentRow = clsReservationRequest.ds.Tables("RRD").Rows.Count - 1 Then

                MsgBox("You are on the last record!!!")
            Else
                clsReservationRequest.currentRow += 1
                clsReservationRequest.ShowDataReservationRequest(clsReservationRequest.currentRow)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Try
            If clsReservationRequest.currentRow <> 0 Then
                clsReservationRequest.currentRow -= 1
                clsReservationRequest.ShowDataReservationRequest(clsReservationRequest.currentRow)
            Else
                MsgBox("You are on the first record!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Try
            clsReservationRequest.currentRow = clsReservationRequest.ds.Tables("RRD").Rows.Count - 1
            clsReservationRequest.ShowDataReservationRequest(clsReservationRequest.currentRow)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgReservationRequest_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgReservationRequest.CellClick
        cntr.CellClickReservationRequest(e)
        btn_update.Enabled = True
        btn_save.Enabled = False
    End Sub

    Private Sub cmbMemberID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMemberID.SelectedIndexChanged
        Try
            clsReservationRequest.DisplayMemberDetails(cmbMemberID.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbFacilityID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFacilityID.SelectedIndexChanged
        Try
            clsReservationRequest.DisplayFacilityDetails(cmbFacilityID.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmReservationRequest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnfirst.Enabled = True
        btnNext.Enabled = True
        btnPrevious.Enabled = True
        btnLast.Enabled = True

        clsDBFun.BindCombo("exec BindMemberID", cmbMemberID)
        clsDBFun.BindCombo("exec BindFacilityDtls", cmbFacilityID)

        clsReservationRequest.navigationReservationRequest()
        cntr.ClearTextReservationRequest()
        cntr.GenerateRequestID()
        cntr.DisplayDataReservationRequest()
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

    Private Sub txtCharges_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCharges.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub
End Class