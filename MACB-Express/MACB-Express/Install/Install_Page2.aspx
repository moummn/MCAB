<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Install_Page2.aspx.vb" Inherits="MACB_Express.Install_Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>第二步，创建新的管理员密码
         
            <br />
            <br />
            您的默认用户名为 Admin，请为默认用户名创建密码，该用户名为MCAB系统中最高权限的用户。<br />
            <br />
            为Admin用户创建密码：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="创建" />
        </div>
        <div>
            <br />
            <asp:Button ID="Button1" runat="server" Text="下一步&gt;" />
        </div>
    </form>
</body>
</html>
