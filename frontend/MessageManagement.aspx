<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MessageManagement.aspx.cs" Inherits="MessageManagement" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <fieldset id="messege" runat="server" 
        style="background-color: #FBFBFB; height: 1352px; width: 858px;">
        <legend>Messege Manangment</legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <fieldset style="text-align: center">
            <asp:LinkButton ID="LinkButton7" runat="server" onclick="LinkButton7_Click">Add 
            Message</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click">Update 
            Message
            </asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton9_Click">Delete 
            Message</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </fieldset>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;
        <asp:Panel ID="Panel3" runat="server" Visible="False">
            <table class="">
                <tr>
                    <td class="">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblMessageNameSelect" runat="server" Text="Select Message Name"></asp:Label>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblMessageName" runat="server" Text="Message Name" 
                            Visible="False"></asp:Label>
                    </td>
                    <td>
                        &nbsp;<asp:DropDownList ID="Message_Name_Drp" runat="server" Height="16px" 
                            Width="227px">
                        </asp:DropDownList>
                        &nbsp;
                        <asp:TextBox ID="Messagename" runat="server" Visible="False" Width="233px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ControlToValidate="Messagename" ErrorMessage="Enter Message Name" 
                            ValidationGroup="update"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click">View 
                        Message</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Message address</td>
                    <td class="">
                        <asp:TextBox ID="TxtMessageAddress" runat="server" Height="29px" Width="457px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="TxtMessageAddress" ErrorMessage="Enter Message Address" 
                            ValidationGroup="update"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Content Message</td>
                    <td>
                        <asp:TextBox ID="txtmessagcontent" runat="server" Enabled="False" 
                            Height="141px" TextMode="MultiLine" Width="444px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="txtmessagcontent" ErrorMessage="Enter Content Message" 
                            ValidationGroup="update"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="">
                        &nbsp;</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="update" runat="server" BackColor="#CCCCCC" BorderColor="Black" 
                            Enabled="False" onclick="update_Click" Text="Update" ValidationGroup="update" 
                            Width="116px" />
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Visible="False" Width="841px">
            <table class="style1">
                <tr>
                    <td class="">
                        &nbsp; Select
                        <asp:Label ID="Label2" runat="server" Text="Message type"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="MessgTypeDrp" runat="server" Height="23px" 
                            ondatabound="MessgTypeDrp_DataBound" Width="223px">
                        </asp:DropDownList>
                        &nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Message Name</td>
                    <td>
                        &nbsp;<asp:TextBox ID="Message_Name" runat="server" Width="278px"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="Message_Name" ErrorMessage="Enter Message Name" 
                            ValidationGroup="add"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Message address</td>
                    <td class="style4">
                        <asp:TextBox ID="TxtMessageAddress0" runat="server" Height="29px" Width="457px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="TxtMessageAddress0" ErrorMessage="Enter Message Address" 
                            ValidationGroup="add"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Content Message</td>
                    <td>
                        <asp:TextBox ID="txtmessagcontent1" runat="server" Height="141px" 
                            TextMode="MultiLine" Width="444px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtmessagcontent1" ErrorMessage="Enter Content Address" 
                            ValidationGroup="add"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:Button ID="Add" runat="server" BackColor="#CCCCCC" BorderColor="Black" 
                            onclick="Button2_Click" Text="Add" ValidationGroup="add" Width="116px" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel2" runat="server" style="margin-left: 21px" Visible="False" 
            Width="819px">
            <table class="">
                <tr>
                    <td class="">
                        &nbsp;<asp:Label ID="lblMessageNameSelect0" runat="server" 
                            Text="Select Message Name"></asp:Label>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblMessageName0" runat="server" Text="Message Name" 
                            Visible="False"></asp:Label>
                    </td>
                    <td>
                        &nbsp;<asp:DropDownList ID="Message_Name_Drp0" runat="server" Height="16px" 
                            Width="227px">
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="Messagename0" runat="server" Visible="False" Width="233px"></asp:TextBox>
                        &nbsp;
                        <asp:LinkButton ID="LinkButton10" runat="server" onclick="LinkButton10_Click">View 
                        Message</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Message address</td>
                    <td class="">
                        <asp:TextBox ID="TxtMessageAddress1" runat="server" Height="29px" Width="457px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Content Message</td>
                    <td>
                        <asp:TextBox ID="txtmessagcontent2" runat="server" Height="141px" 
                            ReadOnly="True" TextMode="MultiLine" Width="444px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="">
                        &nbsp;</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="delete" runat="server" BackColor="#CCCCCC" BorderColor="Black" 
                            Enabled="False" onclick="delete_Click" Text="Delete" Width="116px" />
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    </fieldset>
</asp:Content>

