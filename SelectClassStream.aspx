<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectClassStream.aspx.cs" Inherits="WebApplication7.SelectClassStream" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Select Class Stream</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
     <link rel="stylesheet" href="styles.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Select Class Stream</h2>
            <asp:Button ID="btnClass9" runat="server" Text="9th Class" OnClick="btnClass_Click" />
            <asp:Button ID="btnClass10" runat="server" Text="10th Class" OnClick="btnClass_Click" />
            <asp:Button ID="btnClass12" runat="server" Text="12th Class" OnClick="btnClass_Click" />
            <asp:Button ID="btnNEET" runat="server" Text="NEET" OnClick="btnClass_Click" />
            <asp:Button ID="btnUPSC" runat="server" Text="UPSC" OnClick="btnClass_Click" />
            <asp:Button ID="btnQA" runat="server" Text="QA" OnClick="btnClass_Click" />
        </div>
    </form>
</body>
</html>
