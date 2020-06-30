<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubjectManage.aspx.cs" Inherits="UI.SubJectManage" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<%@ Register Src="BaseUserMenu.ascx" TagName="BaseUserMenu" TagPrefix="uc13" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/tableStyle.css" rel="stylesheet" />
    <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <title></title>
    
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            left: 40px;
            top: 170px;
            height:40px;
            width:130px;
            background-color: antiquewhite;
            color:orangered;
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
        <br />
        <br />
        <br />
        <br />
        <div style="font-size:20px;">
            <table >
                <tr>
                    <th>报名详情</th>
                    <th>修改内容</th>
                    <th>删除报考科目</th>
                    <th>考试科目</th>

                    <th>报名开始时间</th>

                    <th>报名结束时间</th>
                    <th>考试开始时间</th>
                    <th>考试结束时间</th>
                    <th>专业限制</th>
                     <th>年级限制</th>
                    <th>考试说明</th>
                    <th>考试地点</th>
                    


                </tr>
                <%-- <%=strHtml %>--%>

                <%foreach (var item in ExamSubjectsList)
                    {%>

                <tr>
                    <td><a href="DetailsBK.aspx?eid=<%=item.id %>">报名详情</a></td>
                    <td><a href="UpdateSubject.aspx?id=<%=item.id %>">修改考试科目</a></td>
                    <td><a href="DeletSubject.ashx?id=<%=item.id %>">删除报考科目</a></td>
                    <td><%=item.name %></td>

                    <td><%=item.ApplyStar %></td>

                    <td><%=item.ApplyEnd %></td>

                    <td><%=item.ExamStar %></td>

                    <td><%=item.ExamEnd%></td>
                    <td>
                        <% getCheckMajor(item); %>
                    </td>
                    <td>
                        <% getCheckGrade(item); %>
                    </td>
                    <td>
                        <%=item.detail %>
                    </td>
                    <td>
                        <%=item.examPlace %>
                    </td>
                    
                    
                </tr>


                <%}  %>
            </table>
            <br />
            <input type="button" id="add" value="添加考试科目" class="auto-style1" />
        </div>
    </form>
</body>
</html>
<script>
    var add = document.getElementById("add");
    add.onclick = function () {
        window.location.href = "AddSubject.aspx";

    }
</script>
