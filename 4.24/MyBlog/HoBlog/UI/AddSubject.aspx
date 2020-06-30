<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSubject.aspx.cs" Inherits="UI.AddSubject" %>
<%@ Register Src="HeadTT.ascx" TagName="HeadTT" TagPrefix="uc12" %>
<%@ Register Src="BaseUserMenu.ascx" TagName="BaseUserMenu" TagPrefix="uc13" %>
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
            <uc13:BaseUserMenu ID="BaseUserMenu" runat="server" />
        </div>

         <h1>添加考试科目</h1>

        <div>
            <table>
                <tr>
                    <td>考试科目名字：</td>
                    <td><input type="text" name="mz" value="--请输入科目名称" /></td>
                    <td></td>
                </tr>
                <tr>
                    <td>开始报考时间：</td>
                    <td>
                        <input type="text" name="as" value="<%=DateTime.Now %>" />

                    </td>
                    <td></td>
                </tr>
                
                <tr>
                    <td> 结束报考时间：</td>
                    <td> <input type="text" name="ae" value="<%=DateTime.Now %>" /></td>
                    <td></td>
                </tr>
                <tr>
                    <td>考试开始时间：</td>
                    <td><input type="text" name="es" value="<%=DateTime.Now %>" /></td>
                    <td></td>
                </tr>
                <tr>
                    <td>考试结束时间：</td>
                    <td><input type="text" name="ee" value="<%=DateTime.Now %>" /></td>
                    <td></td>
                </tr>
                
                <tr>
                    <td>考试地点：</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>报考分类：</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:KSBMConnectionString %>" SelectCommand="SELECT [name] FROM [SubjectClassify]"></asp:SqlDataSource>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>考试说明：</td>
                    <td>
                       <asp:TextBox ID="TextBox1" style="height:60px; width:200px;"  runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    <td></td>
                </tr>
                
                <tr>
                    <td>限制年级：</td>
                    <td>
                        <input type="radio" name="r1" checked="checked" value="无限制" onclick="visableF();"/> 无限制   <input  type="radio"  name="r1" value="有限制" onclick="visableT()"/> 有限制
               
                        <div id="cb" style=" display:none " >
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server" Visible="True">
                            <asp:ListItem>大一</asp:ListItem>
                            <asp:ListItem>大二</asp:ListItem>
                            <asp:ListItem>大三</asp:ListItem>
                            <asp:ListItem>大四</asp:ListItem>
                        </asp:CheckBoxList>
                      </div>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>限制专业：</td>
                    <td>
                         <input  type="radio" onclick="visableF2();" name="r2" value="无限制" checked="checked" /> 无限制   <input  type="radio" onclick="visableT2();"  name="r2" value="有限制" /> 有限制
                           <div id="cb2"  style="display:none">
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KSBMConnectionString %>" SelectCommand="SELECT [专业名] FROM [major]"></asp:SqlDataSource>
                            <asp:CheckBoxList   ID="CheckBoxList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="专业名" DataValueField="专业名"></asp:CheckBoxList>

                           </div>
                    </td>
                    <td></td>
                </tr>
            </table>
            <input type="submit" value="添加" />
        </div>

       
    </form>
</body>
<script>
    var cb = document.getElementById("cb");
    var cb2 = document.getElementById("cb2");
    function visableF() {
     
        cb.style.display = "none";
    }
    function visableT() {
        cb.style.display = "block";

    }

    function visableF2() {

        cb2.style.display = "none";
    }
    function visableT2() {
        cb2.style.display = "block";

    }
</script>
</html>
