<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="dropDownListTp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Languages de programmation maitrises" ></asp:Label>
        </div>
        <asp:DropDownList ID="dropdownList1" runat="server"></asp:DropDownList>
        <br />
          <asp:Button ID="btnDropDownList1"  runat="server" Text="btn dropdown" OnClick="btnDropDownList1_Click"  />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Text="c++" Value="1"></asp:ListItem>
            <asp:ListItem Text="c#" Value="2"></asp:ListItem>
            <asp:ListItem Text="python" Value="3"></asp:ListItem>
            <asp:ListItem Text="dart" Value="4"></asp:ListItem>
            <asp:ListItem Text="java" Value="5"></asp:ListItem>
            
        </asp:CheckBoxList>
        <br />
        
        <asp:Button ID="Button1"  runat="server" Text="Show" OnClick="Button1_Click" Height="29px" Width="60px"/>
        <asp:RadioButtonList  ID="RadiobuttonList1" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Text="c++" Value="1"></asp:ListItem>
            <asp:ListItem Text="c#" Value="2"></asp:ListItem>
            <asp:ListItem Text="python" Value="3"></asp:ListItem>
            <asp:ListItem Text="dart" Value="4"></asp:ListItem>
            <asp:ListItem Text="java" Value="5"></asp:ListItem>

        </asp:RadioButtonList>
        <br />
        <asp:Button ID="Button2"  runat="server" Text="Submit" OnClick="Button2_Click" />
        <asp:Button ID="Button3"  runat="server" Text="Clear Slection" OnClick="Button3_Click" />
        <p>
            <asp:Label ID="Label2" runat="server" Text="BulletedList"></asp:Label>
        </p>
        <asp:BulletedList ID="BulletedList1" runat="server" DisplayMode="LinkButton" OnClick="bulletedList1_Click">
            <asp:ListItem Text="c++" Value="1"></asp:ListItem>
            <asp:ListItem Text="c#" Value="2"></asp:ListItem>
            <asp:ListItem Text="python" Value="3"></asp:ListItem>
            <asp:ListItem Text="dart" Value="4"></asp:ListItem>
            <asp:ListItem Text="java" Value="5"></asp:ListItem>

        </asp:BulletedList>
       
    </form>
</body>
</html>
