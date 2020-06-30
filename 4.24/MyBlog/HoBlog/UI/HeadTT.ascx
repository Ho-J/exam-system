

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeadTT.ascx.cs" Inherits="UI.HeadTT" %>



<div class="header">
    <div id="log">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/img/sgxyLOG.jpg" Height="95px" Width="330px" />-</div>
    <div id="navMenu">
        <ul>
            <li class='hover'><a href="ksxz.aspx">考生须知</a></li>

             <li class='hover'><a href="bmbz.aspx">报名步骤</a></li>

            <li class='hover'><a href='index.aspx'>登录</a></li>

            <li class='hover'><a href='ExamInfoList.aspx'>考试公告</a></li>

            

           
         
          
            <li class='hover' style="">
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">个人主页</asp:LinkButton>
            </li>
            <li class='hover'><input class="tzBtn" type="button" value="返回上一个页面" onclick="goBack();"/></li>
            <li class='hover'><input class="tzBtn" type="button" value="前进下一个页面" onclick="goForward();"/></li>
            
        </ul>
    </div>
    <div style="position:absolute; top: 54px; left: 1443px; height: 270px; width: 237px;">
            
            
            <br />
            <br />
            
            <br /><br />
            
            <style>
                 .tzBtn{
              
                        background-color:antiquewhite;
                        border-radius:10px;
                        margin-left:4px;
                    }
            </style>
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
        </div>
</div>
