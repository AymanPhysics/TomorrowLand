Public Class CloseForm
    Dim bm As New BasicMethods

    Public State As BasicMethods.CloseState = BasicMethods.CloseState.Cancel
    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        State = BasicMethods.CloseState.Yes
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        State = BasicMethods.CloseState.No
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        State = BasicMethods.CloseState.Cancel
    End Sub

    Private Sub CloseForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        If Module1.MyProject = Project.TomorrowLand Then
            BackgroundImage = Global.TomorrowLand.My.Resources.Resources.TomorrowLand
        ElseIf Module1.MyProject = Project.EFG Then
            BackgroundImage = Global.TomorrowLand.My.Resources.Resources.EFG
        End If
    End Sub
End Class