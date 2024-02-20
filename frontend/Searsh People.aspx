<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Searsh People.aspx.cs" Inherits="Searsh_People" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="User_Name" runat="server" Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" BackColor="#E9E9E9" BorderStyle="Groove" 
        Font-Names="MS Reference Sans Serif" Font-Size="Small" 
        style="text-align: center" 
        Text="Choose the Criterion For Selecting People Records" Width="545px"></asp:Label>
    <asp:Panel ID="Panel4" runat="server" style="margin-left: 68px" Width="90%">
        <table align="center" style="width: 648px; margin-left: 0px">
            <tr>
                <td align="left" style="border: 1px solid #000000; background-color: #EAEAEA;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; search people<br />
                    &nbsp;&nbsp;&nbsp; Creterion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Selector&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Value&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    User Role<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDcreteria" runat="server">
                        <asp:ListItem>Last name</asp:ListItem>
                        <asp:ListItem>degree</asp:ListItem>
                        <asp:ListItem>Country</asp:ListItem>
                        <asp:ListItem>Prefereed Name</asp:ListItem>
                        <asp:ListItem Value="Classifications"></asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:DropDownList ID="Selectordropdown" runat="server">
                        <asp:ListItem>Begins with</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="VuleSearch" runat="server" MaxLength="20"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:DropDownList ID="ddownRole" runat="server" Width="176px">
                        <asp:ListItem>All</asp:ListItem>
                        <asp:ListItem>Editor</asp:ListItem>
                        <asp:ListItem>Reviewer</asp:ListItem>
                        <asp:ListItem>Author</asp:ListItem>
                        <asp:ListItem Value="Candidate Reviewers">Candidate Reviewers</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Text="Clear" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Search" />
                    <br />
                </td>
            </tr>
        </table>
        <br />
        <br />
    </asp:Panel>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Current_Page" runat="server" Text="......."></asp:Label>
    &nbsp;of
    <asp:Label ID="Pages_Number" runat="server" Text="......."></asp:Label>
    (<asp:Label ID="Total_Submission" runat="server" Text="......"></asp:Label>
    &nbsp;Total Result)<br />
    <asp:GridView ID="db_AllsubmissionDecision" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
        BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
        Height="186px" onpageindexchanged="db_AllsubmissionDecision_PageIndexChanged" 
        onpageindexchanging="db_AllsubmissionDecision_PageIndexChanging" 
        onrowcommand="db_AllsubmissionDecision_RowCommand" 
        onselectedindexchanged="db_AllsubmissionDecision_SelectedIndexChanged" 
        onsorting="db_AllsubmissionDecision_Sorting" PageSize="1" Width="1185px">
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <Columns>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:LinkButton ID="Permission_Editor" runat="server" 
                        CommandArgument=' <%#Eval("User_No")%>' CommandName="Permission_Editor" 
                        PostBackUrl="" Text="Permission Editor" />
                    <br />
                    <asp:LinkButton ID="Reviewer_Permissions" runat="server" 
                        CommandArgument=' <%#Eval("User_No")%>' CommandName="Reviewer_Permissions" 
                        PostBackUrl="" Text="Reviewer Permissions" />
                    <br />
                    <asp:LinkButton ID="Update_Role" runat="server" 
                        CommandArgument=' <%#Eval("User_No")%>' CommandName="Update_Role" 
                        PostBackUrl="" Text="Role Update" />
                    <br />
                    <asp:LinkButton ID="Manager_Permissions" runat="server" 
                        CommandArgument=' <%#Eval("User_No")%>' CommandName="Manager_Permissions" 
                        PostBackUrl="" Text="Manager Permissions" />
                    <br />
                    <asp:LinkButton ID="Author_Permissions" runat="server" 
                        CommandArgument=' <%#Eval("User_No")%>' CommandName="Author_Permissions" 
                        PostBackUrl="" Text="Author Permissions" />
                    <br />
                    <asp:LinkButton ID="Send_Email" runat="server" 
                        CommandArgument=' <%#Eval("User_No")%>' CommandName="Send_Email" PostBackUrl="" 
                        Text="Send E-mail" />
                    <br />
                </ItemTemplate>
                <ItemStyle Width="200px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="User Last  Name">
                <ItemTemplate>
                    <%#Eval("User_No")%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="User Degree">
                <ItemTemplate>
                    <%# Eval("User_Name")%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="User Country">
                <ItemTemplate>
                    <%#Eval("User_No")%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="User address">
                <ItemTemplate>
                    <%#Eval("User_No")%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="User Keyword's">
                <ItemTemplate>
                    <%#Eval("User_No")%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="User Email">
                <ItemTemplate>
                    <%#Eval("User_No")%>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
    </asp:GridView>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Panel ID="Panel12" runat="server" Height="293px" Visible="False">
    </asp:Panel>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

