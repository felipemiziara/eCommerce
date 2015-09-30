<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<eCommerce.Models.Produto>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.nome) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.detalhes) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.preco) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.imglink) %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.nome) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.detalhes) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.preco) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.imglink) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.idNumber) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { id=item.id }) %> |
            <%: Html.ActionLink("Details", "Details", new { id=item.id }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { id=item.id }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
