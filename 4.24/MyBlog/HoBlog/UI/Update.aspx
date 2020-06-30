<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="UI.WebForm1" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<%@ Register Src="Studentmenu.ascx" TagName="Studentmenu" TagPrefix="uc13" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
   
    <style type="text/css">
        .btn{
            font-size:20px;
            margin-left:150px;
            margin-top:30px;
            background-color:orange;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
         <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
         <div>
            <uc13:Studentmenu ID="Studentmenu" runat="server" />
        </div>
        


        <div style="margin-left:700px; margin-top:40px; padding-top:20px;padding-left:20px; padding-right:20px;padding-bottom:20px; background-color: antiquewhite;width:400px;">

             <table >
                    <tr >
                        <td class="tqz">学号：</td>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            <%--<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>--%></td>
                        <td>
                       
                        </td>
                    </tr>
                    <tr>
                        <td class="tqz">密码：</td>
                        <td>
                          <asp:TextBox ID="TextBox2" type="password" runat="server"></asp:TextBox>  <%--<input type="password" id="pwd1" name="pwd1" class="kuangc" />  <input type="text" name="xm" id="nameqq" value="" class="kuangc" />--%></td>
                        <td>
                            <div class="ts" id="ts3" style="display: none">密码不得小于6位数</div>
                        </td>
                    </tr>
                <%-- <tr>
                        <td class="tqz">确认密码：</td>
                        <td>
                          <asp:TextBox ID="TextBox1" type="password" runat="server"></asp:TextBox>  </td>
                        <td>
                            <div class="ts" id="ts4" style="display: none">密码不一致</div>
                        </td>
                    </tr>--%>
                    <tr>
                        <td class="tqz">真实姓名：</td>
                        <td>
<%--                            <input type="text" name="xm" id="nameqq" value="" class="kuangc" />--%>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <div class="ts" id="ts2" style="display: none">姓名不得为空</div>
                        </td>
                    </tr>
                   <%-- <tr>
                        <td class="tqz">专业：</td>
                        <td>
                        <asp:DropDownList CssClass="xiala" ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="专业名" DataValueField="专业名" ></asp:DropDownList>  
                        </td>
                    </tr>--%>

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
                            
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>大一</asp:ListItem>
                                <asp:ListItem>大二</asp:ListItem>
                                <asp:ListItem>大三</asp:ListItem>
                                <asp:ListItem>大四</asp:ListItem>
                            </asp:DropDownList>
                            
                            </td>
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
            <asp:Button ID="Button2" runat="server" Text="修改" OnClick="Button2_Click" CssClass="btn" />
        </div>
        




        <%if(Flag){ %>
        <div class="putk">
        </div>
        <%}else { %>
             <%--<div class="putk">
            <div class="z1"><div class="uqz">学号：</div>  <div class="hk"> <%=Sstudents.id %></div></div>
           
            <div class="z1"><div class="uqz">姓名：</div>  <div class="hk"><input name="sname" type="text" value="<%=Sstudents.name%>" /></div></div>
            <div class="z1"> <div class="uqz">密码：</div>  <div class="hk"><input name="p1" type="password" value="<%=Sstudents.pwd %>" /></div></div>
            <div class="z1"><div class="uqz">状态：</div>  <div class="hk"><input name="state" type="text" value="<%=Sstudents.state%>" /></div></div>
            <div class="z1" ><input type="submit" value="修改"  "/></div>
           
        </div>--%>
            <%--<p>学号:<%=Sstudents.id %></p>
            <p>姓名：<input name="sname" type="text" value="<%=Sstudents.name%>" /></p>
            <p>密码：<input name="p1" type="password" value="<%=Sstudents.pwd %>" /></p>
            <p>状态：<input name="state" type="text" value="<%=Sstudents.state%>" /></p>
            <p><input type="submit" value="修改" /></p>--%>
          
            
             
            
        <%} %>
        
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KSBMConnectionString %>" SelectCommand="SELECT [专业名] FROM [major]"></asp:SqlDataSource>

    </form>
</body>
</html>
