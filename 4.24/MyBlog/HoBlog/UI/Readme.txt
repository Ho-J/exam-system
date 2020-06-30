Alert.AlertAndRedirect("对不起您没有登录不能报名", "Default.aspx");
Request.QueryString["id"];
Response.Write("<script>alert(' ');</script>");
 Response.Write("<script>alert('正在开发ing ');</script>");
  Server.Transfer(str);
   position: absolute;


 <div id="biao">
            <h1>已报考科目</h1>
            <div id="tab">
                <table>
                    <tr>
                        <th>考试科目</th>
                        <th>报名开始时间</th>
                        <th>报名结束时间</th>
                        <th>考试开始时间</th>
                        <th>考试结束时间</th>
                        <th>报考状态</th>

                    </tr>
                    <%-- <%=strHtml %>--%>
                    <%if (examSubjectsList.ToArray().Length > 0){%>
                        <%foreach (var item in examSubjectsList)
                            {%>

                        <tr>
                            <td><%=item.name %></td>
                            <td><%=item.ApplyStar %></td>
                            <td><%=item.ApplyEnd %></td>
                            <td><%=item.ExamStar %></td>
                            <td><%=item.ExamEnd%></td>
                            <td><a href='DelteBM.ashx?eid=<%=item.id%>&sid=<%=Sstudents.id%>'>取消报名</a></td>
                        
                        </tr>
                    
                        <%}  %>
                    <%} %>
                </table>
                
            </div>
            <a href="baokao.aspx?id=<%=Sstudents.id%>">报考</a>
            <br />
           <%--<a href="Update.aspx?id=<%=Sstudents.id%>&s=1">修改个人信息</a>--%>
        </div>

        <br />
         <br />
        