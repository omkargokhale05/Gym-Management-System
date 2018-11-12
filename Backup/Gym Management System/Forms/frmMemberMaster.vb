Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.MemberClass
Public Class frmMemberMaster
#Region "Declaration"

    Dim clsMember As New MemberClass
    Dim cntr As New Controller
    Dim clsDBFun As New DBFunction
    Dim clsCon As New DBConnection

#End Region

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        clsMember.CheckTextMember()
        If clsMember.flag = True Then
            cntr.AddMember(txtMemberID.Text, txtMemberName.Text, rtbMemberAddress.Text, txtResidentNo.Text, txtMobileNo.Text, DTPDateOfBirth.Text, cmbGender.Text)
            cntr.DisplayDataMember()
            cntr.ClearTextMember()
            cntr.GenerateMemberId()

        Else
            clsMember.flag = True
        End If
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        clsMember.CheckTextMember()
        If clsMember.flag = True Then
            cntr.UpdateMember(txtMemberID.Text, txtMemberName.Text, rtbMemberAddress.Text, txtResidentNo.Text, txtMobileNo.Text, DTPDateOfBirth.Text, cmbGender.Text)
            cntr.DisplayDataMember()
            cntr.ClearTextMember()
            cntr.GenerateMemberId()
            clsMember.navigationMember()

            btn_update.Enabled = False
        Else
            clsMember.flag = True
        End If
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click

        cntr.DeleteMember(txtMemberID.Text)
        cntr.DisplayDataMember()
        btn_update.Enabled = False
        btn_Delete.Enabled = False

    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        cntr.ClearTextMember()
        cntr.GenerateMemberId()
        btn_save.Enabled = True
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        Try
            clsMember.currentRow = 0
            clsMember.ShowDataMember(clsMember.currentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            If clsMember.currentRow = clsMember.ds.Tables("MD").Rows.Count - 1 Then

                MsgBox("You are on the last record!!!")
            Else
                clsMember.currentRow += 1
                clsMember.ShowDataMember(clsMember.currentRow)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Try
            If clsMember.currentRow <> 0 Then
                clsMember.currentRow -= 1
                clsMember.ShowDataMember(clsMember.currentRow)
            Else
                MsgBox("You are on the first record!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Try
            clsMember.currentRow = clsMember.ds.Tables("MD").Rows.Count - 1
            clsMember.ShowDataMember(clsMember.currentRow)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMemberMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnfirst.Enabled = True
        btnNext.Enabled = True
        btnPrevious.Enabled = True
        btnLast.Enabled = True
        btn_Delete.Enabled = False
        clsMember.navigationMember()
        cntr.ClearTextMember()
        cntr.GenerateMemberId()
        cntr.DisplayDataMember()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        cntr.SearchMember(txtSearch.Text)
    End Sub

    Private Sub dgMemberShow_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMemberShow.CellClick
        cntr.CellClickMember(e)
        btn_update.Enabled = True
        btn_Delete.Enabled = True
        btn_save.Enabled = False

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