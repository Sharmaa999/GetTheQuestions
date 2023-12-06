﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnvironmentQuestions.aspx.cs" Inherits="WebApplication7.EnvironmentQuestions" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Environment Questions</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
     <link rel="stylesheet" href="styles.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Environment Questions</h2>
            <asp:Label ID="lblQuestions" runat="server" EnableViewState="false" />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" EnableViewState="false" />
        </div>
    </form>
</body>
</html>
