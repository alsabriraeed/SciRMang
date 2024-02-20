<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Add_Edit_Remove_Author.aspx.cs" Inherits="Add_Edit_Remove_Author" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style2
        {
            height: 740px;
        }
        .style3
        {
            width: 203px;
        }
        .style8
        {
            width: 3px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 850px">
        <table class="style2" style="border: 1pt solid #666666;">
            <tr>
                <td class="" 
                    style="font-size: medium; font-family: 'Microsoft Sans Serif'; font-weight: bold;" 
                    valign="top">
                    <br />
                    <br />
                    Edit Submission<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <table align="center" cellspacing="1" class="style7" 
                        style="width: 211px; height: 123px">
                        <tr>
                            <td class="">
                                &nbsp;</td>
                            <td align="left">
                                <asp:Label ID="Label2" runat="server" BackColor="#F2F2F2" BorderColor="Black" 
                                    BorderStyle="Groove" BorderWidth="1px" Font-Bold="True" Font-Size="X-Small" 
                                    Height="22px" 
                                    Text="Enter Metadata                                     ‬                   " 
                                    Width="96%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="">
                                &nbsp;</td>
                            <td align="left">
                                <asp:Label ID="Label3" runat="server" BackColor="#F2F2F2" BorderColor="Black" 
                                    BorderStyle="Groove" BorderWidth="1px" Font-Bold="True" Font-Size="X-Small" 
                                    Height="22px" style="margin-left: 0px" Text="Add/Edit/Remove Authors" 
                                    Width="96%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="">
                                &nbsp;</td>
                            <td align="left">
                                <asp:Label ID="Label4" runat="server" BackColor="#F2F2F2" BorderColor="Black" 
                                    BorderStyle="Groove" BorderWidth="1px" Font-Bold="True" Font-Size="X-Small" 
                                    Height="22px" Text="Attach File" Width="96%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="">
                                &nbsp;</td>
                            <td valign="top">
                                &nbsp;</td>
                        </tr>
                    </table>
                                        </td>
                                        <td class="" 
                                            style="border-left-style: dotted; border-left-width: thin; border-left-color: #0099CC" 
                                            valign="top">
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                                            <br />
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="Label64" runat="server" Font-Size="Small" Font-Underline="True" 
                                                ForeColor="#0000CC" Text="Insert Special Chararcter"></asp:Label>
                                            <br />
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <fieldset style="background-position: 25px -54px; height: 685px; background-color: #CCCCCC; right: 20px; left: 30px; width: 602px; margin-right: 20px; margin-left: 19px;">
                                                <legend style="border-width: thin; border-style: solid; width: 204px; height: 19px; background-color: #FFFFFF; font-weight: bold; vertical-align: top;">
                                                    Please Enter the Following;&nbsp;&nbsp;</legend>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                        <hr style="border: 1pt solid #FF0000; background-color: #FFFFFF; color: #FF0000; height: -15px;" 
                            width="95%" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label66" runat="server" ForeColor="#000066" Text="  Enter the names of anyone who contributed to your manuscript by clicking 'Add&lt;br/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Author'.The order of the author may be changed by clicking the arrows. the first &lt;br /&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;author of the manuscript may be indicated .Multiple Academic Degree may be &lt;br /&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;entered ,separated by commas(M.U.,thu,ju).to change the corresponding author,&lt;br /&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;enter the new corresponding author's name in the text boxes,and clicck the check box&lt;br /&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;labeled 'please select if this is the corresponding author'.
"></asp:Label>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; A * indicates the field is required .<hr 
                            style="border: 1pt solid #FF0000; color: #FF0000; height: -15px;" width="95%" />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:Label ID="Label67" runat="server" Text="First Name*"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txt_author_first_name" runat="server" Height="18px" 
                            Width="233px"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label68" runat="server" Text="Middle Initial"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txt_author_middle_name" runat="server" Width="235px"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label69" runat="server" Text="Last Names*"></asp:Label>
                        &nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:TextBox ID="txt_author_last_name" runat="server" Width="236px"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label71" runat="server" Text="Academic Degree(s)"></asp:Label>
                        &nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:TextBox ID="txt_academic_degree" runat="server" Height="16px" 
                            Width="236px"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label72" runat="server" Text="Affiliation"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                        <asp:TextBox ID="txt_author_affiliation" runat="server" Width="236px"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label73" runat="server" Text="E-mail Address"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txt_author_E_mail_address" runat="server" Width="235px"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label74" runat="server" 
                            Text="Please select if this is the corresponding author"></asp:Label>
                        &nbsp;<asp:CheckBox ID="chcorrespondingauthor" runat="server" Text=" " />
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lpl" runat="server" Text="lpl"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" 
                            onclick="Button4_Click" Text="Update " />
                        &nbsp;&nbsp; &nbsp;
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                            Text="Add Author" Width="126px" />
                        &nbsp;<br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" PostBackUrl="~/EditSubmition.aspx" 
                            Text="Previous" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button3" runat="server" PostBackUrl="~/AttachFiles.aspx" 
                            Text="Next" />
                        &nbsp;<asp:GridView ID="GrdAuthor" runat="server" AutoGenerateColumns="False" 
                            CellPadding="4" ForeColor="#333333" GridLines="None" Height="2%" 
                            onrowcommand="GrdAuthor_RowCommand" style="margin-left: 16px" Width="572px">
                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <RowStyle BackColor="#FFFBD6" BorderColor="#999999" ForeColor="#333333" />
                            <Columns>
                                <asp:TemplateField>
                                    <HeaderStyle BackColor="#3A5568" BorderStyle="None" Font-Bold="True" 
                                        Font-Names="MS UI Gothic" Font-Size="X-Small" ForeColor="White" Height="5%" 
                                        Width="25%" />
                                    <ItemStyle Font-Bold="True" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="First Name">
                                    <ItemTemplate>
                                        <%#Eval("Author_First_Name")%>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#3A5568" ForeColor="White" Height="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Middle Initial">
                                    <ItemTemplate>
                                        <%#Eval("Author_Middle_Name")%>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#3A5568" ForeColor="White" Height="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Last Name">
                                    <ItemTemplate>
                                        <%#Eval("Author_Last_Name")%>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#3A5568" ForeColor="White" Height="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Academic Degree">
                                    <ItemTemplate>
                                        <%#Eval("Author_Acadimic_Degree")%>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#3A5568" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Affilation">
                                    <ItemTemplate>
                                        <%#Eval("Author_Afilication")%>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#3A5568" ForeColor="White" Height="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="E-mail Address">
                                    <ItemTemplate>
                                        <%#Eval("Author_Email_Address")%>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#3A5568" ForeColor="White" Height="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Action">
                                    <FooterStyle ForeColor="White" />
                                    <HeaderStyle BackColor="#3A5568" />
                                    <ItemTemplate>
                                        <asp:LinkButton ID="Edit_Author" runat="server" 
                                            CommandArgument='<%#Eval("Author_No")%>' CommandName="Edit_Author">Edit_Author</asp:LinkButton>
                                        <asp:LinkButton ID="Remove_Author" runat="server" 
                                            CommandArgument='<%#Eval("Author_No")%>' CommandName="Remove_Author">Remove_Author</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <AlternatingRowStyle BackColor="White" />
                        </asp:GridView>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                    </fieldset><br />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

