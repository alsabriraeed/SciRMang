<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UnassignReviewer.aspx.cs" Inherits="UnassignReviewer" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">




        .style25
        {
            width: 881px;
            height: 60px;
        }
        .style26
        {
            width: 261px;
        }
        .style29
        {
            width: 270px;
        }
        .style28
        {
            width: 123px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 686px; font-family: 'MS Reference Sans Serif'; font-weight: normal; font-size: x-small; width: 953px;">
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Small" 
            Text="Unassign Reviewer"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<br />
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <fieldset style="border: 1px solid #000000; height: 98px; background-color: #F2F2F2; width: 904px;">
            <legend align="top" 
                style="border-style: solid; border-width: 1px;  font-size: small; font-weight: bold;">
                Editor&nbsp; UNAssigned</legend>
            <table cellpadding="0" cellspacing="0" class="style25" 
                style="border-style: solid; border-width: 1px; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: bold;">
                <tr bgcolor="#00008F" 
                    style="border-style: solid; border-width: 1px; color: #FFFFFF;">
                    <td align="left" class="style26" style="border-style: solid; border-width: 1px">
                        Name</td>
                    <td align="left" class="style29" style="border-style: solid; border-width: 1px">
                        Letter</td>
                    <td class="style28" style="border-style: solid; border-width: 1px">
                        &nbsp;</td>
                    <td align="left" style="border-style: solid; border-width: 1px">
                        Do Not Send Letter</td>
                </tr>
                <tr>
                    <td align="left" class="style26" style="border-style: solid; border-width: 1px">
                        <asp:LinkButton ID="Editor_Name" runat="server">LinkButton</asp:LinkButton>
                    </td>
                    <td align="center" class="style29" 
                        style="border-style: solid; border-width: 1px">
                        <asp:DropDownList ID="dropAssignEditor" runat="server" Height="19px" 
                            Width="262px">
                            <asp:ListItem>Assign Editor</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td align="left" class="style28" style="border-style: solid; border-width: 1px">
                        <asp:LinkButton ID="Customize" runat="server" onclick="Customize_Click">Customize</asp:LinkButton>
                    </td>
                    <td align="center" style="border-style: solid; border-width: 1px">
                        <asp:CheckBox ID="Not_Send_Letter" runat="server" Text=" " />
                    </td>
                </tr>
            </table>
        </fieldset><br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="CmdClose" runat="server" BackColor="#F2F2F2" Height="23px" 
            Text="Cancel" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="CmdClose0" runat="server" BackColor="#F2F2F2" Height="23px" 
            onclick="CmdClose0_Click" Text="Confirm Selection and Send Letters" 
            Width="234px" />
    </div>
</asp:Content>

