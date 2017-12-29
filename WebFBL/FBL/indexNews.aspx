<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexNews.aspx.cs" Inherits="FBL.indexNews" %>
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
        <a href="Index.aspx" class="btn btn-outline-light my-2 my-sm-0" type="submit" style="font-family: 'Athiti', sans-serif; color:#3d3232 ;font-size: 20px;">BACK TO HOME</a>
      </form>
    </nav>

    <form id="form1" runat="server" style ="background-color :#605959">
        <div>

            <br /><br />
            


            <div class="container">
                
              <div class="row">
                <div class="col-2">
                  
                </div>
                <div class="col-8">
                    <div class="row" id="usercontent" runat="server">
                          
                        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    


                      
                    </div>

                </div>
                <div class="col-2">
                  
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

