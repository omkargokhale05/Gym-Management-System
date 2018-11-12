Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.MembershipRenewalClass
Public Class frmMembershipRenewal

#Region "Declaration"

    Dim clsRenewalMembershipDtls As New MembershipRenewalClass
    Dim cntr As New Controller
    Dim clsDBFun As New DBFunction
    Dim clsCon As New DBConnection

#End Region

    Private Sub cmbPackageID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPackageID.SelectedIndexChanged
        Try
            clsRenewalMembershipDtls.DisplayPackageDetails(cmbPackageID.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save.Click
        clsRenewalMembershipDtls.CheckTextMembershipRenewal()
        If clsRenewalMembershipDtls.flag = True Then
            cntr.AddMembershipRenewalDtls(cmbMembershipID.SelectedValue, DTPRenewalDate.Text, cmbPackageID.SelectedValue, DTPValidUpto.Text, txtTotalFee.Text, txtPaidFee.Text, txtBalanceAmount.Text, cmbPaymentMode.Text, txtBankName.Text, txtCheqckNo.Text)
            cntr.DisplayDataMembershipRenewal()
            cntr.ClearTextMembershipRenewal()
            clsRenewalMembershipDtls.navigationMembershipRenewal()
        Else
            clsRenewalMembershipDtls.flag = True
        End If
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        clsRenewalMembershipDtls.CheckTextMembershipRenewal()
        If clsRenewalMembershipDtls.flag = True Then
            cntr.UpdateMembershipRenewalDtls(cmbMembershipID.SelectedValue, DTPRenewalDate.Text, cmbPackageID.SelectedValue, DTPValidUpto.Text, txtTotalFee.Text, txtPaidFee.Text, txtBalanceAmount.Text, cmbPaymentMode.Text, txtBankName.Text, txtCheqckNo.Text)
            cntr.DisplayDataMembershipRenewal()
            cntr.ClearTextMembershipRenewal()
            clsRenewalMembershipDtls.navigationMembershipRenewal()

            btn_update.Enabled = False
        Else
            clsRenewalMembershipDtls.flag = True
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        cntr.ClearTextMembershipRenewal()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        Try
            clsRenewalMembershipDtls.currentRow = 0
            clsRenewalMembershipDtls.ShowDataMembershipRenewal(clsRenewalMembershipDtls.currentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            If clsRenewalMembershipDtls.currentRow = clsRenewalMembershipDtls.ds.Tables("MRD").Rows.Count - 1 Then

                MsgBox("You are on the last record!!!")
            Else
                clsRenewalMembershipDtls.currentRow += 1
                clsRenewalMembershipDtls.ShowDataMembershipRenewal(clsRenewalMembershipDtls.currentRow)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Try
            If clsRenewalMembershipDtls.currentRow <> 0 Then
                clsRenewalMembershipDtls.currentRow -= 1
                clsRenewalMembershipDtls.ShowDataMembershipRenewal(clsRenewalMembershipDtls.currentRow)
            Else
                MsgBox("You are on the first record!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Try
            clsRenewalMembershipDtls.currentRow = clsRenewalMembershipDtls.ds.Tables("MRD").Rows.Count - 1
            clsRenewalMembershipDtls.ShowDataMembershipRenewal(clsRenewalMembershipDtls.currentRow)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMembershipRenewal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnfirst.Enabled = True
        btnNext.Enabled = True
        btnPrevious.Enabled = True
        btnLast.Enabled = True

        clsDBFun.BindCombo("exec BindPackageID", cmbPackageID)
        clsDBFun.BindCombo("exec BindMembershipID", cmbMembershipID)

        clsRenewalMembershipDtls.navigationMembershipRenewal()
        cntr.ClearTextMembershipRenewal()
        cntr.DisplayDataMembershipRenewal()
    End Sub

    Private Sub dgMembershipRenewalDetails_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMembershipRenewalDetails.CellClick
        cntr.CellClickMembershipRenewal(e)
        btn_update.Enabled = True
        btn_save.Enabled = False
    End Sub

    Private Sub txtPaidFee_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPaidFee.LostFocus
        Try
            If txtBalanceAmount.Text = "" Then

                If Val(txtTotalFee.Text) < Val(txtPaidFee.Text) Then
                    MessageBox.Show("Please Enter Right Ammount")
                    txtBalanceAmount.Clear()
                    txtPaidFee.Clear()
                Else
                    txtBalanceAmount.Text = Val(txtTotalFee.Text) - Val(txtPaidFee.Text)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbPaymentMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPaymentMode.SelectedIndexChanged
        If cmbPaymentMode.Text = "CASH" Then
            txtBankName.Enabled = False
            txtCheqckNo.Enabled = False
        Else
            txtBankName.Enabled = True
            txtCheqckNo.Enabled = True
        End If
    End Sub

    Private Sub txtBalanceAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBalanceAmount.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCheqckNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCheqckNo.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtNoOfInstallments_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoOfInstallments.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPackageAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPackageAmount.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTotalFee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalFee.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub
End Class