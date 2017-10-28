<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cDiscos.aspx.cs" Inherits="SistemaDeVentasDiscografico.Consulta.cDiscos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
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
                <td>&nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="DiscoId" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:BoundField DataField="DiscoId" HeaderText="DiscoId" InsertVisible="False" ReadOnly="True" SortExpression="DiscoId" />
                            <asp:BoundField DataField="NombreDisco" HeaderText="NombreDisco" SortExpression="NombreDisco" />
                            <asp:BoundField DataField="Artista" HeaderText="Artista" SortExpression="Artista" />
                            <asp:BoundField DataField="Productor" HeaderText="Productor" SortExpression="Productor" />
                            <asp:BoundField DataField="SelloDiscografico" HeaderText="SelloDiscografico" SortExpression="SelloDiscografico" />
                            <asp:BoundField DataField="FechaLanzamiento" HeaderText="FechaLanzamiento" SortExpression="FechaLanzamiento" />
                            <asp:BoundField DataField="FechaCreacion" HeaderText="FechaCreacion" SortExpression="FechaCreacion" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConStr %>" SelectCommand="SELECT [DiscoId], [NombreDisco], [Artista], [Productor], [SelloDiscografico], [FechaLanzamiento], [FechaCreacion] FROM [Discos]"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
