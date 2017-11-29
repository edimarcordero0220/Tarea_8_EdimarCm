<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="rDiscos.aspx.cs" Inherits="SistemaDeVentasDiscografico.Registros.rDiscos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 18;
        }
    </style>
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
                     
                    <asp:TextBox ID="IdTextBox" runat="server" CssClass="auto-style1" Width="48px"></asp:TextBox>
                     &nbsp;&nbsp;
                      <asp:Button ID="BuscarButton" runat="server" Text="Buscar" Width="58px" /> 
                    
                </div>

                <div class="text-center">
                    <div>
                        <asp:Label ID="Label2" runat="server" Text="Productor "></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:TextBox ID="ProductorTextBox" runat="server"></asp:TextBox>
                    
                </div>

                <div class="text-center">
                    <div>
                        <asp:Label ID="Label3" runat="server" Text="Fecha Lanzamiento"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:TextBox ID="FechaTextBox" runat="server"></asp:TextBox>
                    
                </div>

                 <div class="text-center">
                    <div>
                        <asp:Label ID="Label4" runat="server" Text="Nombre del Dicos"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
                    
                </div>

                <div class="text-center">
                    <div>
                        <asp:Label ID="Label5" runat="server" Text="Sello"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:TextBox ID="SelloTextBox" runat="server"></asp:TextBox>
                    
                </div>

                <div class="text-center">
                    <div>
                        <asp:Label ID="Label6" runat="server" Text="Artista"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:TextBox ID="ArtistaTextBox" runat="server"></asp:TextBox>
                    
                </div>

                <div class="text-center">
                    <div>
                        <asp:Label ID="Label7" runat="server" Text="Fecha Creacion"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:TextBox ID="FechacreacionTextBox" runat="server" Enabled="False"></asp:TextBox>
                    
                </div>

                <div class="text-center">
                    <div>
                        <asp:Label ID="Label8" runat="server" Text="Usuario Creador"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:DropDownList ID="UsuariosDropDownList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre" OnSelectedIndexChanged="UsuariosDropDownList_SelectedIndexChanged">
                    </asp:DropDownList>
                    
                </div>

                

                </div></div>

             
       

      </body>
        
        <br></br>
         <div class="container">
            <div class="text-center">
                <div class="text-center">
                    <div>
                       
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConStr %>" SelectCommand="SELECT [Nombre] FROM [Usuarios]"></asp:SqlDataSource>
                       
                     <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" style="height: 26px" />  
                        &nbsp;&nbsp;
                         <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" OnClick="NuevoButton_Click" /> 
                        &nbsp;&nbsp;
                        <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />  
                        
                    </div>
                </div>
     
                 </div></div>


</asp:Content>




