<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QA.aspx.cs" Inherits="WebApplication7.QA" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>QA Subjects</title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>QA Subjects</h2>
            <asp:Button ID="btnIndianCultureAdvance" runat="server" Text="Indian Culture Advance" OnClick="btnSubject_Click" />
            <asp:Button ID="btnHistory" runat="server" Text="History" OnClick="btnSubject_Click" />
            <asp:Button ID="btnEnvironment" runat="server" Text="Environment" OnClick="btnSubject_Click" />
        </div>
    </form>
</body>
</html>
