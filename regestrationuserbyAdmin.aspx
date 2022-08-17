<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="regestrationuserbyAdmin.aspx.cs" Inherits="regestrationuserbyAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
الاسم&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxName" runat="server" Width="280px"></asp:TextBox>
&nbsp;&nbsp;
    <br /><br />
    تاريخ الميلاد &nbsp;:اليوم&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>

&nbsp; الشهر&nbsp;&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" 
        AutoPostBack="True">
        <asp:ListItem>يتاير</asp:ListItem>
        <asp:ListItem>فبراير</asp:ListItem>
        <asp:ListItem>مارس</asp:ListItem>
        <asp:ListItem>أبريل</asp:ListItem>
        <asp:ListItem>مايو</asp:ListItem>
        <asp:ListItem>يونيه</asp:ListItem>
        <asp:ListItem>يوليو</asp:ListItem>
        <asp:ListItem>أغسطس</asp:ListItem>
        <asp:ListItem>سبتمبر</asp:ListItem>
        <asp:ListItem>أكتوبر</asp:ListItem>
        <asp:ListItem>نوفمبر</asp:ListItem>
        <asp:ListItem>ديسمبر</asp:ListItem>
    </asp:DropDownList>
&nbsp; السنه&nbsp;
    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label1" runat="server" 
        Font-Bold="True" Font-Size="Medium" ForeColor="Blue" ></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br /><br />
    محل الاقامه&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxrBoxCoun" runat="server" Width="286px"></asp:TextBox>
    <br /><br />
    التليفون&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtboxPhonr" runat="server" Width="285px"></asp:TextBox>
    <br /><br />
    البريد الالكترونى&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxEmail" runat="server" Width="286px"></asp:TextBox>
    <br /><br />
    كلمة السر&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxPWD" runat="server" Width="289px"></asp:TextBox>
    <br /><br />
    إعادة كلمه السر&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxRePWD" runat="server" Width="291px"></asp:TextBox>
    <br /><br />
    صوره شخصيه&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br /><br />
    <br /><br />
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="BtnSave" runat="server" Text="حـــفظ" Width="94px" 
        onclick="BtnSave_Click" Font-Bold="True" Font-Size="Medium" 
        ForeColor="#996600" BackColor="ControlLight"/>
    <br />

</asp:Content>

