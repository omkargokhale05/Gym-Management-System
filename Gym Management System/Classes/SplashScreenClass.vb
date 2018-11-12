Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.DBConnection
Public Class SplashScreenClass

#Region "Timer_tick"
    Public Sub Timer_tick()
        Try

            GymManagementSplashForm.Splash_prog.Increment(2)
            GymManagementSplashForm.prglbl.Text = GymManagementSplashForm.Splash_prog.Value
            If GymManagementSplashForm.Splash_prog.Value = 100 Then
                GymManagementSplashForm.Hide()
                GymManagementSplashForm.timer_splash.Dispose()
                frmLogin.ShowDialog()
                frmLogin.Show()
                GymManagementSplashForm.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class
