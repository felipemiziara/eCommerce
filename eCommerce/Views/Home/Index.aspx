<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<eCommerce.Models.Catalogo>" %>
<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page - eCommerce MVC Application
</asp:Content>

<asp:Content ID="indexFeatured" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Home Page.</h1>
                <h2><%: ViewBag.Message %></h2>
            </hgroup>
        </div>
    </section>
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>We suggest the following:</h3>
    <ol class="round">

        <%foreach(var produto in Model.lista){ %>
        <li class="<%: produto.idNumber %>">
            <img src=<%: produto.imglink %> alt="ASP.NET" class="img-responsive"/>
            <div class="container">
                <div class="carousel-caption">
                    <p>
                        <%: produto.nome %> -- R$ <%: produto.preco %>
                        <%: Html.ActionLink("Ver Produto", "Details", "Produto",  new { id=produto.id }, null)%>
                        <%-- <a class="btn btn-default btn-default" asp-controller="Produto" asp-action="Detalhes" asp-route-id="@produto.id">Ver Detalhes</a>--%>
                    </p>
                </div>
            </div>
        </li>
        <%}%>
    </ol>
</asp:Content>
