<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTeacher.aspx.cs" Inherits="UI.AddTeacher" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <style>
        #Button1{
            margin-top:50px;
            margin-left:140px;
            font-size:20px;
        }
    </style>
    <title></title>
</head>
<body>

    <form id="form1" runat="server" >
        <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
        <div style="margin-left:400px; margin-top:30px;padding-left:300px;padding-top:40px;padding-bottom:40px; width:800px; background-color:cornsilk;">
            <table >
                <tr>
                        <td class="tqz">证件照：</td>
                        <td>
                            <asp:Image ID="Image2" runat="server" Height="156px" Width="114px" /></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:FileUpload ID="fileUp" runat="server" /><asp:Button ID="Button2" runat="server" Text="上传" OnClick="Button1_Click" /></td>
                    </tr>
           
                <tr>
                    <td>账号：</td>
                    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>密码：</td>
                    <td><asp:TextBox ID="TextBox2" type="password"  runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>姓名：</td>
                    <td><asp:TextBox ID="TextBox7"  runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
               
                <tr>
                    <td>职位：</td>
                    <td><asp:TextBox ID="TextBox3"  runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>电话：</td>
                    <td><asp:TextBox ID="TextBox4"  runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>邮箱</td>
                   <td><asp:TextBox ID="TextBox5"  runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>学院：</td>
                    <td><asp:TextBox ID="TextBox6"  runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
            </table>
            <asp:Button ID="Button1" runat="server" Text="注册" OnClick="Button1_Click1" />
        </div>
        
    </form>
</body>
</html>
