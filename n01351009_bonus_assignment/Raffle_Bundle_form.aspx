<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Raffle_Bundle_form.aspx.cs" Inherits="n01351009_bonus_assignment.Raffle_Bundle_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HTTB Program - A Raffle</title>
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>HTTB Program - A Raffle</h1>
            <section>
                <h2>Enter the number of ticket(s)</h2>
                <asp:TextBox ID="number_of_tickets" type="number" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="number_of_tickets" ErrorMessage="Please enter number of ticket(s)"></asp:RequiredFieldValidator>
                <asp:CustomValidator runat="server" ForeColor="Red" ControlToValidate="number_of_tickets" OnServerValidate="Number_Of_Tickets_Validate" ErrorMessage="Please enter valid number of tickets"></asp:CustomValidator>
            </section>
            <section>
                <asp:Button ID="btn_submit" runat="server" Text="Order" />
            </section>
            <section>
                <div runat="server" id="raffle_bundle_summary"></div>
            </section>
        </div>
    </form>
</body>
</html>
