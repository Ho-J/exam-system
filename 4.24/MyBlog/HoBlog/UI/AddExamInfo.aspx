<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddExamInfo.aspx.cs" Inherits="UI.MessageManage" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<%@ Register Src="BaseUserMenu.ascx" TagName="BaseUserMenu" TagPrefix="uc13" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <title></title>
    <style>
        .WarnMes{
            color:red;
        }
        .Body_Title{
            margin-left:500px;
            width:900px;
            margin-top:20px;
        }
        #Button1{
            font-size:30px;
            position: absolute;
            top:400px;
            left:100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
        <div>
            <uc13:BaseUserMenu ID="BaseUserMenu" runat="server" />
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="管理公告" OnClick="Button1_Click"  />
        </div>
      
    <div class="Body_Title" >
        <fieldset class="TipMes">
        <legend style="color:Green; font-weight:bolder;">》》添加考试公告》</legend>
            <table >
                <tr>
                    <td >
                        标题：</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" style="width:400px;"></asp:TextBox><span class="WarnMes">**</span>
                    </td>
                </tr>
                <tr>
                    <td>
                        来源：</td>
                    <td> <asp:TextBox ID="TextBox3" runat="server" value="本站" style="width:200px;"> </asp:TextBox><span class="WarnMes">*</span></td>
                </tr>
                <tr>
                    <td>
                        内容：</td>
                    <td>
                       <asp:TextBox ID="TextBox1" style="height:400px; width:600px;"  runat="server" TextMode="MultiLine"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="BtnSave" runat="server" onclick="BtnSave_Click" Text=" ↑↑发布信息 ↑↑" Height="30px" />
                    </td>
                </tr>
            </table>
            </fieldset>
    </div>
    </form>
</body>
</html>
