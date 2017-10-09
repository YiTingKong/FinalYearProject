Public Class AdminHome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSignIn_Click(sender As Object, e As ImageClickEventArgs) Handles btnSignIn.Click
        If txtUName.Text = "Kongyt" And txtpassword.Text = "abc123" Then
            Response.Redirect("~/AdminHome.aspx")
        Else
            txtpassword.Text = ""
            txtUName.Text = ""
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub
End Class