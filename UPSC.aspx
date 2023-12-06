<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UPSC.aspx.cs" Inherits="WebApplication7.UPSC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UPSC Subjects</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>UPSC Subjects</h2>
            <asp:Button ID="btnReasoning" runat="server" Text="Reasoning" OnClick="btnSubject_Click" />
            <asp:Button ID="btnIndianCulture" runat="server" Text="Indian Culture" OnClick="btnSubject_Click" />
            <asp:Button ID="btnPolitics" runat="server" Text="Politics" OnClick="btnSubject_Click" />
            <asp:Button ID="btnQuants" runat="server" Text="Quants" OnClick="btnSubject_Click" />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
