<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <div>
        <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            تواصل معنا </h2>
        <br />
        <table>
            <!-- Name -->
            <tr>
                <td align="center">
                    الأسم:</td>
                <td>
                    <asp:TextBox ID="txtName" 
                                    runat="server"
                                    Columns="50" Width="523px"></asp:TextBox>
                </td>
            </tr>

            <!-- Subject -->
            <tr>
                <td align="center">
                    الموضوع :
                </td>
                <td>
                    <asp:DropDownList ID="ddlSubject" runat="server" Height="16px" Width="232px">
                        <asp:ListItem>÷إسأل سؤال</asp:ListItem>
                        <asp:ListItem>أبلغ عن مشكله</asp:ListItem>
                       <asp:ListItem>أخرى</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <!-- Message -->
            <tr>
                <td align="center">
                    الرساله:
                </td>
                <td>
                    <asp:TextBox ID="txtMessage" 
                                    runat="server"
                                    Columns="40"
                                    Rows="6" 
                                    TextMode="MultiLine" Height="228px" Width="519px"></asp:TextBox>
                </td>
            </tr>

            <!-- Submit -->
            <tr align="center">
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="إرسال" 
                        onclick="btnSubmit_Click" BackColor="#990000" Font-Size="Medium" 
                        ForeColor="#FFFF99" Height="36px" Width="83px" />
                </td>
            </tr>
            
            <!-- Results -->
            <tr align="center">
                <td colspan="2">
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>

