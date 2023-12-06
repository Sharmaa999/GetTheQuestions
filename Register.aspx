<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication7.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styles.css">
    <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
    <script src="password-strength.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Create Account</h2>
            <asp:TextBox ID="txtUsername" runat="server" placeholder="Username" required></asp:TextBox>
            <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password" required></asp:TextBox>
            <div id="password-strength-container"></div>
            <br />
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" placeholder="Confirm Password" required></asp:TextBox>
            <br />
            <asp:DropDownList ID="ddlUserRole" runat="server">
                <asp:ListItem Text="User" Value="User"></asp:ListItem>
                <asp:ListItem Text="Admin" Value="Admin"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblSelectedRole" runat="server" Text="Selected Role: "></asp:Label>
            <asp:Button ID="btnCreateAccount" runat="server" Text="Create Account" OnClick="btnCreateAccount_Click" />
            <asp:Label ID="lblErrorMessage" runat="server" Text="Label"></asp:Label>
        </div>

        <script>
            // Use jQuery to update the selected role label
            $(document).ready(function () {
                $('#<%= ddlUserRole.ClientID %>').change(function () {
                    var selectedRole = $(this).val();
                    $('#<%= lblSelectedRole.ClientID %>').text("Selected Role: " + selectedRole);
                });
            });

            // Use jQuery to initialize password strength indicator
            $(document).ready(function () {
                $('#txtPassword').passwordStrength({
                    container: '#password-strength-container'
                });
            });
        </script>
    </form>
</body>
</html>
