<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SomeForm.aspx.cs" Inherits="WebApplication.SomeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch1" runat="server" Text="Search Now" OnClick="btnSearch1_Click" />
    
    </div>
    </form>
</body>
</html>
