<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsBK.aspx.cs" Inherits="UI.DetailsBK" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<%@ Register Src="BaseUserMenu.ascx" TagName="BaseUserMenu" TagPrefix="uc13" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/tableStyle.css" rel="stylesheet" />
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
        <div>
            <h1>科目报考详情</h1>
            <table>
                    <tr>
                        <th>姓名</th>

                        <th>年级</th>
                        
                        <th>报名时间</th>
                       
                        <th>考试状态</th>

                        <th>分数</th>
                        
                    </tr>
                    <%foreach(var item in ListDetailsSubject) {%>

                    <tr>
                        <td><%=item.name %></td>

                        <td><%=item.grade%></td>
                
                        <td><%=item.ApplyTime %></td>
                        <%  switch (item.Estate) { case 1:EstateName = "待考试";break;case 2:EstateName = "等待录入成绩";break; case 3:EstateName = "成绩已录入";break;} %>
                        <td><%=EstateName %></td>

                        <td><%=item.Score  %></td>
                      
                    </tr>
                    <%}  %>
                </table>
        </div>
    </form>
</body>
</html>
