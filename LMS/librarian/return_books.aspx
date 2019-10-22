<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="return_books.aspx.cs" Inherits="LMS.librarian.return_books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
     <div class="breadcrumbs">
        <div class="col-sm-4">
            <div class="page-header float-left">
                <div class="page-title">
                    <h1>Return Books</h1>
                </div>
            </div>
      
            </headerTemplate>
            <ItemTemplate>
                <tr>
                        
                    <td><%#Eval("student_enrollment_no") %></td>
                    <td><%#Eval("books_isbn") %></td>
                    <td><%#Eval("books_issue_date") %></td>
                    <td><%#Eval("books_approx_return_date") %></td>
                    <td><%#Eval("student_username") %></td>
                    <td><%#Eval("is_book_return") %></td>
                    <td><%#Eval("books_returned_date") %></td>
                    <td><%#Eval("lateday") %></td>
                    <td><%#Eval("Penalty1") %></td>
                    <td><a href ="returnbooks.aspx?id=<%#Eval("id") %>">Return Books</a></td>
                </tr>


            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:DataList>

       
    </div>
</asp:Content>
