Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.MembershipClass
Public Class frmMembershipDetails

#Region "Declaration"

    Dim clsMembershipDtls As New MembershipClass
    Dim cntr As New Controller
    Dim clsDBFun As New DBFunction
    Dim clsCon As New DBConnection

#End Region

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        clsMembershipDtls.CheckTextMembership()
        If clsMembershipDtls.flag = True Then
            cntr.AddMembershipDtls(txtMembershipID.Text, cmbMemberID.SelectedValue, DTPMembershipDate.Text, txtPurpose.Text, cmbPackageID.SelectedValue, DTPValidOut.Text, txtTotalFee.Text, txtPaidFee.Text, txtBalanceAmount.Text, cmbPaymentMode.Text, txtBankName.Text, txtCheqckNo.Text)
            cntr.DisplayDataMembership()
            cntr.ClearTextMembership()
            cntr.GenerateMembershipID()

        Else
            clsMembershipDtls.flag = True
        End If
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        clsMembershipDtls.CheckTextMembership()
        If clsMembershipDtls.flag = True Then
            cntr.UpdateMembershipDtls(txtMembershipID.Text, cmbMemberID.SelectedValue, DTPMembershipDate.Text, txtPurpose.Text, cmbPackageID.SelectedValue, DTPValidOut.Text, txtTotalFee.Text, txtPaidFee.Text, txtBalanceAmount.Text, cmbPaymentMode.Text, txtBankName.Text, txtCheqckNo.Text)
            cntr.DisplayDataMembership()
            cntr.ClearTextMembership()
            cntr.GenerateMembershipID()
            clsMembershipDtls.navigationMembership()

            btn_update.Enabled = False
        Else
            clsMembershipDtls.flag = True
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        cntr.ClearTextMembership()
        cntr.GenerateMembershipID()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        Try
            clsMembershipDtls.currentRow = 0
            clsMembershipDtls.ShowDataMembership(clsMembershipDtls.currentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            If clsMembershipDtls.currentRow = clsMembershipDtls.ds.Tables("MSD").Rows.Count - 1 Then

                MsgBox("You are on the last record!!!")
            Else
                clsMembershipDtls.currentRow += 1
                clsMembershipDtls.ShowDataMembership(clsMembershipDtls.currentRow)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Try
            If clsMembershipDtls.currentRow <> 0 Then
                clsMembershipDtls.currentRow -= 1
                clsMembershipDtls.ShowDataMembership(clsMembershipDtls.currentRow)
            Else
                MsgBox("You are on the first record!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Try
            clsMembershipDtls.currentRow = clsMembershipDtls.ds.Tables("MSD").Rows.Count - 1
            clsMembershipDtls.ShowDataMembership(clsMembershipDtls.currentRow)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgMembershipDetails_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMembershipDetails.CellClick
        cntr.CellClickMembership(e)
        btn_update.Enabled = True
        btn_save.Enabled = False
    End Sub

    Private Sub frmMembershipDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnfirst.Enabled = True
        btnNext.Enabled = True
        btnPrevious.Enabled = True
        btnLast.Enabled = True

        clsDBFun.BindCombo("exec BindMemberID", cmbMemberID)
        clsDBFun.BindCombo("exec BindPackageID", cmbPackageID)

        clsMembershipDtls.navigationMembership()
        cntr.ClearTextMembership()
        cntr.GenerateMembershipID()
        cntr.DisplayDataMembership()
    End Sub
    Private Sub cmbPackageID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPackageID.SelectedIndexChanged
        Try
            clsMembershipDtls.DisplayPackageDetails(cmbPackageID.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbMemberID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMemberID.SelectedIndexChanged
        Try
            clsMembershipDtls.DisplayMemberDetails(cmbMemberID.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPaidFee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaidFee.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
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

    Private Sub txtCheqckNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCheqckNo.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
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

    Private Sub txtPackageName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPackageName.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.TextOnly(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtResidentNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResidentNo.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBalanceAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBalanceAmount.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub
End Class