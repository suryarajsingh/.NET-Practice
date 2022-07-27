<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment_2_home.aspx.cs" Inherits="Assignment1.Assignment_2_home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
             <asp:Label ID="lblname" runat="server" />
            <br />
            <br />
             <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Logout" />
        </div>
    </form>
</body>
</html>
