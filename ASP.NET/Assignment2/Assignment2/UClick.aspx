<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UClick.aspx.cs" Inherits="Assignment2.UClick" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            WELCOME<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

        </div>
    </form>
</body>
</html>
