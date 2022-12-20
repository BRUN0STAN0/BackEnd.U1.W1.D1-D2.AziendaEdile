<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="RegistraPagamento.aspx.cs" Inherits="AziendaEdile.RegistraPagamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="fs-1 text-center m-3">Registra pagamento</div>
    <div class="row g-3 mt-3">
        <div class="col-md-6 form-floating">
            <asp:TextBox ID="TextBox_Periodo" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>
            <label>Periodo</label>
        </div>
        <div class="col-md-6 form-floating">
            <asp:TextBox ID="TextBox_Ammontare" CssClass="form-control" runat="server"></asp:TextBox>
            <label>Ammontare</label>
        </div>
        <div class="col-md-2 d-flex align-items-center border text-muted border-1 rounded-2">
            <asp:CheckBox ID="CheckBox_Acconto" runat="server" Text="Acconto?" />
        </div>
        <div class="col-md-6 form-floating">
            <asp:TextBox ID="TextBox_CercaDipendente" CssClass="form-control"  runat="server"></asp:TextBox>
            <label>Cerca Dipendente</label>
        </div>
        <div class="col-md-1 form-floating">
            <asp:LinkButton ID="LinkButton_CercaDipendente" OnClick="LinkButton_CercaDipendente_Click" CssClass="btn btn-light border border-2 w-100 h-100 d-flex align-items-center justify-content-center" runat="server">🔎</asp:LinkButton>
        </div>
        <div class="col-md-3 form-floating">
            <asp:DropDownList ID="DropDownList_Dipendente" CssClass="form-control" runat="server"></asp:DropDownList>
            <label>Seleziona Dipendente</label>
        </div>
        <div class="col-12">
            <asp:Button ID="Button_RegistraPagamento" OnClick="Button_RegistraPagamento_Click" runat="server" CssClass="w-100 btn btn-dark" Text="Registra Pagamento" />
        </div>
    </div>
    <asp:Label ID="Label_ERROR" runat="server"></asp:Label>
</asp:Content>
