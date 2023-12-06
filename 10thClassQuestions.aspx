<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="10thClassQuestions.aspx.cs" Inherits="WebApplication7._10thClassQuestions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>10th Class Questions</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
     <link rel="stylesheet" href="styles.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>10th Class Questions</h2>
            <asp:Button ID="btnGeometry" runat="server" Text="Geometry" OnClick="btnSubject_Click" />
            <asp:Button ID="btnAlgebra" runat="server" Text="Algebra" OnClick="btnSubject_Click" />
            <asp:Button ID="btnScience1" runat="server" Text="Science1" OnClick="btnSubject_Click" />
            <asp:Button ID="btnScience2" runat="server" Text="Science2" OnClick="btnSubject_Click" />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
