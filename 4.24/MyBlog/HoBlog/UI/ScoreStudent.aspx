<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScoreStudent.aspx.cs" Inherits="UI.ScorStudent" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<%@ Register Src="Studentmenu.ascx" TagName="Studentmenu" TagPrefix="uc13" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <link href="css/tableStyle.css" rel="stylesheet" />
    <title></title>
    <style>
       .cx li{
            float:left;
            margin-left:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div>
                  <uc12:HeadTT ID="HeadTT" runat="server" />
            </div>
         <div>

            <uc13:Studentmenu ID="Studentmenu" runat="server" />
        </div>
            <div style="width:800px; margin-left:550px;">
                 <div  class="cx">
            <ul >
                <li ><asp:Button ID="Button2" runat="server" Text="查找全部" OnClick="Button2_Click" /></li>
                <li> <asp:Button ID="Button3" runat="server" Text="查找已录入" OnClick="Button3_Click" /></li>
                <li><asp:Button ID="Button4" runat="server" Text="查找未录入" OnClick="Button4_Click" /></li>
                <li><asp:TextBox ID="km" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="科目查找" OnClick="Button1_Click" /></li>
    
            </ul>
          
        </div>
             <br />
             <br />
       
        <div style="margin-left:60px;">
            
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" OnRowUpdating="GridView1_RowUpdating" EmptyDataText="未找到相关考试科目" ShowHeaderWhenEmpty="True">
                <Columns>
                    <asp:BoundField DataField="eid" HeaderText="考试科目" />
                    <asp:BoundField DataField="sid" HeaderText="学生编号" Visible="False" />
                    <asp:BoundField DataField="estate" HeaderText="科目状态" />
                    <asp:BoundField DataField="score" HeaderText="分数" />
                </Columns>
            </asp:GridView>
        </div>
            </div>
           
       
        </div>
    </form>
</body>
</html>
