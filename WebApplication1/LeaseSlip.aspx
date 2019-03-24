<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="LeaseSlip.aspx.cs" Inherits="WebApplication1.LeaseSlip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Your previous leases:</p>
    <p>
        <asp:GridView ID="grdLeases" runat="server" AutoGenerateColumns="False">
        </asp:GridView>
    </p>
    <p>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        Select for a new lease:</p>
    <table>
        <tr>
            <td><asp:GridView ID="grdDock" runat="server"></asp:GridView></td>
            <td style="width:20px">&nbsp;</td>
            <td><asp:GridView ID="grdSlip" runat="server"></asp:GridView></td>
        </tr>

        <tr>
            <td><asp:ObjectDataSource ID="ObjectDataSource2" runat="server"></asp:ObjectDataSource></td>
            <td>&nbsp;</td>
            <td><asp:ObjectDataSource ID="ObjectDataSource3" runat="server"></asp:ObjectDataSource></td>
        </tr>
        <tr>&nbsp;</tr>
        
    </table>
    <asp:Button ID="btnLease" runat="server" Text="Lease" />
</asp:Content>
