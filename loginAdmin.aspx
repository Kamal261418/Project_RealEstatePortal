<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="loginAdmin.aspx.cs" Inherits="loginAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
        ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" 
        ForeColor="#003300"></asp:Label>
&nbsp;
    <br />
    <asp:Panel ID="Panel1" runat="server" Height="183px" Width="335px" 
        BackColor="#0066FF" BorderColor="White" BorderStyle="Outset" CssClass="button" 
        Font-Size="Medium" ForeColor="White">
        &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Italic="True" 
            Text="البريد الالكترونى"></asp:Label>
        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;<br />&nbsp;
        <asp:TextBox ID="TextBoxName" runat="server" Height="34px" Width="284px"></asp:TextBox>
        <br />
        &nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Italic="True" Text="كلمة السر"></asp:Label>
        &nbsp;&nbsp; &nbsp;&nbsp;<br />
        <br />
        &nbsp;&nbsp;<asp:TextBox ID="TextBoxPassword" runat="server" Height="31px" 
            TextMode="Password" Width="280px"></asp:TextBox>
        <br />
        <br />
&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="دخول" 
            onclick="Button1_Click" BackColor="White" BorderColor="White" 
            BorderStyle="Inset" CssClass="button" Font-Bold="True" Font-Size="Medium" 
            ForeColor="#0033CC" Width="87px" />
        &nbsp; &nbsp;</asp:Panel>
    &nbsp;&nbsp;
    <br />
</asp:Content>

