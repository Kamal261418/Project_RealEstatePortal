<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="projects.aspx.cs" Inherits="projects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
       <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#336666"
            BorderStyle="Double" BorderWidth="3px" CellPadding="4"
            Font-Names="Verdana" Font-Size="Small" GridLines="Horizontal" RepeatColumns="3" RepeatDirection="Horizontal"
            Width="912px" Height="16px" 
           onselectedindexchanged="DataList1_SelectedIndexChanged1" >
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" Font-Size="Large" ForeColor="White"
                HorizontalAlign="Center" VerticalAlign="Middle" />
            <HeaderTemplate>
                Projects </HeaderTemplate>
            <ItemStyle ForeColor="#333333" BorderWidth="2px" BackColor="White" />
            <ItemTemplate>
                <asp:ImageButton ID="imgEmp" runat="server" Width="200px" Height="190px" ImageUrl='<%# Bind("projectimage") %>' PostBackUrl='<%#"ProjectDetails.aspx?projectDetails="+Eval("projectDetails")%>' style="padding-left:40px"/><br />
                <b>اسم المشروع:</b>
                <asp:Label ID="lblCName" runat="server" Text='<%# Bind("ProjectName") %>'></asp:Label>
                <br />
          
            </ItemTemplate>
            <SelectedItemStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            
        </asp:DataList>

  
        </asp:Content>

