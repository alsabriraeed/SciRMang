<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SendBackToAutho.aspx.cs" Inherits="SendBackToAutho" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style1
        {
            width: 200px;
        }
        .style2
        {
            width: 433px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center" 
        style="border: 1px groove #000000; height: 279px; font-family: 'MS Reference Sans Serif'; font-weight: bold; font-size: medium; width: 839px;">
        <br />
        &nbsp;&nbsp;&nbsp; Send Back to Author - Select Letter
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <fieldset style="width: 789px; height: 40px; font-weight: normal; font-size: x-small; background-color: #F2F2F2;">
            To change the letter sent to the Author, select adifferent letter from the 
            drop-dowen menue.to customize the letter, click the &#39;Customize&#39; link. Then click 
            &#39;Send Letter&#39; from this page, or &#39;Send Now&#39; from the customize letter page to 
            send the letter.</fieldset>&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <fieldset style="width: 809px; height: 67px; font-weight: normal; font-size: x-small; background-color: #F2F2F2;">
            &nbsp;&nbsp;&nbsp;
            <table align="center" bold;="" border-bottom-style:"groove";="" 
                border-left-style:="" cellpadding="0" cellspacing="0" font-size:="" 
                font-weight:="" groove";="" groove;="" small;"="" 
                style="border-width: 1px; width: 786px; height: 41px;  border-right-style:">
                <tr bgcolor="#00008C" style="color: #FFFFFF">
                    <td class="style1" style="border-style: groove; border-width: 1px">
                        &nbsp;Name&nbsp;</td>
                    <td class="style2" style="border-style: groove; border-width: 1px">
                        &nbsp;Letter&nbsp;</td>
                    <td style="border-style: groove; border-width: 1px">
                        &nbsp;</td>
                </tr>
                <tr style="border-style: groove; border-width: 1px; font-weight: lighter;">
                    <td class="style1" style="border-style: groove; border-width: 1px">
                        <asp:LinkButton ID="Lbl_Author_Name" runat="server" 
                            CommandName="Lbl_Author_Name"></asp:LinkButton>
                    </td>
                    <td class="style2" style="border-style: groove; border-width: 1px">
                        <asp:DropDownList ID="DdMessages_Send_Back" runat="server" Height="25px" 
                            Width="205px">
                        </asp:DropDownList>
                    </td>
                    <td style="border-style: groove; border-width: 1px">
                        &nbsp;&nbsp;&nbsp; &nbsp;<asp:LinkButton ID="Customize" runat="server" onclick="Customize_Click">Customize</asp:LinkButton>
                    </td>
                </tr>
            </table>
            &nbsp;</fieldset><br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="CmdCancel" runat="server" BackColor="#F2F2F2" Height="22px" 
            Text="Cancel" />
        &nbsp;
        <asp:Button ID="CmdSendLetter" runat="server" BackColor="#F2F2F2" Height="22px" 
            onclick="CmdSendLetter_Click" Text="Send Letter" />
    </div>
</asp:Content>

