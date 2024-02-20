<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditorinCilfDecisionandCommentsforManuscript.aspx.cs" Inherits="EditorinCilfDecisionandCommentsforManuscript" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style1
        {
            height: 20px;
            width: 897px;
        }
        .style3
        {
            width: 67px;
        }
        .style4
        {
            width: 153px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="border: 1px solid #000000; height: 747px; width: 982px;">
        <br />
        &nbsp;
        <fieldset style="height: 546px; width: 954px; background-color: #F2F2F2; margin-left: 11px; font-weight: normal; font-family: 'MS Reference Sans Serif'; font-size: 10px; bottom: 1px;">
            <legend style="border-style: solid; border-width: 1px; font-family: 'MS Reference Sans Serif'; font-size: x-small; font-weight: bold; width: 560px;">
                &nbsp;Editor-in-Chief Decision and Comments for Manuscript Number<asp:Label 
                    ID="Article_Notxt" runat="server" Text=".........................."></asp:Label>
            </legend>&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <table align="right" cellpadding="0" cellspacing="0" 
                style="height: 30px; font-size: 9px; font-weight: bold; width: 926px;">
                <tr>
                    <td class="style1">
                        cartilaginous Avulsion of the Femoral Attachment of the Another Cruciate 
                        Ligament in a Three-Year-Old Child: A Thirteen-Year-Followup. A Case Report.<br />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Original Submission&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" 
                Text="..............................................."></asp:Label>
            &nbsp;<asp:Label ID="Label4" runat="server" ForeColor="Red" Text="(..............)"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table align="center" cellpadding="0" cellspacing="0" 
                style="height: 11px; width: 489px">
                <tr>
                    <td class="">
                        &nbsp;&nbsp;Decision:</td>
                    <td class="">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="147px">
                            <asp:ListItem>No Decision</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="">
                        &nbsp;Overall Editor Manuscript Rating(1-100):
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="32px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CmdClose" runat="server" BackColor="#F2F2F2" Height="23px" 
                Text="Cancel" Width="52px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CmdClose0" runat="server" BackColor="#F2F2F2" Height="23px" 
                onclick="CmdClose0_Click" Text="Save &amp; Submit Later " Width="129px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CmdClose1" runat="server" BackColor="#F2F2F2" Height="23px" 
                Text="Proof &amp; Print" Width="81px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CmdClose2" runat="server" BackColor="#F2F2F2" Height="23px" 
                Text="Proceed" Width="67px" />
            <br />
            &nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink27" runat="server" Font-Bold="False" 
                Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="XX-Small" 
                Font-Underline="True" ForeColor="Blue">Details</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink28" runat="server" Font-Bold="False" 
                Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="XX-Small" 
                Font-Underline="True" ForeColor="Blue">History</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink29" runat="server" Font-Bold="False" 
                Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="XX-Small" 
                Font-Underline="True" ForeColor="Blue">Similar Articles in MEDLINE</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink30" runat="server" Font-Bold="False" 
                Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="XX-Small" 
                Font-Underline="True" ForeColor="Blue">Invite Reviewers</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink31" runat="server" Font-Bold="False" 
                Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="XX-Small" 
                Font-Underline="True" ForeColor="Blue">View Manuscript Rating Card</asp:HyperLink>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table align="center" border="1" cellpadding="0" cellspacing="0" class="style1">
                <tr bgcolor="Silver" style="font-weight: bold; font-size: x-small">
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="">
                        &nbsp;Original Submission&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink32" runat="server" Font-Bold="False" 
                            Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="XX-Small" 
                            Font-Underline="True" ForeColor="Blue">..........</asp:HyperLink>
                    </td>
                    <td class="">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink33" runat="server" Font-Bold="False" 
                            Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="XX-Small" 
                            Font-Underline="True" ForeColor="Blue">..........</asp:HyperLink>
                    </td>
                    <td class="">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink34" runat="server" Font-Bold="False" 
                            Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="XX-Small" 
                            Font-Underline="True" ForeColor="Blue">..........</asp:HyperLink>
                    </td>
                    <td class="">
                        &nbsp;<asp:HyperLink ID="HyperLink38" runat="server" Font-Bold="False" 
                            Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="XX-Small" 
                            Font-Underline="True" ForeColor="Blue">Accept</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink35" runat="server" Font-Bold="False" 
                            Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="XX-Small" 
                            Font-Underline="True" ForeColor="Blue">..........</asp:HyperLink>
                    </td>
                    <td class="">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink37" runat="server" Font-Bold="False" 
                            Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="XX-Small" 
                            Font-Underline="True" ForeColor="Blue">..........</asp:HyperLink>
                    </td>
                    <td class="">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink44" runat="server" Font-Bold="False" 
                            Font-Italic="False" Font-Names="MS Reference Sans Serif" Font-Size="XX-Small" 
                            Font-Underline="True" ForeColor="Blue">..........</asp:HyperLink>
                    </td>
                    <td class="">
                        &nbsp;</td>
                </tr>
            </table>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CmdClose3" runat="server" BackColor="#F2F2F2" Height="23px" 
                onclick="CmdClose3_Click" Text="Editor Instructions" Width="121px" />
            <br />
            <br />
            <br />
            &nbsp;
            <br />
            <br />
            &nbsp;<br />
            <br />
            <br />
            &nbsp;
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CmdClose7" runat="server" BackColor="#F2F2F2" Height="23px" 
                Text="Cancel" Width="52px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CmdClose8" runat="server" BackColor="#F2F2F2" Height="23px" 
                Text="Save &amp; Submit Later " Width="129px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CmdClose9" runat="server" BackColor="#F2F2F2" Height="23px" 
                Text="Proof &amp; Print" Width="81px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CmdClose10" runat="server" BackColor="#F2F2F2" Height="23px" 
                Text="Proceed" Width="67px" />
            &nbsp;<br />
        </fieldset></div>
</asp:Content>

