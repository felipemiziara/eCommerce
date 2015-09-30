<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<eCommerce.Models.Produto>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

<fieldset>
    <legend>Produto</legend>
    <div class="display-field">
       <img src="<%: Html.DisplayFor(model => model.imglink) %>" />
    </div>

    <div class="display-label" style="font-weight: bold; text-transform: capitalize">
        <%: Html.DisplayNameFor(model => model.nome) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.nome) %>
    </div>

    <div class="display-label" style="font-weight: bold; text-transform: capitalize">
        <%: Html.DisplayNameFor(model => model.detalhes) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.detalhes) %>
    </div>

    <div class="display-label" style="font-weight: bold; text-transform: capitalize">
        <%: Html.DisplayNameFor(model => model.preco) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.preco) %>
    </div>

</fieldset>
<p>

    <%: Html.ActionLink("Edit", "Edit", new { id=Model.id }) %> |
    <%: Html.ActionLink("Back to List", "Index") %> |
    <%: Html.ActionLink("Adicionar ao Carrinho", "Add", "Carrinho", new { i=Model.id }, null) %>
</p>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
