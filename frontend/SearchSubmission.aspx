<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SearchSubmission.aspx.cs" Inherits="SearchSubmission" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style3
        {
            width: 84%;
          
            border-style: solid;
            border-width: 1px;
            margin-left: 53px;
        }
        .style4
        {
            width: 621px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="left" dir="ltr" 
        style="border: thin groove #000000; height: ; font-family: 'MS Reference Sans Serif'; font-weight: lighter; font-size: small;   margin-left: 0px; clip: rect(auto, auto, auto, auto); width: 871px;">
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Search submissions 
        selection criteria<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table cellpadding="0" cellspacing="0" class="">
            <tr>
                <td class="style4" style="font-size: x-small">
                    &nbsp;&nbsp;&nbsp; Create a new Search definition or choose existing Search definition to Run, 
                    Edit, or Remove. You may refine
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Your criteria further on the
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="True" 
                        ForeColor="Blue">Advanced criteria</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
        </table>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Search Definition"></asp:Label>
        &nbsp;:
        <asp:DropDownList ID="DDLSearchDefination" runat="server" Height="16px" 
            Width="160px">
            <asp:ListItem>Choose Saved Search</asp:ListItem>
        </asp:DropDownList>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="#F2F2F2" 
            Text="Remove Search Definition" Width="160px" />
        &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" BackColor="#F2F2F2" 
            Text="Edit Selected Search Definition" Width="184px" />
        &nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" BackColor="#F2F2F2" 
            Text="Run Selected Search Definition" Width="188px" />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" BackColor="#F2F2F2" Height="">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" Font-Underline="True" 
                ForeColor="Blue">Help With Searching</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" Font-Underline="True" 
                ForeColor="Blue">Insert Social Character</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink4" runat="server" Font-Underline="True" 
                ForeColor="Blue">Value Options</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink5" runat="server" Font-Underline="True" 
                ForeColor="Blue">Advanced Criteria</asp:HyperLink>
            <br />
            &nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <fieldset style="height: ; width: 865px">
                &nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <fieldset style="height: ; width: 754px; margin-right: 0px; background-color: #FFFFFF;">
                    <hr style="border-style: none; height: " />
                    <table border="1" cellpadding="0" cellspacing="0" class="" 
                        style="border-style: none none groove none; border-bottom-color: #000000;">
                        <tr bgcolor="#00008C" 
                            style="border-style: none groove none none; border-width: thin; color: #FFFFFF; font-weight: bold;">
                            <td class="" 
                                style="border-style: none groove none none; border-width: thin; color: #FFFFFF;">
                                &nbsp;&nbsp; (&nbsp;</td>
                            <td class="" 
                                style="border-width: thin; border-style: none groove none none;">
                                Criterion</td>
                            <td class="" 
                                style="border-width: thin; border-style: none groove none none;">
                                Is/Is not</td>
                            <td class="" 
                                style="border-style: none groove none none; border-top-width: thin;">
                                Selector</td>
                            <td class="" 
                                style="border-width: thin; border-style: none groove none none;">
                                Value</td>
                            <td class="" 
                                style="border-width: thin; border-style: none groove none none;">
                            </td>
                            <td class="" 
                                style="border-width: thin; border-style: none groove none none;">
                                &nbsp; )&nbsp;</td>
                            <td class="" 
                                style="border-width: thin; border-style: none groove none none;">
                            </td>
                            <td class="" 
                                style="border-style: none groove none none; border-width: thin">
                            </td>
                        </tr>
                        <tr>
                            <td class="" style="border-style: none; border-top-color: #FFFFFF">
                                <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="42px">
                                </asp:DropDownList>
                            </td>
                            <td class="" style="border-style: none">
                                <asp:DropDownList ID="DDLCriterion" runat="server" Height="22px" Width="200px">
                                </asp:DropDownList>
                            </td>
                            <td class="" style="border-style: none">
                                <asp:DropDownList ID="DDLISIsnot" runat="server" Height="16px" Width="54px">
                                </asp:DropDownList>
                            </td>
                            <td class="" style="border-style: none">
                                <asp:DropDownList ID="DDLSelector" runat="server" Height="16px" Width="138px">
                                </asp:DropDownList>
                            </td>
                            <td class="" style="border-style: none;">
                                <asp:TextBox ID="TxtValue" runat="server" BorderStyle="Groove" 
                                    style="margin-left: 9px" Width="156px"></asp:TextBox>
                            </td>
                            <td class="" style="border-style: none">
                                &nbsp;</td>
                            <td class="" style="border-style: none">
                                <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="42px">
                                </asp:DropDownList>
                            </td>
                            <td style="border-style: none">
                                &nbsp;</td>
                            <td style="border-style: none">
                                &nbsp;</td>
                        </tr>
                    </table>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" Height="21px" Text="Add" Width="34px" />
                    &nbsp;<hr style="height: " />
                </fieldset> &nbsp;
            </fieldset><table cellpadding="0" cellspacing="0" class="">
            </table>
        </asp:Panel>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" BackColor="#F2F2F2" Height="19px" 
            Text="Clear" />
        &nbsp;
        <asp:Button ID="Button6" runat="server" BackColor="#F2F2F2" Height="19px" 
            Text="Search" />
    </div>
</asp:Content>

