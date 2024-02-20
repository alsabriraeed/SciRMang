<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default1.aspx.vb" Inherits="_Default1" %>

<%@ Register Assembly="GradientPanel" Namespace="BXSW.SLControls" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>SMTP Demonstration</title>
</head>
<body style="font-size: medium; font-family: Arial; color: navy;" text="#000099">
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
            <tr>
                <td height="60" valign="bottom">
                    <cc1:GradientPanel ID="GradientPanel1" runat="server" Direction="Vertical" EndColor="DarkGray"
                        Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="Black" Height="60px"
                        StartColor="LightSteelBlue">
                        <br />
                        &nbsp; &nbsp;&nbsp;&nbsp; Send SMTP Mail Demonstration<br />
                        &nbsp;
                    </cc1:GradientPanel>
                    <br />
                </td>
            </tr>
            <tr>
                <td height="100%" valign="top">
                    <table style="width: 100%">
                        <tr>
                            <td align="right" style="width: 20%; height: 9px" valign="top">
                                &nbsp; To:&nbsp;
                            </td>
                            <td style="width: 100%; height: 9px" valign="top">
                                &nbsp;
                                <asp:TextBox ID="txtTo" runat="server" Width="432px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="right" height="10" style="width: 20%" valign="top">
                                &nbsp; From:&nbsp;
                            </td>
                            <td height="20" style="width: 100%" valign="top">
                                &nbsp;
                                <asp:TextBox ID="txtFrom" runat="server" Width="432px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="right" height="10" style="width: 20%" valign="top">
                                &nbsp; CC:&nbsp;
                            </td>
                            <td height="20" style="width: 100%" valign="top">
                                &nbsp;
                                <asp:TextBox ID="txtCC" runat="server" Width="432px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="right" height="10" style="width: 20%" valign="top">
                                &nbsp; Subject:&nbsp;
                            </td>
                            <td height="20" style="width: 100%" valign="top">
                                &nbsp;
                                <asp:TextBox ID="txtSubject" runat="server" Width="432px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="right" height="10" style="width: 20%" valign="top">
                                &nbsp; Message:&nbsp;
                            </td>
                            <td height="20" style="width: 100%" valign="top">
                                &nbsp;
                                <asp:TextBox ID="txtMessage" runat="server" Height="216px" TextMode="MultiLine" Width="432px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="right" height="10" style="width: 20%" valign="top">
                                &nbsp; Attachments:&nbsp;
                            </td>
                            <td height="20" style="width: 100%" valign="top">
                                &nbsp;&nbsp;<asp:FileUpload ID="fileAttachments" runat="server" Width="520px" /></td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 20%; height: 20px" valign="top">
                            </td>
                            <td style="width: 100%; height: 20px" valign="top">
                                &nbsp;
                                <asp:Button ID="btnClear" runat="server" Text="Clear" />
                                <asp:Button ID="btnSend" runat="server" Text="Send" /></td>
                        </tr>
                    </table>
                    <br />
                    &nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/sendSmsMsg.aspx">No, I want to send an SMS Message to a Cell Phone</asp:HyperLink></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
