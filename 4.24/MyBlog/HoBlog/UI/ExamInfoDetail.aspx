<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExamInfoDetail.aspx.cs" Inherits="UI.ExamInfoDetail" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="css/head.css" rel="stylesheet" media="screen" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc12:HeadTT ID="HeadTT" runat="server" />
        </div>
        <div style="margin-top:20px; margin-left:400px; width:1000px;height:1080px;padding-top:20px;padding-bottom:20px; background-color:aliceblue;">
            <h1 style="text-align:center; ">
                <asp:Label ID="Label1" runat="server" Text="Label">标题</asp:Label>
            </h1>
            <div >
                <ul style="color:red;">
                    <li style="float:left;"><asp:Label ID="Label2" runat="server" Text="Label" >日期</asp:Label></li>
                    <li style="float:left; margin-left:600px;"><asp:Label ID="Label3" runat="server" Text="Label" >来源</asp:Label></li>
                </ul>
                
            </div>
            <br />
            <div style="padding-left:20px; padding-right:20px;">
                <p>
                
                <asp:Label ID="Label4" runat="server" Text="Label">这是文本</asp:Label>
            </p>
            </div>
            
        </div>
    </form>
</body>
</html>
