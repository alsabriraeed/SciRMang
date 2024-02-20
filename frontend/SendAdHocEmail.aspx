<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SendAdHocEmail.aspx.cs" Inherits="SendAdHocEmail" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style1
        {
            width: 96%;
            height: 44px;
        }
        .style3
        {
            width: 225px;
            height: 17px;
        }
        .style4
        {
            height: 17px;
        }
        .style2
        {
            width: 225px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center" 
        style="border-style: solid; border-width: 1px; height: ; font-family: 'MS Reference Sans Serif'; font-weight: bold; font-size: large;">
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp; Send Ad Hoc Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;
        <fieldset style="height: ; width: 738px; font-family: 'MS Reference Sans Serif'; font-size: x-small; font-weight: normal; background-color: #F2F2F2;">
            <br />
            The journal has pre-configured one or more letters which you may use as a 
            starting point. Selct a letter, then click &#39;Customize Letter&#39; , insert your 
            comments, and send the 
            letter.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <table bgcolor="White" border="2" cellpadding="0" cellspacing="0" 
                class="">
                <tr>
                    <td class="" style="border-style: solid; border-width: 1px">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="dropRole" runat="server" 
                            onselectedindexchanged="dropRole_SelectedIndexChanged">
                            <asp:ListItem>Please Choose The Role</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="">
                        <asp:DropDownList ID="dropMessageType" runat="server">
                            <asp:ListItem>Please Choose The Message Type</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="" style="border-style: solid; border-width: 1px">
                        <br />
                        <br />
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Select" />
                    </td>
                </tr>
                <tr>
                    <td class="" style="border-style: solid; border-width: 1px">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="Lbl_Author_Name" runat="server" 
                            CommandName="Lbl_Author_Name" Visible="False"></asp:LinkButton>
                        <br />
                        <asp:DropDownList ID="DropUser" runat="server" Height="21px" Visible="False" 
                            Width="172px">
                            <asp:ListItem>Please Choose User</asp:ListItem>
                            <asp:ListItem Selected="True">All</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="">
                        <br />
                        <asp:DropDownList ID="DropSendEmail0" runat="server" Height="16px" 
                            Visible="False" Width="220px">
                            <asp:ListItem>Pleas Choose a Letter</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="border-style: solid; border-width: 1px">
                        &nbsp;</td>
                </tr>
            </table>
        </fieldset><br />
        <br />
        <asp:Button ID="CmdCancel" runat="server" BackColor="#F2F2F2" 
            Font-Size="Medium" Height="22px" onclick="CmdCancel_Click" 
            Text="Customize Letter" Width="155px" />
        <br />
        <br />
    </div>
</asp:Content>

