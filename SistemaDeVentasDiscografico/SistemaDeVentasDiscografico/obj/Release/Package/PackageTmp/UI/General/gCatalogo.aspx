<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="gCatalogo.aspx.cs" Inherits="SistemaDeVentasDiscografico.UI.General.gContactanos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <br />
    <br />
    <br />
    <br />

    <form id="form1" runat="server">
        <div>
            <asp:ContentPlaceHolder ID="ContentPlaceHolder1" runat="server">
            </asp:ContentPlaceHolder>
   
            <div class="contact section" id="section-5">
                <div class="container">
                </div>
                <asp:ScriptManager ID="ScriptManager" runat="server">
                </asp:ScriptManager>
            </div>
            <script src="Scripts/jquery.nav.js"></script>

        </div>
</form>

</asp:Content>
