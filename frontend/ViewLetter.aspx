<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewLetter.aspx.cs" Inherits="ViewLetter" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center" 
        style="border-style: solid; border-width: 1px; height: 709px; font-family: 'MS Reference Sans Serif'; font-size: large; font-weight: bold;">
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; View Letter<br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="CmdClose" runat="server" BackColor="#F2F2F2" Height="19px" 
            Text="Close" />
        &nbsp;&nbsp;
        <asp:Button ID="CmdRecend" runat="server" BackColor="#F2F2F2" Height="19px" 
            onclick="CmdRecend_Click" Text="Send Now" />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" BackColor="#F2F2F2" BorderStyle="Groove" 
            Height="438px" style="margin-left: 0px" Width="792px">
            <br />
            <table cellpadding="0" cellspacing="0" 
                style="width: 744px; margin-left: 0px; font-size: small; height: 91px;">
                <tr>
                    <td align="left" class="style2">
                        &nbsp;Date&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Now_Date" runat="server"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="left" class="style2">
                        &nbsp;To&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="recieve" runat="server"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="left" class="style2">
                        &nbsp;From&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="sendere" runat="server"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="left" class="style2">
                        &nbsp;Subject&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Subject" runat="server"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="left" class="style2">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            <asp:TextBox ID="Txt_message_content" runat="server" BorderStyle="Groove" 
                Height="304px" Width="754px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="CmdClose0" runat="server" BackColor="#F2F2F2" Height="19px" 
                Text="Close" />
            &nbsp;&nbsp;
            <asp:Button ID="CmdRecend0" runat="server" BackColor="#F2F2F2" Height="19px" 
                onclick="CmdRecend0_Click" Text="Send Now" />
            <br />
            <br />
        </asp:Panel>
        &nbsp;&nbsp;&nbsp;
    </div>
</asp:Content>

