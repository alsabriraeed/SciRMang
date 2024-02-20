<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style3
        {
            width: 94%;
            margin-right: 2px;
        }
        .style4
        {
            width: 99px;
            height: 1211px;
        }
        .style14
        {
             
            height: 1211px;
            width: 556px;
        }
        .style26
        {
            height: 35px;
            width: 137px;
        }
        .style28
        {
            height: 35px;
            width: 136px;
        }
        .style19
        {
            height: 35px;
        }
        .style11
        {
            width: 141px;
            height: 22px;
        }
        .style27
        {
            width: 137px;
            height: 22px;
        }
        .style29
        {
            width: 136px;
            height: 22px;
        }
        .style17
        {
            height: 22px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp;&nbsp; &nbsp;
    <table border=" 1" cellpadding=" " cellspacing=" " class="style3" 
        style="border-style: groove; border-width: thin; font-family: 'MS Reference Sans Serif'; font-size: small; height: 1162px;">
        <tr style="font-size: small">
            <td class="style4" colspan=" " 
                style="border-style: none dotted none none; border-width: thin; font-weight: bold; font-size: small;" 
                valign="top">
                <br />
                <br />
                Editor Main Menuess<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style14" colspan=" " style="border-left-style: " valign="top">
                <fieldset runat="server" style="background-color: #F2F2F2; width: 772px;">
                    <legend style="background-color: #FFFFFF; border-style: groove">Submission With</legend>
                    <table "55px" ;="" class="style3" >
                        <tr>
                            <td class="">
                                <asp:LinkButton ID="One_Reviews_Complete" runat="server" Enabled="False" 
                                    onclick="One_Reviews_Complete_Click">1 Reviews Complete</asp:LinkButton>
                            </td>
                            <td class="">
                                <asp:LinkButton ID="Two_Reviews_Complete" runat="server" Enabled="False" 
                                    onclick="Two_Reviews_Complete_Click">2 Reviews Complete</asp:LinkButton>
                            </td>
                            <td class="">
                                <asp:LinkButton ID="Tree_Reviews_Complete" runat="server" Enabled="False" 
                                    onclick="Tree_Reviews_Complete_Click">3 Reviews Complete</asp:LinkButton>
                            </td>
                            <td class="">
                                <asp:LinkButton ID="Four_Reviews_Complete" runat="server" Enabled="False" 
                                    onclick="Four_Reviews_Complete_Click">+4 Reviews Complete</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td class="">
                                <asp:Label ID="One_Reviews_Complete_Count" runat="server">1</asp:Label>
                            </td>
                            <td class="" valign="top">
                                <asp:Label ID="Two_Reviews_Complete_Count" runat="server">2</asp:Label>
                            </td>
                            <td class="">
                                <asp:Label ID="Three_Reviews_Complete_Count" runat="server">3</asp:Label>
                            </td>
                            <td class="">
                                <asp:Label ID="Four_Reviews_Complete_Count" runat="server">4</asp:Label>
                            </td>
                        </tr>
                    </table>
                </fieldset>
                <br />
                <br />
                <fieldset id="Fieldset2" runat="server" 
                    style="background-color: #F2F2F2; margin-right: 0px; width: 776px;">
                    <legend style="background-color: #FFFFFF; border-style: groove; width: 84px;">Search
                    </legend>&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink5" runat="server" Font-Underline="True" 
                        NavigateUrl="~/SearchSubmission.aspx">Search Submission</asp:HyperLink>
                    &nbsp;|
                    <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click" 
                        style="font-weight: 700">Search People</asp:LinkButton>
                    <br />
                    <br />
                </fieldset>
                <br />
                <br />
                <br />
                <fieldset id="Fieldset1" runat="server" 
                    style="background-color: #F2F2F2; height: 103px; width: 779px;">
                    <legend style="background-color: #FFFFFF; border-style: groove">Editor &#39;To-Do&#39; List</legend>
                    &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:HyperLink ID="HyperLink7" runat="server">My Pending Assignment</asp:HyperLink>
                    &nbsp;(<asp:Label ID="lblMyPendingAssignment" runat="server" Text=" "></asp:Label>
                    ) &nbsp; &nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:LinkButton ID="New_Submission_Requering_Assignment" runat="server" 
                        Enabled="False" onclick="New_Submission_Requering_Assignment_Click">New 
                    Submission Requering Assignment</asp:LinkButton>
                    <asp:Label ID="New_Submission_Requering_Assignment_Count" runat="server"></asp:Label>
                    &nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Revised_Submission_Requering_Assignment" runat="server" 
                        Enabled="False" onclick="Revised_Submission_Requering_Assignment_Click">Revised 
                    Submission Requering Assignment</asp:LinkButton>
                    <asp:Label ID="Revised_Submission_Requering_Assignment_Count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="SubmissionNeedingApprovalEdit" runat="server" 
                        Enabled="False" onclick="SubmissionNeedingApprovalEdit_Click">Submission 
                    Needing Approval by Eidtor</asp:LinkButton>
                    &nbsp;<asp:Label ID="SubmissionNeedingApproval" runat="server" 
                        Text="SubmissionNeedingApproval"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:LinkButton ID="Submission_Send_back_to_Author_for_Approval" runat="server" 
                        Enabled="False" onclick="Submission_Send_back_to_Author_for_Approval_Click" 
                        PostBackUrl="~/Submission Send back to Author .aspx">Submission Send back to 
                    Author for Approval</asp:LinkButton>
                    <asp:Label ID="Submission_Send_back_to_Author_for_Approval_count" 
                        runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Submission_Approval_By_Author" runat="server" 
                        Enabled="False" PostBackUrl="~/Submission_Approve_By Author.aspx">Submission 
                    Approval By Author</asp:LinkButton>
                    <asp:Label ID="Submission_Approval_By_Author_Count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Incomplete_Submissions" runat="server" Enabled="False" 
                        onclick="Incomplete_Submissions_Click" 
                        PostBackUrl="~/Incomplete Submissions.aspx">Incomplete Submissions</asp:LinkButton>
                    &nbsp;<asp:Label ID="Incomplete_Submissions_Count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:LinkButton ID="Direct_To_Editor_Ne_Submissions" 
                        runat="server" Enabled="False" onclick="Direct_To_Editor_Ne_Submissions_Click">Direct 
                    to Editor New Submission</asp:LinkButton>
                    &nbsp;
                    <asp:Label ID="number_of_article_Count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Direct_To_Editor_Revised_Submission" runat="server" 
                        Enabled="False" onclick="Direct_To_Editor_Revised_Submission_Click">Direct 
                    to Editor Revised Submission</asp:LinkButton>
                    <asp:Label ID="Number_Of_Revised_Submission" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="New_Invitation" runat="server" Enabled="False" 
                        PostBackUrl="~/ReciveInvititionsForAssignment.aspx">New Invitation</asp:LinkButton>
                    <asp:Label ID="New_Invitation_Count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="New_Assignment" runat="server" Enabled="False" 
                        PostBackUrl="~/New Assignments.aspx">New Assignment</asp:LinkButton>
                    <asp:Label ID="New_Assignment_Count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Submission_With_Required_Reviews_Complete" runat="server" 
                        Enabled="False" onclick="Submission_With_Required_Reviews_Complete_Click">Submission 
                    With Required Reviews Complete</asp:LinkButton>
                    <asp:Label ID="Submission_With_Required_Reviews_Complete_Count" runat="server"></asp:Label>
                    &nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:HyperLink ID="HyperLink10" runat="server" ForeColor="#0000CC" 
                        NavigateUrl="~/Submissions Requiring Additional Reviewers.aspx">Submissions 
                    Requiring Additional Reviewers</asp:HyperLink>
                    (<asp:Label ID="lblSubmissionsRequiringAdditionalReviewers" runat="server" 
                        Text=" "></asp:Label>
                    )
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink36" runat="server">Reviews In Progress</asp:HyperLink>
                    ()<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Editor_Invited_No_Response" runat="server" Enabled="False" 
                        onclick="Editor_Invited_No_Response_Click">Editor Invited-No Response</asp:LinkButton>
                    <asp:Label ID="Editor_Invited_No_Response_Count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Editor_Assign_No_Complete" runat="server" Enabled="False" 
                        onclick="Editor_Assign_No_Complete_Click">Editor Assign_No Complete</asp:LinkButton>
                    <asp:Label ID="Editor_Assign_No_Complete_Count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Decline_Editor_For_Submissions" runat="server" 
                        Enabled="False" onclick="Decline_Editor_For_Submissions_Click">Decline 
                    Editor For Submissions</asp:LinkButton>
                    <asp:Label ID="Decline_Editor_For_Submissions_Count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink12" runat="server">Reviews In Progress</asp:HyperLink>
                    (<asp:Label ID="lblReviewsInProgress" runat="server" Text=" "></asp:Label>
                    )
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Reviewers_Invited_No_Response" runat="server" 
                        Enabled="False" onclick="Reviewers_Invited_No_Response_Click1">Reviewers 
                    Invited-No Response</asp:LinkButton>
                    <asp:Label ID="Reviewers_Invited_No_Response_Count" runat="server"></asp:Label>
                    &nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Submissions_Under_Review" runat="server" Enabled="False" 
                        onclick="Submissions_Under_Review_Click">Submissions Under Review</asp:LinkButton>
                    <asp:Label ID="Submissions_Under_Review_cont" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Decline_Reviewer_For_Submissins" runat="server" 
                        Enabled="False" onclick="Decline_Reviewer_For_Submissins_Click">Decline Reviewer For Submissins</asp:LinkButton>
                    &nbsp;<asp:Label ID="Decline_Reviewer_For_Submissins_Count" runat="server"></asp:Label>
                    <br />
                </fieldset><br />
                &nbsp;<fieldset style="width: 768px; height: 99px">
                    <br />
                    <legend style="border: thin solid #CCCCCC">View All Assigned&nbsp;</legend>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="View_All_Assigned_Submissions" runat="server" 
                        Enabled="False" onclick="View_All_Assigned_Submissions_Click">View All 
                    Assigned Submission</asp:LinkButton>
                    <asp:Label ID="View_All_Assigned_Submissions_count" runat="server"></asp:Label>
                    &nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="View_All_Assigned_Submission" runat="server" 
                        Enabled="False" onclick="View_All_Assigned_Submission_Click">View All 
                    Assigned Submissions being Edited
                    </asp:LinkButton>
                    <asp:Label ID="View_All_Assigned_Submission_count" runat="server"></asp:Label>
                </fieldset>
                <br />
                <br />
                <br />
                <fieldset id="Fieldset4" runat="server" 
                    style="background-color: #F2F2F2; margin-right: 0px; width: 780px;">
                    <legend style="background-color: #FFFFFF; border-style: groove">Subordinate Editor 
                        Pending Assignments</legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Group_By_Editor_Assigned" runat="server" Enabled="False" 
                        onclick="Group_By_Editor_Assigned_Click">Group By Editor Assigned</asp:LinkButton>
                    <asp:Label ID="Group_By_Editor_Assigned_Count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Group_By_Editor_With_current_Responsibility" runat="server" 
                        Enabled="False" onclick="Group_By_Editor_With_current_Responsibility_Click">Group 
                    By Editor With current Responsibility</asp:LinkButton>
                    <asp:Label ID="Group_By_Editor_With_current_Responsibility_Count" 
                        runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Group_By_Manuscript_Status" runat="server" Enabled="False" 
                        onclick="Group_By_Manuscript_Status_Click">Group By Manuscript Status</asp:LinkButton>
                    <asp:Label ID="Group_By_Manuscript_Status_Count" runat="server"></asp:Label>
                </fieldset>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;
                <br />
                <fieldset id="Fieldset5" runat="server" 
                    style="background-color: #F2F2F2; margin-right: 0px; width: 781px;">
                    <legend style="background-color: #FFFFFF; border-style: groove">Submissions With 
                        Decisions</legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Submissions_Out_For_Revisions" runat="server" 
                        Enabled="False" onclick="Submissions_Out_For_Revisions_Click">Submissions 
                    Out For Revisions</asp:LinkButton>
                    <asp:Label ID="Submissions_Out_For_Revisions_count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="All_Submissions_With_Editors_Decision" runat="server" 
                        Enabled="False" onclick="All_Submissions_With_Editors_Decision_Click">All 
                    Submissions With Editors Decisions</asp:LinkButton>
                    <asp:Label ID="All_Submissions_With_Editors_Decision_count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink22" runat="server" Font-Underline="True">All 
                    Submissions With Final Decisions
                    </asp:HyperLink>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:LinkButton ID="Accept" runat="server" Enabled="False" 
                        onclick="Accept_Click">Accept</asp:LinkButton>
                    <asp:Label ID="Accept_Count" runat="server"></asp:Label>
                    ,
                    <asp:LinkButton ID="Reject" runat="server" Enabled="False" 
                        onclick="Reject_Click1">Reject</asp:LinkButton>
                    <asp:Label ID="Reject_Count" runat="server"></asp:Label>
                    ,
                    <asp:LinkButton ID="Withdrawen" runat="server" Enabled="False" 
                        onclick="Withdrawen_Click1">Withdrawen</asp:LinkButton>
                    <asp:Label ID="Withdrawen_Count" runat="server"></asp:Label>
                    (<asp:Label ID="lblWithdrawen" runat="server" Text=" "></asp:Label>
                    )
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:LinkButton ID="My_Assignments_With_Decision" 
                        runat="server" Enabled="False" onclick="My_Assignments_With_Decision_Click">My 
                    Assignments With Decision</asp:LinkButton>
                    <asp:Label ID="My_Assignments_With_Decision_Count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                </fieldset>
                <br />
                <br />
                <br />
                <fieldset id="Fieldset6" runat="server" 
                    style="background-color: #F2F2F2; margin-right: 0px; width: 781px;">
                    <legend style="background-color: #FFFFFF; border-style: groove; height: 22px;">
                        Linked Submision Groups </legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click">Linked 
                    Groups</asp:LinkButton>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:LinkButton ID="Active_Linked_Submision_Groups" runat="server" 
                        Enabled="False" onclick="Active_Linked_Submision_Groups_Click">Active Linked 
                    Submision Groups</asp:LinkButton>
                    <asp:Label ID="Active_Linked_Submision_Groups_Count" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Inactive_Linked_Submision_Groups" runat="server" 
                        Enabled="False" onclick="Inactive_Linked_Submision_Groups_Click">Inactive 
                    Linked Submision Groups</asp:LinkButton>
                    <asp:Label ID="Inactive_Linked_Submision_Groups_Count" runat="server"></asp:Label>
                    <br />
                </fieldset>
                <br />
                <br />
                <br />
                <fieldset id="Fieldset7" runat="server" 
                    style="background-color: #F2F2F2; margin-right: 0px; width: 779px; height: 142px;">
                    <legend style="background-color: #FFFFFF; border-style: groove; height: 19px; ">
                        System Administrator Administrative Functions</legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">System 
                    Administrator Functions</asp:LinkButton>
                    &nbsp;&nbsp; &nbsp;&nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:HyperLink ID="HyperLink30" runat="server" Font-Underline="True" 
                        ForeColor="#0000CC">Register New User</asp:HyperLink>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click4">Send 
                    Reminder
                    </asp:LinkButton>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</fieldset> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
    </table>
</asp:Content>

