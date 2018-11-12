Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.HealthClass
Public Class frmHealthDetails

#Region "Declaration"

    Dim clsHealthDtls As New HealthClass
    Dim cntr As New Controller
    Dim clsDBFun As New DBFunction
    Dim clsCon As New DBConnection

#End Region

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        clsHealthDtls.CheckTextHealth()
        If clsHealthDtls.flag = True Then
            cntr.AddHealthDtls(txtHealthID.Text, txtHeight.Text, txtWeight.Text, txtHeartBeat.Text, txtBMI.Text, txtChestSize.Text, txtWaistSize.Text, txtBicepSize.Text)
            cntr.DisplayDataHealth()
            cntr.ClearTextHealth()
            cntr.GenerateHealthId()

        Else
            clsHealthDtls.flag = True
        End If
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        clsHealthDtls.CheckTextHealth()
        If clsHealthDtls.flag = True Then
            cntr.UpdateHealthDtls(txtHealthID.Text, txtHeight.Text, txtWeight.Text, txtHeartBeat.Text, txtBMI.Text, txtChestSize.Text, txtWaistSize.Text, txtBicepSize.Text)
            cntr.DisplayDataHealth()
            cntr.ClearTextHealth()
            cntr.GenerateHealthId()
            clsHealthDtls.navigationHealth()

            btn_update.Enabled = False
        Else
            clsHealthDtls.flag = True
        End If
    End Sub
    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        cntr.ClearTextHealth()
        cntr.GenerateHealthId()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        Try
            clsHealthDtls.currentRow = 0
            clsHealthDtls.ShowDataHealth(clsHealthDtls.currentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            If clsHealthDtls.currentRow = clsHealthDtls.ds.Tables("HD").Rows.Count - 1 Then

                MsgBox("You are on the last record!!!")
            Else
                clsHealthDtls.currentRow += 1
                clsHealthDtls.ShowDataHealth(clsHealthDtls.currentRow)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Try
            If clsHealthDtls.currentRow <> 0 Then
                clsHealthDtls.currentRow -= 1
                clsHealthDtls.ShowDataHealth(clsHealthDtls.currentRow)
            Else
                MsgBox("You are on the first record!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Try
            clsHealthDtls.currentRow = clsHealthDtls.ds.Tables("HD").Rows.Count - 1
            clsHealthDtls.ShowDataHealth(clsHealthDtls.currentRow)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMemberMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnfirst.Enabled = True
        btnNext.Enabled = True
        btnPrevious.Enabled = True
        btnLast.Enabled = True

        clsHealthDtls.navigationHealth()
        cntr.ClearTextHealth()
        cntr.GenerateHealthId()
        cntr.DisplayDataHealth()
    End Sub

    Private Sub dgHealthShow_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgHealthShow.CellClick
        cntr.CellClickHealth(e)
        btn_update.Enabled = True
        btn_save.Enabled = False
    End Sub
    Private Sub txtHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHeight.TextChanged
        Try
            If Val(txtWeight.Text) > 150 Or Val(txtHeight.Text) > 250 Then
                MessageBox.Show("Please Enter Corrrect Height or Weight")
                txtWeight.Text = ""
                txtHeight.Text = ""
                txtWeight.Focus()

            Else

                txtBMI.Text = (Val(txtWeight.Text) / ((Val(txtHeight.Text) / 100) * (Val(txtHeight.Text) / 100)))
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtBicepSize_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBicepSize.KeyPress
        Try
            e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBMI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBMI.KeyPress
        Try
            ' e.KeyChar = Chr(clsDBFun.numval(Asc(e.KeyChar)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtChestSize_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChestSize.KeyPress
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

    Private Sub txtWaistSize_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWaistSize.KeyPress
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
End Class