<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Custom_Letter_UnAssignEditor.aspx.cs" Inherits="Custom_Letter_UnAssignEditor" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">





        .style3
        {
            width: 88%;
        }
        .style4
        {
            width: 621px;
        }
        .style8
        {
            width: 856px;
            height: 28px;
        }
        .style9
        {
            width: 621px;
            height: 28px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="border-width: 1px; border-style: solid; height: 894px; font-family: 'MS Reference Sans Serif'; font-weight: bold; font-size: small; width: 826px;">
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Customize Letter - Ad-hoc from editor<br />
        <br />
        <br />
        <br />
        <fieldset style="width: 816px; height: 52px; background-color: #F2F2F2;">
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Cancel" />
            &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Preview and Send" />
        </fieldset><br />
        <br />
        <fieldset style="height: 421px; width: 812px; background-color: #F2F2F2;">
            <br />
            <table align="center" cellpadding="0" cellspacing="0" class="style3" 
                style="border: 1px solid #FFFFFF;  height: ; font-size: small;">
                <tr>
                    <td align="left" class="">
                        &nbsp;From</td>
                    <td align="left" class="" style="border: 1pt solid #FFFFFF;">
                        &nbsp;&nbsp;
                        <asp:Label ID="Now_Date" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr valign="top">
                    <td align="left" class="">
                        To:</td>
                    <td align="left" class="" style="border: 1pt solid #FFFFFF;">
                        &nbsp;&nbsp;
                        <asp:Label ID="recieve" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr valign="top">
                    <td align="left" class="">
                        Letter Subject:</td>
                    <td align="left" class="" style="border: 1pt solid #FFFFFF;">
                        &nbsp;
                        <asp:Label ID="sendere" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr valign="top">
                    <td align="left" class="">
                        cc: Settings:</td>
                    <td class="" style="border: 1pt solid #FFFFFF;">
                        <asp:Label ID="Subject" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr valign="top">
                    <td align="left" class="" style="border: 1pt solid #FFFFFF;">
                        Letter Body:</td>
                    <td class="" style="border: 1pt solid #FFFFFF;" valign="middle">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="HyperLink20" runat="server" Font-Bold="False" 
                            Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="Small" 
                            Font-Underline="True" ForeColor="Blue">Insert Special Character</asp:HyperLink>
                        &nbsp; &nbsp;</td>
                </tr>
                <tr valign="top">
                    <td class="" colspan="2" valign="bottom">
                        <br />
                        &nbsp;&nbsp;<asp:TextBox ID="Txt_message_content" runat="server" Height="277px" 
                            Width="676px"></asp:TextBox>
                        &nbsp;
                        <br />
                    </td>
                </tr>
            </table>
        </fieldset></div>
</asp:Content>

