<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateSubject.aspx.cs" Inherits="UI.UpdateSubject" %>
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
        <table >
            <tr>
                <td>科目名称:</td>
                <td><input name="name" value="<%=Sub.name %>"/></td>
                <td></td>
            </tr>
            <tr>
                <td>报考开始时间：</td>
                <td><input name="ApplyStar" value="<%=Sub.ApplyStar %>"/>    </td>
                <td></td>
            </tr>
            <tr>
                <td>报考结束时间：</td>
                <td><input name="ApplyEnd" value="<%=Sub.ApplyEnd %>"/></td>
                <td></td>
            </tr>
            <tr>
                <td>考试开始时间：</td>
                <td><input name="ExamStar" value="<%=Sub.ExamStar %>"/></td>
                <td></td>
            </tr>
            <tr>
                <td>考试结束时间：</td>
                <td><input name="ExamEnd" value="<%=Sub.ExamEnd %>"/></td>
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
             <tr style="display:block;">
                <td>.</td>
                <td>.</td>
                <td>.</td>
            </tr>
            <tr style="border:2px  dotted; ">
                <td > 限制专业:</td>
                <td>
                     <asp:RadioButton ID="RadioButton3" GroupName="rr2"    runat="server" OnCheckedChanged="RadioButton3_CheckedChanged" onclick="visableF2();" />无限制  <asp:RadioButton ID="RadioButton4"  GroupName="rr2"  runat="server" onclick="visableT2();" OnCheckedChanged="RadioButton4_CheckedChanged"/>  有限制
                
                    <div id="cb2"  style="display:block">
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KSBMConnectionString %>" SelectCommand="SELECT [专业名] FROM [major]"></asp:SqlDataSource>
                    <asp:CheckBoxList   ID="CheckBoxList2"  runat="server" DataSourceID="SqlDataSource1" DataTextField="专业名" DataValueField="专业名" OnDataBound="CheckBoxList2_DataBound" OnSelectedIndexChanged="CheckBoxList2_SelectedIndexChanged"></asp:CheckBoxList> </div>
                </td>
                <td></td>
            </tr>
            <tr>
                <td>.</td>
                <td>.</td>
                <td>.</td>
            </tr>
            <tr>
                <td>限制年级:</td>
                <td>
                   

                    <asp:RadioButton ID="RadioButton1" GroupName="rr1"    runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" onclick="visableF();" />无限制 
                    <asp:RadioButton ID="RadioButton2"  GroupName="rr1"  runat="server" onclick="visableT();" OnCheckedChanged="RadioButton2_CheckedChanged" />  有限制

                    <div id="cb" style=" display:block " >
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" Visible="True" >
                    <asp:ListItem>大一</asp:ListItem>
                    <asp:ListItem>大二</asp:ListItem>
                    <asp:ListItem>大三</asp:ListItem>
                    <asp:ListItem>大四</asp:ListItem>
                     </asp:CheckBoxList>
                </div>
                </td>
                <td></td>
            </tr>
        </table>
        <div>
            
            <div >
               <asp:ScriptManager ID="ScriptManager1" runat="server">

               </asp:ScriptManager>
                
                
            
                </div>
            <input type="submit"  value="修改" />
        </div>
    </form>
</body>
    <script >
        //function hid() {
        //    var cb = document.getElementById("cb");
        //    cb.style.display = "nono";
        //}
        //hid();
        var cb = document.getElementById("cb");
        var cb2 = document.getElementById("cb2");
        var cbl2 = document.getElementById("CheckBoxList2");
        windown.onload = function () {
            //// 方法体
            ////年级
            //var r3 = document.getElementById("rr1");
            //if (r3[0].checked == true) {
            //    visableF();
            //}
        }
       
        function visableF() {

            cb.style.display = "none";
           
        }
        //年级
        function visableT() {
            cb.style.display = "block";

        }

        function visableF2() {

            cb2.style.display = "none";

        }
        function visableT2() {
            cb2.style.display = "block";

        }
        function visableT2() {
            cb2.style.display = "block";

        }
        function R2Select(ck) {
            var r2 = document.getElementsByName("rr2");

            if (ck == "有限制") {
                r2[1].checked = true;
                visableT2();
            } else {
                r2[0].checked = true;
                visableF2();//不可见
            }
     
        }
        function R1Select(ck) {
            var r1 = document.getElementsByName("rr1");

            if (ck == "有限制") {
                r1[1].checked = true;
                visableT();
            } else {
                r1[0].checked = true;
                visableF();//不可见
            }
     
        }

</script>

</html>
