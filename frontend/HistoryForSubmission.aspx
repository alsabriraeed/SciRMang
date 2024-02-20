<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="HistoryForSubmission.aspx.cs" Inherits="HistoryForSubmission" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center" 
        
        style="border-style: solid; border-width: 1px; height: 618px; font-family: 'MS Reference Sans Serif'; font-weight: bold; font-size: small; background-color: #FFFFFF; width: 1053px;">
        &nbsp;&nbsp;<br />
        &nbsp;&nbsp; History for submission Number
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="CmdClose" runat="server" BackColor="#F2F2F2" Height="23px" 
            Text="Close" />
        <br />
        <br />
        <fieldset style="border: 1px solid #000000; height: 137px; background-color: #F2F2F2; width: 809px;">
            <legend style="border-style: solid; border-width: 1px;" valign="top">Status History</legend>
            <asp:GridView ID="Status_history" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-left: 26px" 
                Width="795px">
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#E3EAEB" />
                <Columns>
                    <asp:TemplateField HeaderText="Status Date">
                        <ItemTemplate>
                            <%#Eval("Status_Date")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Submission Status">
                        <ItemTemplate>
                            <%#Eval("Status_Name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Role Family">
                        <ItemTemplate>
                            <%#Eval("Family_Role_Name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Revision">
                        <ItemTemplate>
                            <%#Eval("Article_Revision")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Operator">
                        <ItemTemplate>
                            <asp:LinkButton ID="User_name" runat="server" 
                                CommandArgument='<%#Eval("User_No")%>' CommandName="User_name" PostBackUrl="" 
                                Text='<%#Eval("User_Name")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
        </fieldset><br />
        &nbsp;&nbsp;&nbsp;
        <br />
        <fieldset style="border: 1px solid #000000; height: 137px; background-color: #F2F2F2; width: 809px;">
            <legend align="top" style="border-style: solid; border-width: 1px; ">CORESPONDING&nbsp; 
                HISTORY</legend>
            <asp:GridView ID="Message_history" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" ForeColor="#333333" GridLines="None" 
                onrowcommand="Message_history_RowCommand" style="margin-left: 26px" 
                Width="795px">
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#E3EAEB" />
                <Columns>
                    <asp:TemplateField HeaderText=" Sent Date">
                        <ItemTemplate>
                            <%#Eval("Message_Send_Date")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Letter Name">
                        <ItemTemplate>
                            <asp:LinkButton ID="Message_name" runat="server" 
                                CommandArgument='<%#Eval("Message_No")%>' CommandName="Message_name" 
                                PostBackUrl="" Text='<%#Eval("Message_Name")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Role Family">
                        <ItemTemplate>
                            <%#Eval("Family_Role_Name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Revision">
                        <ItemTemplate>
                            <%#Eval("Article_Revision")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Operator">
                        <ItemTemplate>
                            <asp:LinkButton ID="User_name0" runat="server" 
                                CommandArgument='<%#Eval("User_No")%>' CommandName="User_name" PostBackUrl="" 
                                Text='<%#Eval("User_Name")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </fieldset></div>
</asp:Content>

