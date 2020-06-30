<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherManage.aspx.cs" Inherits="UI.TeacherManage" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<%@ Register Src="BaseUserMenu.ascx" TagName="BaseUserMenu" TagPrefix="uc13" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <link href="css/tableStyle.css" rel="stylesheet" />
    </head>
<body>
    <form id="form1" runat="server">
         <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
        <div>
            <uc13:BaseUserMenu ID="BaseUserMenu" runat="server" />
        </div>

        <div style="width:1150px; margin-left:400px;margin-top:20px;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="UpdateTeacher.aspx?id={0}" HeaderText="分配或修改" Text="分配或修改" />
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
                    <asp:BoundField DataField="id" HeaderText="编号" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="account" HeaderText="账号" SortExpression="account" />
                    <asp:BoundField DataField="password" HeaderText="密码" SortExpression="password" />
                    <asp:BoundField DataField="name" HeaderText="姓名" SortExpression="name" />
                    <asp:BoundField DataField="academy" HeaderText="学院" SortExpression="academy" />
                    <asp:BoundField DataField="position" HeaderText="职位" SortExpression="position" />
                    <asp:BoundField DataField="tel" HeaderText="电话" SortExpression="tel" />
                    <asp:BoundField DataField="emil" HeaderText="邮箱" SortExpression="emil" />
                    <asp:BoundField DataField="state" HeaderText="状态" SortExpression="state" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KSBMConnectionString %>" DeleteCommand="DELETE FROM [Teachers] WHERE [id] = @id" InsertCommand="INSERT INTO [Teachers] ([account], [password], [name], [academy], [tel], [emil], [position], [imgUrl], [state]) VALUES (@account, @password, @name, @academy, @tel, @emil, @position, @imgUrl, @state)" SelectCommand="SELECT * FROM [Teachers]" UpdateCommand="UPDATE [Teachers] SET [account] = @account, [password] = @password, [name] = @name, [academy] = @academy, [tel] = @tel, [emil] = @emil, [position] = @position, [imgUrl] = @imgUrl, [state] = @state WHERE [id] = @id">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="account" Type="String" />
                    <asp:Parameter Name="password" Type="String" />
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="academy" Type="String" />
                    <asp:Parameter Name="tel" Type="String" />
                    <asp:Parameter Name="emil" Type="String" />
                    <asp:Parameter Name="position" Type="String" />
                    <asp:Parameter Name="imgUrl" Type="String" />
                    <asp:Parameter Name="state" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="account" Type="String" />
                    <asp:Parameter Name="password" Type="String" />
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="academy" Type="String" />
                    <asp:Parameter Name="tel" Type="String" />
                    <asp:Parameter Name="emil" Type="String" />
                    <asp:Parameter Name="position" Type="String" />
                    <asp:Parameter Name="imgUrl" Type="String" />
                    <asp:Parameter Name="state" Type="String" />
                    <asp:Parameter Name="id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
        
    </form>
</body>
</html>
