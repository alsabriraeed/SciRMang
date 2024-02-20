Imports System
Imports System.Net
Imports System.Net.Mail


Partial Class sendSmsMsg
    Inherits System.Web.UI.Page


#Region "Declarations"

    ' message elements
    Private mMailServer As String
    Private mTo As String
    Private mFrom As String
    Private mMsg As String
    Private mSubject As String
    Private mPort As Integer

#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Load the names of the common carriers 
        cboCarrier.Items.Add("@itelemigcelular.com.br")
        cboCarrier.Items.Add("@message.alltel.com")
        cboCarrier.Items.Add("@message.pioneerenidcellular.com")
        cboCarrier.Items.Add("@messaging.cellone-sf.com")
    End Sub



    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click

        'send message

        Dim strMsg As String
        strMsg = txtMessage.Text

        If strMsg.Length >= 140 Then
            strMsg = strMsg.Substring(1, 140)
        End If

        mTo = Trim(txtToNumber.Text) & Trim(cboCarrier.SelectedItem.ToString())
        mFrom = Trim(txtFrom.Text)
        mSubject = Trim(txtSubject.Text)
        mMsg = Trim(txtMessage.Text)
        mMailServer = ConfigurationManager.AppSettings.Get("MyMailServer")
        mPort = ConfigurationManager.AppSettings.Get("MyMailServerPort")

        Try

            Dim message As New MailMessage(mFrom, mTo, mSubject, mmsg)
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


End Class
