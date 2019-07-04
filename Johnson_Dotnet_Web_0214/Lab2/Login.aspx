<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
    
    <table class="table table-primary" style="width: 78%; text-align: center;" align="center">
        <thead>
            <tr><th colspan="2" class="text-center">
                <img class="mb-4" src="images/Yacht_logo2.png" alt="" width="72" height="72">
                <h2 class="mb-3 font-weight-normal"><strong>Register / Login</strong></h2>
            </th></tr>
        </thead>
        <tbody>
            <tr>
                <td style="text-decoration: underline; width: 149px;" class="text-center">
                    <span style="text-decoration: underline">
                    <em><strong>First Name:</strong></em><strong> </strong></span>
                </td>
                <td style="text-align: left" class="text-center">
                    <asp:TextBox ID="txtFName" runat="server" Width="377px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="First Name is required." ControlToValidate="txtFName" ForeColor="Red">*required
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-decoration: underline; width: 149px;" class="text-center">
                    <span style="text-decoration: underline">
                    <em><strong>Last Name:</strong></em><strong> </strong></span>
                </td>
                <td style="text-align: left" class="text-center">
                    <asp:TextBox ID="txtLName" runat="server" Width="375px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Last name is required." ControlToValidate="txtLName" ForeColor="Red">*required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-decoration: underline; width: 149px;" class="text-center">
                    <span style="text-decoration: underline">
                    <em><strong>Customer Phone:</strong></em><strong> </strong></span>
                </td>
                <td style="text-align: left" class="text-center">
                    <asp:TextBox ID="txtPhone" runat="server" Width="373px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Phone number is required." ControlToValidate="txtPhone" ForeColor="Red">*required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-decoration: underline; width: 149px;" class="text-center">
                    <span style="text-decoration: underline">
                    <em><strong>Customer City:</strong></em><strong> </strong></span>
                </td>
                <td style="text-align: left" class="text-center">
                    <asp:TextBox ID="txtCity" runat="server" Width="373px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="City is required." ControlToValidate="txtCity" ForeColor="Red">*required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnRegister" CssClass="btn-outline-primary" runat="server" Text="Go/ Login" OnClick="btnRegister_Click" style="font-weight: bold" Width="135px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnClear" runat="server" BorderColor="#0066FF" CssClass="auto-style26" OnClick="btnClear_Click" style="color: #0099FF" Text="Clear" Width="139px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
                </td>
            </tr>
        </tbody>
    </table>
    <div class="text-center">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" style="margin-top: 0px" Width="995px" />
    </div>
    <p class="mt-5 mb-3 text-muted">&nbsp;</p>
    
    
    
</asp:Content>
