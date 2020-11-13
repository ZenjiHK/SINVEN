<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WAVistas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" />
    <script src='https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js'></script>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script>
    <script src="https://kit.fontawesome.com/3080cbac7f.js"></script>
    <link rel="stylesheet" href="/Estilos/Login.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page">
            <!--Login & Signup in single row-->
            <div class="row">
                <!--Column for signin-->
                <div class="col-sm-8 text-center signin">
                    <p class="h4 mb-4 text-center signintext top"><strong>Inicia sesión en SINVEN</strong></p>
                    <!--Login with Social Media Buttons-->
                    <p class="text-center signintext">Ingresa tus datos en el formulario</p>
                    <!-- Email -->
                    <asp:TextBox ID="txtEmail" runat="server" type="email" class="form-control mb-4" placeholder="&#xf0e0; Correo electrónico" style="font-family: Arial, FontAwesome"/>
                    <!-- Password -->
                    <asp:TextBox ID="txtPass" runat="server" type="password" class="form-control mb-4" placeholder="&#xf023; Password" style="font-family: Arial, FontAwesome"/>
                    <!-- Sign in button -->
                    <asp:Button ID="btnEntrar" class="btn btn-info LoginBtn" runat="server" Text="INGRESAR" />
                </div>
                <!--Column for signin-->
                <div class="col-sm-4 signup text-center">
                    <h2 class="HelloFriend">¡Bienvenido!</h2>
                    <h4 class="SignupText">En SINVEN, serás capaz de administrar el inventario de tu restaurante de manera sencilla<br /><br />
                        Inicia sesión para que puedas acceder a todas sus funcionalidades</h4>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
