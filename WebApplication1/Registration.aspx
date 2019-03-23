<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication1.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 612px;
        }
        .auto-style3 {
            width: 353px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2" style="text-align: center;">
        <tr>
            <td colspan="2" class="auto-style3" style="text-indent: 150px; font-size: x-large; font-weight: bold; text-decoration: underline;">Login<br />
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style3" style="text-indent: 250px">First Name:</td>
            <td>
                <asp:TextBox ID="uxFName" runat="server" Width="166px"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td class="auto-style3" style="text-indent: 250px">Last Name:</td>
            <td>
                <asp:TextBox ID="uxLName" runat="server" Width="165px"></asp:TextBox>
            </td>
        </tr>
            
        <tr>
            <td colspan="2"/>

            </td>
        </tr>
         <tr>
            <td colspan="2" class="auto-style3" style="text-indent: 150px; font-size: x-large; font-weight: bold; ">
                <asp:Button ID="uxButton" runat="server" Height="28px" Text="Login" Width="72px" />
                <br />
                <br />
            </td>
        </tr>
    </table>  
</asp:Content>
