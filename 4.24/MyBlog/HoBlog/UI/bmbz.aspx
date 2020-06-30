<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bmbz.aspx.cs" Inherits="UI.bmxz" %>
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
            报名步骤</h1>
        <fieldset>
            <legend>第一阶段，注册个人信息和上传电子照片 </legend>
            <table border="0" cellpadding="5" cellspacing="0" style="margin: 0px auto">
                <tr>
                    <td align="middle" valign="center">
                        <div style="border-right: black 1px solid; padding-right: 8px; border-top: black 1px solid;
                            padding-left: 8px; padding-bottom: 5px; margin: 0px 8px; border-left: black 1px solid;
                            width: 130px; padding-top: 5px; border-bottom: black 1px solid; background-color: #ff9933;
                            text-decoration: underline">
                            <a href=ksxz.aspx ><span style="color: #0000ff; text-decoration: underline">
                                阅读报名须知</span></a></div>
                    </td>
                </tr>
                <tr style="color: #0000ff; text-decoration: underline">
                    <td align="middle" valign="center">
                        <img alt="" height="30" src="images/arrow_figure.gif" width="15" /></td>
                </tr>
                <tr style="color: #0000ff; text-decoration: underline">
                    <td align="middle" valign="center">
                        <div style="border-right: black 1px solid; padding-right: 8px; border-top: black 1px solid;
                            padding-left: 8px; padding-bottom: 5px; margin: 0px 8px; border-left: black 1px solid;
                            width: 130px; padding-top: 5px; border-bottom: black 1px solid; background-color: #ff9933;
                            text-decoration: underline">
                            <a href=addstudent.aspx ><span style="color: #0000ff">注册个人信息</span></a></div>
                    </td>
                </tr>
                <tr style="color: #0000ff; text-decoration: underline">
                    <td align="middle" valign="center">
                        <img alt="" height="30" src="images/arrow_figure.gif" width="15" /></td>
                </tr>
                <tr style="color: #0000ff; text-decoration: underline">
                    <td align="middle" valign="center">
                        <div style="border-right: black 1px solid; padding-right: 8px; border-top: black 1px solid;
                            padding-left: 8px; padding-bottom: 5px; margin: 0px 8px; border-left: black 1px solid;
                            width: 130px; padding-top: 5px; border-bottom: black 1px solid; background-color: #ff9933">
                          <a href=index.aspx ><span style="color: #0000ff">登录报名系统</span></a>  </div>
                    </td>
                </tr>
                <tr style="color: #0000ff; text-decoration: underline">
                    <td align="middle" valign="center">
                        <img alt="" height="30" src="images/arrow_figure.gif" width="15" /></td>
                </tr>
                <tr style="color: #0000ff; text-decoration: underline">
                    <td align="middle" valign="center">
                        <div style="border-right: black 1px dotted; padding-right: 8px; border-top: black 1px dotted;
                            padding-left: 8px; padding-bottom: 5px; margin: 0px 8px; border-left: black 1px dotted;
                            width: 130px; color: #ffc; padding-top: 5px; border-bottom: black 1px dotted;
                            background-color: #f60">
                            完成个人信息注册</div>
                    </td>
                </tr>
            </table>
        </fieldset>
        <fieldset>
            <legend>选择报考科目，点击报考</legend>
            <table border="0" cellpadding="5" cellspacing="0" style="margin: 0px auto">
                <tr>
                    <td align="middle" valign="center">
                        <div style="border-right: black 1px solid; padding-right: 8px; border-top: black 1px solid;
                            padding-left: 8px; padding-bottom: 5px; margin: 0px 8px; border-left: black 1px solid;
                            width: 130px; padding-top: 5px; border-bottom: black 1px solid; background-color: #ff9933">
                            登录 报名系统</div>
                    </td>
                </tr>
                <tr>
                    <td align="middle" valign="center">
                        <img alt="" height="30" src="images/arrow_figure.gif" width="15" /></td>
                </tr>
                <tr>
                    <td align="middle" valign="center">
                        <div style="border-right: black 1px solid; padding-right: 8px; border-top: black 1px solid;
                            padding-left: 8px; padding-bottom: 5px; margin: 0px 8px; border-left: black 1px solid;
                            width: 130px; padding-top: 5px; border-bottom: black 1px solid; background-color: #ff9933;
                            text-decoration: underline">
                         
                                选择报考科目</div>
                    </td>
                </tr>
                <tr style="color: #0000ff; text-decoration: underline">
                    <td align="middle" valign="center">
                        <img alt="" height="30" src="images/arrow_figure.gif" width="15" /></td>
                </tr>
                <tr style="color: #0000ff; text-decoration: underline">
                    <td align="middle" valign="center">
                        <div style="border-right: black 1px solid; padding-right: 8px; border-top: black 1px solid;
                            padding-left: 8px; padding-bottom: 5px; margin: 0px 8px; border-left: black 1px solid;
                            width: 130px; padding-top: 5px; border-bottom: black 1px solid; background-color: #ff9933;
                            text-decoration: underline">
                            <span style="color: #0000ff">点击 报名考试</span></div>
                    </td>
                </tr>
                
                
                <tr style="color: #0000ff; text-decoration: underline">
                    <td align="middle" valign="center">
                        <img alt="" height="30" src="images/arrow_figure.gif" width="15" /></td>
                </tr>
                <tr style="color: #0000ff; text-decoration: underline">
                    <td align="middle" valign="center">
                        <div style="border-right: black 1px dotted; padding-right: 8px; border-top: black 1px dotted;
                            padding-left: 8px; padding-bottom: 5px; margin: 0px 8px; border-left: black 1px dotted;
                            width: 130px; color: #ffc; padding-top: 5px; border-bottom: black 1px dotted;
                            background-color: #f60; text-decoration: none;">
                            完成考试报名</div>
                    </td>
                </tr>
            </table>
        </fieldset>
        <div style="margin-top: 30px; border-bottom: #666 1px dashed">
            <h1>
                说明</h1>
        </div>
        <p style="font-weight: bold; font-size: 14px">
            <a name="step1"><span style="color: #000000">阅读报名须知</span></a></p>
        <div class="tipcontent">
            请考生仔细阅读本报名须知了解报名流程和有关规定。</div>
        <p style="font-weight: bold; font-size: 14px">
            <a name="step2"><span style="color: #000000">注册个人信息</span></a>
        </p>
        <div class="tipcontent">
            如果考生首次来到日本语能力测试报名网站报名，还没有进行用户注册，请在首页上点击“注册个人信息”按钮。用户注册时，要求考生填写本人的姓名、性别、生日、证件类型和证件号（注意：使用护照报名的考生，请严格按照护照上的英文姓名填写），以及电话号码、手机号码和电子邮件信箱地址等联络信息，还要求考生填写自己随意定义并可以牢记的密码。考生填写个人信息后，还必须在“验证码”栏目处填入图形显示的大写字母。
            <ol style="list-style-type: decimal">
                <li>证件号和密码将作为考生再次登录报名系统（进行查询或修改部分信息）的密码。请考生牢记并慎重保管。 </li>
                <li>中国考生姓名的汉语拼音和生日将打印在考试资料和证书上。请注意您的中文姓名应严格按照《新华字典》的规范正确拼写。 </li>
                <li>使用护照报名的考生，请严格按照护照上的英文姓名填写。 </li>
            </ol>
        </div>
        <p style="font-weight: bold; font-size: 14px">
            <a name="step3"><span style="color: #000000">上传电子照片</span></a>
        </p>
        <div class="tipcontent">
            因为照片将会打印在您的准考证上，建议考生到专业照相馆拍摄下述规格、尺寸的电子照片，以免由于照片问题，影响到您的成绩使用。
            <ol style="list-style-type: decimal">
                <li>照片要求：
                    <ul>
                        <li>本人在6个月内标准证件照片 </li>
                        <li>尺寸：宽3cm，高4cm（其规格可参照“标准护照照片”的规格尺寸） </li>
                        <li>正面免冠，包括整体头部 </li>
                        <li>确认本人的脸部清晰 </li>
                        <li>黑白或彩色照片均可 </li>
                    </ul>
                </li>
                <li>技术规格：
                    <ul>
                        <li>格式：JPG/JPEG </li>
                        <li>文件大小：6KB到100KB之间 </li>
                    </ul>
                </li>
            </ol>
            <p>
                <strong>提示：</strong>考生可携带移动存储设备（U盘，移动硬盘等）到附近照相馆，请工作人员按照以上规格为您拍摄电子格式的护照照片，并把电子照片文件存储在您的移动存储设备中。然后自己登录报名网站，点击“上传电子照片”后，进入电子照片上传系统，选择存储在您的移动存储设备中的电子照片文件，根据网站提示，完成照片上传。<strong>注意：电子照片只可上传一次。</strong>
            </p>
        </div>
        <p style="font-weight: bold; font-size: 14px">
            <a name="step4"><span style="color: #000000">选择考试级别和考点</span></a></p>
        <div class="tipcontent">
            <p>
                在考生进行用户注册后，或仍然没有预定任何座位时，将被导入此页面。</p>
            <p>
                <strong>选择级别：</strong>选择级别页面将显示新“日本语能力测试”的五个级别（7月份的考试为三个级别）以及每个级别对应的报名开始时间和截止时间。考生通过点击“下一步（选择考点）”按钮选定级别并进入到选择考点页面。</p>
            <p>
                请注意：各个级别报名开通时间不同，如果“下一步（选择考点）”按钮处于非激活状态，则该级别报名未开通或已经截止。</p>
            <p>
                <strong>选择考点：</strong>选择考点页面将显示考生选定级别的所有考点名称、状态和对应的“预定座位”按钮。考生按照自己的意愿通过点击“预定”按钮预定座位。如果考点状态为“名额暂满”，则“预定”按钮为非激活状态，该考点不能预定座位。
            </p>
            <p>
                <strong>请注意：</strong>在报名期间，如果考点状态为“名额暂满”，并不意味着该考点在报名截止前肯定不再有名额，系统对于已经预定座位的考生在过期未交费、取消预定和更换考点的情况下将定时释放其预定的座位，供其它考生预定。</p>
        </div>
        <p style="font-weight: bold; font-size: 14px">
            <a name="step5"><span style="color: #000000">填写报名表</span></a></p>
        <div class="tipcontent">
            <p>
                考生必须在预定座位后<strong>24 小时内</strong>提交报名表，逾期未提交报名表的考生，系统将自动取消其预定的座位。</p>
            <p>
                考生预定完座位后将被直接导入填写报名表页面，预定座位后离开报名系统的考生重新登录后也可通过选择填写报名表进入此页面。考生应按页面各项要求填写，所填信息须真实、准确、完整，否则系统将拒绝接受您提交的信息。考生姓名、姓名拼音、性别、证件号码及生日等信息已从考生用户注册信息中导入，考生不必再次填写，也不能改动。</p>
        </div>
        <p style="font-weight: bold; font-size: 14px">
            <a name="step6"><span style="color: #000000">完成网上支付</span></a></p>
        <div class="tipcontent">
            <p>
                考试费用：日本语能力测试的考试费为人民币<strong>350</strong>元/人。</p>
            <p>
                交费方式：通过中国工商银行或中国招商银行的网上支付系统交纳考费。</p>
            <p>
                交费期限：从预定座位开始，考生必须预定座位后 <strong>24 小时内</strong>填写并提交报名表，在<strong>72小时内</strong>完成网上支付；<strong>在报名截止日期前2天报名的考生须在24小时之内完成支付</strong>。逾期未支付考费的，报名系统将自动取消考生预定的座位。</p>
            <p>
                网上支付操作方法：考生点击“交费”按钮后，系统将显示相应的中国工商银行或中国招商银行网上付费按钮，点击其中之一便可以开始进行网上付费。选择银行后，您将重新被引导到中国工商银行或中国招商银行的安全网页。请按照银行的要求完成付费程序。当付费完成后，<strong>请记录下银行所提供的定单号</strong>，以便日后用于核对和查询你的付款。通常考试中心报名系统会立即收到你的付款确认，至此你已完成整个报名的个人操作。银行网上支付系统如发生延迟向考试中心报名系统确认考生付款的情况，请考生在12小时之后登录考试中心报名网站，以便核实您的付费和报名状态。如果你仍未看到对您付费的确认，请拨打考试中心服务热线以寻求帮助。<strong>请您在未确认是否交费成功时，不要轻易重复进行网上支付。
                </strong>
            </p>
            <p>
                银行手续费：银行将向考生收取网上支付手续费用<strong>2元/次</strong>。</p>
            <p>
                交费的规定：日本语能力测试网上报名系统确认考生交纳的考费后，（1）考生因故不参加考试的，考费不予退还；（2）报名截止日前，其它考点如有座位，考生可以更换考点,但仅有一次更换考点的机会（无须支付额外费用）；（3）
                考生不得更改考试级别、姓名、姓名拼音、性别、证件类型、证件号码及出生日期；（4）因报名时提交个人信息错误导致不能考试的，考费不予退还。</p>
        </div>
        <p style="font-weight: bold; font-size: 14px">
            <a name="step7"><span style="color: #000000">自行打印准考证</span></a></p>
        <div class="tipcontent">
            <p>
            </p>
            报名截止后，网站在“重要通知”中会发布打印准考证的具体时间段，届时请考生在规定的时间内，使用A4纸自行打印准考证。
            <p>
            </p>
            <p>
                <strong>请注意：</strong>考生须保证所持有效证件与上网报名时提交的证件类型和证件号码一致。考生报名时提交的证件号码已打印在准考证上，如考生所持证件信息与准考证上的信息不符，将不能参加考试。</p>
            <p>
                至此，您已经完成了新“日本语能力测试”的所有报名步骤，请妥善保管好您的准考证和有效身份证件。</p>
        </div>
    </div>
    </form>
</body>
</html>
