<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InfoManage.aspx.cs" Inherits="UI.InfoManage" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<%@ Register Src="BaseUserMenu.ascx" TagName="BaseUserMenu" TagPrefix="uc13" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <link href="css/tableStyle.css" rel="stylesheet" />
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
        <div style="width:700px; margin-left:600px;margin-top:20px;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" EmptyDataText="发布公告为空" ShowHeaderWhenEmpty="True">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="编号" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="title" HeaderText="标题" SortExpression="title" />
                    <asp:BoundField DataField="creatId" HeaderText="创建人" SortExpression="creatId" />
                    <asp:BoundField DataField="creatTime" HeaderText="发布时间" SortExpression="creatTime" />
                    <asp:BoundField DataField="source" HeaderText="来源" SortExpression="source" />
                    <asp:ButtonField CommandName="Delete" HeaderText="删除公告" ShowHeader="True" Text="删除" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KSBMConnectionString %>" SelectCommand="SELECT [id], [creatTime], [creatId], [source], [title] FROM [ExamInform]" DeleteCommand="DELETE FROM [ExamInform] WHERE [id] = @id" InsertCommand="INSERT INTO [ExamInform] ([creatTime], [creatId], [source], [title]) VALUES (@creatTime, @creatId, @source, @title)" UpdateCommand="UPDATE [ExamInform] SET [creatTime] = @creatTime, [creatId] = @creatId, [source] = @source, [title] = @title WHERE [id] = @id">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="creatTime" Type="DateTime" />
                    <asp:Parameter Name="creatId" Type="String" />
                    <asp:Parameter Name="source" Type="String" />
                    <asp:Parameter Name="title" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="creatTime" Type="DateTime" />
                    <asp:Parameter Name="creatId" Type="String" />
                    <asp:Parameter Name="source" Type="String" />
                    <asp:Parameter Name="title" Type="String" />
                    <asp:Parameter Name="id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
