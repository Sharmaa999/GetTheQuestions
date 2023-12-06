<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReasoningQuestions.aspx.cs" Inherits="WebApplication7.ReasoningQuestions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reasoning Questions</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
     <link rel="stylesheet" href="styles.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Reasoning Questions</h2>
            <asp:Label ID="lblQuestions" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
