<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Raffle_Bundle_form.aspx.cs" Inherits="n01351009_bonus_assignment.Raffle_Bundle_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HTTB Program - A Raffle</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>HTTB Program - A Raffle</h1>
            <section>
                <h2>Enter the number of ticket(s)</h2>
                <asp:TextBox ID="number_of_tickets" type="number" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="number_of_tickets" ErrorMessage="Please enter number of ticket(s)"></asp:RequiredFieldValidator>
                <asp:CompareValidator runat="server" ControlToValidate="number_of_tickets" Operator="GreaterThan" ValueToCompare="0" ErrorMessage="Please enter number of ticket(s) greater than 0"></asp:CompareValidator>
            </section>
            <section>
                <asp:Button ID="btn_submit" runat="server" Text="Order" />
            </section>
            <section>
                <div id=""></div>
            </section>
        </div>
    </form>
</body>
</html>
