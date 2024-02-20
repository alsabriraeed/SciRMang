<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Decline Invitation.aspx.cs" Inherits="Decline_Invitation" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">





        .style1
        {
            width: 90%;
            height: 405px;
            border: 5px solid #ffffff;
            background-color: #ffffff;
        }
        .style3
        {
           
            width: 146px;
            height: 246px;
        }
        .style2
        {            height: 246px;
        }
        #field1
        {
            height: 73px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <br />
        <table align="center" bgcolor="White" border="4" cellpadding="4" 
            cellspacing="0" class="style1" dir="ltr" 
            style="padding: 2px; margin: auto; height: 242px; position: inherit; border-left-color: #FFCC66; border-left-width: 2px; border-right-color: #FFCC66; border-right-width: 2px; border-top-color: #FFCC66; border-top-width: 1px; border-bottom-color: #FFCC66; border-bottom-width: 2px;">
            <tr>
                <td class="style3" dir="ltr" 
                    style="border-style: none dashed none none; border-width: 0px 3px 0px 0px; font-weight: bold; border-right-color: #CCCCCC;" 
                    valign="top">
                    <br />
                    <br class="style5" />
                    <span class="style6">DECLINE
                    <br />
                    INVITATION</span></td>
                <td id="T" class="style2" style="border-style: none" valign="top">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;<fieldset id="field1" runat="server" 
                        style="border: 1px hidden #CCCCCC; background-color: #FFFFFF; margin-left: 19px; right: auto; width: 678px; height: 175px; left: auto; position: inherit; z-index: auto;">
                        &nbsp;<hr noshade="noshade" style="height: 1px; width: 90%; " />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" BackColor="#F4F4F4" 
                            Height="16px" style="font-family: 'MS Reference Sans Serif'; font-size: small" 
                            Text="Please state a reason for declining  to Invitation manuescript " 
                            Width="71%"></asp:Label>
                        &nbsp;&nbsp;<asp:Label ID="Label7" runat="server" BackColor="#F4F4F4" 
                            style="font-family: 'MS Reference Sans Serif'; font-size: small; margin-left: 0px;" 
                            Text="تاريخ الرفض" Width="17%"></asp:Label>
                        &nbsp;&nbsp; &nbsp;<asp:Label ID="Label4" runat="server" Text="."></asp:Label>
                        &nbsp;&nbsp;<br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" BackColor="#F4F4F4" 
                            Height="16px" style="font-family: 'MS Reference Sans Serif'; font-size: small" 
                            Text="provide some information that will help us contact this person  ." 
                            Width="89%"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <hr noshade="noshade" style="height: 1px; width: 90%; color: #333333" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="Reason_Decline" runat="server" Height="142px" 
                            TextMode="MultiLine" Width="608px" 
                            ontextchanged="Reason_Decline_TextChanged"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                            ID="CmdCancel1" runat="server" BorderColor="Black" Text="Cancel" Width="73px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="CmdSubmit" runat="server" BorderColor="Black" Height="26px" 
                            onclick="CmdSubmit_Click" Text="Submit" Width="77px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </fieldset>
                </td>
            </tr>
        </table>
        <br />
    </div>
</asp:Content>

