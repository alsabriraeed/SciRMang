<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UnassignEditor.aspx.cs" Inherits="UnassignEditor" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style1
        {
            width: 214px;
            height: 339px;
        }
        .style2
        {
            width: 713px;
             
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="border-style: solid; border-width: 1px; height: 403px">
        &nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<table border=" " cellpadding="0" cellspacing="0" 
            style="border: 0px none #808080;   width: 920px; height: 282px;">
            <tr>
                <td class="style1" style="border-right-style: dotted; border-right-width: 1px" 
                    valign="top">
                    <br />
                    &nbsp;
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" 
                        Font-Names="MS Reference Sans Serif" Font-Size="Large" Text="Unassign Editor"></asp:Label>
                </td>
                <td class="style2" valign="top">
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <fieldset style="border-width: 1px 0px 1px 0px; width: 669px; height: 187px; background-color: #F2F2F2; border-top-style: solid; border-bottom-style: solid; font-family: 'MS Reference Sans Serif'; font-size: small;">
                        <br />
                        &nbsp;Are you sure you want to unassign the Editor? If you unassign the Editor from 
                        this submission,<br />
                        &nbsp;Joe Editor, M.D. will no longer be responsible for the submission, and the 
                        submission must be&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; assigned to another Editor.<br />
                        <br />
                        &nbsp;Click &#39;Switch to New Editor&#39; to immediately assign a new Editor to the 
                        submission.<br />
                        &nbsp;<br />
                        &nbsp;Click &#39;Roll Back to previous Editor&#39; to move the submission back up the chain 
                        to the<br />
                        &nbsp;Assigning Editor.<br />
                        <br />
                        &nbsp;
                        <br />
                        &nbsp;<br />
                        &nbsp;</fieldset>&nbsp;&nbsp;<br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="CmdClose" runat="server" BackColor="#F2F2F2" Height="23px" 
                        Text="Cancel" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="CmdClose0" runat="server" BackColor="#F2F2F2" Height="23px" 
                        onclick="CmdClose0_Click" Text="Switch to New Editor" Width="141px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="CmdClose1" runat="server" BackColor="#F2F2F2" Height="23px" 
                        onclick="CmdClose1_Click" Text="Roll Back to Previous Editor" Width="178px" />
                    <br />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

