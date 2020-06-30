<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addStudent.aspx.cs" Inherits="UI.addStudent" %>
<%@ Register Src="Studentmenu.ascx" TagName="Studentmenu" TagPrefix="uc13" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" style="width: auto; height: auto">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    
    <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <link href="css/zc.css" rel="stylesheet" />
    <title>学生报名系统账号注册</title>

    <style>
        .tqz{
            text-align:right;
            
        }
    </style>

</head>
<body style="background-color: white; height: 1000px;">
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
        <div>
            <uc13:Studentmenu ID="Studentmenu" runat="server" />
        </div>
       
    
            <div style="background-color: aliceblue; margin-left:600px; margin-top :60px; height:700px;width:550px;">
                <table style="margin-left:60px; margin-top:40px; padding-top:20px; ">
                  

                    <tr >
                        <td class="tqz">学号：</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" class="kuangc"></asp:TextBox>
          </td>
                        <td>
                            <div class="ts" id="ts1" style="display: none">学号不得为空！</div>
                        </td>
                    </tr>
                    <tr>
                        <td class="tqz">密码：</td>
                        <td>
                            <asp:TextBox ID="TextBox2" type="password" runat="server" class="kuangc"></asp:TextBox></td>
                        <td>
                            <div class="ts" id="ts3" style="display: none">密码不得小于6位数</div>
                        </td>
                    </tr>
                    <tr>
                        <td class="tqz">真实姓名：</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" class="kuangc"></asp:TextBox>
                          
                        </td>
                        <td>
                            <div class="ts" id="ts2" style="display: none">姓名不得为空</div>
                        </td>
                    </tr>
                    <tr>
                        <td class="tqz">专业：</td>
                        <td>
                            <asp:DropDownList CssClass="xiala" ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="专业名" DataValueField="专业名" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                        </td>
                    </tr>

                    <tr>
                        <td class="tqz">电话：</td>
                        <td>
                            <asp:TextBox ID="tel" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tqz">邮箱：</td>
                        <td>
                            <asp:TextBox ID="emil" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tqz">学院：</td>
                        <td>
                            <asp:TextBox ID="academy" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tqz">年级：</td>
                        <td>
                            <select name="grade" class="xiala">
                                <option value="大一">大一</option>
                                <option value="大二">大二</option>
                                <option value="大三">大三</option>
                                <option value="大四">大四</option>
                            </select></td>
                    </tr>
                    <tr>
                        <td class="tqz">证件照：</td>
                        <td>
                            <asp:Image ID="Image2" runat="server" Height="156px" Width="114px" /></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:FileUpload ID="fileUp" runat="server" /><asp:Button ID="Button1" runat="server" Text="上传" OnClick="Button1_Click" /></td>
                    </tr>

                </table>
                <div id="tj">
                    <asp:Button ID="Button3"  runat="server" CssClass="tijiao" OnClick="Button3_Click" Style="z-index: 1" Text="注册" />
                </div>
            </div>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KSBMConnectionString %>" SelectCommand="SELECT [专业名] FROM [major]"></asp:SqlDataSource>


    </form>

</body>
</html>


