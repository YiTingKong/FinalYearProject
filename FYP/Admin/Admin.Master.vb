﻿Public Class Admin
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub lbChgPwrd_Click(sender As Object, e As EventArgs) Handles lbChgPwrd.Click
        Server.Transfer("AdminChangePassword.aspx", True)
    End Sub

    Protected Sub lbLogOut_Click(sender As Object, e As EventArgs) Handles lbLogOut.Click
        Server.Transfer("AdminLoginPage.aspx", True)
    End Sub

    Protected Sub lbProduct_Click(sender As Object, e As EventArgs) Handles lbProduct.Click
        Server.Transfer("AdminClothesCreate.aspx", True)
    End Sub

    Protected Sub lbTech_Click(sender As Object, e As EventArgs) Handles lbTech.Click
        Server.Transfer("AdminTechCreate.aspx", True)
    End Sub

    Protected Sub lbMachines_Click(sender As Object, e As EventArgs) Handles lbMachines.Click

    End Sub
End Class