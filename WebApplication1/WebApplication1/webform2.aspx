<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webform2.aspx.cs" Inherits="WebApplication1.webform2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Preferred Electives (Select any 3)<br />
            <br />
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="123px" SelectionMode="Multiple">
            <asp:ListItem Value="Cloud Computing"></asp:ListItem>
            <asp:ListItem Value="Web Services"></asp:ListItem>
            <asp:ListItem Value="Network Security"></asp:ListItem>
            <asp:ListItem Value="Artificial Intelligence"></asp:ListItem>
            <asp:ListItem Value="Optimization Techniques"></asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Confirm" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="63px" TextMode="MultiLine" Visible="False" Width="322px"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Select 3 only " Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Select Submission Date" Visible="False" />
    </form>
</body>
</html>
