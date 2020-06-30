<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ksxz.aspx.cs" Inherits="UI.ksxz" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <title></title>
    <style>
        .maincontent{
            /*color:red;*/
            width:66%;
            margin-left:13%;
            padding-left:2%;
            padding-right:2%;
            padding-top:20px;
            background-color: aliceblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
           <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
         <div class="maincontent">
        <h1>
            考生须知</h1>
        <p>
            <strong>一、报名基本步骤</strong>
        </p>
        <blockquote>
            &nbsp; &nbsp; 注册个人信息→登录→上传电子照片→选择考点和级别（预定座位）→填写报名表→网上付费→打印准考证。
        </blockquote>
        <p>
            <strong>二、您需要关注的时间点</strong>
        </p>
        <blockquote>
            <ol style="list-style-type: decimal">
                <li>网上报名时间及考试时间<br />
                    相关信息请访问报名网站中重要通知发布。 </li>
                <li>支付时间限制<br />
                    考生须在预定座位后 24 小时内填写报名表，并在 72 小时内完成网上付费，在报名截止日期前2天报名的考生须在24小时之内完成支付，否则系统将自动取消考生已预定的座位；考生在上述期限内也可随时自行取消预定的座位。
                </li>
                <li>释放考位时间<br />
                    系统每天下午14时自动释放被考生放弃或被取消的名额。 </li>
            </ol>
        </blockquote>
        <p>
            <strong>三、上网报名的准备工作</strong>
        </p>
        <blockquote>
            <strong>证件要求：</strong>
            <blockquote>
                日本语能力测试在报名和考试时规定考生可以使用的有效的证件:</blockquote>
            <ul style="margin-left: 40px; list-style-type: square">
                <li>来自中国大陆和香港、澳门地区的中国考生请使用有效的身份证或护照； </li>
                <li>来自台湾地区的中国考生请使用台湾居民往来大陆通行证； </li>
                <li>外国籍考生请使用有效的护照； </li>
                <li>军人考生请使用军官证或士兵证； </li>
                <li>未到法定领取身份证年龄的考生须在报名时填写身份证号码（户口本里有号码），并在参加考试时携带学生证（必须在有效期内）和户口本。 </li>
            </ul>
            <p>
            </p>
            <blockquote>
                请考生首先决定使用证件的种类，并保证在报名、领准考证和考试时均使用同一证件原件。在考生首次上网报名进行用户注册时，要求考生提交证件类型、证件号码、姓名、拼音姓名、性别和出生日期，一旦完成支付后，将不允许改变。在考生完成报名后，证件号码将打印在准考证上。在考试时，如考生所持证件信息与准考证上所打印证件信息不符，考点将拒绝考生进入考场。</blockquote>
        </blockquote>
        <blockquote>
            <strong>银行卡：</strong>
            <blockquote>
                日本语能力测试网上报名系统收取考费的方式仅限于网上支付。考生可任选中国工商银行或中国招商银行的网上银行支付系统交纳考费。这将使您能够通过互联网一次完成整个报名程序，并支付较低的手续费。如果您没有上述两家银行的可以进行网上支付的银行卡，请到中国工商银行或中国招商银行营业部去办理。中国工商银行(<a
                    href="http://www.icbc.com.cn/"><span style="color: #0000ff; text-decoration: underline">http://www.icbc.com.cn/</span></a>)和中国招商银行(<a
                        href="http://www.cmbchina.com/"><span style="color: #0000ff; text-decoration: underline">http://www.cmbchina.com/</span></a>)在其网站和营业部均备有相关服务的详细资料。
            </blockquote>
        </blockquote>
        <blockquote>
            <strong>电脑系统：</strong>
            <blockquote>
                日本语能力测试网上报名要求您的电脑应与互联网相连接并且装有网络浏览器（最好是Microsoft IE6.0以上版本浏览器）。推荐显示分辨率为 1024*768
                。中国考生须提供本人的简体中文姓名和地址，因此，中国考生须使用简体中文操作系统来输入汉字。在汉字输入状态下，注意必须采取半角方式输入数字。
            </blockquote>
        </blockquote>
        <p>
            <strong>四、考试</strong>
        </p>
        <blockquote>
            考生应在<strong>考试开始前30分钟</strong>携带准考证和个人有效证件（来自中国大陆和香港、澳门地区的中国考生请使用有效的身份证或护照；来自台湾地区的中国考生请使用台湾居民往来大陆通行证；外国考生请使用有效的护照；未到法定领取身份证年龄的考生须携带学生证和户口本）抵达考场，考试开始前及考试期间将对个人证件进行验证。考场桌面上禁止摆放铅笔、橡皮、准考证、证件之外的任何物品（如食品饮料等），携带移动电话及其它通讯工具进入考场的，按作弊处理。
        </blockquote>
        <p>
            <strong>五、领取成绩单</strong>
        </p>
        <blockquote>
            成绩单和证书约在考试后3个月到达考点。届时请考生与考点（见考点信息）咨询成绩到达情况以领取成绩单或证书。
        </blockquote>
    </div>
    </form>
</body>
</html>
