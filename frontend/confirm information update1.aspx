<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="confirm information update1.aspx.cs" Inherits="confirm_information_update1" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style1
        {
            width: 90%;
            height: 375px;
            border: 5px solid #ffffff;
            background-color: #ffffff;
        }
        .style3
        {
            height: 437px;
            width: 169px;
        }
        .style2
        {
            height: 437px;
        }
        #field1
        {
            height: 73px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" bgcolor="White" border="4" cellpadding="4" 
        cellspacing="4" class="style1" dir="ltr" 
        style="border-color: #FFCC66; border-width: 1px 2px 2px 2px; padding: 2px; margin: auto;">
        <tr>
            <td class="style3" dir="ltr" 
                style="border-style: none dashed none none; border-width: 0px 3px 0px 0px; font-weight: bold; border-right-color: #CCCCCC;" 
                valign="top">
                <br />
                <br class="style5" />
                <span class="style5">CONFIRM INFORMATION </span>
                <br class="style5" />
                <span class="style5">UPDATE </span>
            </td>
            <td class="style2" style="border-style: none" valign="top">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Italic="False" Font-Overline="False" 
                    Font-Underline="True" Text=" Insert special character"></asp:Label>
                &nbsp;<fieldset id="field1" runat="server" 
                    style="border-style: hidden; border-color: #CCCCCC; border-width: 1px; background-color: #F4F4F4; margin-left: 19px; right: auto; width: 678px; height: 268px; left: auto; position: inherit; z-index: auto;">
                    <legend style="border-style: groove">&nbsp;Required information &nbsp;</legend>&nbsp;&nbsp;<br />
                    <br />
                    <hr noshade="noshade" style="height: 2px; width: 90%; color: #FF0000" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Height="64px" style="margin-left: 31px" 
                        Text="one or more required fields are not  filled in , if you wish to enter the missing  information  ,click'privious page ' to go to the previous page or you may click 'Continoue' to submit the changes you did make and proceed." 
                        Width="90%"></asp:Label>
                    <br />
                    &nbsp;&nbsp;
                    <br />
                    <hr noshade="noshade" style="height: 2px; width: 90%; color: #FF0000" />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="cmdPreviousPage" runat="server" BackColor="#CCCCCC" 
                        BorderColor="Black" Font-Bold="True" Text="&lt;&lt; Previous Page" 
                        Width="198px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="cmdContinoue" runat="server" BackColor="#CCCCCC" 
                        BorderColor="Black" Text="Continoue" Width="114px" />
                </fieldset>
            </td>
        </tr>
    </table>
</asp:Content>

