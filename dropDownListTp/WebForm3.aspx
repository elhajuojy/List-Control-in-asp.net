<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="dropDownListTp.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server"/>&nbsp;
            <asp:Button  ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload"/>
            <br />
            <asp:Label ID="lblMessage" runat="server" Font-bold="true" > </asp:Label>
        </div>
    </form>
</body>
</html>
