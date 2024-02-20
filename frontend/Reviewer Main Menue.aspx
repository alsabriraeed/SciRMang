<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Reviewer Main Menue.aspx.cs" Inherits="Reviewer_Main_Menue" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">




        .style1
        {
            width: 91%;
            height: 199px;
            border: 5px solid #ffffff;
            background-color: #ffffff;
        }
        .style3
        {
            height: 84px;
            width: 247px;
        }
        #field2
        {
            height: 123px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;<table align="center" bgcolor="White" border="4" cellpadding="4" 
            cellspacing="4" class="style1" dir="ltr" 
            style="border-width: 1px 2px 2px 1px; border-color: #FFCC66; padding: 2px; margin: auto;">
            <tr>
                <td class="style3" dir="ltr" 
                    style="border-color: #FFFFFF #CCCCCC #FFFFFF #FFFFFF; border-width: 0px 2px 0px 0px; font-weight: bold; border-right-style: dotted;" 
                    valign="top">
                    &nbsp;<br />
                    REVIEWER&nbsp; MAIN MENUE&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td class="style5" valign="top">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;<fieldset id="field2" runat="server" 
                        style="border: 1px hidden #CCCCCC; background-color: #F4F4F4; margin-left: 23px; right: inherit; width: 615px;">
                        <legend style="border-style: groove; background-color: #FFFFFF; font-weight: bold;">
                            Reviewer Assignments&nbsp;&nbsp;&nbsp;&nbsp; </legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="New_Reviewer_Invitationss" runat="server" Enabled="False" 
                            onclick="New_Reviewer_Invitationss_Click" 
                            PostBackUrl="~/new reviewer invitation.aspx">New Reviewer Invitation
                        </asp:LinkButton>
                        <asp:Label ID="New_Reviewer_Invitation_Count" runat="server"></asp:Label>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="Pending_Assignment" runat="server" Enabled="False" 
                            onclick="Pending_Assignment_Click" 
                            PostBackUrl="~/Pending ReviewerAssignments.aspx">Pending Assignment
                        </asp:LinkButton>
                        <asp:Label ID="Pending_Assignment_cont" runat="server"></asp:Label>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="Completed_Assignments" runat="server" Enabled="False" 
                            PostBackUrl="~/Completed Reviewer Assignment.aspx">Completed Assignments</asp:LinkButton>
                        &nbsp;<asp:Label ID="Completed_Assignments_count" runat="server"></asp:Label>
                        &nbsp;<br />
                    </fieldset>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>

