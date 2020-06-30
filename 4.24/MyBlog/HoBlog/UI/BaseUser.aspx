<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BaseUser.aspx.cs" Inherits="UI.BaseUser" %>

<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<%@ Register Src="BaseUserMenu.ascx" TagName="BaseUserMenu" TagPrefix="uc13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
       <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <title></title>
    <style>
        ul{
            font-size:20px;
        }
        #d1{
            width:400px;
            height:200px;
            background-color:aliceblue;
            margin-left:700px;
            margin-top:200px;
            padding-left:40px;
            padding-top:20px;
        }
    </style>
</head>
<body>
  
    <form id="form1" runat="server">
         <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
        <div>
            <uc13:BaseUserMenu ID="BaseUserMenu" runat="server" />
        </div>
        <div id="d1">
            <ul>
                <li>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">修改密码</asp:LinkButton>
                    <%--<a href="UpdateManage.aspx?name=<%=Base_user.name %>">修改密码</a>--%>

                </li>
                <li>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">学生账号密码管理</asp:LinkButton>
                    <%--<a href="StudentList.aspx">学生账号密码管理</a>--%>

                </li>
                <li>
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">报名考试科目管理</asp:LinkButton>
                    <%--<a href="SubjectManage.aspx">报名考试科目管理</a>--%>

                </li>
                <li> 
                     <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">考试公告</asp:LinkButton>
                    <%--<a href="MessageManage.aspx">修改通知</a>--%>

                </li>
                <li> 
                     <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">教师账号管理</asp:LinkButton>
                <%--    <a href="TeacherManage.aspx">教师账号管理</a>--%>

                </li>
                    
                <li>
                    <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click" >专业管理</asp:LinkButton>
                </li>

                <li>
                    <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click"  >报考分类管理</asp:LinkButton>
                </li>
            </ul>
            
        </div>
    </form>
</body>
</html>
