<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="dropDownListTp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
        <h1>Tp dropdown list</h1>
        <h2>using SqlSever </h2>
    </center>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Conteint</td>
                    <td>
                        <asp:DropDownList ID="ddlContinents" runat="server" width="200px" AutoPostBack="true" OnSelectedIndexChanged="ddlContinents_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td>Country : </td>
                    <td>
                         <asp:DropDownList ID="ddlCountry" runat="server" width="200px" AutoPostBack="true" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td>City : </td>
                    <td>
                         <asp:DropDownList ID="ddlCity" runat="server" width="200px" AutoPostBack="true"></asp:DropDownList>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
