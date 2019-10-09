<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="coordinate_problem_form.aspx.cs" Inherits="n01351009_bonus_assignment.coordinate_problem_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Coordinate</title>
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Coordinate</h1>
        <section>
            <h2>X-axis value :</h2>
            <asp:TextBox ID="x_axis_value" type="number" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="x_axis_value" ErrorMessage="Please enter X-axis value"></asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" ForeColor="Red" ControlToValidate="x_axis_value" OnServerValidate="Validate_Axis_Value" ErrorMessage="Please enter valid number"></asp:CustomValidator>
        </section>
        <section>
            <h2>Y-axis value :</h2>
            <asp:TextBox ID="y_axis_value" type="number" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="y_axis_value" OnServerValidate="Validate_Number" ErrorMessage="Please enter Y-axis value"></asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" ForeColor="Red" ControlToValidate="y_axis_value" OnServerValidate="Validate_Axis_Value" ErrorMessage="Please enter valid number"></asp:CustomValidator>
        </section>
        <section>
            <div runat="server" id="quadrant_summary"></div>
            <asp:Button ID="btn_submit" runat="server" Text="Submit" />
        </section>
    </form>
</body>
</html>
