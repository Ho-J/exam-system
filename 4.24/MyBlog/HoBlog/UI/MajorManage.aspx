<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MajorManage.aspx.cs" Inherits="UI.MajorManage" %>
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
    <form id="form1" runat="server" >
        <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
         <div>
            <uc13:BaseUserMenu ID="BaseUserMenu" runat="server" />
        </div>

        <div style="margin-left:550px;">
            <div>
                <table>
                    <tr>
                        <td>添加专业：</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" /></td>
                    </tr>
                </table>
            </div>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="专业编号" DataSourceID="SqlDataSource2" Height="170px" Width="740px">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="专业编号" HeaderText="专业编号" InsertVisible="False" ReadOnly="True" SortExpression="专业编号" />
                    <asp:BoundField DataField="专业名" HeaderText="专业名" SortExpression="专业名" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:KSBMConnectionString %>" DeleteCommand="DELETE FROM [major] WHERE [专业编号] = @专业编号" InsertCommand="INSERT INTO [major] ([专业名]) VALUES (@专业名)" SelectCommand="SELECT * FROM [major]" UpdateCommand="UPDATE [major] SET [专业名] = @专业名 WHERE [专业编号] = @专业编号">
                <DeleteParameters>
                    <asp:Parameter Name="专业编号" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="专业名" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="专业名" Type="String" />
                    <asp:Parameter Name="专业编号" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
<script>
    
</script>
</html>
