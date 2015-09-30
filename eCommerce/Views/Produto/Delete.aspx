<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<eCommerce.Models.Produto>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>Produto</legend>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.nome) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.nome) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.detalhes) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.detalhes) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.preco) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.preco) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.imglink) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.imglink) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.idNumber) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.idNumber) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
