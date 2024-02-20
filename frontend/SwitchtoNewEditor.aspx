<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SwitchtoNewEditor.aspx.cs" Inherits="SwitchtoNewEditor" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style1
        {
            width: 99%;
            height: 529px;
        }
        .style2
        {
            width: 142px;
        }
        .style3
        {
            width: 113%;
            height: 37px;
            margin-left: 18px;
            margin-bottom: 0px;
        }
        .style4
        {
            width: 647px;
        }
        .style12
        {
            width: 118%;
            height: 267px;
        }
        .style14
        {
            width: 73px;
            height: 41px;
        }
        .style15
        {
            width: 665px;
            height: 41px;
        }
        .style22
        {
            width: 608px;
            height: 41px;
        }
        .style17
        {
            width: 107px;
            height: 41px;
        }
        .style18
        {
            width: 70px;
            height: 41px;
        }
        .style19
        {
            height: 41px;
            width: 233px;
        }
        .style9
        {
            width: 73px;
        }
        .style21
        {
            width: 665px;
        }
        .style23
        {
            width: 608px;
        }
        .style8
        {
            width: 107px;
        }
        .style11
        {
            width: 70px;
        }
        .style20
        {
            width: 233px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 590px; width: 1081px; margin-right: 98px">
        &nbsp;<br />
        &nbsp;
        <table class="style1">
            <tr>
                <td align="left" class="style2" 
                    style="font-family: 'MS Reference Sans Serif'; font-size: large; font-weight: bold" 
                    valign="top">
                    <br />
                    Switch to New Editor<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;<fieldset 
                        style="border-width: 0px; font-size: small; width: 167px; font-weight: normal; height: 381px;">
                        &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Small" 
                            Text="Manuscript Number:" Width="117%"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;Please select the Editor to whom you would like to assign this submission. You 
                        can send this Editor either the default editor assignment letter or a customized 
                        letter.You will also have the opportunity to customize the letter being sent to 
                        customize the letter being sent to the editor who is being assigned.</fieldset><br />
                    &nbsp;
                </td>
                <td align="left" valign="top">
                    <table cellpadding="0" cellspacing="0" class="style3">
                        <tr>
                            <td align="center" class="style4" 
                                style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #F2F2F2;" 
                                valign="middle">
                                <br />
                                <br />
                                Click the Blind Editors link to block access to this submission for one or more 
                                Editors<br />
                                &nbsp;&nbsp;<asp:HyperLink ID="HyperLink22" runat="server" Font-Bold="False" 
                                    Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="Small" 
                                    Font-Underline="True" ForeColor="Blue">Blind Editors</asp:HyperLink>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="White" class="style4" 
                                style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #FFFFFF;" 
                                valign="top">
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#00008F" class="style4" 
                                style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #F2F2F2;" 
                                valign="top">
                                <table cellpadding="0" cellspacing="0" class="style12">
                                    <tr>
                                        <td>
                                            <table align="center" bgcolor="White" border="1" cellpadding="0" 
                                                cellspacing="0" frame=" " 
                                                style="border-style: inherit; border-width: 1px; width: 731px; height: 119px; margin-top: 10px">
                                                <tr align="left" bgcolor="#00008C" 
                                                    style="font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: bold; color: #FFFFFF;" 
                                                    valign="bottom">
                                                    <td class="style14">
                                                        &nbsp; Select&nbsp;
                                                    </td>
                                                    <td class="style15">
                                                        &nbsp;Editor Role&nbsp;</td>
                                                    <td class="style22">
                                                        Editor Name</td>
                                                    <td class="style17">
                                                        &nbsp;Current Assignments</td>
                                                    <td class="style18">
                                                        &nbsp; Classification Matches</td>
                                                    <td class="style19">
                                                        &nbsp; Available during Next 60 days</td>
                                                </tr>
                                                <tr>
                                                    <td class="style9">
                                                        &nbsp;</td>
                                                    <td align="left" class="style21">
                                                        &nbsp;
                                                    </td>
                                                    <td align="left" class="style23">
                                                        <asp:HyperLink ID="HyperLink23" runat="server" Font-Bold="False" 
                                                            Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="Small" 
                                                            Font-Underline="True" ForeColor="Blue">Editor Name</asp:HyperLink>
                                                    </td>
                                                    <td class="style8">
                                                        &nbsp;</td>
                                                    <td class="style11">
                                                        &nbsp;</td>
                                                    <td class="style20">
                                                        &nbsp;&nbsp; &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style9">
                                                        &nbsp;</td>
                                                    <td align="left" class="style21">
                                                        &nbsp;&nbsp;&nbsp;
                                                    </td>
                                                    <td align="left" class="style23">
                                                        &nbsp;</td>
                                                    <td class="style8">
                                                        &nbsp;</td>
                                                    <td class="style11">
                                                        &nbsp;</td>
                                                    <td class="style20">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style9">
                                                        &nbsp;</td>
                                                    <td align="left" class="style21">
                                                        &nbsp;
                                                    </td>
                                                    <td align="left" class="style23">
                                                        &nbsp;</td>
                                                    <td class="style8">
                                                        &nbsp;</td>
                                                    <td class="style11">
                                                        &nbsp;</td>
                                                    <td class="style20">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style9">
                                                        &nbsp;</td>
                                                    <td align="left" class="style21">
                                                        &nbsp;
                                                    </td>
                                                    <td align="left" class="style23">
                                                        &nbsp;</td>
                                                    <td class="style8">
                                                        &nbsp;</td>
                                                    <td class="style11">
                                                        &nbsp;</td>
                                                    <td class="style20">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style9">
                                                        &nbsp;</td>
                                                    <td align="left" class="style21">
                                                        &nbsp;
                                                    </td>
                                                    <td align="left" class="style23">
                                                        &nbsp;</td>
                                                    <td class="style8">
                                                        &nbsp;</td>
                                                    <td class="style11">
                                                        &nbsp;</td>
                                                    <td class="style20">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style9">
                                                        &nbsp;</td>
                                                    <td align="left" class="style21">
                                                        &nbsp; &nbsp;</td>
                                                    <td align="left" class="style23">
                                                        &nbsp;</td>
                                                    <td class="style8">
                                                        &nbsp;</td>
                                                    <td class="style11">
                                                        &nbsp;</td>
                                                    <td class="style20">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style9">
                                                        &nbsp;</td>
                                                    <td align="left" class="style21">
                                                        &nbsp;
                                                    </td>
                                                    <td align="left" class="style23">
                                                        &nbsp;</td>
                                                    <td class="style8">
                                                        &nbsp;</td>
                                                    <td class="style11">
                                                        &nbsp;</td>
                                                    <td class="style20">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style9">
                                                        &nbsp;</td>
                                                    <td align="left" class="style21">
                                                        &nbsp;
                                                    </td>
                                                    <td align="left" class="style23">
                                                        &nbsp;</td>
                                                    <td class="style8">
                                                        &nbsp;</td>
                                                    <td class="style11">
                                                        &nbsp;</td>
                                                    <td class="style20">
                                                        &nbsp;</td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    &nbsp;<br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="CmdCancel" runat="server" BackColor="#F2F2F2" Height="20px" 
                        Text="Cancel" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="CmdCancel0" runat="server" BackColor="#F2F2F2" Height="20px" 
                        onclick="CmdCancel0_Click" Text="Proceed" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

