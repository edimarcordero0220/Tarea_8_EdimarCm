<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaDeVentasDiscografico.LoginDelSistema" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="Diseño/bootstrap.css" />
    <link rel="stylesheet" href="Diseño/bootstrap.min.css" />
    
    <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
    </style>
    
</head>
  
<body >
    
       <div class="container">
            <div class="text-center">
                 <div class="card card-container">
    <form id="form1" runat="server" class="auto-style1">
        <br></br>
        <h1>Login</h1>

            <br></br>    
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
                   
                   
                    
                </div>
                <div id="remember" class="checkbox">
                    <label>
                        <input type="checkbox" value="remember-me"> Remember me
                    </label>
                </div>
              <asp:Button ID="IniciarButton" runat="server" OnClick="IniciarButton_Click" Text="Iniciar" />
            </form>
            <a href="#" class="forgot-password">
               
            </a>
      

        
                 
        </div>
    </form>
                
           
                
           
                </div></div>  </div>
</body>

</html>
