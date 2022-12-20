<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="DettaglioPagamenti.aspx.cs" Inherits="AziendaEdile.DettaglioPagamenti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mt-3 col-md-12 gradient-custom text-center bg-dark text-white rounded-3">
        <h1><asp:Label ID="Label_Cognome" runat="server"></asp:Label></h1>
        <h2><asp:Label ID="Label_Nome" runat="server"></asp:Label></h2>
    </div>
    <div class="col-12">
        <asp:GridView ID="GridView_Pagamenti" CssClass="table table-striped table-secondary border border-light w-100 " ItemType="AziendaEdile.Pagamento" AutoGenerateColumns="false" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="Nr Pagamento">
                    <ItemTemplate><%# Item.ID_Pagamento %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Data" >
                    <ItemTemplate><%# Item.Periodo.ToString("Y") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="E' un acconto?" >
                    <ItemTemplate><%# Item.Acconto %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Pagamento" >
                    <ItemTemplate><%# Item.Ammontare %></ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <asp:Label ID="Label_ERROR" runat="server"></asp:Label>
</asp:Content>
