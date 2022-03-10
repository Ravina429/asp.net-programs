<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication1.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <h1>MKPITS SOLUTION</h1>
        </div>
        <div style="text-align: center">
            <p>
                &nbsp;</p>
        </div>
        <div style="text-align: center">
            <p style="text-align: left">
                Enter number 1<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
        </div>
        <div style="text-align: center">
            <p style="text-align: left">
                Enter number 2<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
        </div>
        <div style="text-align: center">
            <p style="text-align: left">
                Enter number 3<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
