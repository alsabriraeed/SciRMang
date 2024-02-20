<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditSubmition.aspx.cs" Inherits="EditSubmition" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style1
        {
            width: 100%;
            height: 961px;
        }
        .style2
        {
            width: 219px;
        }
        .style8
        {
            width: 3px;
        }
        .style3
        {
            width: 90%;
            height: 119px;
        }
        .style4
        {
            width: 93%;
            height: 42px;
        }
        .style13
        {
            width: 224px;
        }
        .style10
        {
            height: 19px;
        }
        .style11
        {
            height: 28px;
        }
        .style12
        {
            height: 141px;
        }
        .style14
        {
            width: 224px;
            height: 35px;
        }
        .style15
        {
            height: 35px;
        }
        .style16
        {
            height: 27px;
        }
        .style17
        {
            height: 159px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: ; width: 961px;">
        &nbsp;&nbsp;&nbsp;&nbsp;
        <table cellpadding="0" cellspacing="0" class="">
            <tr>
                <td align="center" bgcolor="White" class="" 
                    style="border-width: 1px; border-style: solid dashed solid solid; border-color: #C0C0C0 #999999 #C0C0C0 #C0C0C0; font-family: 'MS Reference Sans Serif'; font-weight: bolder; font-size: large" 
                    valign="top">
                    <br />
                    Edit Submission&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                    <table align="center" cellspacing="1" class="">
                        <tr>
                            <td class="">
                                &nbsp;</td>
                            <td align="left">
                                <asp:Label ID="Label2" runat="server" BackColor="#F2F2F2" BorderColor="Black" 
                                    BorderStyle="Groove" BorderWidth="1px" Font-Bold="True" Font-Size="X-Small" 
                                    Height="22px" 
                                    Text="Enter Metadata                                     ‬                   " 
                                    Width="96%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="">
                                &nbsp;</td>
                            <td align="left">
                                <asp:Label ID="Label3" runat="server" BackColor="#F2F2F2" BorderColor="Black" 
                                    BorderStyle="Groove" BorderWidth="1px" Font-Bold="True" Font-Size="X-Small" 
                                    Height="22px" style="margin-left: 0px" Text="Add/Edit/Remove Authors" 
                                    Width="96%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="">
                                &nbsp;</td>
                            <td align="left">
                                <asp:Label ID="Label4" runat="server" BackColor="#F2F2F2" BorderColor="Black" 
                                    BorderStyle="Groove" BorderWidth="1px" Font-Bold="True" Font-Size="X-Small" 
                                    Height="22px" Text="Attach File" Width="96%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td align="center" 
                    style="border-width: 1px; border-style: solid solid solid dotted; border-color: #C0C0C0" 
                    valign="top">
                    <br />
                    <table cellpadding="0" cellspacing="0" class="style3">
                        <tr>
                            <td align="left" 
                                style="background-color: #F2F2F2; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: bold; border-top-style: solid;  border-bottom-style: solid; border-top-color: Red; border-bottom-color: Red; border-width: 1px 0px 1px 0px" 
                                valign="top">
                                &nbsp;<br />
                                &nbsp;You are about to edit %ARTICLE_TITLE%. Would you like to:sp;&nbsp;<br />
                                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Edit 
                                the sumission</asp:LinkButton>
                                &nbsp;(and rebuild PDF)<br />
                                <br />
                                &nbsp;
                                <asp:HyperLink ID="HyperLink13" runat="server" Font-Bold="True" 
                                    Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="Small" 
                                    Font-Underline="True" ForeColor="Blue">Edit the sumission data only</asp:HyperLink>
                                <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="CmdCancel" runat="server" BackColor="#F2F2F2" Text="Cancel" />
                                &nbsp;&nbsp;
                                <asp:Button ID="Button1" runat="server" BackColor="#CCCCCC" BorderColor="Black" 
                                    onclick="Button1_Click" Text="Save" Width="89px" />
                                &nbsp;
                                <asp:Button ID="Next_Button" runat="server" onclick="Next_Button_Click" 
                                    Text="Next" />
                                <br />
                            </td>
                        </tr>
                    </table>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <fieldset style="height: 480px; background-color: #F2F2F2; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: bold; width: 674px; margin-right: 0px;">
                        <legend style="border-style: solid; border-width: 1px; width: 119px;">&nbsp;Edit Metadata
                        </legend>
                        <br />
                        <br />
                        <table bgcolor="#F2F2F2" cellpadding="0" cellspacing="0" class="">
                            <tr>
                                <td align="left" 
                                    style="border-top-style: solid; border-bottom-style: solid; border-top-width: 1px; border-bottom-width: 1px; border-top-color: Red; border-bottom-color: Red;  border-right-width: 0px; font-weight: normal;">
                                    &nbsp; Enter submissio metadata below. Required fields are marked with *.</td>
                            </tr>
                        </table>
                        <br />
                        <table align="center" cellpadding="0" cellspacing="0" class="style5">
                            <tr>
                                <td align="left" class="" 
                                    style="border-bottom-style: solid; border-bottom-width: 1px; border-right-style: solid; border-right-width: 1px; border-right-color: #C0C0C0; border-bottom-color: #C0C0C0;">
                                    &nbsp;*ArticleType:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                                <td align="left" class="">
                                    &nbsp;<asp:DropDownList ID="ArticleTypedrop" runat="server" 
                                        DataTextField="Article_Type_Name" DataValueField="Article_Type_No" 
                                        Height="16px" Width="148px">
                                        <asp:ListItem>Manual Submission</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" class="" colspan="2" 
                                    style="border-bottom-style: solid; border-bottom-width: 1px; border-top-color: #C0C0C0; border-right-style: solid; border-right-width: 1px; border-right-color: #C0C0C0;">
                                    &nbsp;* Full Title:&nbsp;</td>
                            </tr>
                            <tr>
                                <td align="left" bgcolor="White" class="" colspan="2" 
                                    style="border-bottom-style: solid; border-bottom-width: 1px; border-top-color: #C0C0C0; border-right-style: solid; border-right-width: 1px; border-right-color: #C0C0C0;" 
                                    valign="top">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                                    <asp:HyperLink ID="HyperLink14" runat="server" Font-Bold="False" 
                                        Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="X-Small" 
                                        Font-Underline="True" ForeColor="Blue" style="text-align: center">Insert 
                                    Special Character</asp:HyperLink>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <br />
                                    &nbsp;<asp:TextBox ID="Full_Title" runat="server" Height="120px" 
                                        TextMode="MultiLine" Width="644px"></asp:TextBox>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td align="left" class="style11" colspan="2" 
                                    style="border-bottom-style: solid; border-bottom-width: 1px; border-top-color: #C0C0C0; border-right-style: solid; border-right-width: 1px; border-right-color: #C0C0C0;">
                                    &nbsp;Short Title:&nbsp;</td>
                            </tr>
                            <tr>
                                <td align="left" bgcolor="White" class="style12" colspan="2" 
                                    style="border-bottom-style: solid; border-bottom-width: 1px; border-top-color: #C0C0C0; border-right-style: solid; border-right-width: 1px; border-right-color: #C0C0C0;" 
                                    valign="top">
                                    <br />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:HyperLink ID="HyperLink15" runat="server" Font-Bold="False" 
                                        Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="X-Small" 
                                        Font-Underline="True" ForeColor="Blue">Insert Special Character</asp:HyperLink>
                                    <br />
                                    <br />
                                    &nbsp;<asp:TextBox ID="Short_Title" runat="server" Height="88px" 
                                        TextMode="MultiLine" Width="618px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" class="style14" 
                                    style="border-bottom-style: solid; border-bottom-width: 1px; border-top-color: #C0C0C0; border-right-style: solid; border-right-width: 1px; border-right-color: #C0C0C0;">
                                    &nbsp;Section/Category&nbsp;
                                </td>
                                <td align="left" bgcolor="White" class="style15" 
                                    style="border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #C0C0C0">
                                    <asp:DropDownList ID="Section_Category" runat="server" 
                                        DataTextField="Article_Categories" DataValueField="Article_Categories" 
                                        Height="16px" Width="153px">
                                        <asp:ListItem>Please Choose:
                                        </asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" class="style16" colspan="2" 
                                    style="border-bottom-style: solid; border-bottom-width: 1px; border-top-color: #C0C0C0; border-right-style: solid; border-right-width: 1px; border-right-color: #C0C0C0;">
                                    &nbsp;Keywords (separated by semicol&nbsp;Keywords (separated by semicolons):&nbsp;</td>
                            </tr>
                            <tr>
                                <td bgcolor="White" class="style17" colspan="2" 
                                    style="border-bottom-style: solid; border-bottom-width: 1px; border-top-color: #C0C0C0; border-right-style: solid; border-right-width: 1px; border-right-color: #C0C0C0;" 
                                    valign="top">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:HyperLink ID="HyperLink16" runat="server" Font-Bold="False" 
                                        Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="X-Small" 
                                        Font-Underline="True" ForeColor="Blue">Insert Special Character</asp:HyperLink>
                                    <br />
                                    <br />
                                    <asp:TextBox ID="key_Words" runat="server" Height="112px" TextMode="MultiLine" 
                                        Width="634px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </fieldset>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

