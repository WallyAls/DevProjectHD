<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="issue_books.aspx.cs" Inherits="LMS.librarian.issue_books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

       <div class="row">
                  <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Issue Books</strong>
                        </div>
                        <div class="card-body">
                          <!-- Credit Card -->
                          <div id="pay-invoice">
                              <div class="card-body">
                                
                                  <form action="" id="f1" runat="server" method="post" novalidate="novalidate">
                                      
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Select Enrollment Number</label>
                                          <asp:DropDownList ID ="enrno" runat="server" CssClass="form-control">    

                                          </asp:DropDownList>
                                          </div>

                                         <div class="form-group">
                                          <label for="" class="control-label mb-1">Books ISBN</label>
                                       <asp:DropDownList ID ="isbn" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="isbn_SelectedIndexChanged">   

                                          </asp:DropDownList>
                                          </div>

                                          <div class="form-group">
                                      <asp:Image ID="i1" runat="server" Height="150" Width="150" /> <br />
                                              <asp:Label ID="booksname" runat="server" /> <br />
                                               <asp:Label ID="instock" runat="server" /> <br />

                                        
                                          </div>
                                     
                                     
                                      <div>
                                     
                                           <asp:Button ID="b1" runat="server"  class="btn btn-lg btn-info btn-block" Text ="Issue Books" OnClick="b1_Click" />
                                         
                                      </div>

                                       <div class="alert alert-success" id="msg" runat="server" style="margin-top:10px; display:none">
                             <strong>Your book is added successfully</strong> 
                        </div>


                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div><!--/.col-->
</asp:Content>
