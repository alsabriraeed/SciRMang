<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Create a New Group.aspx.cs" Inherits="Create_a_New_Group" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">




        .style1
        {
            width: 820px;
            height: 559px;
        }
        .style2
        {
            width: 77%;
            margin-left: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="margin-right: 10%; margin-left: 10%">
        <tr>
            <td class="style1" 
                style="border: 1pt solid #000000; font-family: 'MS Reference Sans Serif'; font-weight: bold; font-size: small; color: #000066;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    ForeColor="#000066" Text=" create a new Linked Submission Group"></asp:Label>
                <br />
                <br />
                <fieldset style="height: 139px; background-color: #E6E6E6; margin-left: 15px; margin-right: 15px; width: 1109px;">
                    <legend style="border: thin solid #C0C0C0; background-color: #FFFFFF; font-weight: bold; color: #000066; font-size: medium;">
                        To create a new Linked Submission Group</legend>&nbsp;&nbsp;<br />
                    &nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="Please enter a Linked Submission Group Name(limit of 1000 characters) and selected a Linked Submission Group
&lt;br /&gt;&nbsp;&nbsp;Type."></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="Black" Text="Linked With Group:"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Font-Size="Medium" Text=" Ageneral group suitable for linking submission together for a wide variety of uses(e.g,
&lt;br /&gt;&nbsp;&nbsp;submissions by the same Author or submissions based on a similar topic.)"></asp:Label>
                    <br />
                    &nbsp;&nbsp;
                    <br />
                    &nbsp;
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="Black" Text="Letter to the Editor Group:"></asp:Label>
                    <asp:Label ID="Label6" runat="server" Font-Size="Medium" Text=" A 'speciality'group where Invited Authors may be proveded PDF access to other
&lt;br /&gt;&nbsp;linked submissions that belong to the group when they are solicited for a commentary.Note: A submission can 
&lt;br /&gt;&nbsp;only belong to one Letter to the Editor Group."></asp:Label>
                    <br />
                    &nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;
                    <asp:Label ID="Label7" runat="server" Font-Size="Medium" 
                        Text="Once the new Linked Submission Group has been created,it is selected by default in the drop-down on the Add
&lt;br /&gt;&nbsp;&nbsp;to/Create Linked Submision Group page.Clicking the 'Add to Group'button on the Add to/Create Linked 
&lt;br /&gt;&nbsp;&nbsp;Submission Group page will then add the submision to the newly created group."></asp:Label>
                    <br />
                    &nbsp;
                    <br />
                    &nbsp;<br />
                    <table class="style2" 
                        style="border: 1pt solid #CCCCCC; width: 97%; margin-right: 5px; margin-left: 5px;">
                        <tr>
                            <td style="margin: 2px; background-color: #FFFFFF; width: 30%; padding-top: 6px;" 
                                width="30%">
                                &nbsp;&nbsp;
                                <asp:Label ID="Label8" runat="server" Font-Size="Medium" 
                                    Text="Linked Submision Group Name:"></asp:Label>
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <br />
                            </td>
                            <td style="margin: 0px; background-color: #FFFFFF">
                                <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Medium" 
                                    Font-Underline="True" ForeColor="#3333CC">Insert Special Character</asp:HyperLink>
                                <br />
                                <asp:TextBox ID="Group_Name" runat="server" Width="400px"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label ID="Label9" runat="server" Font-Italic="True" Font-Size="Medium" 
                                    Text="Maximum Linked Submission Group Name is 1000 characters."></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="margin: 4px; background-color: #FFFFFF; width: 30%;" width="30%">
                                <br />
                                <asp:Label ID="Label10" runat="server" Font-Size="Medium" 
                                    Text="Linked Submision Group Type:"></asp:Label>
                                <br />
                            </td>
                            <td style="background-color: #FFFFFF">
                                <input id="Radio1" checked="checked" name="R1" type="radio" value="V1" /><asp:Label 
                                    ID="Label11" runat="server" Font-Size="Medium" Text="Linked With"></asp:Label>
                                <br />
                                <input id="Radio2" checked="checked" name="R2" type="radio" value="V1" /><asp:Label 
                                    ID="Label12" runat="server" Font-Size="Medium" Text="Letter To the Editor"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    <br />
                </fieldset><br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Font-Bold="True" Text="Cancel" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Font-Bold="True" 
                    onclick="Button2_Click" Text="Submit" />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

