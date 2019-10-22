<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="edit_books.aspx.cs" Inherits="LMS.librarian.edit_books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">


                                          </asp:FileUpload>
                                          </div>
                                          <div class="form-group">
                                          <label for="" class="control-label mb-1">Books Video</label> <br />
                                             <asp:Label ID ="booksvideo" runat="server" Text=""></asp:Label>

                                          <asp:FileUpload ID ="f3" runat="server" class="form-control">    

                                          </asp:FileUpload>
                                          </div>
                                           <div class="form-group">
                                          <label for="" class="control-label mb-1">Book's Author Name</label>
                                          <asp:TextBox ID ="authorname" runat="server" class="form-control">    

                                          </asp:TextBox>
                                          </div>

                                           <div class="form-group">
                                          <label for="" class="control-label mb-1">Books Isbn</label>
                                          <asp:TextBox ID ="isbn" runat="server" class="form-control">    

                                          </asp:TextBox>
                                          </div>
                                           <div class="form-group">
                                          <label for="" class="control-label mb-1">Books Quantity</label>
                                          <asp:TextBox ID ="qty" runat="server" class="form-control">    

                                          </asp:TextBox>
                                          </div>
                                        
                                     
                                     
                                     
                                     
                                     
                                      <div>
                                     
                                           <asp:Button ID="b1" runat="server"  class="btn btn-lg btn-info btn-block" Text ="Update Books" OnClick="b1_Click"/>
                                         
                                      </div>



                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div><!--/.col-->

</asp:Content>
