Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.PackageMaster
Public Class frmPackageMaster
#Region "Declaration"

    Dim clsPackage As New PackageMaster
    Dim cntr As New Controller
    Dim clsDBFun As New DBFunction
    Dim clsCon As New DBConnection

#End Region

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try
            clsPackage.CheckTextPackage()
            If clsPackage.flag = True Then
                cntr.AddPackage(txtPackageID.Text, txtPackageName.Text, txtPackageAmount.Text, rtbPackageTerms.Text, cmbActiveStatus.Text, txtNoOfInstallments.Text)

                For i = 0 To lstselectedFacilityName.Items.Count - 1
                    Dim facilityId As Integer
                    facilityId = lstFaciD.Items(i)
                    cntr.addPackageMapping(txtPackageID.Text, facilityId)
                Next

                cntr.DisplayDataPackage()
                cntr.ClearTextPackage()
                cntr.GeneratePackageId()
            Else
                MessageBox.Show("Error in Adding Package Master")
                clsPackage.flag = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        clsPackage.CheckTextPackage()
        If clsPackage.flag = True Then
            cntr.UpdatePackage(txtPackageAmount.Text, txtPackageName.Text, txtPackageAmount.Text, rtbPackageTerms.Text, cmbActiveStatus.Text, txtNoOfInstallments.Text)
            cntr.DisplayDataPackage()
            cntr.ClearTextPackage()
            cntr.GeneratePackageId()
            clsPackage.navigationPackage()

            btn_update.Enabled = False
        Else
            clsPackage.flag = True
        End If
    End Sub
    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        cntr.ClearTextPackage()
        cntr.GeneratePackageId()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        If lstFacilityName.SelectedValue = 0 Then
            MessageBox.Show("Please Select Facility")
        Else
            lstselectedFacilityName.Items.Add(lstFacilityName.Text)
            lstFaciD.Items.Add(lstFacilityName.SelectedValue)
            lstFacilityName.Text = ""
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            lstselectedFacilityName.Items.Remove(lstselectedFacilityName.SelectedItem)
            lstFaciD.Items.Remove(lstFaciD.SelectedItem)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmPackageMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnfirst.Enabled = True
        btnNext.Enabled = True
        btnPrevious.Enabled = True
        btnLast.Enabled = True

        cntr.BindFacilityDtls()

        clsPackage.navigationPackage()
        cntr.ClearTextPackage()
        cntr.GeneratePackageId()
        cntr.DisplayDataPackage()
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        Try
            clsPackage.currentRow = 0
            clsPackage.ShowDataPackage(clsPackage.currentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            If clsPackage.currentRow = clsPackage.ds.Tables("PM").Rows.Count - 1 Then

                MsgBox("You are on the last record!!!")
            Else
                clsPackage.currentRow += 1
                clsPackage.ShowDataPackage(clsPackage.currentRow)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Try
            If clsPackage.currentRow <> 0 Then
                clsPackage.currentRow -= 1
                clsPackage.ShowDataPackage(clsPackage.currentRow)
            Else
                MsgBox("You are on the first record!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Try
            clsPackage.currentRow = clsPackage.ds.Tables("PM").Rows.Count - 1
            clsPackage.ShowDataPackage(clsPackage.currentRow)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstselectedFacilityName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstselectedFacilityName.Click
        Try
            Dim a As Integer = 0
            a = lstselectedFacilityName.SelectedIndex

            lstFaciD.SetSelected(a, True)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgPackageShow_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPackageShow.CellClick
        cntr.CellClickPackage(e)
        btn_update.Enabled = True
        btn_save.Enabled = False

    End Sub

    Private Sub txtPackageAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPackageAmount.KeyPress
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
End Class