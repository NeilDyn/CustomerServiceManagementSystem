﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestForm.aspx.cs" Inherits="WebApplication.TestForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter Search No."></asp:Label>
        <asp:TextBox ID="txtSearchNo" runat="server" style="margin-left: 13px" Width="170px" ForeColor="#CCCCCC"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search" style="margin-left: 10px" Width="126px" OnClick="Button1_Click" />



    </div>
        <asp:GridView ID="gdvSalesOrder" runat="server" Height="125px" Width="1287px" OnRowDataBound="gdvSalesOrder_RowDataBound" style="margin-top: 30px">
        </asp:GridView>
        <asp:GridView ID="gdvSalesLines" runat="server" Width="1284px">
        </asp:GridView>
    </form>
</body>
</html>