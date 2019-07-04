<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lease.aspx.cs" Inherits="Lab2.Lease" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container p-2" style="width: 100%; height: 778px; margin-right: 0px">
        <div class="row" style="text-align: center; width: 1458px; height: 780px">
            <div class="text-left" style="height: 49px">
                <strong>
                <span class="auto-style29">Please select a lease for the dock to make a reservation:&nbsp;</span><span style="font-size: medium">&nbsp;
            <asp:DropDownList ID="drpDockPicker" runat="server" CssClass="col-sm-6" 
                OnSelectedIndexChanged="drpDockPicker_SelectedIndexChanged" 
                AutoPostBack="True" style="left: 147px; top: 10px; width: 36%; height: 28px">
                <asp:ListItem Selected="True" Value="0">--Please Select--</asp:ListItem>
                <asp:ListItem Value="1">Dock A (Facility: Both Water and Electricity)</asp:ListItem>
                <asp:ListItem Value="2">Dock B (Facility: Water Only)</asp:ListItem>
                <asp:ListItem Value="3">Dock C (Facility: Electricity Only)</asp:ListItem>
            </asp:DropDownList>
                </span> 
                <br />
                <br />
                </strong>
                <br />
            </div>
            <div class="text-left">
                <br />
                <div class="text-center">
        <asp:GridView ID="grdAvailableSlips" runat="server" CssClass="table table-dark table-striped w-20 my-8" Width="1185px"
            CellPadding="0" ForeColor=blue GridLines="None" AllowSorting="True" OnRowCommand="grdAvailableSlips_RowCommand" 
            AllowPaging="True" PageSize="7" OnSelectedIndexChanged="grdAvailableSlips_SelectedIndexChanged" CaptionAlign="Top" HorizontalAlign="Center">
        <AlternatingRowStyle BackColor="pink" ForeColor="#284775" />
        <Columns>
            <asp:ButtonField CommandName="lease" Text="Lease"/>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>

                </div>

            </div>

            <br />

    <asp:Label ID="lblLeaseHistory" runat="server" CssClass="h3 my-4"></asp:Label>
    
            <br />
    
            <div class="text-center">
                <strong>
    <asp:GridView ID="grdLeaseHistory" runat="server" CssClass="table table-dark table-striped w-20 my-8" Width="1183px"
            CellPadding="0" ForeColor=blue GridLines="None" AllowSorting="True" OnRowCommand="grdAvailableSlips_RowCommand" 
            AllowPaging="True" PageSize="7" OnSelectedIndexChanged="grdAvailableSlips_SelectedIndexChanged" CaptionAlign="Top" HorizontalAlign="Center" style="color: #FFFFFF; background-color: #0099FF"/>

                </strong>

            </div>
            <br />
            <table align="center" style="width: 80%">
                <tr>
                    <td class="text-center">
        <div class="text-center" style="width: 1408px">
            <br />

    </div>

                    </td>
                </tr>
            </table>
        </div>
    </div>
    
    <hr/>

    </asp:Content>
