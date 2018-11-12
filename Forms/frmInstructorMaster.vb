﻿Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.InstructorClass
Public Class frmInstructorMaster

#Region "Declaration"

    Dim clsInstructor As New InstructorClass
    Dim cntr As New Controller
    Dim clsDBFun As New DBFunction
    Dim clsCon As New DBConnection

#End Region

    Private Sub txtMobileNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobileNo.Leave
        Dim a As String
        Try
            a = Convert.ToInt64(txtMobileNo.Text)
            If a.Length <> 10 Then
                MsgBox("Enter minimum 10 nos")
                txtMobileNo.Focus()
            End If
        Catch ex As Exception
            MsgBox("Enter minimum 10 nos")
            txtMobileNo.Focus()
        End Try

    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        clsInstructor.CheckTextInstructor()
        If clsInstructor.flag = True Then
            cntr.AddInstructor(txtInstructorID.Text, txtInstructorName.Text, rtbInstructorAddress.Text, txtMobileNo.Text, cmbExperts.Text, DTPDateOfJoin.Text, cmbGender.Text)
            cntr.DisplayDataInstructor()
            cntr.ClearTextInstructor()
            cntr.GenerateInstructorId()
            Me.dgInstructorShow.Refresh()
        Else
            clsInstructor.flag = True
        End If
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        clsInstructor.CheckTextInstructor()
        If clsInstructor.flag = True Then
            cntr.UpdateInstructor(txtInstructorID.Text, txtInstructorName.Text, rtbInstructorAddress.Text, txtMobileNo.Text, cmbExperts.Text, DTPDateOfJoin.Text, cmbGender.Text)
            cntr.DisplayDataInstructor()
            cntr.ClearTextInstructor()
            cntr.GenerateInstructorId()
            clsInstructor.navigationInstructor()
            btn_update.Enabled = False
            Me.dgInstructorShow.Refresh()
        Else
            clsInstructor.flag = True
        End If
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click

        cntr.DeleteInstructor(txtInstructorID.Text)
        cntr.DisplayDataInstructor()
        btn_update.Enabled = False
        btn_Delete.Enabled = False
        Me.dgInstructorShow.Refresh()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        cntr.ClearTextInstructor()
        cntr.GenerateInstructorId()
        cntr.DisplayDataInstructor()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        Try
            clsInstructor.currentRow = 0
            clsInstructor.ShowDataInstructor(clsInstructor.currentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            If clsInstructor.currentRow = clsInstructor.ds.Tables("IM").Rows.Count - 1 Then

                MsgBox("You are on the last record!!!")
            Else
                clsInstructor.currentRow += 1
                clsInstructor.ShowDataInstructor(clsInstructor.currentRow)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Try
            If clsInstructor.currentRow <> 0 Then
                clsInstructor.currentRow -= 1
                clsInstructor.ShowDataInstructor(clsInstructor.currentRow)
            Else
                MsgBox("You are on the first record!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Try
            clsInstructor.currentRow = clsInstructor.ds.Tables("IM").Rows.Count - 1
            clsInstructor.ShowDataInstructor(clsInstructor.currentRow)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmInstructorMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnfirst.Enabled = True
        btnNext.Enabled = True
        btnPrevious.Enabled = True
        btnLast.Enabled = True
        btn_Delete.Enabled = False

        clsInstructor.navigationInstructor()
        cntr.ClearTextInstructor()
        cntr.GenerateInstructorId()
        cntr.DisplayDataInstructor()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If rbtID.Checked = False And rbtName.Checked = False Then
            MsgBox("Please click a Radiobutton")
        End If
        cntr.SearchInstructor(txtSearch.Text)
        btn_update.Enabled = True
        btn_Delete.Enabled = True
    End Sub
    Private Sub dgInstructorShow_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgInstructorShow.CellClick
        cntr.CellClickInstructor(e)
        btn_update.Enabled = True
        btn_save.Enabled = False
        btn_Delete.Enabled = True
    End Sub

    Private Sub txtInstructorName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInstructorName.KeyPress
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

    Private Sub rbtID_CheckedChanged(sender As Object, e As EventArgs) Handles rbtID.CheckedChanged
        txtSearch.Clear()
    End Sub

    Private Sub rbtName_CheckedChanged(sender As Object, e As EventArgs) Handles rbtName.CheckedChanged
        txtSearch.Clear()
    End Sub
End Class