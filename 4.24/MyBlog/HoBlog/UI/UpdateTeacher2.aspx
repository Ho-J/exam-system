<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateTeacher2.aspx.cs" Inherits="UI.UpdateTeacher2" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
     <link href="css/gerenlianjie.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
        
        <div class="grlj">
            <ul>
                <li>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">修改信息</asp:LinkButton>
                </li>
               <li>
                   <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">处理考试科目成绩</asp:LinkButton>
                </li>
            </ul>
        </div>

        <div>
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
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
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
            <asp:Button ID="Button1" runat="server" Text="修改资料" OnClick="Button1_Click1" />
        </div>
        
    </form>
</body>
</html>
