<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="rClientes.aspx.cs" Inherits="SistemaDeVentasDiscografico.Registros.rClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <!DOCTYPE html>
    <html>
    <head>
        <title></title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    </head>

  <body>
      <div class="container">
            <div class="text-center">
                
                 <div class="text-center">
                    <div>
                        <asp:Label ID="Label1" runat="server" Text="Id "></asp:Label>
                    </div>
                </div>
                
                 <div  class="text-center">
                     
                    <asp:TextBox ID="IdTextBox" runat="server" CssClass="auto-style1" Width="48px" TextMode="Number"></asp:TextBox>
                     &nbsp;&nbsp;
                      <asp:Button ID="BuscarButton" runat="server" Text="Buscar" Width="58px" OnClick="BuscarButton_Click" /> 
                    
                </div>
                 <div class="text-center">
                    <div>
                        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
                    
                </div>

                 <div class="text-center">
                    <div>
                        <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:TextBox ID="ApellidoTextBox" runat="server"></asp:TextBox>
                    
                </div>
                 <div class="text-center">
                    <div>
                        <asp:Label ID="Label4" runat="server" Text="Direccion"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:TextBox ID="DireccionTextBox" runat="server"></asp:TextBox>
                    
                </div>

                 <div class="text-center">
                    <div>
                        <asp:Label ID="Label5" runat="server" Text="Cedula"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:TextBox ID="CedulaTextBox" runat="server"></asp:TextBox>
                    
                </div>
                 <div class="text-center">
                    <div>
                        <asp:Label ID="Label6" runat="server" Text="Fecha"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:TextBox ID="FechaTextBox" runat="server"></asp:TextBox>
                    
                </div>

                 <div class="text-center">
                    <div>
                        <asp:Label ID="Label7" runat="server" Text="Usuario Creador"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConStr %>" SelectCommand="SELECT [Nombre] FROM [Usuarios]"></asp:SqlDataSource>
                     <asp:DropDownList ID="UsuarioDropDownList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre">
                     </asp:DropDownList>
                    
                </div>



                </div></div>

             
        <div class="text-center">
                    <div>
                        
          

                        <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
                        &nbsp;&nbsp;
          

                        <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" OnClick="NuevoButton_Click" />
                        &nbsp;&nbsp;
                        <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
          

              </div></div>

      </body>
       
</asp:Content>
