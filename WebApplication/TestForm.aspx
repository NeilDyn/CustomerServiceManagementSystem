<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestForm.aspx.cs" Inherits="WebApplication.TestForm" %>

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
        <asp:GridView ID="gdvSalesOrder" runat="server" Height="16px" Width="1287px" style="margin-top: 30px" Caption="Sales Order" CaptionAlign="Left">
            <RowStyle VerticalAlign="Top" />                          
        </asp:GridView>
        <asp:GridView ID="gdvSalesLine" runat="server" BorderStyle="Solid" Caption="Sales Lines" CaptionAlign="Left" Height="16px" Width="1280px">
            <RowStyle VerticalAlign="Top" />
        </asp:GridView>
    </form>
</body>
</html>
