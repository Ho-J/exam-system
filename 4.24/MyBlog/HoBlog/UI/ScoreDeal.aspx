<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScoreDeal.aspx.cs" Inherits="UI.ScoreDeal" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <link href="css/tableStyle.css" rel="stylesheet" />
     <link href="css/gerenlianjie.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
       
     .cx li{
         float:left;
         margin-left:15px;
     }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
        <div class="grlj">
            <ul>
                <li>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">修改信息</asp:LinkButton>
                </li>
               <li>
                   <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">处理考试科目成绩</asp:LinkButton>
                </li>
            </ul>
        </div>


        <div style="margin-left:550px;">
             <div class="cx">
            <ul>
                <li><asp:Button ID="Button2" runat="server" Text="查找全部" OnClick="Button2_Click" /></li>
                <li> <asp:Button ID="Button3" runat="server" Text="查找已录入" OnClick="Button3_Click" /></li>
                <li><asp:Button ID="Button4" runat="server" Text="查找未录入" OnClick="Button4_Click" /></li>
                <li><asp:TextBox ID="xm" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="姓名查找" OnClick="Button1_Click" /></li>
    
            </ul>
          
        </div>
            <br />
            <br />

        <div>
            <asp:GridView ID="GridView1" runat="server" ShowHeaderWhenEmpty="True"  AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" OnUnload="GridView1_Unload" EmptyDataText="暂无需要处理的分数" OnRowEditing="GridView1_RowEditing" Width="579px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdated="GridView1_RowUpdated" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="sid" HeaderText="姓名"  ReadOnly="True"/>
                    <asp:BoundField DataField="eid" HeaderText="考试科目" ReadOnly="True" />
                    <asp:BoundField DataField="estate" HeaderText="状态" ReadOnly="True" />
                    <asp:BoundField DataField="score" HeaderText="分数" />
                    <asp:CommandField ButtonType="Button" CancelText="取消修改" EditText="修改成绩" HeaderText="修改成绩" ShowEditButton="True" />
                </Columns>
            </asp:GridView>
        </div>
        </div>

       
    </form>
</body>
</html>
