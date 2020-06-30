<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateTeacher.aspx.cs" Inherits="UI.UpdateTeacher" %>
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
        
        <div>
            <table >
               
           
                <tr>
                    <td>账号：</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>姓名：</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>密码：</td>
                    <td><asp:TextBox ID="TextBox2" type="password"  runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td>分配考试科目：</td>
                    <td>
                        <div>
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name" OnDataBound="CheckBoxList1_DataBound" OnLoad="CheckBoxList1_Load"></asp:CheckBoxList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KSBMConnectionString %>" SelectCommand="SELECT [name] FROM [ExamSubject]"></asp:SqlDataSource>
                        </div>
                    </td>
                    <td>&nbsp;</td>
                </tr>
               
            </table>
            <asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click1" />
        </div>
        
    </form>
</body>
</html>
