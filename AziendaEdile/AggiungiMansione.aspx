<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AggiungiMansione.aspx.cs" Inherits="AziendaEdile.AggiungiMansione" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fs-1 text-center m-3">
        <a href="ArchiviaDipendente.aspx">Ritorna ad Archivia Dipendente</a>
        </div>
      <div class="row g-3 mt-3">
        <div class="col-12 form-floating">
            <asp:TextBox ID="TextBox_Tipologia" CssClass="form-control" runat="server"></asp:TextBox>
            <label>Tipologia Mansione</label>
        </div>
        <div class="col-12 form-floating">
            <asp:TextBox ID="TextBox_Descrizione" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>
            <label>Descrizione Mansione</label>
        </div>
        <div class="col-12">
            <asp:Button ID="Button_InsertMansione" OnClick="Button_InsertMansione_Click" runat="server" CssClass="btn btn-dark w-100 h-100" Text="Inserisci Mansione" />
        </div>
    </div>
    <asp:Label ID="Label_ERROR" runat="server"></asp:Label>
</asp:Content>
