<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="baokao.aspx.cs" Inherits="UI.baokao" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<%@ Register Src="Studentmenu.ascx" TagName="Studentmenu" TagPrefix="uc13" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/tableStyle.css" rel="stylesheet" />
    <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <link href="css/gerenlianjie.css" rel="stylesheet" />

    <style>
        .js{
            width:100%;
            height:100px;
            background-color:aliceblue;
            padding-top:20px;
        }
        .js ul{
         
           margin-left:400px;
            
        }
        .js li{
          height:40px;
          background-color: khaki;
          float:left;
          margin-left:20px;
          padding-top:14px;
          border-radius:10px;

        }
        .js li a {
            font-size: 20px;
            
            color: cornflowerblue;
            color: brown;
            padding-right: 1em;
            padding-left: 1em;
            margin-left: 2px;
            display: block;
            /*text-decoration: none;*/
        }
    </style>

    <title>报考页面</title>
</head>
<body>
   
    <form id="form1" runat="server">
        <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
       
       <div>
            <uc13:Studentmenu ID="Studentmenu" runat="server" />
        </div>
        
        <div class="js">
            <ul id="jsul">
                <% foreach (var str in classifyName){  %>
                <li><a href="baokao.aspx?classify=<%=str %>"><%=str %></a></li>
                <%} %>
                
               <%-- <li><a href="#">校园活动竞赛</a></li>
                <li><a href="#">职业资格考试</a></li>
                <li><a href="#">文学竞赛</a></li>
                <li><a href="#">体育竞赛</a></li>
                <li><a href="#">专业赛事</a></li>--%>
            </ul>
        </div>
        
       
        <br />

        <div style="width:1240px; margin-left:300px; padding-left:40px;padding-top:40px;">
            <div style="margin-bottom:20px;">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="科目查询" OnClick="Button1_Click" />
            </div>
             <div  >
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EmptyDataText="暂无您能报考的科目" ShowHeaderWhenEmpty="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="AddBaokao.aspx?eid={0}" HeaderText="报名考试" Text="报名考试" />
                    <asp:BoundField DataField="id" HeaderText="考试科目编号" />
                    <asp:BoundField DataField="name" HeaderText="科目名字" />
                    <asp:BoundField DataField="applyEnd" HeaderText="报考截至时间" />
                    <asp:BoundField DataField="examPlace" HeaderText="考试地点" />
                    <asp:BoundField DataField="examStar" HeaderText="考试开始时间" />
                    <asp:BoundField DataField="examEnd" HeaderText="考试结束时间" />
                    <asp:BoundField DataField="detail" HeaderText="考试说明" />
                </Columns>
            </asp:GridView>
        </div>
        </div>

       
    </form>
</body>
<script>
    function changeBackground() {
        var jsul = document.getElementById("jsul");

    }
</script>
</html>
