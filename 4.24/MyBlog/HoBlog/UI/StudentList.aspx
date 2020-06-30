<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="UI.StudentList" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<%@ Register Src="BaseUserMenu.ascx" TagName="BaseUserMenu" TagPrefix="uc13" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/tableStyle.css" rel="stylesheet" />
    <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />

    <title>学生账号管理</title>
</head>
<body>
   
    <form id="form1" runat="server">
         <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
         <div>
            <uc13:BaseUserMenu ID="BaseUserMenu" runat="server" />
        </div>
        <div style="padding-left:450px;padding-top:20px;">
            <div>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource2" Height="900px" Width="903px" OnRowDataBound="GridView1_RowDataBound">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="id" HeaderText="学生账号" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="name" HeaderText="姓名" SortExpression="name" />
                        <asp:BoundField DataField="password" HeaderText="密码" SortExpression="password" />
                        <asp:BoundField DataField="grade" HeaderText="年级" SortExpression="grade" />
                        <asp:BoundField DataField="major" HeaderText="专业" SortExpression="major" Visible="False" />
                        <asp:BoundField DataField="emil" HeaderText="邮箱" SortExpression="emil" />
                        <asp:BoundField DataField="tel" HeaderText="电话" SortExpression="tel" />
                        <asp:BoundField DataField="academy" HeaderText="学院" SortExpression="academy" />
                        <asp:BoundField DataField="state" HeaderText="状态" SortExpression="state" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:KSBMConnectionString %>" DeleteCommand="DELETE FROM [Students] WHERE [id] = @id" InsertCommand="INSERT INTO [Students] ([id], [name], [password], [grade], [major], [emil], [tel], [academy], [state]) VALUES (@id, @name, @password, @grade, @major, @emil, @tel, @academy, @state)" SelectCommand="SELECT [id], [name], [password], [grade], [major], [emil], [tel], [academy], [state] FROM [Students]" UpdateCommand="UPDATE [Students] SET [name] = @name, [password] = @password, [grade] = @grade, [major] = @major, [emil] = @emil, [tel] = @tel, [academy] = @academy, [state] = @state WHERE [id] = @id">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="id" Type="String" />
                        <asp:Parameter Name="name" Type="String" />
                        <asp:Parameter Name="password" Type="String" />
                        <asp:Parameter Name="grade" Type="String" />
                        <asp:Parameter Name="major" Type="String" />
                        <asp:Parameter Name="emil" Type="String" />
                        <asp:Parameter Name="tel" Type="String" />
                        <asp:Parameter Name="academy" Type="String" />
                        <asp:Parameter Name="state" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="name" Type="String" />
                        <asp:Parameter Name="password" Type="String" />
                        <asp:Parameter Name="grade" Type="String" />
                        <asp:Parameter Name="major" Type="String" />
                        <asp:Parameter Name="emil" Type="String" />
                        <asp:Parameter Name="tel" Type="String" />
                        <asp:Parameter Name="academy" Type="String" />
                        <asp:Parameter Name="state" Type="Int32" />
                        <asp:Parameter Name="id" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:KSBMConnectionString %>" DeleteCommand="DELETE FROM [Students] WHERE [id] = @original_id AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([password] = @original_password) OR ([password] IS NULL AND @original_password IS NULL)) AND (([state] = @original_state) OR ([state] IS NULL AND @original_state IS NULL)) AND (([grade] = @original_grade) OR ([grade] IS NULL AND @original_grade IS NULL)) AND (([major] = @original_major) OR ([major] IS NULL AND @original_major IS NULL)) AND (([emil] = @original_emil) OR ([emil] IS NULL AND @original_emil IS NULL)) AND (([tel] = @original_tel) OR ([tel] IS NULL AND @original_tel IS NULL)) AND (([academy] = @original_academy) OR ([academy] IS NULL AND @original_academy IS NULL))" InsertCommand="INSERT INTO [Students] ([id], [name], [password], [state], [grade], [major], [emil], [tel], [academy]) VALUES (@id, @name, @password, @state, @grade, @major, @emil, @tel, @academy)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [id], [name], [password], [state], [grade], [major], [emil], [tel], [academy] FROM [Students]" UpdateCommand="UPDATE [Students] SET [name] = @name, [password] = @password, [state] = @state, [grade] = @grade, [major] = @major, [emil] = @emil, [tel] = @tel, [academy] = @academy WHERE [id] = @original_id AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([password] = @original_password) OR ([password] IS NULL AND @original_password IS NULL)) AND (([state] = @original_state) OR ([state] IS NULL AND @original_state IS NULL)) AND (([grade] = @original_grade) OR ([grade] IS NULL AND @original_grade IS NULL)) AND (([major] = @original_major) OR ([major] IS NULL AND @original_major IS NULL)) AND (([emil] = @original_emil) OR ([emil] IS NULL AND @original_emil IS NULL)) AND (([tel] = @original_tel) OR ([tel] IS NULL AND @original_tel IS NULL)) AND (([academy] = @original_academy) OR ([academy] IS NULL AND @original_academy IS NULL))">
                    <DeleteParameters>
                        <asp:Parameter Name="original_id" Type="String" />
                        <asp:Parameter Name="original_name" Type="String" />
                        <asp:Parameter Name="original_password" Type="String" />
                        <asp:Parameter Name="original_state" Type="Int32" />
                        <asp:Parameter Name="original_grade" Type="String" />
                        <asp:Parameter Name="original_major" Type="String" />
                        <asp:Parameter Name="original_emil" Type="String" />
                        <asp:Parameter Name="original_tel" Type="String" />
                        <asp:Parameter Name="original_academy" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="id" Type="String" />
                        <asp:Parameter Name="name" Type="String" />
                        <asp:Parameter Name="password" Type="String" />
                        <asp:Parameter Name="state" Type="Int32" />
                        <asp:Parameter Name="grade" Type="String" />
                        <asp:Parameter Name="major" Type="String" />
                        <asp:Parameter Name="emil" Type="String" />
                        <asp:Parameter Name="tel" Type="String" />
                        <asp:Parameter Name="academy" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="name" Type="String" />
                        <asp:Parameter Name="password" Type="String" />
                        <asp:Parameter Name="state" Type="Int32" />
                        <asp:Parameter Name="grade" Type="String" />
                        <asp:Parameter Name="major" Type="String" />
                        <asp:Parameter Name="emil" Type="String" />
                        <asp:Parameter Name="tel" Type="String" />
                        <asp:Parameter Name="academy" Type="String" />
                        <asp:Parameter Name="original_id" Type="String" />
                        <asp:Parameter Name="original_name" Type="String" />
                        <asp:Parameter Name="original_password" Type="String" />
                        <asp:Parameter Name="original_state" Type="Int32" />
                        <asp:Parameter Name="original_grade" Type="String" />
                        <asp:Parameter Name="original_major" Type="String" />
                        <asp:Parameter Name="original_emil" Type="String" />
                        <asp:Parameter Name="original_tel" Type="String" />
                        <asp:Parameter Name="original_academy" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </div>
            
         <%--   <table>
                <tr>
                    <th>学号</th>
                    <th>姓名</th>
                    <th>密码</th>
                    <th>学生状态</th>
                    <th>年级</th>
                    <th>修改账号</th>
                    <th>删除用户</th>
                </tr>
                 <%foreach (var item in StudentsList)
                            {%>

                        <tr>
                            <td><%=item.id %></td>
                            <td><%=item.name %></td>
                            <td><%=item.pwd %></td>
                            <td><%=item.state %></td>
                            <td><%=item.grade %></td>
                            <td><a href='Update.aspx?id=<%=item.id%>&s=2'>修改账号</a></td>
                            <td><a href='detailStudent.aspx?id=<%=item.id%>&sid=<%=item.id%>'>学生详情</a></td>
                        
                        </tr>
                    
                        <%}  %>
                <tr>
                    
                </tr>
            </table>--%>
        </div>
    </form>
</body>
</html>
