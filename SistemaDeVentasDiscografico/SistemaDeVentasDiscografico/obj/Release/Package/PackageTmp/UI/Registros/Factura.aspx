<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Factura.aspx.cs" Inherits="SistemaDeVentasDiscografico.UI.Factura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <div class="text-center">

                <div class="text-center">
                    <div>
    <asp:Label ID="Label1" runat="server" Text="Factura Id"></asp:Label>
    
    <hr />
    <asp:Label ID="Label2" runat="server" Text="ID Factura"></asp:Label>
&nbsp;
    <asp:TextBox ID="IDTextBox" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;
    <asp:Button ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Fecha"></asp:Label>
&nbsp;
    <asp:TextBox ID="FechaTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Usuarios Creador"></asp:Label>
&nbsp;
    <asp:DropDownList ID="UsuariocreadorDropDownList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre">
    </asp:DropDownList>
    <br />
    <hr />


    <br />
    ID Cliente&nbsp;&nbsp;
    <asp:TextBox ID="ClienteTextBox" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;
    <asp:Button ID="BuscarclienteButton" runat="server" Text="Buscar" OnClick="BuscarclienteButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Nombre"></asp:Label>
&nbsp;<asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
    <br />
    <hr />
    <asp:Label ID="Label6" runat="server" Text="ID Disco"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="IdDiscoTextBox" runat="server" Width="97px" TextMode="Number"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Button ID="BuscardiscoButton" runat="server" OnClick="BuscardiscoButton_Click" Text="Buscar" />
    &nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Text="Nombre Disco"></asp:Label>
&nbsp;
    <asp:TextBox ID="NombreDiscoTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label8" runat="server" Text="Aplicar Precio"></asp:Label>
&nbsp;
    <asp:TextBox ID="PrecioTextBox" runat="server" Width="86px" TextMode="Number"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Button ID="AgregarButton" runat="server" Text="Agregar" OnClick="AgregarButton_Click" />
    <br />
    <br />
      <asp:GridView ID="FacturaGridView" CssClass="auto-style3" runat="server" ForeColor="#333333" Width="758px" ShowFooter="True" Height="115px" HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" Font-Bold="False" />
                <EditRowStyle BackColor="#2461BF" HorizontalAlign="Center" VerticalAlign="Middle" />
                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
                <FooterStyle BackColor="#C0C0C0" Font-Bold="True" ForeColor="White" BorderColor="white" BorderWidth="2px" HorizontalAlign="Justify" VerticalAlign="Top" />
                <HeaderStyle BackColor="#C0C0C0" Font-Bold="True" ForeColor="White" BorderStyle="Outset" Font-Italic="True" Font-Size="12pt" HorizontalAlign="Center" VerticalAlign="Middle" />
                <PagerStyle BackColor="#F8F8FF" ForeColor="White" HorizontalAlign="Center" BorderColor="Black" BorderWidth="2px" />
                <RowStyle BackColor="#EFF3FB" BorderColor="Black" BorderStyle="None" BorderWidth="2px" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" BorderStyle="Solid" BorderWidth="3px" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" BorderStyle="Solid" BorderWidth="3px" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
    <br />
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label9" runat="server" Text="Total"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TotalTextBox" runat="server" Width="113px" TextMode="Number"></asp:TextBox>
    <br />
    <br />
    <br />
                        </div></div></div></div>
    <div class="text-center">
                    <div>
                       
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConStr %>" SelectCommand="SELECT [Nombre], [UsuarioId] FROM [Usuarios]"></asp:SqlDataSource>
                        <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
&nbsp;
                        <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" />
&nbsp;
                        <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" />
                    </div>
                </div>
    <br />
    


</asp:Content>
