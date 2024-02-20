<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DetailForManuscriptNumber2.aspx.cs" Inherits="DetailForManuscriptNumber2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        
        .style1
        {
            
            margin-left: 0px;
        }
        .style25
        {            width: 857px;
            height: 36px;
        }
        
        .style4
        {            width: 765px;
        }
        .style42
        {
            height: 38px;
            width: 285px;
        }
        .style43
        {
            height: 38px;
            width: 483px;
        }
        .style39
        {
            width: 285px;
            height: 24px;
        }
        .style40
        {
            width: 483px;
            height: 24px;
        }
        .style41
        {
            height: 24px;
        }
        .style37
        {
            width: 285px;
            height: 25px;
        }
        .style38
        {
            width: 483px;
            height: 25px;
        }
        .style24
        {
            width: 285px;
        }
        .style20
        {
            width: 483px;
        }
        .style9
        {
            height: 19px;
            width: 285px;
        }
        .style22
        {
            height: 19px;
            width: 483px;
        }
        .style26
        {
            height: 21px;
        }
        .style10
        {
            height: 108px;
        }
        
        .style27
        {
            width: 142px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="border: 1px solid #CCCCCC; height: 1080px; margin-right: 0px;">
        &nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="#F2F2F2" Height="19px" 
            onclick="Button1_Click" Text="Cancel" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" BackColor="#F2F2F2" Height="19px" 
            onclick="Button2_Click" Text="Save And Close" />
        <br />
        <br />
        <br />
        <table cellpadding="0" cellspacing="0" class="style1" 
            style="border-style: groove;  border-width: thin;height: 40px; width: 864px;">
            <tr>
                <td align="left" class="style25" 
                    style="border-color: #C0C0C0; background-color: #F3F3F3; font-size: x-small; color: #0000FF; font-family: 'MS Reference Sans Serif';">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="True" 
                        NavigateUrl="~/View_Abstract.aspx">Abstract</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:HyperLink ID="HyperLink8" runat="server" Font-Underline="True">Production 
                    Notes</asp:HyperLink>
                    &nbsp; &nbsp;&nbsp;<asp:LinkButton ID="LinkBEditor" runat="server" onclick="LinkButton2_Click">Editors</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkBReviewer" runat="server" onclick="LinkButton1_Click">Reviewers</asp:LinkButton>
                    &nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink7" runat="server" Font-Underline="True">Reviewers 
                    Proposed by Editors</asp:HyperLink>
                    <br />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <table "groove" "MS Reference Sans Serif" "MS Reference Sans Serif" ;="" ;="" 
            ;="" align="center" bold;"="" border-style:="" cellpadding="0" cellspacing="0" 
            class="style4" font-family:="" font-family:="" font-weight:="" 
            style="border-style: groove; border-width: 1px; font-family: 'MS Reference Sans Serif'; font-weight: bold; font-size: small; height: 800px;">
            <tr style="background-color: #F2F2F2">
                <td class="style4" colspan="2" style="border-style: groove; border-width: 1px">
                </td>
            </tr>
            <tr style="border-style: solid; border-width: 1px">
                <td bgcolor="#F2F2F2" class="style42" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Corresponding Author:</td>
                <td class="style43" style="border-style: groove; border-width: 1px;" 
                    valign="top">
                    &nbsp;<asp:Label ID="corresponding_Author" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style39" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Corresponding Author E-Mail:</td>
                <td class="style40" style="border-style: groove; border-width: 1px">
                    <asp:Label ID="corresponding_Email" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style41" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp;Other Authors:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td bgcolor="#F2F2F2" class="style41" 
                    style="border-style: groove; border-width: 1px">
                    <asp:Label ID="other_Author" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style39" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Author Comments:</td>
                <td class="style40" style="border-style: groove; border-width: 1px">
                    <asp:Label ID="Auther_Comment" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style39" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp;Article Full Title &nbsp;</td>
                <td class="style40" style="border-style: groove; border-width: 1px">
                    <asp:Label ID="Article_Full_Title" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style39" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Short Title:</td>
                <td class="style40" style="border-style: groove; border-width: 1px">
                    <asp:Label ID="Short_Title" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style39" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Article Type:</td>
                <td class="style40" style="border-style: groove; border-width: 1px">
                    <asp:Label ID="Article_Type" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style37" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Section/Category:</td>
                <td class="style38" style="border-style: groove; border-width: 1px">
                    <asp:Label ID="Section_Category" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style39" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Keywords:</td>
                <td class="style40" style="border-style: groove; border-width: 1px">
                    <asp:Label ID="Article_keywords" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style39" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Classifications:</td>
                <td class="style40" style="border-style: groove; border-width: 1px">
                    <asp:Label ID="Article_Classifiction" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style39" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Requested Editor:</td>
                <td class="style40" style="border-style: groove; border-width: 1px">
                    <asp:Label ID="Request_Editor" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style39" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Initial Date Submitted:</td>
                <td class="style40" style="border-style: groove; border-width: 1px">
                    <asp:Label ID="Initial_Status_Date" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style39" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Editorial Status Date:</td>
                <td class="style40" style="border-style: groove; border-width: 1px">
                    <asp:Label ID="Status_Date" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style37" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Current Editorial Status:&nbsp;</td>
                <td class="style38" style="border-style: groove; border-width: 1px">
                    <asp:Label ID="Current_Status" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style24" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Author Days To Revise:</td>
                <td class="style20" style="border-style: groove; border-width: 1px">
                    &nbsp;<asp:TextBox ID="TxtAuthorDaysToRevise" runat="server" BorderColor="#F2F2F2" 
                        BorderStyle="Ridge" Height="24px" Width="240px"></asp:TextBox>
                    &nbsp;</td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style24" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Final Disposition Term:</td>
                <td class="style20" style="border-style: groove; border-width: 1px">
                    &nbsp;&nbsp;<asp:Label ID="Set_Final_Decision" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#F2F2F2" class="style9" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp; Corresponding Editor:</td>
                <td class="style22" style="border-style: groove; border-width: 1px">
                    <asp:DropDownList ID="DDlCorrespondingEditor" runat="server" Height="19px" 
                        Width="330px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr bgcolor="#F2F2F2">
                <td bgcolor="#F2F2F2" class="style26" colspan="2" 
                    style="border-style: groove; border-width: 1px">
                    &nbsp;<a runat="server" name="abstract">abstract</a> 
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink9" runat="server" Font-Bold="True" 
                        Font-Size="X-Small" Font-Underline="True" ForeColor="Blue">Top</asp:HyperLink>
                </td>
            </tr>
            <tr bgcolor="#F2F2F2">
                <td bgcolor="White" class="style10" colspan="2" 
                    style="border-style: groove; border-width: 1px" valign="top">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:HyperLink ID="HyperLink10" runat="server" 
                        Font-Bold="True" Font-Size="X-Small" Font-Underline="True" ForeColor="Blue">Insert 
                    Special Character</asp:HyperLink>
                    &nbsp;<asp:TextBox ID="Article_Abstract" runat="server" BorderStyle="Groove" 
                        Height="102px" style="margin-top: 0px" Width="932px"></asp:TextBox>
                    <br />
                    <a id="A1" runat="server" name="ManuscriptNotes">Manuscript Notes:</a><br />
                    <br />
                    &nbsp;<asp:TextBox ID="Article_Notes" runat="server" BorderStyle="Groove" 
                        Height="120px" style="margin-top: 0px" Width="928px"></asp:TextBox>
                    <br />
                    <table border="1" cellpadding="0" cellspacing="0" 
                        style="width: 839px; font-family: 'MS Reference Sans Serif'; font-size: x-small; font-weight: bold;">
                        <tr>
                            <td bgcolor="#F3F3F3" class="style27">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

