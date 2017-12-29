<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="Login.aspx.vb" Inherits="MACB_Express.Login1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .LoginFrame {            
            margin:0px auto;  
            width:300px;
            
        }
    </style>
   <div>
        <div class="LoginFrame">
        <asp:Login ID="aspLogin1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px"  ForeColor="#333333" Width="300px" RememberMeText="记住密码">
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <LabelStyle Height="40px" />
            <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px"  ForeColor="#284E98" />
            <TextBoxStyle Width="200px" />
            <TitleTextStyle BackColor="#507CD1" Font-Bold="True"  ForeColor="White" />
        </asp:Login>
        </div>
    </div>
</asp:Content>
