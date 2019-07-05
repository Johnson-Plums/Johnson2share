<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="travelWebsite.Index" %>


<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Travel Experts</title>
    <link href="styling/PanelFix.css" rel="stylesheet" />
    <style>
        .CarouselModifyer {
            width: 80vw;
            height: 80vh;
        }
        .packTile {
            background-repeat: no-repeat;
            background-size: cover;  
            background-position: center center;
            float:left;
            width: 80vw;
            height: 80vh;
        }
        #item1 {
            background-image: url("images/europe travel.jpg"); 
        }
        #item2 {
            background-image: url("images/china yangshuo.jpg"); 
        }
        .auto-style6 {
            padding: 15px;
            color: #CC66FF;
        }
    </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="container">
        <div class="panel panel-primary">
            <div class="auto-style6">
                <strong>The most safe, caring and pleasant travel experience you have ever seen.
            </strong>
            </div>
       <%--     <div>
                <iframe width="420" height="315"
                src="https://www.youtube.com/watch?v=vr0qNXmkUJ8?autoplay=1">
                </iframe>
            </div>--%>
            <div class="panel-footer vertical-center">
                    <div id="carouselExampleControls" class="carousel slide CarouselModifyer" data-ride="carousel">
                      <div class="carousel-inner">
                        <div id="item2" class="carousel-item active packTile text-center">
                            Asian Expedition
                        </div>
                        <div id="item1" class="carousel-item packTile text-center">
                            European Vacation
                      </div>
                      <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                      </a>
                      <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                      </a>
                    </div>
            </div>
        </div>
    </div>
    </div>
</asp:Content>