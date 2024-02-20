<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AttachFiles.aspx.cs" Inherits="AttachFiles" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">



        .style1
        {
            width:100%;
            height: 664px;
        }
        .style19
        {            height: 350px;
            right: 30px;
            left: 20px;
            width: 622px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 875px">
        <table class="style1" style="border: 1pt solid #666666;">
            <tr>
                <td class="style19" 
                    style="border-left-style: dotted; border-left-width: thin; border-left-color: #0099CC" 
                    valign="top">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Label ID="Label300" runat="server" Font-Size="Small" Font-Underline="True" 
                        ForeColor="#0000CC" Text="Insert Special Chararcter"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <fieldset style="background-position: 25px -54px; height: 284px; background-color: #CCCCCC; right: 20px; left: 30px; width: 708px; margin-left: 23px; margin-top: 7px;">
                        <legend style="border-width: thin; border-style: solid; width: 132px; height: 19px; background-color: #FFFFFF; font-weight: bold; vertical-align: top;">
                            Please Attach Files </legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                        <hr style="border: 1pt solid #FF0000; background-color: #FFFFFF; color: #FF0000; height: -15px;" 
                            width="95%" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label301" runat="server" Text="Required item are marked with a *.when all items have been attached ,click Next 
&lt;br /&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;at the bottum of the page.
"></asp:Label>
                        <hr style="border: 1pt solid #FF0000; color: #FF0000; height: -15px;" 
                            width="95%" />
                        <fieldset style="border-style: none; margin: 5px 30px 8px 20px; width: 654px; padding-top: 9px; height: 28px; background-color: #CCCCCC;">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
                            <asp:Label ID="Label302" runat="server" Font-Bold="False" ForeColor="#000099" 
                                Text="Item"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="Dbl_File_Type" runat="server" Height="17px" Width="199px">
                            </asp:DropDownList>
                        </fieldset><br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label303" runat="server" Text="Enter a Description, Select Online web systemor offline delivery. if Online web 
&lt;br /&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;System is selected, click the Browse button to select a file, then click the Attach this 
 &lt;br /&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;file button. if offline is selected, click the Attach this infomation button. 
"></asp:Label>
                        <br />
                        <fieldset style="border-style: none; margin-top: 16px;">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label304" runat="server" ForeColor="#000066" Text="Discription"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txt_description" runat="server" Width="233px"></asp:TextBox>
                        </fieldset><fieldset 
                            style="border-style: none; margin-right: 30px; margin-left: 20px; margin-top: 5px">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label305" runat="server" ForeColor="#000066" 
                                Text="Delivery Method"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:RadioButton ID="radio_online" runat="server" GroupName="ob" Text=" " />
                            <asp:Label ID="Label306" runat="server" Text="Online Web System"></asp:Label>
                            &nbsp;&nbsp;&nbsp;
                            <asp:RadioButton ID="radio_offline" runat="server" GroupName="ob" Text=" " />
                            &nbsp;<asp:Label ID="Label307" runat="server" Text="offline"></asp:Label>
                        </fieldset>&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
                        <asp:Label ID="Label308" runat="server" ForeColor="#000066" Text="File Name:"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:FileUpload ID="Uploader" runat="server" Height="26px" 
                            Width="210px" />
                                <script runat="server">
                                   
                                
                                </script>
                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="messeg" runat="server" Text="."></asp:Label>
                        &nbsp;<asp:Label ID="ttt" runat="server" Text="."></asp:Label>
                        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        &nbsp;&nbsp;<asp:Label ID="lblStatus" runat="server" Text="."></asp:Label>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="GridFile" runat="server" onclick="GridFile_Click" 
                            Text="Attach This File" />
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" 
                            NavigateUrl="./Upload/index.docx">HyperLink</asp:HyperLink>
                        &nbsp;<br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:GridView ID="GridView_File" runat="server" 
                            AutoGenerateColumns="False" onrowcommand="GridView_File_RowCommand">
                            <Columns>
                                <asp:TemplateField HeaderText="Order">
                                    <ItemTemplate>
                                        <asp:TextBox ID="order" runat="server" Text='<%# Eval("file_order") %>'></asp:TextBox>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#3A5568" ForeColor="White" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Item">
                                    <ItemTemplate>
                                        <asp:DropDownList ID="DropDownList6" runat="server" Height="16px" Width="136px">
                                            <asp:ListItem Enabled="False">none</asp:ListItem>
                                            <asp:ListItem>Test Article</asp:ListItem>
                                            <asp:ListItem>Terms of Agreement</asp:ListItem>
                                            <asp:ListItem>Manuscript</asp:ListItem>
                                            <asp:ListItem>Research Paper</asp:ListItem>
                                            <asp:ListItem>Rapid Communication</asp:ListItem>
                                            <asp:ListItem>Case Report</asp:ListItem>
                                            <asp:ListItem>Annual Meeting Abstract</asp:ListItem>
                                        </asp:DropDownList>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#3A5568" ForeColor="White" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Desctiption">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txtdescription" runat="server" 
                                            Text='<%# Eval("File_Description") %>'></asp:TextBox>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#3A5568" ForeColor="White" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="File Name">
                                    <ItemTemplate>
                                        <%# Eval("File_Name")%>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#3A5568" ForeColor="White" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Size">
                                    <ItemTemplate>
                                        <%# Eval("File_Size")%>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#3A5568" ForeColor="White" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Last Modified">
                                    <ItemTemplate>
                                        <%# Eval("File_Last_Modified")%>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#3A5568" ForeColor="White" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Action">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink2" runat="server" 
                                            NavigateUrl='./Upload/<%# Eval("File_Name")%>' Text="DownLoad"></asp:HyperLink>
                                        <asp:LinkButton ID="File_Remove" runat="server" 
                                            CommandArgument='<%#Eval("File_No") %>' CommandName="file_no">Remove</asp:LinkButton>
                                        <br />
                                        <asp:LinkButton ID="File_Edite" runat="server" 
                                            CommandArgument='<%#Eval("File_No") %>' CommandName="file_no1">Edit</asp:LinkButton>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#3A5568" ForeColor="White" />
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="CmdPervisou" runat="server" Font-Bold="True" Text="previous" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="mdNext" runat="server" Font-Bold="True" onclick="mdNext_Click" 
                            Text="Next" />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    </fieldset></td>
            </tr>
        </table>
    </div>
</asp:Content>

