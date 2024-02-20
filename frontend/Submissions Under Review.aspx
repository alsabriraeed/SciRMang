<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Submissions Under Review.aspx.cs" Inherits="Submissions_Under_Review" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">




        .style2
        {
             
            border: 2px solid #CCCCCC;
            background-color: #c0c0c0;
        }
        .style24
        {
            width: 274px;
            height: 58px;
        }
        .style25
        {
            width: 107px;
            height: 58px;
        }
        .style28
        {
            width: 283px;
            height: 58px;
        }
        .style8
        {
            width: 159px;
            height: 58px;
        }
        .style27
        {
            width: 185px;
            height: 58px;
        }
        .style23
        {
            width: 274px;
        }
        .style29
        {
            width: 283px;
        }
        .style30
        {
            width: 159px;
        }
        .style22
        {
            width: 185px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="border: 1pt solid #000000;  font-family: 'MS Reference Sans Serif'; ">
        <fieldset style="border-style: solid; border-color: #CCCCCC; width: 980px; height: 321px; margin-left: 15px; font-size: small; color: #000066; background-color: #EAEAEA; border-top-width: 1pt;">
            <legend style="border: 1pt solid #C0C0C0; color: #000066; font-size: medium; background-color: #FFFFFF; font-weight: bold;">
                Submission Under Reviews-(------)Editor&nbsp; </legend>
            <br />
            &nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" 
                ForeColor="#000099" Text="Contents:"></asp:Label>
            &nbsp;<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Page:"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="......."></asp:Label>
            Of
            <asp:Label ID="Label4" runat="server" Text="......."></asp:Label>
            (<asp:Label ID="Label5" runat="server" Text="......"></asp:Label>
            &nbsp;total submissions)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dispaly
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="  ">10</asp:ListItem>
                <asp:ListItem>
                </asp:ListItem>
            </asp:DropDownList>
            result per page.<br />
            &nbsp;&nbsp;&nbsp;
            <table align="center" cellpadding="8" cellspacing="0" class="style2" dir="ltr" 
                style="border-style: none solid none solid; border-width: 1pt; border-color: #808080; background-color: #FFFFFF; height: 310px; width: 95%;" 
                width="95%">
                <tr cellpadding="0" style="font-size: small">
                    <td class="style24" 
                        style="font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                        Action
                    </td>
                    <td class="style25" 
                        style="border-style: none solid none solid; border-color: #808080; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF; border-right-width: 1pt; border-left-width: 1pt;" 
                        valign="baseline">
                        Manuscript Number<br />
                    </td>
                    <td class="style28" 
                        style="font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                        &nbsp;Artical<br />
                        Type</td>
                    <td class="style8" 
                        style="border-style: none solid none solid; border-color: #808080; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF; border-right-width: 1pt; border-left-width: 1pt;">
                        Article
                        <br />
                        Title</td>
                    <td class="style27" 
                        style="border-style: none solid none solid; border-color: #808080; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF; border-right-width: 1pt; border-left-width: 1pt;">
                        Author Name
                        <br />
                    </td>
                    <td bgcolor="#3A5568" style="color: #FFFFFF">
                        <b>Reviewers Name</b></td>
                    <td class="style27" 
                        style="font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                        Review<br />
                        Request<br />
                        Date</td>
                    <td style="background-color: #3A5568; color: #FFFFFF; font-weight: bold;">
                        Review<br />
                        Accept<br />
                        Date</td>
                    <td style="background-color: #3A5568; color: #FFFFFF; font-family: 'Microsoft Sans Serif'; font-weight: bold;">
                        Review<br />
                        Accept
                        <br />
                        Date<br />
                        Due</td>
                    <td style="color: #FFFFFF; font-family: 'Microsoft Sans Serif'; background-color: #3A5568; font-weight: bold;">
                        Review<br />
                        Days<br />
                        To<br />
                        Review</td>
                    <td style="color: #FFFFFF; background-color: #3A5568; font-family: 'Microsoft Sans Serif'; font-weight: bold;">
                        Review<br />
                        Days<br />
                        Total(خارج المراجعه)</td>
                    <td id="o" class="style27" 
                        style="border-style: none solid none solid; border-color: #808080; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF; border-right-width: 1pt; border-left-width: 1pt;">
                        Status Date<br />
                    </td>
                    <td class="style27" 
                        style="font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF;">
                        Current status</td>
                    <td class="style27" 
                        style="border-style: none solid none solid; border-color: #808080; font-family: 'MS Reference Sans Serif'; font-size: small; font-weight: 700; background-color: #3A5568; color: #FFFFFF; border-right-width: 1pt; border-left-width: 1pt;">
                        Reviewer Name</td>
                </tr>
                <tr>
                    <td class="style23" 
                        style="border-style: none solid solid none; border-width: 1pt; border-color: #808080; font-family: 'MS Reference Sans Serif'; font-size: x-small" 
                        valign="top">
                        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="False" 
                            Font-Size="Small" ForeColor="#000099" 
                            style="text-decoration: underline; color: #0000CC">View Submation</asp:HyperLink>
                        <br />
                        <asp:HyperLink ID="HyperLink38" runat="server" Font-Underline="True" 
                            ForeColor="#0000CC" NavigateUrl="~/SubmitEditorsDecisionandComments.aspx">Submit 
                        Decision and Comments</asp:HyperLink>
                        <br />
                        <asp:HyperLink ID="HyperLink47" runat="server" Font-Underline="True" 
                            ForeColor="Blue" NavigateUrl="~/SendAdHocEmail.aspx">Send E-mail</asp:HyperLink>
                        <br />
                        <asp:HyperLink ID="HyperLink45" runat="server" Font-Underline="True" 
                            ForeColor="Blue" NavigateUrl="~/DetailForManuscriptNumber2.aspx">Details</asp:HyperLink>
                        <br />
                        <asp:HyperLink ID="HyperLink7" runat="server" Font-Underline="True" 
                            ForeColor="Blue" NavigateUrl="~/HistoryForSubmission.aspx">History</asp:HyperLink>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                    </td>
                    <td class="style6">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td class="style29" 
                        style="border-style: none none solid none; border-width: 2px 1pt 1pt 2px; border-color: #CCCCCC #CCCCCC #999999 #CCCCCC">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="style30" 
                        style="border-style: none none solid solid; border-width: 1pt; border-color: #808080;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td class="style22" 
                        style="border-style: none solid solid solid; border-width: 1px; border-color: #808080;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>
                    </td>
                    <td class="style22" 
                        style="border-style: none solid solid none; border-width: 1pt; border-color: #808080;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td class="style22" 
                        style="border-style: none solid solid none; border-width: 2px 1pt 1pt 1pt; border-color: #808080;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td class="style22" 
                        style="border-style: none solid solid none; border-width: 1pt; border-color: #808080;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td class="style22" 
                        style="border-style: none solid solid none; border-width: 1pt; border-color: #808080;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="db_Under" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
                CellPadding="4" onrowcommand="db_Under_RowCommand" 
                onselectedindexchanged="db_Under_SelectedIndexChanged" 
                style="text-align: center" Width="1144px">
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <Columns>
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:LinkButton ID="View_Submation" runat="server" 
                                CommandArgument=' <%#Eval("Article_No")%>' CommandName="View_Submation" 
                                PostBackUrl="" Text=" View Submation" />
                            <br />
                            <asp:LinkButton ID="Submit_Recommendation" runat="server" 
                                CommandArgument=' <%#Eval("Article_No")%>' CommandName="Submit_Recommendation" 
                                PostBackUrl="" Text="Submit Recommendation" />
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
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </fieldset><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink14" runat="server" Font-Bold="True" 
            Font-Underline="True" ForeColor="#0000CC" NavigateUrl="~/Default.aspx">Editor 
        Main Menu</asp:HyperLink>
        <br />
        &nbsp;
        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Medium" 
            ForeColor="Black" 
            Text="You should use the free Adobe Acrobat Reader 6 or later for best PDF Viewing  Results"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    </div>
</asp:Content>

