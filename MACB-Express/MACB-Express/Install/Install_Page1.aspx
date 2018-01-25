<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Install_Page1.aspx.vb" Inherits="MACB_Express.Install_Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            第一步，填写数据库的基本资料<br />
            <br />
            注意，MCAB目前仅在Microsoft SQL Express上测试通过，使用其他数据库可能会产生不可遇见的问题，请谨慎使用。<br />
            <br />
            <table style="width:400px;">
                <tr>
                    <td class="auto-style1">数据库名称</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="tbDBName" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td>数据库端口</td>
                    <td>
                        <asp:TextBox ID="tbDBPort" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td>登录名</td>
                    <td>
                        <asp:TextBox ID="tbDBUser" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td>密码</td>
                    <td>
                        <asp:TextBox ID="tbDBPasw" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="测试连接" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="下一步&gt;" style="height: 21px" />
                    </td>
                </tr>
            </table>
            
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="" SelectCommand=""></asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
