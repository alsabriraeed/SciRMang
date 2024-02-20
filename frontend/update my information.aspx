<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="update my information.aspx.cs" Inherits="update_my_information" Title="Untitled Page" %>

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
            height: 383px;
            width: 25%;
        }
        .style2
        {
            height: 383px;
        width: 75%;
        }
        #field1
        {
            height: 73px;
        }
        .style4
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000099;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 470px">
        <br />
        <table align="center" bgcolor="White" border="4" cellpadding="4" 
            cellspacing="4" class="style1" dir="ltr" 
            style="border-style: hidden; border-width: 1px 2px 2px 1px; border-color: #FFCC66; padding: 2px; margin: auto;">
            <tr>
                <td class="style3" dir="ltr" 
                    style="border-color: #FFFFFF #CCCCCC #FFFFFF #FFFFFF; border-width: 0px 2px 0px 0px; border-style: none dotted none none; font-weight: bold" 
                    valign="top">
                    <span class="style5">UPDATE MY </span>
                    <br class="style5" />
                    <span class="style5">INFORMATOIN</span><br class="style5" />
                    <br />
                    <br />
                    <br />
                    <span class="style7"><span class="style6">To update&nbsp; any information,
                    <br />
                    make the changes&nbsp; on the form and click update . required fields have an 
                    asterisk next to the lable<br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    </span></span>
                </td>
                <td class="style2" style="border-style: none; border-width: 0px" valign="top">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;&nbsp;
                    <asp:Label ID="Label12" runat="server" style="text-decoration: underline" 
                        Text="insert special character "></asp:Label>
                    &nbsp;&nbsp;<fieldset id="field1" runat="server" 
                        style="border: 1px hidden #CCCCCC; background-color: #F4F4F4; margin-left: 19px; right: auto; width: 637px; height: 268px; left: auto; position: inherit; z-index: auto;">
                        <legend style="border-style: groove">&nbsp;Login information &nbsp;</legend>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label9" runat="server" BorderColor="#E6E6E3" Height="63px" 
                            style="font-family: Arial, Helvetica, sans-serif; font-size: small" Text="the user name you choose must be unique within the system .
&nbsp;&nbsp;If the one you choose is already in use , yuo will     be   asket for another .
" Width="350px"></asp:Label>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="#FF3300" 
                            style="font-family: Arial, Helvetica, sans-serif; font-size: small" 
                            Text="User Name *:"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TxtUserName" runat="server" Width="267px"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#FF3300" 
                            style="font-family: Arial, Helvetica, sans-serif; font-size: small" 
                            Text="Password  *: "></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TxtPassword" runat="server" style="margin-right: 0px" 
                            Width="265px"></asp:TextBox>
                        &nbsp;<br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label10" runat="server" Height="75px" 
                            Text="The defult login role is the user role that will be used if you  strik that will&nbsp; be used if you strik&nbsp; the enter key when logging   in and you have not made a specific selection ." 
                            Width="371px"></asp:Label>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label8" runat="server" 
                            style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #000099" 
                            Text="&nbsp;Defulte  login  Role : "></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="DDlDefulteLoginRole" runat="server" AutoPostBack="True" 
                            Height="16px" Width="113px">
                            <asp:ListItem Selected="True">Auther</asp:ListItem>
                            <asp:ListItem>Reviewer</asp:ListItem>
                            <asp:ListItem>Editor</asp:ListItem>
                            <asp:ListItem>Publisher</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="cmdSubmit" runat="server" BackColor="#CCCCCC" 
                            BorderColor="Black" onclick="cmdSubmit_Click" Text="Submit" Width="93px" />
                        <br />
                        &nbsp;
                        <br />
                    </fieldset>
                </td>
            </tr>
        </table>
        <span class="style4">
        <br />
    </div>
    </span>
</asp:Content>

