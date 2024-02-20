<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Completed Reviewer Assignment.aspx.cs" Inherits="Completed_Reviewer_Assignment" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">




        .style1
        {
            width: 98%;
           
           
            border: 2px solid #FFCC66;
            background-color: #c0c0c0;
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
                        style="background-color: #F4F4F4; border: 1px hidden #CCCCCC; height: 493px; margin-top: 11px;">
                        <legend style="border: 1px hidden #CCCCCC">Completed Reviewer Assignments For<asp:Label 
                                ID="User_Name" runat="server">استرجاع الاسم المراجع</asp:Label>
                        </legend>
                        <br />
                        &nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label2" runat="server" 
                            style="font-family: 'MS Reference Sans Serif'" Text="page :"></asp:Label>
                        <asp:Label ID="Current_Page" runat="server" Text="رقم الصفحه "></asp:Label>
                        <asp:Label ID="Label4" runat="server" Text="of"></asp:Label>
                        &nbsp;<asp:Label ID="Total_Submission" runat="server" Text="عدد الصغحات الكليه "></asp:Label>
                        <asp:Label ID="Label6" runat="server" Text=")"></asp:Label>
                        <asp:Label ID="Pages_Number" runat="server" Text="عدد المقالات في الصفحه "></asp:Label>
                        <asp:Label ID="Label8" runat="server" 
                            style="font-family: 'MS Reference Sans Serif'; font-size: small" 
                            Text="total submission "></asp:Label>
                        &nbsp;)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label10" runat="server" 
                            Text="&nbsp; Display"></asp:Label>
                        &nbsp;<%  DateTime date = new DateTime();
                                      date = DateTime.Now;
                                        %>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Selected="True">استرجاع</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;
                        <asp:Label ID="Label9" runat="server" Text="result per page . "></asp:Label>
                        &nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;
                        <asp:GridView ID="db_completed" runat="server" AllowPaging="True" 
                            AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
                            BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                            onpageindexchanged="db_completed_PageIndexChanged" 
                            onpageindexchanging="db_completed_PageIndexChanging" 
                            onrowcommand="db_completed_RowCommand" 
                            onselectedindexchanged="GridView1_SelectedIndexChanged1" 
                            onsorted="db_completed_Sorted" onsorting="db_completed_Sorting" PageSize="1" 
                            style="text-align: center" Width="1144px">
                            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                            <RowStyle BackColor="White" ForeColor="#003399" />
                            <Columns>
                                <asp:TemplateField HeaderText="Action">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="View_Reviewer_Comment" runat="server" 
                                            CommandArgument=' <%#Eval("Article_No")%>' CommandName="View_Reviewer_Comment" 
                                            PostBackUrl="" Text=" View Reviewer Comments" />
                                        <br />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="My Reviewer Number">
                                    <ItemTemplate>
                                        <%#Eval("User_Order") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Manuscript Number">
                                    <ItemTemplate>
                                        <%#Eval("Article_No")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Article type">
                                    <ItemTemplate>
                                        <%# Eval("Article_Type_Name")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Article Title">
                                    <ItemTemplate>
                                        <%#Eval("Article_Full_Title") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Final Disposition">
                                    <ItemTemplate>
                                        <%#Eval("Article_Final_Disposition_term")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Status Date">
                                    <ItemTemplate>
                                        <%#Eval("Current_Status_Date") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Current Status">
                                    <ItemTemplate>
                                        <%#Eval("Current_Status_Name")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Date Reviewer Invited">
                                    <ItemTemplate>
                                        <%#Eval("invit_date")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Date Reviewer Agreed">
                                    <ItemTemplate>
                                        <%#Eval("assign_date")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Date Reviewe Due">
                                    <ItemTemplate>
                                        <%#Eval("due_date")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Date Review Submitted">
                                    <ItemTemplate>
                                        <%#Eval("complete_date")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Days Taken"></asp:TemplateField>
                                <asp:TemplateField HeaderText="Days Invitation Outstanding">
                                    <ItemTemplate>
                                        <%# Eval("assign_date")%>
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
                                        <%#Eval("Article_No")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        </asp:GridView>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label11" runat="server" 
                            style="font-family: 'MS Reference Sans Serif'" Text="page :"></asp:Label>
                        <asp:Label ID="Label12" runat="server" Text="رقم الصفحه "></asp:Label>
                        <asp:Label ID="Label13" runat="server" Text="of"></asp:Label>
                        &nbsp;<asp:Label ID="Label14" runat="server" Text="عدد المقالات في الصفحه "></asp:Label>
                        &nbsp;<asp:Label ID="Label15" runat="server" Text=")"></asp:Label>
                        <asp:Label ID="Label16" runat="server" Text="عدد الصغحات الكليه "></asp:Label>
                        &nbsp;<asp:Label ID="Label17" runat="server" 
                            style="font-family: 'MS Reference Sans Serif'; font-size: small" 
                            Text="total submission "></asp:Label>
                        )&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label18" runat="server" Text="&nbsp; Display"></asp:Label>
                        &nbsp;
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem Selected="True">استرجاع</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;&nbsp;
                        <asp:Label ID="Label19" runat="server" Text="result per page . "></asp:Label>
                        &nbsp;<br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:Button ID="ReviewerMainMenu" runat="server" BackColor="#CCCCCC" 
                            BorderColor="Black" PostBackUrl="~/Reviewer Main Menue.aspx" 
                            Text="&lt;&lt; Reviewer Main Menu" />
                        &nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label20" runat="server" 
                            Text="you should use the free adobe reader 8 or later best pdf viewing results ."></asp:Label>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:ImageButton ID="CmdDownloadPdf" runat="server" 
                            AlternateText="Donwnload PDF" Height="40px" Width="119px" />
                        <br />
                    </fieldset>&nbsp;<br />
                </td>
            </tr>
        </table>
        <br />
    </div>
</asp:Content>

