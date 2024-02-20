<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="errorlogin.aspx.cs" Inherits="errorlogin" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">



        .style1
        {
            width: 90%;
            height: 241px;
            border: 5px solid #ffffff;
            background-color: #ffffff;
        }
        .style3
        {
            height: 231px;
            width: 181px;
        }
        #field2
        {
            height: 123px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        `&nbsp;<table align="center" bgcolor="White" border="4" cellpadding="4" 
            cellspacing="4" class="" dir="ltr" 
            style="border-style: hidden; border-width: 1px 2px 2px 1px; border-color: #FFCC66; padding: 2px; margin: auto;">
            <tr>
                <td class="style3" dir="ltr" 
                    style="border-style: none dotted none none; border-width: 0px 3px 0px 0px; font-weight: bold; border-right-color: #CCCCCC;" 
                    valign="top">
                    &nbsp;LOG-IN ERROR&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td class="" valign="top">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True" 
                        Font-Italic="False" Font-Overline="False" Font-Underline="False" 
                        ForeColor="Red" Text="you do not have rewiewer privilleges on this journal ."></asp:Label>
                    &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label6" runat="server" Font-Italic="False" Font-Overline="False" 
                        Font-Underline="False" 
                        Text="please re-enter your password and select  on of the login option below ."></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Font-Italic="False" Font-Overline="False" 
                        Font-Underline="True" Text=" Insert special character"></asp:Label>
                    &nbsp;<fieldset id="field2" runat="server" 
                        style="border: 1px hidden #CCCCCC; background-color: #9999FF; margin-left: 23px; right: inherit; width: 623px;">
                        <legend style="border-style: groove; background-color: #FFFFFF;">pleas Enter the 
                            following&nbsp;&nbsp;&nbsp; </legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        Password&nbsp; :<asp:TextBox ID="password0" runat="server" 
                            style="margin-right: 0px" Width="224px"></asp:TextBox>
                        <br />
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="cmdCancel" runat="server" BackColor="#CCCCCC" 
                            BorderColor="Black" Text="Cancel " />
&nbsp;&nbsp;
                        <asp:Button ID="cmdLoginAsAuther" runat="server" BackColor="#CCCCCC" 
                            BorderColor="Black" Text=" Login As Auther" Width="112px" />
&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="cmdLoginAsEditor" runat="server" BackColor="#CCCCCC" 
                            BorderColor="Black" Text="Login As Editor " Width="101px" />
&nbsp;
                        <asp:Button ID="cmdLoginAsPublisher" runat="server" BackColor="#CCCCCC" 
                            BorderColor="Black" Text=" Login  As Publisher" Width="140px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </fieldset>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>

