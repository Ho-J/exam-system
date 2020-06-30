<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="UI.index" %>



<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <link href="css/dl.css" rel="stylesheet" />
    <title>计算机考试网上报名系统登录页面</title>

    <style type="text/css">
        .auto-style1 {
            /*//border-radius: 100px;*/
            background-color: orange;
            height: 30px;
            width: 66px;
        }
        .auto-style2 {
            height: 290px;
            padding-top:20px;
            
            background-color:antiquewhite;
        }
        .auto-style3 {
            top: 86px;
            left: 9px;
            margin-left: 551px;
        }
    </style>
</head>
<body  style="background-color: aliceblue; height:1000px;">

    <form id="form1" runat="server" enctype="multipart/form-data">
       
        <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>


        <div id="dl" style=" display:block;" class="auto-style3">
            <div id="biaoti">
                学生网上报名系统登录
            </div>

            <div id="kuang" class="auto-style2">
                <div class="in">
                    <div class="op">
                        账号：<input type="text" name="id" value="" id="id"  />
                    </div>
                    <div id="zhText" class="ts" style="width: 80px; margin-top: 4px; display: none;">账号输入为空</div>

                </div>
                <br />
                <div class="in">
                    <div class="op">
                        密码：<input type="password" name="pwd" id="pwd" value="" />
                    </div>

                    <div id="pwdText" class="ts" style="width: 80px; margin-top: 4px; display: none">密码输入为空</div>
                </div>
                <br />
                <br />
                <div>
                    <label>
                        <input type="radio" name="fx" value="1" checked="checked" />学生账号</label>
                    <label>
                        <input type="radio" name="fx" value="2" />管理员账号</label>
                    <label>
                        <input type="radio" name="fx" value="3" />教师账号</label>
                </div>

                <br />
                <br />
                <asp:Button ID="Button1" runat="server" class="tijiao" Text="登录" OnClick="Button1_Click" />
              
                <br />
                <br />
                <br />
                <input class="auto-style1" type="button" value="学生注册" id="zc" />
                <input class="auto-style1" type="button" value="教师注册" id="teacherzc"  />
               
            </div>

        </div>
    </form>



<%--    &nbsp;
    
            <img src="img/sgxy2.jpg" style="position: absolute; top: 226px; left: 1247px; height: 338px; width: 519px;" />
    &nbsp;
         <img src="img/sgxy1.jpg" class="auto-style2" />--%>

</body>
</html>
<script>

    var checkF1 = false;
    var checkF2 = false;
    var zc = document.getElementById("zc");
    var teacherzc = document.getElementById("teacherzc");
    var id = document.getElementById("id");
    var pwdd = document.getElementById("pwd");
    zc.onclick = function () {
        window.location.href = "addStudent.aspx";

        //window.alert();
    }
    teacherzc.onclick = function () {
        window.location.href = "Addteacher.aspx";
    }
    pwdd.onblur = function () {
        var pwd = document.getElementById("pwdText");
        if (pwdd.value.length < 1) {
            pwd.style.display = "block";
            //pwd.innerHTML = "密码输入为空";
            checkF1 = false;
            return false;
        } else {
            pwd.style.display = "none";
            checkF1 = true;
            return true;
        }
    }
    id.onblur = function () {
        var str = document.getElementById("zhText");
        if (id.value.length < 1) {


            //str.innerHTML = "账号输入为空";
            str.style.display = "block";
            checkF2 = false;
            return false;
        } else {
            str.style.display = "none";
            checkF2 = true;
            return true;
        }

    }
    //function check() {
    //    alert();
    //    return false;
    //}

    var sub = document.getElementById("sub");
    sub.onclick = function () {
        if (checkF1 && checkF2) {
            return true;
        } else {
            return false;
        }

    }
    

</script>
