﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Decline review confirmation.aspx.cs" Inherits="Decline_review_confirmation" Title="Untitled Page" %>

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
           
            width: 241px;
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
                    <span class="style6">DECLINE REVIEW CONFIRMATION</span>
                </td>
                <td class="style2" style="border-style: none" valign="top">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;<fieldset id="field1" runat="server" 
                        style="border: 1px hidden #CCCCCC; background-color: #FFFFFF; margin-left: 19px; right: auto; width: 678px; height: 175px; left: auto; position: inherit; z-index: auto;">
                        &nbsp;&nbsp;<br />
                        <hr noshade="noshade" style="height: 2px; width: 90%; color: #FF0000" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" BackColor="#F4F4F4" 
                            style="margin-left: 7px; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700;" 
                            Text="Thank you for  considering the ivitation to review manuscript " 
                            Width="69%"></asp:Label>
                        &nbsp;<asp:Label ID="DECLINE_DATE" runat="server" BackColor="#F4F4F4" 
                            style="font-weight: 700"></asp:Label>
                        &nbsp;<asp:Label ID="Label4" runat="server" Text="."></asp:Label>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label5" runat="server" BackColor="#F4F4F4" Height="19px" 
                            style="font-family: 'MS Reference Sans Serif'; font-size: small; margin-top: 0px;" 
                            Text="you decision to decline has been forworded to the juornal " Width="88%"></asp:Label>
                        <br />
                        <hr noshade="noshade" style="height: 2px; width: 90%; color: #FF0000" />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="HyperLink2" runat="server" 
                            NavigateUrl="~/Reviewer Main Menue.aspx" 
                            style="text-decoration: underline; color: #0000CC">Return to main menue
                        </asp:HyperLink>
                        <br />
                    </fieldset>
                </td>
            </tr>
        </table>
        <br />
    </div>
</asp:Content>
