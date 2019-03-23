<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication1.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 689px;
        }
        .auto-style3 {
            width: 353px;
        }
    .auto-style4 {
        width: 685px;
    }
    .auto-style5 {
        width: 327px;
    }
    .auto-style7 {
        width: 327px;
        height: 44px;
    }
        .auto-style8 {
            width: 350px;
            height: 44px;
        }
        .auto-style9 {
            width: 350px;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style4" style="text-align: center;">
        <tr>
            <td colspan="2" class="auto-style3" style="text-indent: 150px; font-size: x-large; font-weight: bold; ">You are a member?<br />
            </td>
        </tr>

        <tr>
            <td colspan="2" class="auto-style3" style="text-indent: 150px; font-size: x-large; font-weight: bold; ">Please login here:<br />
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style8" style="text-indent: 250px; text-align: left;">First Name:</td>
            <td class="auto-style7" style="text-align: left">
                <asp:TextBox ID="txtFName" runat="server" Width="165px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFName" ErrorMessage="First name is required" Font-Names="Arial" Font-Size="Small" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td class="auto-style9" style="text-indent: 250px; text-align: left;">Last Name:</td>
            <td class="auto-style5" style="text-align: left">
                <asp:TextBox ID="txtLName" runat="server" Width="165px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLName" ErrorMessage="Last name is required" Font-Names="Arial" Font-Size="Small" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
            
        <tr>
            <td colspan="2" style="height:50px; text-align: justify"/>
                <asp:Label ID="lblLogErr" runat="server" BackColor="White" Font-Names="Arial" Font-Size="Smaller" ForeColor="Red"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" Width="231px" BackColor="White" Font-Names="Arial" Font-Size="Small" />
        </tr>
         <tr>
            <td colspan="2" class="auto-style3" style="text-indent: 150px; font-size: x-large; font-weight: bold; ">
                <asp:Button ID="btnLogin" runat="server" Height="28px" Text="Login" Width="72px" OnClick="btnLogin_Click" />
                <br />                
            </td>
        </tr>

        <tr>
            <td colspan="2" class="auto-style3" style="text-indent: 150px; font-size: x-large; font-weight: bold; ">
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Large" Font-Underline="True" ForeColor="#1B3D8B" BackColor="#B5C0CA" NavigateUrl="~/LeaseSlip.aspx" ViewStateMode="Enabled">Lease Slip page</asp:HyperLink>
                <br />
            </td>
        </tr>

    </table>  
</asp:Content>



<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="auto-style2" style="text-align: center;">
        <tr>
            <td colspan="2" class="auto-style3" style="text-indent: 150px; font-size: x-large; font-weight: bold; text-align: center;">Are you new?<br />
            </td>
        </tr>

        <tr>
            <td colspan="2" class="auto-style3" style="text-indent: 150px; font-size: x-large; font-weight: bold; text-align: center;">Please register first:<br />
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style3" style="text-indent: 250px; text-align: justify;">First Name:</td>
            <td style="text-align: left">
                <asp:TextBox ID="txtFirstName" runat="server" Width="165px"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td class="auto-style3" style="text-indent: 250px; text-align: justify;">Last Name:</td>
            <td style="text-align: left">
                <asp:TextBox ID="txtLastName" runat="server" Width="165px"></asp:TextBox>
            </td>
        </tr>
            

        <tr>
            <td class="auto-style3" style="text-indent: 250px; text-align: justify;">Phone:</td>
            <td style="text-align: left">
                <asp:TextBox ID="TextBox1" runat="server" Width="165px"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td class="auto-style3" style="text-indent: 250px; text-align: justify;">City:</td>
            <td style="text-align: left">
                <asp:TextBox ID="TextBox2" runat="server" Width="165px"></asp:TextBox>
            </td>
        </tr>
            
        <tr>
            <td colspan="2" style="height:50px; text-align: justify"/>
                <asp:Label ID="lblRegErr" runat="server" BackColor="White" Font-Size="Smaller" ForeColor="Red"></asp:Label>
        </tr>
         <tr>
            <td colspan="2" class="auto-style3" style="text-indent: 150px; font-size: x-large; font-weight: bold; ">
                <asp:Button ID="btnRegister" runat="server" Height="28px" Text="Register" Width="72px" OnClick="btnLogin_Click" />
                <br />
                <br />
            </td>
        </tr>
    </table>  
</asp:Content>

