<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="new reviewer invitation.aspx.cs" Inherits="new_reviewer_invitation" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style1
        {
            width: 98%;
            height: 385px;
            border: 2px solid #FFCC66;
            background-color: #c0c0c0;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="font-family: 'MS Reference Sans Serif'; font-size: 12px">
        <br />
        <br />
        <br />
        <table align="center" cellpadding="4" cellspacing="4" class="style1" dir="ltr" 
            style="border-width: 1px 2px 2px 1px; border-color: #FFCC66; background-color: #FFFFFF" 
            width="98%">
            <tr>
                <td>
                    <fieldset id="field" runat="server" 
                        style="background-color: #FFFFFF; border: 1px hidden #CCCCCC; height: 334px; margin-top: 11px;">
                        <legend style="border: 1px hidden #CCCCCC">New Reviewer invitations for
                            <asp:Label ID="User_Name" runat="server" style="font-weight: 700">استرجاع الاسم 
                            المراجع</asp:Label>
                        </legend>
                        <br />
                        &nbsp;
                        <asp:Label ID="Label1" runat="server" 
                            style="font-family: 'MS Reference Sans Serif'; font-size: small" 
                            Text="you have been  invited to review  the following manuescript .please agree to review or decline to review the manuescript ."></asp:Label>
                        <br />
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label2" runat="server" 
                            style="font-family: 'MS Reference Sans Serif'" Text="page :"></asp:Label>
                        <asp:Label ID="Current_Page" runat="server" Text="رقم الصفحه "></asp:Label>
                        <asp:Label ID="Label4" runat="server" Text="of"></asp:Label>
                        &nbsp;<asp:Label ID="Pages_Number" runat="server" Text="عدد المقالات في الصفحه "></asp:Label>
                        (<asp:Label ID="Total_Submission" runat="server" Text="--------------"></asp:Label>
                        <asp:Label ID="Label8" runat="server" 
                            style="font-family: 'MS Reference Sans Serif'; font-size: small" 
                            Text="total submission "></asp:Label>
                        &nbsp;)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label10" runat="server" Text="&nbsp; Display"></asp:Label>
                        &nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Selected="True">استرجاع</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;<asp:Label ID="Label9" runat="server" Text="result per page . "></asp:Label>
                        <br />
                        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                            AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
                            BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                            onpageindexchanged="GridView1_PageIndexChanged" 
                            onpageindexchanging="GridView1_PageIndexChanging" 
                            onrowcommand="GridView1_RowCommand" 
                            onselectedindexchanged="GridView1_SelectedIndexChanged1" 
                            onsorting="GridView1_Sorting" PageSize="1" style="text-align: center" 
                            Width="1144px">
                            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                            <RowStyle BackColor="White" ForeColor="#003399" />
                            <Columns>
                                <asp:TemplateField HeaderText="Action">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="View_Submation" runat="server" 
                                            CommandArgument=' <%#Eval("Article_No")%>' CommandName="View_Submation" 
                                            PostBackUrl="" Text=" View Submation" />
                                        <br />
                                        <asp:LinkButton ID="View_Abstract" runat="server" 
                                            CommandArgument=' <%#Eval("Article_No")%>' CommandName="View_Abstract" 
                                            PostBackUrl="" Text=" View Abstract" />
                                        <br />
                                        <asp:LinkButton ID="Agree_to_Review" runat="server" 
                                            CommandArgument=' <%#Eval("Article_No")%>' CommandName="Agree_to_Review" 
                                            PostBackUrl="" Text=" Agree to Review " />
                                        <br />
                                        <asp:LinkButton ID="Decline_to_Review" runat="server" 
                                            CommandArgument=' <%#Eval("Article_No")%>' CommandName="Decline_to_Review" 
                                            PostBackUrl="" Text=" Decline to Review" />
                                        <br />
                                        <asp:LinkButton ID="Similar_Articles_in_MEDLINE" runat="server" 
                                            CommandArgument=' <%#Eval("Article_No")%>' 
                                            CommandName="Similar_Articles_in_MEDLINE" PostBackUrl="" 
                                            Text=" Similar Articles in MEDLINE" />
                                        <br />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Manuscript Number">
                                    <ItemTemplate>
                                        <%#Eval("Article_No")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Article type">
                                    <ItemTemplate>
                                        <%#Eval("Article_Type_Name")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Article Title">
                                    <ItemTemplate>
                                        <%#Eval("Article_Full_Title")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Status Date">
                                    <ItemTemplate>
                                        <%#Eval("Current_Status_Date")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Current Status">
                                    <ItemTemplate>
                                        <%#Eval("Current_Status_Name")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Date Reviewer Invited">
                                    <ItemTemplate>
                                        <%#Eval("Status_Date")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Days Invitation Outstanding">
                                    <ItemTemplate>
                                        <%#Eval("Article_No")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Editor Name">
                                    <ItemTemplate>
                                        <%#Eval("User_Name")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Key word">
                                    <ItemTemplate>
                                        <%#Eval("Article_Keywords")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Classification">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="Classifications" runat="server" 
                                            CommandArgument=' <%#Eval("Article_No")%>' CommandName="Classifications" 
                                            PostBackUrl="" Text=" Classifications" />
                                        <br />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        </asp:GridView>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
                        <br />
                        <br />
                    </fieldset>&nbsp;<br />
                    <br />
                    &nbsp;<br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

