<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rDisco.aspx.cs" Inherits="SistemaDeVentasDiscografico.Registros.rDisco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
    <title></title>
    
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/angularjs/1.0.7/angular.min.js"></script>

    <style type="text/css">

        .auto-style1 {
            width: 220px;
        }
        .auto-style2 {
            width: 180px;
        }
        .auto-style3 {
            margin-right: 39px;
        }
        .auto-style4 {
            width: 220px;
            height: 47px;
        }
        .auto-style5 {
            width: 180px;
            height: 47px;
        }
        .auto-style6 {
            height: 47px;
        }
        .auto-style7 {
            width: 220px;
            height: 29px;
        }
        .auto-style8 {
            width: 180px;
            height: 29px;
        }
        .auto-style9 {
            height: 29px;
        }
        .auto-style10 {
            width: 137px;
        }
        .auto-style11 {
            width: 152px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Registro de Disco</div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="IdDisco"></asp:Label>
                    <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="Label4" runat="server" Text="Productor"></asp:Label>
                    <asp:TextBox ID="ProductorTextBox" runat="server" CssClass="auto-style3" Width="133px"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label7" runat="server" Text="Fecha Lanzamiento"></asp:Label>
                    <asp:TextBox ID="Fecha2TextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="Label5" runat="server" Text="Sello "></asp:Label>
                    <asp:TextBox ID="SelloTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Artista"></asp:Label>
                    <asp:TextBox ID="ArtistaTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Fecha Creacion"></asp:Label>
                    <asp:TextBox ID="Fecha1TextBox" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style10">
                    <asp:Button ID="GuardarButton" runat="server" OnClick="GuardarButton_Click" Text="Guardar" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
                </td>
                <td>
                    <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" OnClick="NuevoButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
</html>
