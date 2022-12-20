<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AziendaEdile.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row ">
    <asp:Repeater ID="Repeater_Dipendente" ItemType="AziendaEdile.Dipendente" runat="server">
        <ItemTemplate>
            <div class="col col-lg-6 mb-lg-4 my-3">
                <div class="card mb-3 rounded-2">
                    <div class="row g-0">
                        <div class="col-md-4 gradient-custom text-center bg-secondary text-white"
                            style="border-top-left-radius: .5rem; border-bottom-left-radius: .5rem;">
                            <div class="my-5"><img src="https://freesvg.org/img/abstract-user-flat-4.png" class="img-fluid w-50" /></div>
                            <h5><%#Item.Cognome %></h5>
                            <p><%#Item.Nome %></p>
                            <i class="far fa-edit mb-5"></i>
                        </div>
                        <div class="col-md-8">
                            <div class="card-body p-4 ">
                                <h6  class="text-nowrap overflow-scroll">Indirizzo <span class="fs-5 fw-lighter"><%#Item.Indirizzo%></span> </h6>
                                <hr class="m-0 p-0">
                                <h6  class="text-nowrap overflow-scroll">Cod.Fiscale <span class="fs-5 fw-lighter"><%#Item.CodiceFiscale%></span> </h6>
                                <hr class="m-0 p-0">
                                <h6  class="text-nowrap overflow-scroll">Coniugato <span class="fs-5 fw-lighter">
                                <asp:Label runat="server" Text="Si" Visible="<%#Item.Coniugato%>"></asp:Label> <asp:Label runat="server" Text="No" Visible="<%#!Item.Coniugato%>"></asp:Label></span> </h6>
                                <hr class="m-0 p-0">
                                <h6  class="text-nowrap overflow-scroll">Figli <span class="fs-5 fw-lighter"><%#Item.NumeroFigliACarico%></span> </h6>
                                <hr class="m-0 p-0">
                                <h6  class="text-nowrap overflow-scroll">Mansione <span class="fs-5 fw-lighter"><%#Item.Mansione%></span> </h6>
                                <hr class="m-0 p-0">
                                <a href="DettaglioPagamenti.aspx?ID=<%# Item.ID_Dipendente %>" class="btn btn-dark"  > Dettaglio Pagamenti Utente </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
        </div>
    <asp:Label ID="Label_ERROR" runat="server"></asp:Label>
</asp:Content>
