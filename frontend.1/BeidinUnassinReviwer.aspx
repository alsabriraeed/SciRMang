<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BeidinUnassinReviwer.aspx.cs" Inherits="BeidinUnassinReviwer" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">



        .style1
        {
            width: 106%;
           
        }
        .style2
        {
            width: 181px;
        }
        .style3
        {
            width: 120%;
         
            margin-left: 20px;
            margin-bottom: 0px;
        }
        .style4
        {
            width: 647px;
        }
        .style8
        {
            width: 208px;
           
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td align="left" class="style2" 
                style="font-family: 'MS Reference Sans Serif'; font-size: large; font-weight: bold" 
                valign="top">
                <br />
                Unassign Reviewer<br />
                &nbsp;<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;
            </td>
            <td align="left" valign="top">
                <table cellpadding="0" cellspacing="0" class="style3">
                    <tr>
                        <td align="center" class="style4" 
                            style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #F2F2F2; padding-right: 50px; padding-left: 31px;" 
                            valign="middle">
                            <br />
                            Please Select Editor that want Unassign
                            <table cellpadding="0" cellspacing="0" class="style3">
                                <tr>
                                    <td align="center" class="" width=" " 
                                        style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #00008F; color: #FFFFFF; font-weight: bold;">
                                        Manuscript Classifications&nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" bgcolor="White" class="" width=" ">
                                        <asp:Label ID="Article_Classification" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <table cellpadding="0" cellspacing="0" class="style3">
                                <tr>
                                    <td align="center" class="" 
                                        style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #00008F; color: #FFFFFF; font-weight: bold;">
                                        Classifications&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                    <td align="center" class="" 
                                        style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #00008F; color: #FFFFFF; font-weight: bold;">
                                        Classification
                                        <br />
                                        Matches</td>
                                    <td align="center" class="" colspan="2" 
                                        style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #00008F; color: #FFFFFF; font-weight: bold;">
                                        Current Arguments</td>
                                    <td align="center" class="" 
                                        style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #00008F; color: #FFFFFF; font-weight: bold;">
                                        Reviewer&nbsp; Name</td>
                                </tr>
                                <tr>
                                    <td align="left" class="" 
                                        style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #FFFFFF; color: #000000; font-weight: normal;">
                                        <asp:Label ID="User_Classification" runat="server"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                    <td align="left" class="" 
                                        style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #FFFFFF; color: #000000; font-weight: normal;">
                                        <asp:Label ID="ClassificationMatches" runat="server"></asp:Label>
                                    </td>
                                    <td align="left" class="" 
                                        style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #FFFFFF; color: #000000; font-weight: normal;">
                                        <asp:Label ID="Current_Argument" runat="server"></asp:Label>
                                    </td>
                                    <td align="left" class="" colspan="2" 
                                        style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #FFFFFF; color: #000000; font-weight: normal;">
                                        &nbsp;&nbsp;
                                        <asp:Label ID="Editor_Name" runat="server"></asp:Label>
                                    &nbsp;</td>
                                </tr>
                            </table>
                                    <!-- Users.User_Name,Role_Table.Role_Name,count,matches_count  from Users --> 
              <!--         <asp:Repeater runat="server"  ID="Datasourse_Editor">      <HeaderTemplate>   <table class="style6">
                                    <tr>
                                        <td>
                                            <br />
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td>x
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr></HeaderTemplate> 
                                  <ItemTemplate>  <tr>
                                        <td>
                                            &nbsp;</td>
                                        <td> <%#Eval("User_Name")%>
                                            &nbsp;</td>
                                        <td><%#Eval("Role_Name")%>
                                            &nbsp;</td>
                                        <td><%#Eval("count")%>
                                            &nbsp;</td>
                                        <td><%#Eval("matches_count")%>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr></ItemTemplate>
                       <FooterTemplate>         </table>  </FooterTemplate>  </asp:Repeater>   -->
                       
                                <br />
                            <br />
                   <!-- DataSourceID="Datasourse_Editor" -->
                                <br />
                            <br />
                            <br />
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                                CellPadding="3" DataKeyNames="user_No" GridLines="Horizontal" 
                                onrowcommand="GridView1_RowCommand" 
                                onselectedindexchanged="GridView1_SelectedIndexChanged1" PageSize="1" 
                                style="margin-right: 122px" Width="800px">
                                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                <Columns>
                                    <asp:CommandField ButtonType="Button" HeaderText="Select" 
                                        ShowSelectButton="True" />
                                    <asp:TemplateField HeaderText="Reviewer Role">
                                        <ItemTemplate>
                                            <%#Eval("Role_Name")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Reviewer Name">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" CommandArgument=' <%#Eval("User_No")%>' 
                                                CommandName="Editor_Names" PostBackUrl="" Text=' <%#Eval("User_Name")%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Reviewer Number">
                                        <ItemTemplate>
                                            <%#Eval("User_Order")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="More_Information">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="Editor_Classifications" runat="server" 
                                                CommandArgument=' <%#Eval("User_No")%>' CommandName="More_Information" 
                                                PostBackUrl="" Text="More Information" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Assign Complete">
                                        <ItemTemplate>
                                            <%#Eval("Assign_Complete")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <AlternatingRowStyle BackColor="#F7F7F7" />
                            </asp:GridView>
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="center" bgcolor="White" class="style4" 
                            style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #FFFFFF;" 
                            valign="top">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="center" bgcolor="#00008F" class="style4" 
                            style="font-family: 'MS Reference Sans Serif'; font-size: small; background-color: #F2F2F2;" 
                            valign="top">
                            &nbsp;</td>
                    </tr>
                </table>
                &nbsp;<br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Text="Cancel" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="Proceed" />
            </td>
        </tr>
    </table>
</asp:Content>

