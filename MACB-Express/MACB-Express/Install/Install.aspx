<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Install.aspx.vb" Inherits="MACB_Express._Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            欢迎使用MACB安装向导！<br />
            首次使用该系统前,您必须初始化数据库,该向导会引导您对数据的配置和初始化。<br />
            注意!该向导会<strong>清除</strong>您已有的MACB数据库,如果原数据库存有重要资料，请注意备份！<br />
            <br />
            点击“下一步”即开始进行配置！<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="下一步&gt;" />

        </div>
    </form>
</body>
</html>
