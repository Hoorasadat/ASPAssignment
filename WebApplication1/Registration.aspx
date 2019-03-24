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
        .auto-style10 {
            width: 353px;
            height: 37px;
        }
        .auto-style11 {
            height: 37px;
        }
        .auto-style12 {
            width: 353px;
            height: 34px;
        }
        .auto-style13 {
            height: 34px;
        }
        .auto-style14 {
            width: 353px;
            height: 35px;
        }
        .auto-style15 {
            height: 35px;
        }
        .auto-style16 {
            width: 353px;
            height: 33px;
        }
        .auto-style17 {
            height: 33px;
        }
        .auto-style18 {
            height: 50px;
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
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFName" ErrorMessage="First name is required" Font-Names="Arial" Font-Size="Small" ForeColor="#FF3300" ValidationGroup="1">*</asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td class="auto-style9" style="text-indent: 250px; text-align: left;">Last Name:</td>
            <td class="auto-style5" style="text-align: left">
                <asp:TextBox ID="txtLName" runat="server" Width="165px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLName" ErrorMessage="Last name is required" Font-Names="Arial" Font-Size="Small" ForeColor="#FF3300" ValidationGroup="1">*</asp:RequiredFieldValidator>
            </td>
        </tr>
            
        <tr>
            <td colspan="2" style="height:50px; text-align: justify"/>
                <asp:Label ID="lblLogErr" runat="server" BackColor="White" Font-Names="Arial" Font-Size="Smaller" ForeColor="Red"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" Width="231px" BackColor="White" Font-Names="Arial" Font-Size="Small" ValidationGroup="1"/>
        </tr>
         <tr>
            <td colspan="2" class="auto-style3" style="text-indent: 150px; font-size: x-large; font-weight: bold; ">
                <asp:Button ID="btnLogin" runat="server" Height="28px" Text="Login" Width="72px" OnClick="btnLogin_Click" ValidationGroup="1" Font-Bold="True" Font-Size="Medium" Font-Underline="True"/>
                <br />                
            </td>
        </tr>
        <tr>
            <td>
                <br />
            </td>
        </tr>

        <tr>
            <td colspan="2" class="auto-style3" style="text-indent: 150px; font-size: medium; font-weight: bold; text-align: center;">
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Large" Font-Underline="True" ForeColor="#1B3D8B" BackColor="#B5C0CA" NavigateUrl="~/LeaseSlip.aspx" ViewStateMode="Enabled">Lease Slip page</asp:HyperLink>
                &nbsp;<br />
                </td>
        </tr>

        <tr>
            <td colspan="2" style="font-size: medium; color: #FFFFFF; font-weight: bold;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                (Log in first!)
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
            <td class="auto-style10" style="text-indent: 250px; text-align: justify;">First Name:</td>
            <td style="text-align: left" class="auto-style11">
                <asp:TextBox ID="txtFirstName" runat="server" Width="165px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First name is required" ForeColor="#FF3300" ValidationGroup="2">*</asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td class="auto-style12" style="text-indent: 250px; text-align: justify;">Last Name:</td>
            <td style="text-align: left" class="auto-style13">
                <asp:TextBox ID="txtLastName" runat="server" Width="165px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last name is required" ForeColor="#FF3300" ValidationGroup="2">*</asp:RequiredFieldValidator>
            </td>
        </tr>
            

        <tr>
            <td class="auto-style14" style="text-indent: 250px; text-align: justify;">Phone:</td>
            <td style="text-align: left" class="auto-style15">
                <asp:TextBox ID="txtPhone" runat="server" Width="165px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPhone" ErrorMessage="Phone number is required" ForeColor="#FF3300" ValidationGroup="2">*</asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td class="auto-style16" style="text-indent: 250px; text-align: justify;">City:</td>
            <td style="text-align: left" class="auto-style17">
                <asp:TextBox ID="txtCity" runat="server" Width="165px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCity" ErrorMessage="City is required" ForeColor="#FF3300" ValidationGroup="2">*</asp:RequiredFieldValidator>
            </td>
        </tr>
            
        <tr>
            <td colspan="2" style="text-align: justify" class="auto-style18"/>
                <asp:Label ID="lblRegErr" runat="server" BackColor="White" Font-Size="Smaller" ForeColor="Red"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary2" runat="server" BackColor="White" Font-Names="Arial" Font-Size="Small" ForeColor="#FF3300" Height="73px" ViewStateMode="Enabled" Width="226px" ValidationGroup="2"/>
        </tr>
         <tr>
            <td colspan="2" class="auto-style3" style="text-indent: 150px; font-size: x-large; font-weight: bold; ">
                <asp:Button ID="btnRegister" runat="server" Height="28px" OnClick="btnRegister_Click1" Text="Register" Width="72px" ValidationGroup="2" Font-Bold="True" Font-Size="Medium" Font-Underline="True" />
                <br />
                <br />
            </td>
        </tr>
    </table>  
</asp:Content>

