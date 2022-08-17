<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
        ID="Label5" runat="server" Font-Size="Medium"></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
        <asp:ListItem>موظف بطيبه</asp:ListItem>
        <asp:ListItem>عميل</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    &nbsp;&nbsp;<asp:Label 
        ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" 
        ForeColor="#666633"></asp:Label>
&nbsp;<br />
    <asp:Panel ID="Panel1" runat="server" Height="219px" Width="319px" 
        BackColor="#91726F" BorderColor="White" BorderStyle="Outset" CssClass="button" 
        Font-Size="Medium" ForeColor="White">
        &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Italic="True" 
            Text="البريد الالكترونى"></asp:Label>
        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxName" runat="server" Width="230px" Height="34px"></asp:TextBox>
        <br />
        &nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Italic="True" Text="كلمة السر"></asp:Label>
        &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPassword" runat="server" Height="31px" Width="226px" 
            TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" 
    Text="تذكرنى" />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="دخول" 
            onclick="Button1_Click" BackColor="White" BorderColor="White" 
            BorderStyle="Dashed" CssClass="button" Font-Bold="True" Font-Size="Medium" 
            ForeColor="#0033CC" Width="87px" />
        &nbsp; &nbsp;</asp:Panel>
    <br />
</asp:Content>

