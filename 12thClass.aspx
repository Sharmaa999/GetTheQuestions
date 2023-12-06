<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="12thClass.aspx.cs" Inherits="WebApplication7._12thClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>12th Class Subjects</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
     <link rel="stylesheet" href="styles.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>12th Class Subjects</h2>
            <asp:Button ID="btnBiology" runat="server" Text="Biology" OnClick="btnSubject_Click" />
            <asp:Button ID="btnChemistry" runat="server" Text="Chemistry" OnClick="btnSubject_Click" />
            <asp:Button ID="btnPhysics" runat="server" Text="Physics" OnClick="btnSubject_Click" />
            <asp:Button ID="btnIT" runat="server" Text="IT" OnClick="btnSubject_Click" />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
