<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="registerRev.aspx.cs" Inherits="registerRev" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style1
        {
            width: 90%;
            height: 30%;
            border: 5px solid #ffffff;
            background-color: #ffffff;
        }
        .style3
        {
            height: 196px;
            width: 218px;
        }
        .style2
        {
            height: 196px;
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
        style="border-style: hidden; border-width: 1px 2px 2px 1px; border-color: #FFCC66; padding: 2px; margin: auto;">
        <tr>
            <td class="style3" dir="ltr" 
                style="border-width: 0px 2px 0px 0px; font-weight: bold; border-right-color: #CCCCCC; border-right-style: dotted;" 
                valign="top">
                LOG-IN</td>
            <td class="style2" style="border-style: none; border-width: 0px" valign="top">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Italic="False" Font-Overline="False" 
                    Font-Underline="True" Text=" Insert special character"></asp:Label>
                &nbsp;<fieldset id="field1" runat="server" 
                    style="border: 1px hidden #CCCCCC; background-color: #9999FF; margin-left: 19px; right: auto; width: 637px; height: auto; left: auto; position: inherit; z-index: auto;">
                    <legend style="border-style: groove; background-color: #FFFFFF;">Pleas Enter the 
                        following&nbsp;&nbsp;&nbsp; </legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; User name :<asp:TextBox 
                        ID="username" runat="server" Width="211px"></asp:TextBox>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password&nbsp; :<asp:TextBox ID="password" 
                        runat="server" style="margin-right: 0px" Width="211px"></asp:TextBox>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:Button ID="cmdAutheLlogin" runat="server" BackColor="#CCCCCC" 
                        BorderColor="Black" Text="Auther Login " Width="94px" />
                    &nbsp;&nbsp;
                    <asp:Button ID="cmdReviewerogin" runat="server" BackColor="#CCCCCC" 
                        BorderColor="Black" Text="Reviewer Login" Width="92px" />
                    &nbsp;
                    <asp:Button ID="cmdEditorLogin" runat="server" BackColor="#CCCCCC" 
                        BorderColor="Black" Text="Editor Login " Width="103px" />
                    &nbsp;
                    <asp:Button ID="cmdPublisheLogin" runat="server" BackColor="#CCCCCC" 
                        BorderColor="Black" Text="Publisher Login " Width="104px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="True" 
                        ForeColor="#0033CC">Send User name / Password
                    </asp:HyperLink>
                    &nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink2" runat="server" Font-Underline="True" 
                        ForeColor="#0033CC">Register New
                    </asp:HyperLink>
                    &nbsp;
                    <asp:HyperLink ID="HyperLink3" runat="server" Font-Underline="True" 
                        ForeColor="#0033CC">Login Help
                    </asp:HyperLink>
                    <br />
                </fieldset>
            </td>
        </tr>
    </table>
</asp:Content>

