<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExamInfoList.aspx.cs" Inherits="UI.ExamInfoList" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1304px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
        <div style="padding-left:300px;padding-top:40px;" class="auto-style1">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CellPadding="4" DataKeyNames="id" Width="1121px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="title" HeaderText="标题" SortExpression="title"  >
                <ControlStyle Font-Size="26px" Font-Underline="True" />
                <HeaderStyle BorderStyle="Solid" />
                <ItemStyle Width="700px" Font-Size="26px" Height="40px" />
                </asp:BoundField>
                <asp:BoundField DataField="creatTime" HeaderText="发布时间" SortExpression="creatTime" >
                <FooterStyle Width="80px" />
                </asp:BoundField>
                <asp:BoundField DataField="source" HeaderText="来源" SortExpression="source" />
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" ShowHeader="False" SortExpression="id" Visible="False" />
                <asp:BoundField DataField="creatId" HeaderText="creatId" SortExpression="creatId" Visible="False" />
                <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="ExamInfoDetail.aspx?id={0}" HeaderText="查看内容" Text="查看内容" />
            </Columns>
          
                <EditRowStyle BackColor="#999999" />
          
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#284775" />

            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" Font-Size="Large" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KSBMConnectionString %>" SelectCommand="SELECT [title], [creatTime], [source], [id], [creatId] FROM [ExamInform]" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
    
        </div>

   </form>
</body>
</html>
