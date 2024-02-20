<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PermissionManagement.aspx.cs" Inherits="PermissionManagement" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="User_Name" runat="server" Text="Label"></asp:Label>
    <asp:Panel ID="Panel4" runat="server" style="margin-left: 68px" Width="90%">
        <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" BorderStyle="Solid" 
            BorderWidth="1px" DynamicHorizontalOffset="2" Font-Names="Verdana" 
            Font-Size="0.8em" ForeColor="#990000" Height="20px" Orientation="Horizontal" 
            StaticSubMenuIndent="10px" Width="661px">
            <StaticSelectedStyle BackColor="#FFCC66" />
            <LevelMenuItemStyles>
                <asp:MenuItemStyle BackColor="#33CCCC" BorderColor="Black" BorderStyle="Solid" 
                    BorderWidth="1px" Font-Underline="False" ForeColor="Black" />
            </LevelMenuItemStyles>
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
            <DynamicMenuStyle BackColor="#FFFBD6" />
            <DynamicSelectedStyle BackColor="#FFCC66" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticHoverStyle BackColor="#990000" ForeColor="White" />
            <Items>
                <asp:MenuItem NavigateUrl="~/PermissionManagement.aspx" 
                    Text="Permission management" Value="Permission management"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/PagesManagement.aspx" Text="Pages management" 
                    Value="Pages management"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/MessageManagement.aspx" Text="messages management" 
                    Value="messages management"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Default.aspx" Text="main menue" Value="main menue">
                </asp:MenuItem>
            </Items>
        </asp:Menu>
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
                    <asp:LinkButton ID="Administrator_Function" runat="server" 
                        CommandArgument=' <%#Eval("User_No")%>' CommandName="Administrator_Function" 
                        PostBackUrl="" Text="Administrator Functions Permissions" />
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
    <asp:Panel ID="AdminFunctiopanel" runat="server" BackColor="#E1E1E1" 
        Height="145px" style="margin-left: 81px" Visible="False" Width="470px">
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>permissional management</asp:ListItem>
            <asp:ListItem>pages management</asp:ListItem>
            <asp:ListItem>user management</asp:ListItem>
            <asp:ListItem>message management</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button14" runat="server" BackColor="#CCCCCC" 
            BorderColor="Black" onclick="Button14_Click" Text="Save &amp; Update" 
            Width="109px" />
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel10" runat="server" Visible="False">
        <table cellpadding="4" cellspacing="1" class="style1">
            <tr>
                <td class="style2" colspan="4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    Permissions&nbsp;&nbsp;&nbsp; for Editor&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click1">General 
                    permissions</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton7" runat="server" onclick="LinkButton7_Click">Managing 
                    Permissions</asp:LinkButton>
                </td>
                <td class="style3">
                    <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton9_Click">Assignment 
                    Recieve Pemissions</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton10" runat="server" onclick="LinkButton10_Click">Direct 
                    To Editor Submissions Recieve Permissions
                    </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="style4" valign="top">
                    <asp:Panel ID="PanelGeneralpermission" runat="server" Visible="False">
                        <br />
                        <asp:CheckBoxList ID="CheckBoxList5" runat="server" BorderStyle="Ridge" 
                            Height="175px" Width="229px">
                            <asp:ListItem>Allow Automatic login to this role</asp:ListItem>
                            <asp:ListItem>Propose Reviewers</asp:ListItem>
                            <asp:ListItem>Remove Proposed Reviewers</asp:ListItem>
                            <asp:ListItem>Proxy register New Author</asp:ListItem>
                            <asp:ListItem>Proxy Register New Reviewer</asp:ListItem>
                            <asp:ListItem>Proxy Register New Editor</asp:ListItem>
                        </asp:CheckBoxList>
                        <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="Save" 
                            Width="87px" />
                        <br />
                        <br />
                    </asp:Panel>
                    <br />
                    &nbsp;
                </td>
                <td class="">
                    <asp:Panel ID="Panel6" runat="server" Height="" Visible="False">
                        <br />
                        <br />
                        <asp:CheckBoxList ID="CheckBoxList3" runat="server" RepeatLayout="Flow" 
                            style="margin-top: 25px" Width="401px">
                            <asp:ListItem>Recieve New Submission Requiring Assignment</asp:ListItem>
                            <asp:ListItem Value="Recieve Resived Submissions Requiring Assignment">Recieve 
                            Resived Submissions Requiring Assignment</asp:ListItem>
                            <asp:ListItem>View Details For the Submissions</asp:ListItem>
                            <asp:ListItem>View History For the Submissions</asp:ListItem>
                            <asp:ListItem>Remove Submissions</asp:ListItem>
                            <asp:ListItem>View File Inventory For The Submission</asp:ListItem>
                            <asp:ListItem>Assign To My Self</asp:ListItem>
                            <asp:ListItem>Send Email</asp:ListItem>
                            <asp:ListItem>Linked Submission</asp:ListItem>
                            <asp:ListItem>View All Assigned Submmisssion Being Edited</asp:ListItem>
                            <asp:ListItem>View All Assigned Submmisssions</asp:ListItem>
                            <asp:ListItem>View Submmisssions out For Revision</asp:ListItem>
                            <asp:ListItem>All Submissions With Editors Decision</asp:ListItem>
                            <asp:ListItem>View Submissions Group By Editor Assigned</asp:ListItem>
                            <asp:ListItem>View Submissions Group By Editor With current Responsibility</asp:ListItem>
                            <asp:ListItem>View Accept Submissions</asp:ListItem>
                            <asp:ListItem>View Reject Submission</asp:ListItem>
                            <asp:ListItem>View Withdrawen Submission</asp:ListItem>
                            <asp:ListItem>Set Final Disposition</asp:ListItem>
                            <asp:ListItem>Group By Submission With Current Status</asp:ListItem>
                            <asp:ListItem>View Submission In Active Linked Submision Groups</asp:ListItem>
                            <asp:ListItem>View Submissions In Inactive Linked Submision Groups</asp:ListItem>
                            <asp:ListItem>Notify To Author</asp:ListItem>
                            <asp:ListItem>View Reviews and comments</asp:ListItem>
                            <asp:ListItem>Create/Edit Linked SubmissionGroup</asp:ListItem>
                            <asp:ListItem>View Linked Submission Group
                            </asp:ListItem>
                            <asp:ListItem>Set Active/Inactive Group</asp:ListItem>
                            <asp:ListItem>Update Date Due For Editor</asp:ListItem>
                            <asp:ListItem>Update Date Due For Reviewer</asp:ListItem>
                        </asp:CheckBoxList>
                        <br />
                        <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
                            Text="Save &amp;Update" />
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                        <br />
                    </asp:Panel>
                    <br />
                </td>
                <td class="" valign="top">
                    <asp:Panel ID="Panel8" runat="server" Height="" Visible="False">
                        <br />
                        <br />
                        <asp:CheckBoxList ID="CheckBoxList4" runat="server" RepeatLayout="Flow" 
                            Width="340px">
                            <asp:ListItem>Recieve New Assignments</asp:ListItem>
                            <asp:ListItem>View Details For the Submissions</asp:ListItem>
                            <asp:ListItem>View History For the Submissions</asp:ListItem>
                            <asp:ListItem>Remove Submissions</asp:ListItem>
                            <asp:ListItem>View File Inventory For The Submission</asp:ListItem>
                            <asp:ListItem>UnAssign other Editor</asp:ListItem>
                            <asp:ListItem>Send Email</asp:ListItem>
                            <asp:ListItem>Linked Submission</asp:ListItem>
                            <asp:ListItem>Recive Assignment With Invitation</asp:ListItem>
                            <asp:ListItem>Recive Assignment Without Invitation</asp:ListItem>
                            <asp:ListItem>Assign Editor</asp:ListItem>
                            <asp:ListItem Value=" Invite Editor">Invite Editor</asp:ListItem>
                            <asp:ListItem>Unassign My Self</asp:ListItem>
                            <asp:ListItem>Unassign Reviewer</asp:ListItem>
                        </asp:CheckBoxList>
                        <br />
                        <asp:Button ID="Button7" runat="server" onclick="Button7_Click" 
                            Text="Save &amp;Update" />
                        <br />
                        <br />
                    </asp:Panel>
                    <br />
                    <br />
                    <br />
                </td>
                <td class="" valign="top">
                    <asp:Panel ID="Panel9" runat="server" Visible="False">
                        <br />
                        <br />
                        <asp:CheckBoxList ID="CheckBoxList2" runat="server" RepeatLayout="Flow" 
                            Width="245px">
                            <asp:ListItem>Direct To Editor New Submission</asp:ListItem>
                            <asp:ListItem>Direct To Editor Resived Submission</asp:ListItem>
                            <asp:ListItem>View Details For the Submissions</asp:ListItem>
                            <asp:ListItem>View History For the Submissions</asp:ListItem>
                            <asp:ListItem>Remove Submissions</asp:ListItem>
                            <asp:ListItem>Redirect Other Editor</asp:ListItem>
                            <asp:ListItem>Assign To My Self</asp:ListItem>
                            <asp:ListItem>Send Email</asp:ListItem>
                        </asp:CheckBoxList>
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button8" runat="server" onclick="Button8_Click" 
                            Text="Save &amp; Update" />
                        <br />
                    </asp:Panel>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />
    <br />
    <asp:Panel ID="Panel11" runat="server" Visible="False">
        <table cellpadding="4" cellspacing="1" class="">
            <tr>
                <td class="">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    Permissions&nbsp;&nbsp;&nbsp; for Reviewers&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="">
                    <asp:LinkButton ID="LinkButton11" runat="server" onclick="LinkButton11_Click">General 
                    Permission</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="" valign="top">
                    <asp:Panel ID="PanelReviewerpermission" runat="server" Visible="False">
                        <br />
                        <asp:CheckBoxList ID="CheckBoxList7" runat="server" BorderStyle="Ridge" 
                            Height="64px" Width="229px">
                            <asp:ListItem>Recieve Invitation</asp:ListItem>
                            <asp:ListItem>Decline To Review</asp:ListItem>
                        </asp:CheckBoxList>
                        <asp:Button ID="Button9" runat="server" onclick="Button9_Click" 
                            Text="Save &amp; update" Width="87px" />
                        <br />
                        <br />
                    </asp:Panel>
                    <br />
                    &nbsp;
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />
    <br />
    <asp:Panel ID="Panel12" runat="server" Height="" Visible="False">
        <table class="">
            <tr>
                <td colspan="3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <b>
                    <span class="">Roles</span></b>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBoxList ID="Editor" runat="server">
                        <asp:ListItem>Editor</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td>
                    <asp:CheckBoxList ID="Reviwerlist" runat="server">
                        <asp:ListItem>Reviewer</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td>
                    <asp:CheckBoxList ID="Author" runat="server">
                        <asp:ListItem>Author</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="">
                    <asp:CheckBoxList ID="CheckBoxList8" runat="server">
                        <asp:ListItem>Managing Editor</asp:ListItem>
                        <asp:ListItem>Editor_in_Chief</asp:ListItem>
                        <asp:ListItem>Associate Editor</asp:ListItem>
                    </asp:CheckBoxList>
                    <asp:Button ID="Button13" runat="server" onclick="Button13_Click" 
                        Text="Save &amp; Update" />
                    <br />
                </td>
                <td class="">
                    <asp:CheckBoxList ID="CheckBoxList9" runat="server">
                        <asp:ListItem>Language Reviewer</asp:ListItem>
                        <asp:ListItem>Referee</asp:ListItem>
                        <asp:ListItem>Statistical Referee</asp:ListItem>
                        <asp:ListItem>Potential Reviewer</asp:ListItem>
                        <asp:ListItem>Entire Database</asp:ListItem>
                    </asp:CheckBoxList>
                    <br />
                    <asp:Button ID="Button11" runat="server" onclick="Button11_Click" 
                        Text="Save &amp; Update" />
                </td>
                <td class="">
                    <asp:CheckBoxList ID="CheckBoxList10" runat="server">
                        <asp:ListItem>Author</asp:ListItem>
                    </asp:CheckBoxList>
                    <br />
                    <asp:Button ID="Button12" runat="server" onclick="Button12_Click" 
                        Text="Save &amp; Update" />
                </td>
            </tr>
        </table>
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

