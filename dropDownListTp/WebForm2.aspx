<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="dropDownListTp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Languages de programmation maitrises"></asp:Label>
        </div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem Text="Bac" Value="1"></asp:ListItem>
            <asp:ListItem Text="Deug" Value="2"></asp:ListItem>
            <asp:ListItem Text="Licence" Value="3"></asp:ListItem>
            <asp:ListItem Text="Master" Value="4"></asp:ListItem>
            <asp:ListItem Text="Doctort" Value="5"></asp:ListItem>
            
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="Button1"  runat="server" Text="Show" OnClick="Button1_Click"/>
    </form>
</body>
</html>
