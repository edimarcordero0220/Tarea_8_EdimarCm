<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="VerCatalogo.aspx.cs" Inherits="SistemaDeVentasDiscografico.UI.General.VerCatalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                   <div class="container">
          <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" BorderColor="#006666" BorderWidth="200px" CellPadding="20" CellSpacing="10" Font-Bold="True" Font-Italic="True" Font-Names="Engravers MT" Font-Overline="False" Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Height="501px" HorizontalAlign="Center" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" RepeatColumns="9" RepeatDirection="Horizontal" ShowFooter="False" ShowHeader="False" Width="572px">
              <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" VerticalAlign="Middle" />
              <ItemTemplate>
                  NombreDisco:
                  <asp:Label ID="NombreDiscoLabel" runat="server" Text='<%# Eval("NombreDisco") %>' />
                  <br />
                  Artista:
                  <asp:Label ID="ArtistaLabel" runat="server" Text='<%# Eval("Artista") %>' />
                  <br />
                  Productor:
                  <asp:Label ID="ProductorLabel" runat="server" Text='<%# Eval("Productor") %>' />
                  <br />
                  SelloDiscografico:
                  <asp:Label ID="SelloDiscograficoLabel" runat="server" Text='<%# Eval("SelloDiscografico") %>' />
                  <br />
                  FechaLanzamiento:
                  <asp:Label ID="FechaLanzamientoLabel" runat="server" Text='<%# Eval("FechaLanzamiento") %>' />
                  <br />
<br />
              </ItemTemplate>
          </asp:DataList>
    </div>
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConStr %>" SelectCommand="SELECT [NombreDisco], [Artista], [Productor], [SelloDiscografico], [FechaLanzamiento] FROM [Discos]"></asp:SqlDataSource>
</asp:Content>
