<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="profileClient.aspx.cs" Inherits="profileClient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <asp:Label ID="Label1" runat="server" Text="name" Font-Bold="True" 
        Font-Italic="True" Font-Size="Medium" ForeColor="#3333CC"></asp:Label>
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" 
        Font-Size="Medium" ForeColor="#3333CC"></asp:Label>
              <div class="project_image" id="templatemo_sidebar">
           <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("clientPhoto") %>' 
                  style="padding-left:40px" Height="200px" Width="191px" />
          </div>
  <div class="newsbox" id="templatemo_content"> 
  <h2> <span>Posts</span></h2>
      <div >      
        <div class="newsbox">
                    <asp:DataList runat="server" ID="ds1" Height="193px" Width="168px" 
                        onselectedindexchanged="ds1_SelectedIndexChanged">
                        <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl ='<%#"newsDetails.aspx?newsid="+Eval("newsDetails") %>' 
                  Text ='<%# HttpUtility .HtmlEncode (Eval ("newsName").ToString ()) %>' ToolTip ='<%# HttpUtility .HtmlEncode (Eval ("newsDetails").ToString ()) %>'   >
                </asp:HyperLink>
            </ItemTemplate>
                         </asp:DataList>
        </div>
          <asp:DataList ID="DataList1" runat="server" 
              onselectedindexchanged="DataList1_SelectedIndexChanged" Height="147px" 
              Width="221px">
                               <ItemTemplate>
                <asp:Label ID="label1" runat="server" NavigateUrl ='<%#(Eval ("postname").ToString ()) %>'
                  Text ='<%# HttpUtility .HtmlEncode (Eval ("postname").ToString ()) %>' ToolTip ='<%# HttpUtility .HtmlEncode (Eval ("postname").ToString ()) %>'   >
                </asp:Label>
            </ItemTemplate>
          </asp:DataList>  
    </div>
       <h2> <span>آخر الأخبار</span></h2>
  </div>
</asp:Content>

