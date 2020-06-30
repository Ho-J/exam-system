<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detailStudent.aspx.cs" Inherits="UI.detailStudent" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<%@ Register Src="Studentmenu.ascx" TagName="Studentmenu" TagPrefix="uc13" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/tableStyle.css" rel="stylesheet" />
     <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <style  type="text/css">
        body{
            /*width:1920px;
            text-align: center;
            display: table-cell;*/
        }
        #detail{
            margin-top:0px;
            border:6px double black;
            font: italic 26px "Trebuchet MS" , Verdana, Arial, Helvetica, sans-serif;
            height:266px;
            text-align: left;
            /*background-color:azure;*/
            border-radius:10px 10px;
        }
        .de{
            /*margin-left:170px;*/
            /*border-left: 3px solid #C1DAD7;*/
            /*border:1px dashed red;*/
            /*width:400px;*/
            /*float:left;*/
            text-align:left;
            
            /*margin-left:80px;*/
        }
        #messsageDiv{
            height:200px;
            /*border:1px dashed red;*/
        }
        #biao{
            /*font-size:60px;*/
            /*border:1px dashed red;*/
        }
        #tab{
            /*border:1px dashed red;*/
            margin-left:440px;
        }
        #msk{
            
            position:absolute;
            width:812px;
            border:10px ridge ;
            border-color:azure;
            top: 11px;
            left: 485px;
            height: 195px;
            background-color:lightgray;
        }
        .tzBtn{
            background-color:orange;
            border-radius:10px;
        }
    </style>
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
         <div>
                  <uc12:HeadTT ID="HeadTT" runat="server" />
            </div>
         <div>

            <uc13:Studentmenu ID="Studentmenu" runat="server" />
        </div>

        <div class="qxbm" style="width:700px;  margin-left:550px;margin-top:40px;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EmptyDataText="暂无已报考数据" OnRowDeleted="GridView1_RowDeleted" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" ShowHeaderWhenEmpty="True">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="编号" Visible="False" />
                    <asp:BoundField DataField="name" HeaderText="考试科目名称" />
                    <asp:BoundField DataField="examStar" HeaderText="考试开始时间" />
                    <asp:BoundField DataField="examEnd" HeaderText="考试结束时间" />
                    <asp:BoundField DataField="examPlace" HeaderText="考试地点" />
                    <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="DeleteBm.aspx?id={0}" HeaderText="取消报名" Text="取消报名" />
                </Columns>
            </asp:GridView>
        </div>
       
    </form>
</body>
    
    <script>
        function goBack() {
            window.history.back()
        }
        function goForward() {
            window.history.forward()
        }
        function goIndex() {
            window.location.href = "index.aspx"; 
        }
    </script>
</html>
