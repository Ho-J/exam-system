<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teacher.aspx.cs" Inherits="UI.Teacher" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <link href="css/gerenlianjie.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .cl{
           
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

        <div style="margin-top:30px;margin-left:400px;">
             <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="科目名字查询" />
        </div>

            <br />
        <div>

            <asp:GridView ID="GridView1" runat="server"  OnLoad="GridView1_Load" CssClass="table table-hover" ShowHeaderWhenEmpty="True" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" EmptyDataText="暂无需要处理的考试科目" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="科目编号" />
                    <asp:BoundField DataField="name" HeaderText="考试科目" />
                    <asp:BoundField DataField="ApplyStar" HeaderText="报名开始时间" />
                    <asp:BoundField DataField="ApplyEnd" HeaderText="报名结束时间" />
                    <asp:BoundField DataField="ExamStar" HeaderText="考试开始时间" />
                    <asp:BoundField DataField="ExamEnd" HeaderText="考试结束时间" />
                    <asp:BoundField DataField="detail" HeaderText="考试科目说明" />
                    <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="ScoreDeal.aspx?subjectid={0}" HeaderText="处理考试科目成绩" Text="处理考试科目成绩">
                    <ControlStyle BackColor="Yellow" BorderColor="#996600" CssClass="cl" />
                    </asp:HyperLinkField>
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
      
        </div>
        </div>
       
    </form>
</body>
</html>
