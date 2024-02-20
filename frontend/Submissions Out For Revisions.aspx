<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Submissions Out For Revisions.aspx.cs" Inherits="Submissions_Out_For_Revisions" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="border: 1pt solid #000000;  font-family: 'MS Reference Sans Serif'; ">
        <fieldset style="border-style: solid; border-color: #CCCCCC; width: 980px; height: 321px; margin-left: 15px; font-size: small; color: #000066; background-color: #EAEAEA; border-top-width: 1pt;">
            <legend style="border: 1pt solid #C0C0C0; color: #000066; font-size: medium; background-color: #FFFFFF; font-weight: bold;">
                Submissions Out For Revisions&nbsp; For
                <asp:Label ID="User_Name" runat="server" Text="----"></asp:Label>
                &nbsp;</legend>
            <br />
            &nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" 
                ForeColor="#000099" Text="Contents:"></asp:Label>
            &nbsp;<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Page:"></asp:Label>
            <asp:Label ID="Current_Page" runat="server" Text="......."></asp:Label>
            Of
            <asp:Label ID="Pages_Number" runat="server" Text="......."></asp:Label>
            (<asp:Label ID="Total_Submission" runat="server" Text="......"></asp:Label>
            &nbsp;total submissions)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dispaly
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="  ">10</asp:ListItem>
                <asp:ListItem>
                </asp:ListItem>
            </asp:DropDownList>
            result per page.<br />
            &nbsp;&nbsp;&nbsp;
            <br />
            <asp:GridView ID="db_VeiwAllAssign_Submission" runat="server" 
                AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
                CellPadding="4" 
                onpageindexchanged="db_VeiwAllAssign_Submission_PageIndexChanged" 
                onpageindexchanging="db_VeiwAllAssign_Submission_PageIndexChanging" 
                onrowcommand="db_VeiwAllAssign_Submission_RowCommand" 
                onrowdatabound="db_VeiwAllAssign_Submission_RowDataBound" 
                onselectedindexchanged="db_VeiwAllAssign_Submission_SelectedIndexChanged" 
                onsorting="db_VeiwAllAssign_Submission_Sorting" PageSize="1" Width="1466px">
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <Columns>
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:LinkButton ID="View_Submation" runat="server" 
                                CommandArgument=' <%#Eval("Article_No")%>' CommandName="View_Submation" 
                                PostBackUrl="" Text=" View Submation" />
                            <br />
                            <asp:LinkButton ID="Details" runat="server" 
                                CommandArgument=' <%#Eval("Article_No")%>' CommandName="Details" PostBackUrl="" 
                                Text="Details" />
                            <br />
                            <asp:LinkButton ID="History" runat="server" 
                                CommandArgument=' <%#Eval("Article_No")%>' CommandName="History" PostBackUrl="" 
                                Text="History" />
                            <br />
                            <asp:LinkButton ID="Send_Email" runat="server" 
                                CommandArgument=' <%#Eval("Article_No")%>' CommandName="Send_Email" 
                                PostBackUrl="" Text="Send E-mail" />
                            <br />
                        </ItemTemplate>
                        <ItemStyle Width="200px" />
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
                            <%#Eval("Article_Full_Title")%>
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
                    <asp:TemplateField HeaderText="Submitted Date">
                        <ItemTemplate>
                            <%#Eval("submitted_Date")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Author Name">
                        <ItemTemplate>
                            <%#Eval("author_name")%>
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
        </fieldset><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink14" runat="server" Font-Bold="True" 
            Font-Underline="True" ForeColor="#0000CC">Editor Main Menu</asp:HyperLink>
        <br />
        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    </div>
</asp:Content>

