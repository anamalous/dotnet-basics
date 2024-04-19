<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="username"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="email"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Restore" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" PostBackUrl="~/WebForm2.aspx" Text="Cross page" ViewStateMode="Enabled" />
            <br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>science</asp:ListItem>
                <asp:ListItem>arts</asp:ListItem>
                <asp:ListItem>commerce</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="124px">
                <asp:ListItem>quantum computing</asp:ListItem>
                <asp:ListItem>artificial intelligence</asp:ListItem>
                <asp:ListItem>network security</asp:ListItem>
                <asp:ListItem>cloud computing</asp:ListItem>
                <asp:ListItem>VLSI</asp:ListItem>
                <asp:ListItem>C#</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Query String" />
        </div>
    </form>
</body>
</html>
