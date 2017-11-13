Public Class Admin
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub lbChgPwrd_Click(sender As Object, e As EventArgs) Handles lbChgPwrd.Click
        Server.Transfer("AdminChangePassword.aspx", True)
    End Sub

    Protected Sub lbLogOut_Click(sender As Object, e As EventArgs) Handles lbLogOut.Click
        Server.Transfer("AdminLoginPage.aspx", True)
    End Sub
End Class