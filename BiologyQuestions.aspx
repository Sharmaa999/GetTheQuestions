<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BiologyQuestions.aspx.cs" Inherits="WebApplication7.Biology" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Biology Questions</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
     <link rel="stylesheet" href="styles.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Biology Questions</h2>
            <!-- Add buttons for Biology questions -->
            <asp:Label ID="lblQuestions" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
