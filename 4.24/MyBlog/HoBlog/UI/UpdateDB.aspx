<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateDB.aspx.cs" Inherits="UI.UpdateDB" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<%@ Register Src="BaseUserMenu.ascx" TagName="BaseUserMenu" TagPrefix="uc13" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
        <div>
            <uc13:BaseUserMenu ID="BaseUserMenu" runat="server" />
        </div>
        <div style="margin-top:40px; margin-left:600px;background-color:aliceblue;width:250px;">
            <table>
                <tr>
                    <td>账号：</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td>账号：</td>
                    <td>
                        <asp:TextBox ID="TextBox1" type="password" runat="server"></asp:TextBox>

                    </td>
                </tr>
            </table>
            <asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
