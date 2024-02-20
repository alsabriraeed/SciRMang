<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View Reviewer Commentsaspx.aspx.cs" Inherits="View_Reviewer_Commentsaspx" Title="Untitled Page" %>

<script runat="server">

   
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">




        .style1
        {
            width: 100%;
            border: 3px solid #FFCC66;
            background-color: #c0c0c0;
        }
        
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <br />
        <table align="center" bgcolor="White" cellpadding="4" cellspacing="4" 
            class="style1" dir="ltr" 
            style="border-left: 1px hidden #FFCC66; border-right: 2px hidden #FFCC66; border-top: 1px hidden #FFCC66; border-bottom: 2px hidden #FFCC66; background-color: #FFFFFF; height: 213px; font-family: 'MS Reference Sans Serif'; font-size: xx-large; font-weight: 700; border-width: 1pt 2pt 2pt 1pt;">
            <tr>
                <td style="font-size: small" valign="top">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label34" runat="server" 
                        style="font-weight: 700; font-size: large; color: #003366;" 
                        Text="View Reviewer Comments for Nanuscript &nbsp;" Width="69%"></asp:Label>
                    &nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Article_No" runat="server" 
                        style="font-weight: 700; font-size: large; color: #003366;" Width="69%"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <hr style="border: 1px hidden #003366; width: 94%; height: -8px; color: #000080; margin-bottom: 0px;" />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label37" runat="server" style="color: #003366" 
                        Text="Click the Reviewer recommendation term to view the Revier comments."></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <hr style="border: 1px hidden #003366; width: 94%; height: -8px; color: #000080; margin-bottom: 0px;" />
                    <br />
                    &nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
                BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CaptionAlign="Left" 
                CellPadding="3" GridLines="Vertical" 
                onpageindexchanged="GridView1_PageIndexChanged" 
                onpageindexchanging="GridView1_PageIndexChanging" 
                onrowcommand="GridView1_RowCommand" onrowediting="GridView1_RowEditing" 
                onselectedindexchanged="GridView1_SelectedIndexChanged" 
                onsorting="GridView1_Sorting" PageSize="5" Width="880px" 
                onrowdatabound="GridView1_RowDataBound" style="text-align: center">
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <Columns>
                     
       
                  
                    <asp:TemplateField HeaderText="Editor Name">
                        <ItemTemplate>
                            <%#Eval("Family_Role")%> ( <%#Eval("User_order")%>)
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Date Completed">
                        <ItemTemplate>
                           <asp:LinkButton ID="view_Review" runat="server" 
                                CommandArgument=' <%#Eval("User_No")%>' CommandName="view_Review" 
                                Text=' <%#Eval("Recommendation")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                  
                </Columns>
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="#DCDCDC" />
            </asp:GridView>
                    <br />
                </td>
            </tr>
        </table>
        <br />
        <br />
    </div>
</asp:Content>

