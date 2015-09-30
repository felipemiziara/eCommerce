<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<eCommerce.Models.Produto>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Create</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Produto</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.nome) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.nome) %>
            <%: Html.ValidationMessageFor(model => model.nome) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.detalhes) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.detalhes) %>
            <%: Html.ValidationMessageFor(model => model.detalhes) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.preco) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.preco) %>
            <%: Html.ValidationMessageFor(model => model.preco) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.imglink) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.imglink) %>
            <%: Html.ValidationMessageFor(model => model.imglink) %>
        </div>


        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
    <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>
