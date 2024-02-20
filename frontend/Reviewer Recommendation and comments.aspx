<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Reviewer Recommendation and comments.aspx.cs" Inherits="Reviewer_Recommendation_and_comments" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style1
        {
            width: 100%;
            border: 3px solid #FFCC66;
            background-color: #c0c0c0;
        }
                
        #field1
        {
            height: 73px;
        }
        
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="4" cellspacing="4" class="style1" dir="ltr" 
        style="border-left: 1px hidden #FFCC66; border-right: 2px hidden #FFCC66; border-top: 1px hidden #FFCC66; border-bottom: 2px hidden #FFCC66; background-color: #FFFFFF; height: 608px; border-width: 1px 2px 2px 1px;">
        <tr>
            <td>
                <fieldset id="field1" runat="server" 
                    style="border: 1px hidden #CCCCCC; background-color: #F4F4F4; margin-left: 46px; right: auto;   left: auto; position: inherit; z-index: auto; width: 910px;">
                    <legend style="border: 1px hidden #CCCCCC; font-family: 'MS Reference Sans Serif'; font-size: small; color: #000000;">
                        &nbsp;Reviewer Recommendation and comments for Menuscript Number
                        <asp:Label ID="Label11" runat="server" Text="استرجاع رقم المراجع "></asp:Label>
                        &nbsp;</legend>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label9" runat="server" BorderColor="#E6E6E3" Height="23px" 
                        style="font-family: Arial, Helvetica, sans-serif; font-size: small; font-weight: 700;" 
                        Text="How To submit a paper to the journal of ABC " Width="283px"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;
                    <asp:Label ID="Label12" runat="server" 
                        style="font-family: 'MS Reference Sans Serif'; font-size: small; text-align: center;" 
                        Text="Orginal submission"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label13" runat="server" 
                        style="font-family: 'MS Reference Sans Serif'; font-size: small" 
                        Text="Reggie Clement"></asp:Label>
                    &nbsp;<asp:Label ID="Label14" runat="server" style="color: #FF0000" 
                        Text="استرجاع المراجعreviewer  1"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label15" runat="server" 
                        style="font-family: 'MS Reference Sans Serif'; font-size: small" 
                        Text="Rcommendation "></asp:Label>
                    &nbsp;<asp:DropDownList ID="RecomendationDd" runat="server">
                        <asp:ListItem Selected="True">no Rcommendation
                        </asp:ListItem>
                        <asp:ListItem Enabled="False">Accept</asp:ListItem>
                        <asp:ListItem>Minor Revsion</asp:ListItem>
                        <asp:ListItem>Reject</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:Label ID="Label18" runat="server" 
                        Text="Overall Manuscript  Rating (1-100)"></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="Overall_Manuscript_Rating" runat="server" Width="55px"></asp:TextBox>
                    <br />
                    <br />
                    &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:Button ID="Button10" runat="server" BackColor="#CCCCCC" 
                        BorderColor="Black" Text="Button" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" BackColor="#CCCCCC" BorderColor="Black" 
                        onclick="Button2_Click" Text="Save &amp; Submit Later" Width="181px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" BackColor="#CCCCCC" BorderColor="Black" 
                        onclick="Button3_Click" Text="Upload Reviewer Attachment " />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button11" runat="server" BackColor="#CCCCCC" 
                        BorderColor="Black" Text="Proof &amp; Print " />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button5" runat="server" BackColor="#CCCCCC" BorderColor="Black" 
                        Text="Proceed" />
                    <br />
                    &nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label17" runat="server" 
                        style="font-family: 'MS Reference Sans Serif'; font-size: small" 
                        Text="For your convenience,and to take advantage of word processing feature (e.g,spell-check,bullts,numbering),we suggest you use your regular word processing program(e.g,Microsoft word,wordprefect) when typing your review. you should then Copy and paste your comments into the boxes provided ,Click the save &amp; submit later button to save your comment and continue working " 
                        Width="90%"></asp:Label>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
                    &nbsp;<asp:Button ID="Button12" runat="server" BackColor="#CCCCCC" 
                        BorderColor="Black" onclick="Button12_Click" Text="Reviewer instruction" />
                    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button14" runat="server" BackColor="#CCCCCC" 
                        BorderColor="Black" onclick="Button14_Click" 
                        Text="Reviewer instruction Comments" />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                </fieldset></td>
        </tr>
    </table>
</asp:Content>

