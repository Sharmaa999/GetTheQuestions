<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="9thClass.aspx.cs" Inherits="WebApplication7._9thClass" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>9th Class Subjects</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
     <link rel="stylesheet" href="styles.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>9th Class Subjects</h2>
            <asp:Button ID="btnMaths" runat="server" Text="Maths" OnClick="btnSubject_Click" />
            <asp:Button ID="btnSocialScience" runat="server" Text="Social Science" OnClick="btnSubject_Click" />
            <asp:Button ID="btnScience" runat="server" Text="Science" OnClick="btnSubject_Click" />
            <asp:Button ID="btnEnglish" runat="server" Text="English" OnClick="btnSubject_Click" />
        </div>
    </form>
</body>
</html>
