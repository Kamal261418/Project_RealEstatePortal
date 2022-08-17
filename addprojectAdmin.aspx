<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="addprojectAdmin.aspx.cs" Inherits="addprojectAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Label ID="Label5" runat="server" Font-Size="Medium" ForeColor="#996633" 
        Text="اسم المشروع"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxname" runat="server" Height="34px" Width="703px"></asp:TextBox>
    <br />
    <br />
&nbsp;<asp:Label ID="Label6" runat="server" Font-Size="Large" Text="تفاصيل المشروع"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxdet" runat="server" Height="112px" TextMode="MultiLine" 
        Width="776px"></asp:TextBox>
    <br />
    <asp:Label ID="Label7" runat="server" Font-Size="Medium" ForeColor="#996633" 
        Text="سكنى"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxhome" runat="server" Height="94px" TextMode="MultiLine" 
        Width="780px"></asp:TextBox>
    <br />
    <asp:Label ID="Label8" runat="server" Font-Size="Medium" ForeColor="#996633" 
        Text="تجارى"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxtrade" runat="server" Height="103px" 
        TextMode="MultiLine" Width="779px"></asp:TextBox>
    <br />
    <asp:Label ID="Label9" runat="server" Font-Size="Medium" ForeColor="#996633" 
        Text="ادارى"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxwork" runat="server" Height="101px" 
        TextMode="MultiLine" Width="778px"></asp:TextBox>
    <br />
    <br />
    صورة المشروع<asp:FileUpload ID="FileUpload1" runat="server" Width="441px" />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="save" runat="server" onclick="save_Click" Text="حفظ" 
        Width="167px" />
    <br />
    <br />

</asp:Content>

