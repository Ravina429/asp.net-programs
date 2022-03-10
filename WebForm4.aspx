<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            color: #993366;
            font-size: x-large;
        }
    </style>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
        <div>
        <div style="text-align: center">
            <span class="auto-style1"><strong>MKPITS SOLUTION</strong></span><strong><br class="auto-style1" />
            </strong><span class="auto-style1"><strong>&nbsp;NAGPUR</strong></span></div>
            <p>
                &nbsp;</p>
        </div>
        <p style="text-align: left">
            Maths Marks =<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p style="text-align: left">
            English Marks =<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: left">
            Science Marks =<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: left">
            <asp:Button ID="Button1" runat="server" Text="Total Marks" />
        </p>
        <p style="text-align: left">
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
        <p style="text-align: left">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p style="text-align: left">
            &nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
