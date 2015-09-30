<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<eCommerce.Models.Carrinho>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<table>
    <tr>
        <th></th>
    </tr>

<% foreach (var item in Model.produtos) { %>
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
      </tr>
<% } %>
    <tr>
        <td>
            <div class="display-label" style="font-weight: bold; text-transform: capitalize">
                Total
            </div>
        </td>
        <td>
            <%: Html.DisplayForModel(Model.total) %>
        </td>
     </tr>
</table>

    <%: Html.ActionLink("Finalizar Compra", "Finalizar") %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
