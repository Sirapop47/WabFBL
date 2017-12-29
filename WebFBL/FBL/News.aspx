<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="FBL.test2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link href="css/bootstrap.css" rel="stylesheet" />

    <link href="https://fonts.googleapis.com/css?family=Athiti" rel="stylesheet">

</head>

<body> 
    <nav class="navbar navbar-dark bg-dark justify-content-between">
      <a class="navbar-brand" style="font-family: 'Athiti', sans-serif; color:#f2eaea ;font-size: 40px;">News</a>
      <form class="form-inline">
        <a href="indexNews.aspx" class="btn btn-outline-light my-2 my-sm-0" type="submit" style="font-family: 'Athiti', sans-serif; color:#3d3232 ;font-size: 20px;">BACK TO NEWs</a>
      </form>
    </nav>

    <form id="form1" runat="server" style ="background-color :#605959">
        <div>

            <br /><br />
            


            <div class="container">
                
              <div class="row">
                <div class="col-sm">
                  
                </div>
                <div class="col-sm">
                    <center>
                    <div class="card" style="width: 40rem;"> 
                        <center><asp:Image ID="Image1" runat="server" CssClass="card-img-top"/></center>
                        
                      <div class="card-body">
                          <a style="font-family: 'Athiti', sans-serif; font-size: 30px;">
                          <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        </a>
                        
                      </div>
                    </div>
                    </center>

                </div>
                <div class="col-sm">
                  
                </div>
              </div>
            </div>

            <br /><br />
            

        </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
</body>
</html>
