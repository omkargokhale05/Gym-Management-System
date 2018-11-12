Public Class GymManagementSplashForm
#Region "Delcation"
    Dim clsSplash As New SplashScreenClass
#End Region

    Private Sub timer_splash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_splash.Tick
        clsSplash.Timer_tick()
    End Sub

End Class