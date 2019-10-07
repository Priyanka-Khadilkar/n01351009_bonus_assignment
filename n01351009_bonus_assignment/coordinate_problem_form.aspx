<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="coordinate_problem_form.aspx.cs" Inherits="n01351009_bonus_assignment.coordinate_problem_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Coordinate</h1>
        <section>
            <h2>X-axis value :</h2>
            <asp:TextBox ID="x_axis_value" type="number" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="x_axis_value" ErrorMessage="Please enter X-axis value"></asp:RequiredFieldValidator>
            <asp:CompareValidator runat="server" ControlToValidate="x_axis_value" Operator="NotEqual" ValueToCompare="0" ErrorMessage="Please enter non-zero x-axis value"></asp:CompareValidator>
        </section>
        <section>
            <h2>Y-axis value :</h2>
            <asp:TextBox ID="y_axis_value" type="number" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="y_axis_value" ErrorMessage="Please enter Y-axis value"></asp:RequiredFieldValidator>
            <asp:CompareValidator runat="server" ControlToValidate="y_axis_value" Operator="NotEqual" ValueToCompare="0" ErrorMessage="Please enter non-zero y-axis value"></asp:CompareValidator>
        </section>
        <section>
            <div runat="server" id="quadrant_summary"></div>
            <asp:Button ID="btn_submit" runat="server" Text="Submit" />
        </section>
    </form>
</body>
</html>
