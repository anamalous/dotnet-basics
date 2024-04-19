<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication7.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        SAP ID:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        NAME:&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        ROLL:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="insert data" />
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="connected" />
&nbsp;
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="disconnected" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
&nbsp;
        <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
        <br />
        roll:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="get" />
        <br />
        name:<asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="sap" HeaderText="sap" SortExpression="sap" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="roll" HeaderText="roll" SortExpression="roll" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentConnectionString2 %>" SelectCommand="SELECT * FROM [Student1]" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
    </form>
</body>
</html>
