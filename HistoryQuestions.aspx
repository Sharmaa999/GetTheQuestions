<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HistoryQuestions.aspx.cs" Inherits="WebApplication7.HistoryQuestions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>History Questions</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
     <link rel="stylesheet" href="styles.css">
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <h2>History Questions</h2>
            <asp:Label ID="lblQuestions" runat="server" EnableViewState="false" />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" EnableViewState="false" />
        </div>
    </form>
</body>
</html>
