<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="weekly_calender_form.aspx.cs" Inherits="n01351009_bonus_assignment.weekly_calender_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Weekly Calender</title>
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Weekly Calender</h1>
            <section>
                <h2>Select your weekly work/study day(s):</h2>
                <asp:CheckBoxList ID="weekly_schedule_days" runat="server" CausesValidation="True">
                    <asp:ListItem Value="0">Monday</asp:ListItem>
                    <asp:ListItem Value="1">Tuesday</asp:ListItem>
                    <asp:ListItem Value="2">Wednesday</asp:ListItem>
                    <asp:ListItem Value="3">Thursday</asp:ListItem>
                    <asp:ListItem Value="4">Friday</asp:ListItem>
                    <asp:ListItem Value="5">Saturday</asp:ListItem>
                    <asp:ListItem Value="6">Sunday</asp:ListItem>
                </asp:CheckBoxList>
            </section>
            <section>
                <asp:Button ID="btn_Submit" runat="server" Text="Submit" />
            </section>
            <section>
                <div runat="server" id="weekly_calender_summary"></div>
            </section>
        </div>
    </form>
</body>
</html>
