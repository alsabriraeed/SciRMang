Imports System
Imports System.Net
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Data
Imports System.Web.SessionState






Partial Class _Default1
    Inherits System.Web.UI.Page


#Region "Declarations"

    ' message elements
    Private mMailServer As String
    Private mTo As String
    Private mFrom As String
    Private mMsg As String
    Private mSubject As String
    Private mCC As String
    Private mPort As Integer
    Dim User_No As Integer
#End Region


    Private Sub MessageBox(ByVal strMsg As String)

        ' generate a popup message using javascript alert function
        ' dumped into a label with the string argument passed in
        ' to supply the alert box text
        Dim lbl As New Label
        lbl.Text = "<script language='javascript'>" & Environment.NewLine _
        & "window.alert(" & "'" & strMsg & "'" & ")</script>"

        ' add the label to the page to display the alert
        Page.Controls.Add(lbl)

    End Sub



    Protected Sub btnSend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSend.Click

        'send message
        User_No = Convert.ToInt16(Session("User_No"))
        Response.Write(User_No)

        Dim strMsg As String
        strMsg = txtMessage.Text

        mTo = Trim(txtTo.Text)
        mFrom = Trim(txtFrom.Text)
        mSubject = Trim(txtSubject.Text)
        mMsg = Trim(txtMessage.Text)
        mMailServer = ConfigurationManager.AppSettings.Get("MyMailServer")
        mPort = ConfigurationManager.AppSettings.Get("MyMailServerPort")
        mCC = Trim(txtCC.Text)

        Try

            Dim message As New MailMessage(mFrom, mTo, mSubject, mMsg)

            If fileAttachments.HasFile Then
                Dim attached As New Attachment(Trim(fileAttachments.PostedFile.FileName.ToString()))
                message.Attachments.Add(attached)
            End If

            If mCC <> "" Or mCC <> String.Empty Then
                Dim strCC() As String = Split(mCC, ";")
                Dim strThisCC As String
                For Each strThisCC In strCC
                    message.CC.Add(Trim(strThisCC))
                Next
            End If


            Dim mySmtpClient As New SmtpClient(mMailServer, mPort)
            mySmtpClient.UseDefaultCredentials = True
            mySmtpClient.Send(message)

            MessageBox("The mail message has been sent to " & message.To.ToString())

        Catch ex As FormatException

            MessageBox("Format Exception: " & ex.Message)

        Catch ex As SmtpException

            MessageBox("SMTP Exception:  " & ex.Message)

        Catch ex As Exception

            MessageBox("General Exception:  " & ex.Message)

        End Try

    End Sub


End Class
