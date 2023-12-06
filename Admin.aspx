<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebApplication7.Admin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Panel</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
           

            <h2>Welcome, Admin!</h2>
             <asp:DropDownList ID="ddlClass" runat="server">
                <asp:ListItem Text="10th Class" Value="10"></asp:ListItem>
                <asp:ListItem Text="12th Class" Value="12"></asp:ListItem>
                <asp:ListItem Text="NEET" Value="NEET"></asp:ListItem>
                <asp:ListItem Text="UPSC" Value="UPSC"></asp:ListItem>
                <asp:ListItem Text="QA" Value="QA"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:DropDownList ID="ddlSubject" runat="server">
                <asp:ListItem Text="Geometry" Value="Geometry"></asp:ListItem>
                <asp:ListItem Text="Algebra" Value="Algebra"></asp:ListItem>
                <asp:ListItem Text="Science1" Value="Science1"></asp:ListItem>
                <asp:ListItem Text="Science2" Value="Science2"></asp:ListItem>
                <asp:ListItem Text="Biology" Value="Biology"></asp:ListItem>
                <asp:ListItem Text="Chemistry" Value="Chemistry"></asp:ListItem>
                <asp:ListItem Text="Physics" Value="Physics"></asp:ListItem>
                <asp:ListItem Text="IT" Value="IT"></asp:ListItem>
                <asp:ListItem Text="BiologyAdvance" Value="BiologyAdvance"></asp:ListItem>
                <asp:ListItem Text="ChemistryAdvance" Value="ChemistryAdvance"></asp:ListItem>
                <asp:ListItem Text="PhysicsAdvance" Value="PhysicsAdvance"></asp:ListItem>
                <asp:ListItem Text="Reasoning" Value="Reasoning"></asp:ListItem>
                <asp:ListItem Text="IndianCulture" Value="IndianCulture"></asp:ListItem>
                <asp:ListItem Text="Politics" Value="Politics"></asp:ListItem>
                <asp:ListItem Text="Quants" Value="Quants"></asp:ListItem>
                <asp:ListItem Text="IndianCultureAdvance" Value="IndianCultureAdvance"></asp:ListItem>
                <asp:ListItem Text="History" Value="History"></asp:ListItem>
                <asp:ListItem Text="Environment" Value="Environment"></asp:ListItem>
            </asp:DropDownList>
            <br />

            <div>
                <label for="txtQuestion">Question Text:</label>
                <asp:TextBox ID="txtQuestion" runat="server"></asp:TextBox>
            </div>

            <div>
                <label for="txtMarks">Marks:</label>
                <asp:TextBox ID="txtMarks" runat="server"></asp:TextBox>
            </div>

            <div>
                <label for="ddlLevel">Level:</label>
                <asp:DropDownList ID="ddlLevel" runat="server">
                    <asp:ListItem Text="Easy" Value="Easy"></asp:ListItem>
                    <asp:ListItem Text="Medium" Value="Medium"></asp:ListItem>
                    <asp:ListItem Text="Hard" Value="Hard"></asp:ListItem>
                </asp:DropDownList>
            </div>

            
            <!-- Display success message -->
            <div>
                <asp:Label ID="Label1" runat="server" ForeColor="Green"></asp:Label>
            </div>


           
            <div>
                <asp:Button ID="Button1" runat="server" Text="Insert Questions" OnClick="btnInsertQuestions_Click" />
            </div>
            <asp:Label ID="lblSuccessMessage" runat="server" Text=""></asp:Label>

             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="QuestionText" HeaderText="Question" SortExpression="QuestionText" />
        <asp:BoundField DataField="Marks" HeaderText="Marks" SortExpression="Marks" />
        <asp:BoundField DataField="Level" HeaderText="Level" SortExpression="Level" />
    </Columns>
</asp:GridView>

            
            

        </div>
    </form>
</body>
</html>
