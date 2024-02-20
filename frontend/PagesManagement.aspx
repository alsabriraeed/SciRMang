<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PagesManagement.aspx.cs" Inherits="PagesManagement" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" Font-Size="Medium" Height="" 
        style="margin-left: 36px" Width="1023px">
        <table cellpadding="0" cellspacing="0" class="" rules="all">
            <tr>
                <td class="" 
                    style="border-width: 0px 0px 3px 0px; border-color: #000000; font-size: large; font-weight: bold; border-bottom-style: solid;">
                    Enable</td>
                <td class="" 
                    style="border-width: 0px 0px 3px 0px; border-color: #000000; font-size: large; font-weight: bold; border-bottom-style: solid;">
                    &nbsp;&nbsp;&nbsp;&nbsp; Pages Registration</td>
                <td class="" 
                    style="border-width: 0px 0px 3px 0px; border-color: #000000; font-size: large; font-weight: bold; border-bottom-style: solid;">
                    Enable</td>
                <td class="" 
                    style="border-width: 0px 0px 3px 0px; border-color: #000000; font-size: large; font-weight: bold; border-bottom-style: solid;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; pages submission and assigning</td>
            </tr>
            <tr>
                <td align="center" class="" valign="top">
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="68px" Width="36px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>
                        </asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td bgcolor="#E6E6E6" class="" 
                    style="font-size: 16pt; font-weight: bold; font-style: italic;" valign="top">
                    -Attach Files Order<br />
                    -Author PDF Approval<br />
                    -CONFIG REGISTRATION<br />
                    -Edit Personal Keyword<br />
                    -ERROR NOTICE<br />
                    -File Inventory<br />
                    -New Submission<br />
                    -PreRegistration<br />
                    -Registeration Page<br />
                    -Registration Quations<br />
                    -Resived Submission comment<br />
                    -Revised Submission Add Author<br />
                    -REVISED Submission Keyword
                    <br />
                    -Revised Submission response To Reviewer<br />
                    -Revised Submmission select File<br />
                    -Select Personal Classfication<br />
                    -Submission Revision article Type<br />
                    -Submit Revision1<br />
                    -Submitting Revised Manuscripts<br />
                    -Summary Attach File<br />
                    -Tracking Progres&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Active" />
                </td>
                <td align="center" bgcolor="#E6E6E6" class="" 
                    style="font-size: 16pt; font-weight: bold; font-style: italic; background-color: #FFFFFF;" 
                    valign="top">
                    <asp:CheckBoxList ID="CheckBoxList2" runat="server" Height="68px" Width="36px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>
                        </asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td bgcolor="#E6E6E6" class="" 
                    style="font-size: 15pt; font-weight: bold; font-style: italic;" valign="top">
                    -Create Linked Submission Group<br />
                    -All Submission with Editor&#39;s Decision<br />
                    -Assign MySelf<br />
                    -AssignEditor<br />
                    AssignEditor_ConfirmSelectionandCustomizeLetters<br />
                    -agree to review conformation<br />
                    -Completed Reviewer Assignment<br />
                    -Current Editor Assignment<br />
                    -Decline Invitation<br />
                    -Decline review confirmation<br />
                    -DeclineInvitation<br />
                    -DeclineInvitationConfirmation<br />
                    -Direct to Editor Revised Submissions
                    <br />
                    -Direct to Editor New Submissions<br />
                    -DetailForManuscriptNumber2<br />
                    -CustomizeLetterAdhocfromeditor<br />
                    -confirm information update1<br />
                    -Create a New Group<br />
                    -Companion Files.<br />
                    -ChangingAuthorAnd ReviewerDueDates<br />
                    -Blinding Editor some Submissions<br />
                    -agree to review conformation&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Active" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

