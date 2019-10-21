<%@ Page Title="" Language="C#" MasterPageFile="~/student/student.Master" AutoEventWireup="true" CodeBehind="student_display_all_books.aspx.cs" Inherits="LMS.student.student_display_all_books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">


    <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Table Head</strong>
                        </div>
                        <div class="card-body">
                            <asp:Repeater ID="r1" runat="server">
                                <HeaderTemplate>
                                         <table class="table">
                              <thead class="thead-dark">
                                <tr>
                                       <th scope="col">Book's Title</th>
                                  <th scope="col">Book's Image</th>  
                                <th scope="col">Book's Pdf</th>
                                    <th scope="col">Book's Video</th>
                                    <th scope="col">Author's Name</th>
                                    <th scope="col">isbn</th>
                                    <th scope="col">Avaliable Quantity</th>
                           
                                </tr>
                              </thead>
                                             <tbody>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <tr>
                                    <td><%#Eval("books_title") %></td>
                                    <td><img src ="../librarian/<%#Eval("books_image") %>" height="100" width="100" /></td>
                                    <td><%#Eval("books_pdf") %> <br /> <%#checkpdf(Eval("books_pdf"),Eval("id")) %></td>
                                    <td><%#Eval("books_video") %> <br /> <%#checkvideo(Eval("books_video"), Eval("id")) %></td>
                                    <td><%#Eval("books_author_name") %></td>
                                    <td><%#Eval("books_isbn") %></td>
                                    <td><%#Eval("avaliable_qty") %></td>
                                   
                                </tr> </ItemTemplate>
                                <FooterTemplate>    </tbody>
                            </table>
</FooterTemplate>
                            </asp:Repeater>
                         
                              
                           
                        </div>
                    </div>
                </div>
</asp:Content>
