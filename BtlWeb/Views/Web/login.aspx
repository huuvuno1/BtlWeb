<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BtlWeb.Views.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form action="login.aspx" runat="server" method="post">
        <input placeholder="Nhap username " name="username"/><br />
        <input placeholder="Nhap password " name="password"/><br />
        <input type="submit" value="Đăng nhập" />
    </form>
</body>
</html>
