Public Class PCs

    Private Sub PCs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        If Module1.MyProject = Project.TomorrowLand Then
            BackgroundImage = Global.TomorrowLand.My.Resources.Resources.TomorrowLand
        ElseIf Module1.MyProject = Project.EFG Then
            BackgroundImage = Global.TomorrowLand.My.Resources.Resources.EFG
        End If
    End Sub
End Class