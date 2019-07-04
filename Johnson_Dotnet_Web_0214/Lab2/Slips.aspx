<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Slips.aspx.cs" Inherits="Lab2.Available" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center" style="color: #FFFFFF; text-decoration: underline; background-color: #0099FF">List of slips currently on stock:</h1>
    <div class="text-center">
        <strong>
    <asp:GridView ID="grdAvailableSlips" CssClass="table table-striped" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" PageSize="7" style="color: #0066CC; background-color: #FFFFFF;" BorderStyle="Outset" BorderWidth="5px">
         <AlternatingRowStyle BackColor="pink" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="SlipID" HeaderText="SlipID" SortExpression="SlipID" />
            <asp:BoundField DataField="Width" HeaderText="Width" SortExpression="Width" />
            <asp:BoundField DataField="Length" HeaderText="Length" SortExpression="Length" />
            <asp:BoundField DataField="DockID" HeaderText="DockID" SortExpression="DockID" />
        </Columns>
    </asp:GridView>
        </strong>
    </div>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAvailableSlipsFromDock" TypeName="CPRG214.Marina.Domain.SlipDB">
        <SelectParameters>
            <asp:Parameter Name="dockID" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>

</asp:Content>
