<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View Submission.aspx.cs" Inherits="View_Submission" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">



        .style1
        {
            
            
            border: 2px solid #FFCC66;
            background-color: #c0c0c0;
        }
        .style2
        {
            
            
            
            border: 2px solid #CCCCCC;
            background-color: #c0c0c0;
        }
        .style8
        {
            width: 88px;
        }
        .style9
        {
            width: 41px;
        }
        .style10
        {
            width: 48px;
        }
        .style11
        {
            width: 57px;
        }
        .style12
        {
            width: 77px;
        }
        .style13
        {
            width: 52px;
        }
        .style14
        {
            width: 89px;
        }
        .style4
        {
            height: 56px;
        }
        .style15
        {
            width: 75px;
            height: 56px;
        }
        .style18
        {
            width: 40px;
            height: 56px;
        }
        .style20
        {
            width: 41px;
            height: 56px;
        }
        .style16
        {
            width: 44px;
            height: 56px;
        }
        .style21
        {
            width: 57px;
            height: 56px;
        }
        .style17
        {
            width: 73px;
            height: 56px;
        }
        .style22
        {
            width: 48px;
            height: 56px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <br />
        <table align="center" cellpadding="4" cellspacing="4" class="style1" dir="ltr" 
            style="border-width: 1px 2px 2px 1px; border-color: #FFCC66; background-color: #FFFFFF" 
            width="98%">
            <tr>
                <td>
                    <fieldset id="field" runat="server" 
                        style="background-color: #F4F4F4; border: 1px hidden #CCCCCC; height: 334px; margin-top: 11px;">
                        <legend style="border: 1px solid #CCCCCC; color: #000000;">New Reviewer invitations 
                            for
                            <asp:Label ID="LblReviewerName" runat="server" style="font-weight: 700">استرجاع 
                            الاسم المراجع</asp:Label>
                        </legend>
                        <br />
                        <br />
                        <table align="center" cellpadding="8" cellspacing="0" class="style2" dir="ltr" 
                            style="border: 1px hidden #CCCCCC; background-color: #FFFFFF; height: 73px; width: 941px;">
                            <tr cellpadding="0">
                                <td class="">
                                    Action&gt;
                                </td>
                                <td class="">
                                    manuescript<br />
                                    number</td>
                                <td class="">
                                    article<br />
                                    type</td>
                                <td class="" 
                                    style="font-family: 'MS Reference Sans Serif'; font-size: x-small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                                    Article
                                    <br />
                                    title</td>
                                <td class="" 
                                    style="font-family: 'MS Reference Sans Serif'; font-size: x-small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                                    Status<br />
                                    Date</td>
                                <td class="" 
                                    style="font-family: 'MS Reference Sans Serif'; font-size: xx-small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                                    Current
                                    <br />
                                    Status</td>
                                <td class="" 
                                    style="font-family: 'MS Reference Sans Serif'; font-size: x-small; font-weight: 700; background-color: #3A5568; color: #E5E5E5;">
                                    Date Reviewer<br />
                                    Invited</td>
                                <td class="" 
                                    style="font-family: 'MS Reference Sans Serif'; font-size: x-small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                                    Days<br />
                                    ivitation<br />
                                    outstanding</td>
                                <td class="" 
                                    style="font-family: 'MS Reference Sans Serif'; font-size: x-small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                                    Editor&#39;s<br />
                                    name</td>
                                <td class="" 
                                    style="font-family: 'MS Reference Sans Serif'; font-size: x-small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                                    keyword</td>
                                <td class="" 
                                    style="font-family: 'MS Reference Sans Serif'; font-size: x-small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                                    clasclassification</td>
                            </tr>
                            <tr bgcolor="#9FBBCF">
                                <td class="" 
                                    style="border-style: none none none solid; border-width: 1px; border-color: #CCCCCC; font-family: 'MS Reference Sans Serif'; font-size: x-small">
                                    <asp:HyperLink ID="HyperLink6" runat="server" 
                                        style="font-weight: 700; text-decoration: underline; color: #0000CC">Action 
                                    Links</asp:HyperLink>
                                    <br />
                                </td>
                                <td class="" 
                                    style="border-style: none solid none solid; border-width: 1pt; border-color: #CCCCCC;">
                                </td>
                                <td class="" 
                                    style="border-style: hidden none hidden none; border-width: 2px; border-color: #CCCCCC">
                                </td>
                                <td class="" 
                                    style="border-style: none solid none solid; border-width: 1pt; border-color: #CCCCCC;">
                                </td>
                                <td class="" 
                                    style="border-style: hidden none hidden none; border-width: 2px; border-color: #CCCCCC">
                                </td>
                                <td class="" 
                                    style="border-style: none solid none solid; border-width: 1pt; border-color: #CCCCCC;">
                                </td>
                                <td class="" 
                                    style="border-style: hidden none hidden none; border-width: 2px; border-color: #CCCCCC">
                                </td>
                                <td class="" 
                                    style="border-style: none solid none solid; border-width: 1pt; border-color: #CCCCCC;">
                                </td>
                                <td class="" 
                                    style="border-style: hidden none hidden none; border-width: 2px; border-color: #CCCCCC">
                                </td>
                                <td class="" 
                                    style="border-style: none solid none solid; border-width: 1pt; border-color: #CCCCCC;">
                                </td>
                                <td class="" 
                                    style="border-style: none solid none none; border-width: 1pt; border-color: #CCCCCC">
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label2" runat="server" 
                            style="font-family: 'MS Reference Sans Serif'" Text="page :"></asp:Label>
                        <asp:Label ID="Label3" runat="server" Text="رقم الصفحه "></asp:Label>
                        <asp:Label ID="Label4" runat="server" Text="of"></asp:Label>
                        &nbsp;<asp:Label ID="Label5" runat="server" Text="عدد الصغحات الكليه "></asp:Label>
                        <asp:Label ID="Label6" runat="server" Text=")"></asp:Label>
                        <asp:Label ID="Label7" runat="server" Text="عدد المقالات في الصفحه "></asp:Label>
                        <asp:Label ID="Label8" runat="server" 
                            style="font-family: 'MS Reference Sans Serif'; font-size: small" 
                            Text="total submission "></asp:Label>
                        &nbsp;)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label10" runat="server" 
                            Text="&nbsp; Display"></asp:Label>
                        &nbsp;
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Selected="True">استرجاع</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;
                        <asp:Label ID="Label9" runat="server" Text="result per page . "></asp:Label>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:Button 
                            ID="Button1" runat="server" BackColor="#CCCCCC" BorderColor="#333333" 
                            style="font-weight: 700; font-family: 'MS Reference Sans Serif'" 
                            Text="&lt;&lt; Reviewer Main Menue" Width="269px" 
                            onclick="Button1_Click" />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                    </fieldset>&nbsp;<br />
                </td>
            </tr>
        </table>
        <br />
    </div>
</asp:Content>

