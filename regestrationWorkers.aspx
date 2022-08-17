<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="regestrationWorkers.aspx.cs" Inherits="regestrationWorkers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <div class="container">
    <asp:Label ID="Label5" runat="server" Font-Size="Medium"></asp:Label>
     
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
        Width="437px">
        <asp:ListItem>موظف بالبوابة العقارية</asp:ListItem>
        <asp:ListItem>عميل</asp:ListItem>
    </asp:RadioButtonList>
       <asp:Panel ID="Panel1" runat="server">
 
    الاسم&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxName" runat="server" Width="306px"></asp:TextBox>
&nbsp;&nbsp;
    <br /><br />
    تاريخ الميلاد &nbsp;:اليوم&nbsp;&nbsp;<asp:DropDownList 
        ID="DropDownList1" runat="server" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
        AutoPostBack="True">
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
    <br />
    <asp:Label ID="Label1" runat="server" 
        Font-Bold="True" Font-Size="Medium" ForeColor="#993300" ></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br /><br />
    محل الاقامه&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxrBoxCoun" runat="server" Width="328px"></asp:TextBox>
    <br /><br />
    التليفون&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtboxPhonr" runat="server" Width="324px"></asp:TextBox>
    <br /><br />
    البريد الالكترونى&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxEmail" runat="server" Width="324px"></asp:TextBox>
    <br /><br />
    كلمة السر&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxPWD" runat="server" Width="325px" TextMode="Password"></asp:TextBox>
    <br /><br />
    إعادة كلمه السر&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxRePWD" runat="server" Width="328px" TextMode="Password"></asp:TextBox>
    <br /><br />
    صوره شخصيه&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:FileUpload ID="FileUpload1" runat="server" Width="331px" />
    <br /><br />
    <br /><br />
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="BtnSave" runat="server" Text="حـــفظ" Width="94px" 
        onclick="BtnSave_Click" Font-Bold="True" Font-Size="Medium" 
        ForeColor="#996600" BackColor="ControlLight"/>
                  </asp:Panel>
    <br />
        <br />
        </div>

</asp:Content>

