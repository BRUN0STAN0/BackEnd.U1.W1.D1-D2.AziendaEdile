<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ArchiviaDipendente.aspx.cs" Inherits="AziendaEdile.ArchiviaDipendente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fs-1 text-center m-3">Archivia nuovo dipendente</div>
    <div class="row g-3 mt-3">
        <div class="col-md-6 form-floating">
            <asp:TextBox ID="TextBox_Nome" CssClass="form-control" runat="server"></asp:TextBox>
            <label>Nome</label>
        </div>
        <div class="col-md-6 form-floating">
            <asp:TextBox ID="TextBox_Cognome" CssClass="form-control" runat="server"></asp:TextBox>
            <label>Cognome</label>
        </div>
        <div class="col-12 form-floating">
            <asp:TextBox ID="TextBox_Indirizzo" CssClass="form-control" runat="server"></asp:TextBox>
            <label>Indirizzo</label>
        </div>
        <div class="col-12 form-floating">
            <asp:TextBox ID="TextBox_CodiceFiscale" CssClass="form-control" runat="server"></asp:TextBox>
            <label>CodiceFiscale</label>
        </div>
        <div class="col-md-3 d-flex align-items-center border text-muted border-1 rounded-2">
            <asp:CheckBox ID="CheckBox_Coniugato" runat="server" Text="Coniugato?" />
        </div>
        <div class="col-md-3 form-floating">
            <asp:TextBox ID="TextBox_NumeroFigliACarico" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
            <label>Numero figli a carico</label>
        </div>
        <div class="col-md-3 form-floating">
            <asp:DropDownList ID="DropDownList_Mansione" CssClass="form-control" runat="server"></asp:DropDownList>
            <label>Mansione</label>
        </div>
        <div class="col-md-3 form-floating">
            <asp:LinkButton ID="LinkButton_AggiungiNuovaMansione" CssClass="btn btn-secondary w-100 h-100" PostBackUrl="~/AggiungiMansione.aspx" runat="server">Aggiungere nuova mansione?</asp:LinkButton>
        </div>
        <div class="col-12">
            <asp:Button ID="Button_InsertDipendente" OnClick="Button_InsertDipendente_Click" runat="server" CssClass="w-100 btn btn-dark" Text="Archivia Dipendente" />
        </div>
    </div>
    <asp:Label ID="Label_ERROR" runat="server"></asp:Label>
</asp:Content>
