<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webform1.aspx.cs" Inherits="WebApplication1.webform1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Enter username:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <div>
            Enter password:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Value="Red"></asp:ListItem>
                <asp:ListItem Value="Green"></asp:ListItem>
                <asp:ListItem Value="Blue"></asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem Value="Bold"></asp:ListItem>
                <asp:ListItem Value="Italic"></asp:ListItem>
                <asp:ListItem Value="Underline"></asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Redirect" Visible="False" />
        </div>
    </form>
</body>
</html>
