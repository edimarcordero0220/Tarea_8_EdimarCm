<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dDetalleDisco.aspx.cs" Inherits="SistemaDeVentasDiscografico.Registros.dDetalleDisco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 188px;
        }
        .auto-style2 {
            width: 229px;
        }
        .auto-style3 {
            width: 188px;
            height: 82px;
        }
        .auto-style4 {
            width: 229px;
            height: 82px;
        }
        .auto-style5 {
            height: 82px;
        }
        .auto-style6 {
            width: 188px;
            height: 83px;
        }
        .auto-style7 {
            width: 229px;
            height: 83px;
        }
        .auto-style8 {
            height: 83px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Detalle Disco</div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Id Detalle"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="searchButton" runat="server" OnClick="searchButton_Click" Text="Buscar" />
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Fecha"></asp:Label>
                    <asp:TextBox ID="FechaTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Disco Id"></asp:Label>
                    <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label4" runat="server" Text="Nombre Disco"></asp:Label>
                    <asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" Text="Buscar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label3" runat="server" Text="Cancion"></asp:Label>
                    <asp:TextBox ID="CancionTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label6" runat="server" Text="Duracion"></asp:Label>
                    <asp:TextBox ID="DuracionTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:Button ID="AgregarButton" runat="server" OnClick="AgregarButton_Click" Text="Agregar" />
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="GuardarButton" runat="server" OnClick="GuardarButton_Click" Text="Guardar" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
     <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
</html>
