<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaDeVentasDiscografico.Login" %>
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

                 <div class="card card-container">
            <!-- <img class="profile-img-card" src="//lh3.googleusercontent.com/-6V8xOA6M7BA/AAAAAAAAAAI/AAAAAAAAAAA/rzlHcD0KYwo/photo.jpg?sz=120" alt="" /> -->
            <img id="profile-img" class="profile-img-card" src="//ssl.gstatic.com/accounts/ui/avatar_2x.png" />
            <p id="profile-name" class="profile-name-card"></p>
            <form class="form-signin">
                 <div class="text-center">
                    <div>
                        <asp:Label ID="Label7" runat="server" Text="Nombre Usuario"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
                    
                </div>
                <div class="text-center">
                    <div>
                        <asp:Label ID="Label1" runat="server" Text="Clave"></asp:Label>
                    </div>
                </div>
                
                 <div class="text-center">
                    <asp:TextBox ID="ContrasenaTextBox" runat="server" TextMode="Password"></asp:TextBox>
                     
                    
                     
                    
                </div>
                <div class="text-center">
                   
                     <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="verCheckBox_CheckedChanged" Text="Ver Contrasena" />
                    
                </div>
                <div id="remember" class="checkbox">
                    <label>
                        <input type="checkbox" value="remember-me"> Remember me
                    </label>
                </div>
               <asp:Button ID="EntrarButton" runat="server" Text="Entrar" OnClick="EliminarButton_Click" style="height: 26px" />
            </form>
            <a href="#" class="forgot-password">
               
            </a>
        </div>


                </div></div>

             
       

      </body>

</asp:Content>
