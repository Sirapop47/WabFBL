<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="FBL.LoginAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link href="css/bootstrap.css" rel="stylesheet" />

    <link href="https://fonts.googleapis.com/css?family=Athiti" rel="stylesheet">

</head>
<body style="background-color:#a2bbd3">
    <form id="form1" runat="server">
        <div>
            <br /><br /><br />
            
              <div class="row">
                <div class="col-sm">
                  
                </div>
                <div class="col-sm" style="background-color:#ede6e6">
                    <br />

                    <form class="form-signin">
                        <h2 class="form-signin-heading" style="font-family:'Athiti', sans-serif;font-size: 48px;"><center>FootBallLeague</center></h2><br />
                        <div class="form-group">
                            <label for="exampleInputEmail1">Username</label> 
                            <asp:TextBox ID="inputUser" runat="server" CssClass="form-control" placeholder="Username" ></asp:TextBox>
                    

                        </div>

                        <div class="form-group">

                            <label for="exampleInputPassword1">Password</label>
                            <asp:TextBox ID="inputPassword" runat="server" CssClass="form-control" placeholder="Password" type="password"></asp:TextBox>


                        </div><br />
                        <div class="row">
                          <div class="col-6 col-md-4"></div>
                          <div class="col-6 col-md-4">
                              <asp:Button ID="btnLogin" runat="server" Text="Login" class="btn btn-lg btn-primary btn-block" type="submit" OnClick="btnLogin_Click"/>

                              <br />

                              
                          </div>
                          <div class="col-6 col-md-4"></div>
                        </div>
                        <center><label id="lblErrorMessage" runat="server" style="font-family:'Athiti', sans-serif;font-size: 20px; color:red">please check Username and password again</label>
                            
                        </center>

                        <center><a class="nav-link" href="Index.aspx" style="font-family:'Athiti', sans-serif;font-size: 20px; color:#0090ff">Back to Home</a></center>

                        
                    </form>
                    <br /><br />

                    
                </div>
                <div class="col-sm">
                  
                </div>
              </div>
            </div>


    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
    
    </form>
</body>
</html>
