<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BaseUserMenu.ascx.cs" Inherits="UI.BaseUserMenu" %>



<style>
    .grlj a {
    font-size: 14px;
    /*color: #FFF;*/
    color:cornflowerblue;
    color:black;
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
    margin-left:4px;
    margin-top:10px;
    Border-radius:8px;

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
                    <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click">主页</asp:LinkButton>
             

                </li>
                <li>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">修改密码</asp:LinkButton>
             

                </li>
                <li>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">学生账号密码管理</asp:LinkButton>
           

                </li>
                <li>
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">报名考试科目管理</asp:LinkButton>
             

                </li>
                <li> 
                     <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">考试公告</asp:LinkButton>
      

                </li>
                <li> 
                     <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">教师账号管理</asp:LinkButton>
                <%--    <a href="TeacherManage.aspx">教师账号管理</a>--%>

                </li>
                    
                <li>
                    <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click" >专业管理</asp:LinkButton>
                </li>
            </ul>
        </div>
