<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Thank you for Reviewing.aspx.cs" Inherits="Thank_you_for_Reviewing" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style1
        {
            width: 85%;
            border: 3px solid #FFCC66;
            background-color: #c0c0c0;
        }
        
        .style2
        {
            height: 104px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <br />
        <table align="center" bgcolor="White" cellpadding="4" cellspacing="4" 
            class="style1" dir="ltr" 
            style="border-left: 1px hidden #FFCC66; border-right: 2px hidden #FFCC66; border-top: 1px hidden #FFCC66; border-bottom: 2px hidden #FFCC66; background-color: #FFFFFF; height: 72px; ">
            <tr>
                <td class="style2" valign="top">
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label19" runat="server" 
                        style="font-weight: 700; font-family: 'MS Reference Sans Serif'; font-size: large" 
                        Text="Thank you fo reviewing Manuscript Number "></asp:Label>
                    &nbsp;
                    <asp:Label ID="Label20" runat="server" 
                        style="font-family: 'MS Reference Sans Serif'; font-size: large; font-weight: 700" 
                        Text="استرجاع التاريخ والاسم انضر الكتاب"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" 
                        runat="server" BackColor="#CCCCCC" BorderColor="#333333" 
                        onclick="Button1_Click" 
                        style="font-weight: 700; font-family: 'MS Reference Sans Serif'" 
                        Text="&lt;&lt; Reviewer Main Menue" Width="269px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
        </table>
        <br />
    </div>
</asp:Content>

