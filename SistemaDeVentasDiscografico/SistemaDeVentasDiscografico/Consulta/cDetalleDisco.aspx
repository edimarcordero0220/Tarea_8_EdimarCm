<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cDetalleDisco.aspx.cs" Inherits="SistemaDeVentasDiscografico.Consulta.cDetalleDisco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
        }
        .auto-style2 {
            width: 124px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Consulta</div>
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="DetalleDiscoID" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:BoundField DataField="DetalleDiscoID" HeaderText="DetalleDiscoID" InsertVisible="False" ReadOnly="True" SortExpression="DetalleDiscoID" />
                            <asp:BoundField DataField="DiscoId" HeaderText="DiscoId" SortExpression="DiscoId" />
                            <asp:BoundField DataField="Cancion" HeaderText="Cancion" SortExpression="Cancion" />
                            <asp:BoundField DataField="DuraciondelaCancion" HeaderText="DuraciondelaCancion" SortExpression="DuraciondelaCancion" />
                            <asp:BoundField DataField="FechaCreacion" HeaderText="FechaCreacion" SortExpression="FechaCreacion" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConStr %>" SelectCommand="SELECT [DetalleDiscoID], [DiscoId], [Cancion], [DuraciondelaCancion], [FechaCreacion], [Nombre] FROM [DetalleDiscos]"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
