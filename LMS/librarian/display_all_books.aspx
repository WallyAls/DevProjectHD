<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="display_all_books.aspx.cs" Inherits="LMS.librarian.display_all_books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

    <link href ="https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css" type="text/css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.3.1.js"></script>
    <script src="https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js"></script>


    <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Table Head</strong>
                        </div>
                        <div class="card-body">
                            <asp:Repeater ID="r1" runat="server">
                                <HeaderTemplate>
                                         <table class="table" id="example">
                              <thead class="thead-dark">
                                <tr>
                                       <th scope="col">Book's Title</th>
                                  <th scope="col">Book's Image</th>  
                                <th scope="col">Book's Pdf</th>
                                    <th scope="col">Book's Video</th>
                                    <th scope="col">Author's Name</th>
                                    <th scope="col">isbn</th>
                                    <th scope="col">Avaliable Quantity</th>
                                      <th scope="col">Edit Books</th>
                                    <th scope="col">Delete Books</th>
                                </tr>
                              </thead>
                                             <tbody>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <tr>
                                    <td><%#Eval("books_title") %></td>
                                    <td><img src ="<%#Eval("books_image") %>" height="100" width="100" /></td>
                                    <td><%#Eval("books_pdf") %> <br /> <%#checkpdf(Eval("books_pdf"),Eval("id")) %></td>
                                    <td><%#Eval("books_video") %> <br /> <%#checkvideo(Eval("books_video"), Eval("id")) %></td>
                                    <td><%#Eval("books_author_name") %></td>
                                    <td><%#Eval("books_isbn") %></td>
                                    <td><%#Eval("avaliable_qty") %></td>
                                    <td><a href ="edit_books.aspx?id=<%#Eval("id") %>">Edit Book</a> </td>
                                    
                                    <td><a href ="delete_files.aspx?id2=<%#Eval("id") %>">Delete Book</a> </td>
                                </tr> </ItemTemplate>
                                <FooterTemplate>    </tbody>
                            </table>
</FooterTemplate>
                            </asp:Repeater>
                         
                              
                           
                        </div>
                    </div>
                </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#example').DataTable({
                "pagingType": "full_numbers"
            });
        });
    </script>


</asp:Content>
