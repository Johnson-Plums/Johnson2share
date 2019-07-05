﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConfirmOrder.aspx.cs" Inherits="travelWebsite.ConfirmOrder" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ContentPlaceHolderID="BodyPlaceHolder" runat="server">

    <asp:DataList ID="DataList1" runat="server" DataSourceID="PackageInfo" OnItemCreated="DataList1_ItemCreated">
        <ItemTemplate>
            Package Id:
            <asp:Label ID="PackageIdLabel" runat="server" Text='<%# Eval("PackageId") %>' />
            <br />
            Package Name:
            <asp:Label ID="PkgNameLabel" runat="server" Text='<%# Eval("PkgName") %>' />
            <br />
           Travel Start Date:
            <asp:Label ID="PkgStartDateLabel" runat="server" Text='<%# Eval("PkgStartDate") %>' />
            <br />
            Package End Date:
            <asp:Label ID="PkgEndDateLabel" runat="server" Text='<%# Eval("PkgEndDate") %>' />
            <br />
            Description:
            <asp:Label ID="PkgDescLabel" runat="server" Text='<%# Eval("PkgDesc") %>' />
            <br />
            Base Price:
            <asp:Label ID="PkgBasePriceLabel" runat="server" Text='<%# Eval("PkgBasePrice") %>' />
            <br />
            Commission:
            <asp:Label ID="PkgAgencyCommissionLabel" runat="server" Text='<%# Eval("PkgAgencyCommission") %>' />
            <br />
            Departure Flight:
            <asp:Label ID="DepartureFlightLabel" runat="server" Text='<%# Eval("DepartureFlight") %>' />
            <br />
            Return Flight:
            <asp:Label ID="ReturnFlightLabel" runat="server" Text='<%# Eval("ReturnFlight") %>' />
            <br />
            <asp:DataList ID="DataList2" runat="server" DataSourceID="PlaneInfo">
                <ItemTemplate>
                    Flight Id:
                    <asp:Label ID="FlightIdLabel" runat="server" Text='<%# Eval("FlightId") %>' />
                    <br />
                    Plane No:
                    <asp:Label ID="FltPlaneNoLabel" runat="server" Text='<%# Eval("FltPlaneNo") %>' />
                    <br />
                    Departure:
                    <asp:Label ID="FltDepartLabel" runat="server" Text='<%# Eval("FltDepart") %>' />
                    <br />
                    Return:
                    <asp:Label ID="FltReturnLabel" runat="server" Text='<%# Eval("FltReturn") %>' />
                    <br />
                    Location:
                    <asp:Label ID="FltLocationLabel" runat="server" Text='<%# Eval("FltLocation") %>' />
                    <br />
                   Destination:
                    <asp:Label ID="FltDestinationLabel" runat="server" Text='<%# Eval("FltDestination") %>' />
                    <br />
                    Region Id:
                    <asp:Label ID="RegionIdLabel" runat="server" Text='<%# Eval("RegionId") %>' />
                    <br />
                   Ticket Price:
                    <asp:Label ID="FltTicketPriceLabel" runat="server" Text='<%# Eval("FltTicketPrice") %>' />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:DataList>
            <asp:ObjectDataSource ID="PlaneInfo" runat="server" SelectMethod="getFlightsById" TypeName="TravelExpertData.DBactions.FlightsTableDB">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DepartureFlightLabel" Name="DepartPlnId" PropertyName="Text" Type="Int32" />
                    <asp:ControlParameter ControlID="ReturnFlightLabel" Name="ReturnPlnId" PropertyName="Text" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
<br />
        </ItemTemplate>
    </asp:DataList>
    <asp:ObjectDataSource ID="PackageInfo" runat="server" SelectMethod="GetPackagesById" TypeName="TravelExpertData.PackageDB">
        <SelectParameters>
            <asp:SessionParameter Name="PackageId" SessionField="lastPckgVw" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    Select a Class: <asp:DropDownList ID="ClassesDropDDl" runat="server" DataSourceID="ClassesSource" DataTextField="ClassName" DataValueField="ClassId"></asp:DropDownList>
    <asp:ObjectDataSource ID="ClassesSource" runat="server" SelectMethod="GetClasses" TypeName="TravelExpertData.DBactions.ClassesDB"></asp:ObjectDataSource>
    &nbsp;<br />
   Number Of Customers: <asp:TextBox runat="server" ID="TravelerCount" name="TravelerCount" type="number" />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm Booking" />
    <br />

</asp:Content>