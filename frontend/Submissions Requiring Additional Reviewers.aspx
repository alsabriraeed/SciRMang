<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Submissions Requiring Additional Reviewers.aspx.cs" Inherits="Submissions_Requiring_Additional_Reviewers" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">




        .style2
        {
             
            border: 2px solid #CCCCCC;
            background-color: #c0c0c0;
        }
        .style24
        {
            width: 274px;
            height: 57px;
        }
        .style25
        {
            width: 107px;
            height: 57px;
        }
        .style28
        {
            width: 283px;
            height: 57px;
        }
        .style8
        {
            width: 88px;
            height: 57px;
        }
        .style27
        {
            width: 185px;
            height: 57px;
        }
        .style23
        {
            width: 274px;
        }
        .style29
        {
            width: 283px;
        }
        .style22
        {
            width: 185px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="border: 1pt solid #000000;  font-family: 'MS Reference Sans Serif'; ">
        <fieldset style="border-style: solid; border-color: #CCCCCC; width: 980px; height: 321px; margin-left: 15px; font-size: small; color: #000066; background-color: #EAEAEA; border-top-width: 1pt;">
            <legend style="border: 1pt solid #C0C0C0; color: #000066; font-size: medium; background-color: #FFFFFF; font-weight: bold;">
                Submission Requering Additional Reviewers -(------)Editor&nbsp; </legend>
            <br />
            &nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" 
                ForeColor="#000099" Text="Contents:"></asp:Label>
            &nbsp;<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Page:"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="......."></asp:Label>
            Of
            <asp:Label ID="Label4" runat="server" Text="......."></asp:Label>
            (<asp:Label ID="Label5" runat="server" Text="......"></asp:Label>
            &nbsp;total submissions)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dispaly
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="  ">10</asp:ListItem>
                <asp:ListItem>
                </asp:ListItem>
            </asp:DropDownList>
            result per page.<br />
            &nbsp;&nbsp;&nbsp;
            <table align="center" cellpadding="8" cellspacing="0" class="style2" dir="ltr" 
                style="border-style: none solid none solid; border-width: 1pt; border-color: #808080; background-color: #FFFFFF; height: 310px; width: 95%;" 
                width="95%">
                <tr cellpadding="0" style="font-size: small">
                    <td class="style24" 
                        style="font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                        Action
                    </td>
                    <td class="style25" 
                        style="border-style: none solid none solid; border-color: #808080; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF; border-right-width: 1pt; border-left-width: 1pt;" 
                        valign="baseline">
                        Manuscript Number<br />
                    </td>
                    <td class="style28" 
                        style="font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                        &nbsp;Artical<br />
                        Type</td>
                    <td class="style8" 
                        style="border-style: none solid none solid; border-color: #808080; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF; border-right-width: 1pt; border-left-width: 1pt;">
                        Article
                        <br />
                        Title</td>
                    <td class="style27" 
                        style="border-style: none solid none solid; border-color: #808080; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF; border-right-width: 1pt; border-left-width: 1pt;">
                        Author Name
                        <br />
                    </td>
                    <td class="style27" 
                        style="font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                        Review<br />
                        Request<br />
                        Date</td>
                    <td id="o" class="style27" 
                        style="border-style: none solid none solid; border-color: #808080; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF; border-right-width: 1pt; border-left-width: 1pt;">
                        Status Date<br />
                    </td>
                    <td class="style27" 
                        style="font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                        Current status</td>
                    <td class="style27" 
                        style="border-style: none solid none solid; border-color: #808080; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF; border-right-width: 1pt; border-left-width: 1pt;">
                        Reviewer Name</td>
                </tr>
                <tr>
                    <td class="style23" 
                        style="border-style: none solid solid none; border-width: 1pt; border-color: #808080; font-family: 'MS Reference Sans Serif'; font-size: x-small" 
                        valign="top">
                        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="False" 
                            Font-Size="Small" ForeColor="#000099" 
                            style="text-decoration: underline; color: #0000CC">View Submation</asp:HyperLink>
                        <br />
                        <asp:HyperLink ID="HyperLink17" runat="server" Font-Bold="False" 
                            Font-Size="Small" ForeColor="#000099" 
                            style="text-decoration: underline; color: #0000CC">Details</asp:HyperLink>
                        <br />
                        <asp:HyperLink ID="HyperLink18" runat="server" Font-Bold="False" 
                            Font-Size="Small" ForeColor="#000099" 
                            style="text-decoration: underline; color: #0000CC">History</asp:HyperLink>
                        <br />
                        <asp:HyperLink ID="HyperLink4" runat="server" Font-Size="Small" 
                            Font-Underline="True" ForeColor="#0000CC" NavigateUrl="~/FileInventory.aspx">File 
                        Inventory</asp:HyperLink>
                        <br />
                        <asp:HyperLink ID="HyperLink10" runat="server" Font-Underline="True" 
                            ForeColor="Blue" NavigateUrl="~/EditSubmition.aspx">Edit Submission</asp:HyperLink>
                        <br />
                        <asp:HyperLink ID="HyperLink11" runat="server" Font-Bold="False" 
                            Font-Size="Small" Font-Underline="True" ForeColor="#0000CC" 
                            NavigateUrl="~/SendAdHocEmail.aspx">Send E-mail</asp:HyperLink>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="style6">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td class="style29" 
                        style="border-style: none none solid none; border-width: 2px 1pt 1pt 2px; border-color: #CCCCCC #CCCCCC #999999 #CCCCCC">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td style="border-style: none none solid solid; border-width: 1pt; border-color: #808080;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td class="style22" 
                        style="border-style: none solid solid solid; border-width: 1px; border-color: #808080;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="style22" 
                        style="border-style: none solid solid none; border-width: 1pt; border-color: #808080;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td class="style22" 
                        style="border-style: none solid solid none; border-width: 2px 1pt 1pt 1pt; border-color: #808080;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td class="style22" 
                        style="border-style: none solid solid none; border-width: 1pt; border-color: #808080;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td class="style22" 
                        style="border-style: none solid solid none; border-width: 1pt; border-color: #808080;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
        </fieldset><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink14" runat="server" Font-Bold="True" 
            Font-Underline="True" ForeColor="#0000CC">Editor Main Menu</asp:HyperLink>
        <br />
        &nbsp;
        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Medium" 
            ForeColor="Black" 
            Text="You should use the free Adobe Acrobat Reader 6 or later for best PDF Viewing  Results"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    </div>
</asp:Content>

