<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Studentmenu.ascx.cs" Inherits="UI.Studentmenu" %>
<link href="css/gerenlianjie.css" rel="stylesheet" />
<style>
    
.grlj a {
    font-size: 14px;
    /*color: #FFF;*/
    color: cornflowerblue;
    color: black;
    padding-right: 1em;
    padding-left: 1em;
    margin-left: 2px;
    display: block;
    text-decoration: none;
}

.grlj ul {
    float: left;
    line-height: 34px;
    height: 34px;
    margin-left: -2px;
}

.grlj li {
    float: left;
    background-color: gold;
    margin-left: 4px;
    margin-top: 10px;
    Border-radius: 8px;
}

.grlj {
    position: absolute;
    left: 1300px;
    top: 30px;
}

</style>

<div class="grlj">
            <ul>
                <li>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">已报名科目</asp:LinkButton>

                </li>
                <li>
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">历史考试成绩</asp:LinkButton>

                </li>
                <li >
                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">考试报名</asp:LinkButton>

                </li>
                <li>
                    <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click1">修改个人资料</asp:LinkButton>

                </li>
            </ul>
        </div>