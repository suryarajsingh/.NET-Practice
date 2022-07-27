<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment_part2.aspx.cs" Inherits="Assignment2.Assignment_part2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Supplier ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="ID" runat="server" TextMode="Number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="ID" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <br />
            Supplier Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="Name" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <br />
            Product Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="P_Name" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="P_Name" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <br />
            Product Quantity&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Quantity" runat="server" TextMode="Number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="Quantity"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Quantity" MaximumValue="1000" MinimumValue="100" Type="Integer"></asp:RangeValidator>
            <br />
            <br />
            Supply Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Date" runat="server" TextMode="Date"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="Date" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Date" Display="Dynamic" ValidationExpression="(YYYY-MM-DD)"></asp:RegularExpressionValidator>
            <br />
            <br />
            Received By&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="Received_By" runat="server" AutoPostBack="True">
            <asp:ListItem>Surya@gmail.com</asp:ListItem>
            <asp:ListItem>Raj@abc.com</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
            <br />
            <br />
            Receiver Phno.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="R_Phno" runat="server" TextMode="Number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ControlToValidate="R_Phno"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="R_Phno" Display="Dynamic" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
            <br />
            <br />
            IsInvoiced 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            <asp:RadioButtonList ID="IsInvoiced" runat="server">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnSave" runat="server" Text="Save" Width="140px" OnClick="BtnSave_Click" />

        </div>
    </form>
</body>
</html>
