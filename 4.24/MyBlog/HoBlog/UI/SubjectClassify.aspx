<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubjectClassify.aspx.cs" Inherits="UI.SubjectClassify" %>
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

        <div>
             <div>
           报考类型： <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" />
        </div>

        <div>

            
            <asp:GridView ID="GridView1" runat="server" EmptyDataText="无数据，请添加" OnDataBound="GridView1_DataBound" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowDeleted="GridView1_RowDeleted" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="766px">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="编号" />
                    <asp:BoundField DataField="name" HeaderText="报考类型" />
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="删除" ShowHeader="True" Text="删除" />
                </Columns>
            </asp:GridView>
        </div>
        </div>
       
    </form>
</body>
</html>
