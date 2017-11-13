Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO.Path

Public Class AdminColourCreate
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'database
        Dim connection As SqlConnection
        connection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Source\Repos\FinalYearProject\FYP\App_Data\FYPdatabase.mdf;Integrated Security=True")
        Try
            connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim err As New StringBuilder()

        'validation
        If fuCImg.HasFile = False Then
            err.AppendLine("- Please select Image for DISPLAY.")
        End If

        If txtColour.Text = "" Then
            err.AppendLine("- Please enter Clothes Colour.")
        End If

        'display error messages
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            Return
        End If

        Try

            'colour button image
            Dim disImg As String = fuCImg.FileName
            fuCImg.PostedFile.SaveAs(Server.MapPath("Img/button/" + disImg))
            Dim CImgPath As String = "Img/button/" + disImg.ToString()

            Dim query As String = "INSERT Colour (colour, colour_button, status) VALUES (@colour, @colourButton, @status)"
            Dim cmd As SqlCommand = New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@colour", txtColour.Text) 'nvarchar
            cmd.Parameters.AddWithValue("@colourButton", CImgPath) 'nvarchar
            cmd.Parameters.AddWithValue("@status", ddlStatus.SelectedValue) 'nvarchar
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            MsgBox("Record saved.", MsgBoxStyle.Information)
            txtColour.Text = ""
            ddlStatus.SelectedIndex = -1
            fuCImg.Attributes.Clear()

        Catch ex As SqlException
            MsgBox(ex.Message, , "Sql Exception")
        Catch ex As Exception
            MsgBox(ex.Message, , "General Exception")
        End Try

    End Sub

    Protected Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtColour.Text = ""
        ddlStatus.SelectedIndex = -1
        fuCImg.Attributes.Clear()
    End Sub
End Class