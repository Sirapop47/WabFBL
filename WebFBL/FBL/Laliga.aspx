<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Laliga.aspx.cs" Inherits="FBL.Laliga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laliga</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link href="css/bootstrap.css" rel="stylesheet" />

    <link href="https://fonts.googleapis.com/css?family=Athiti" rel="stylesheet">

</head>
<body>

    <nav class="navbar navbar-expand-lg navbar-light bg-light">
          <a class="navbar-brand">Laliga</a>
          <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
              <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="navbarSupportedContent">
              <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                  <li class="nav-item active">
                      <a class="nav-link" href="SerieA.aspx">SerieA <span class="sr-only">(current)</span></a>
                        
                  </li>
                   <li>
                       <a class="nav-link" href="BUN.aspx">Bundesliga <span class="sr-only">(current)</span></a>



                   </li>
                   <li>
                        <a class="nav-link" href="EPL.aspx">EPL <span class="sr-only">(current)</span></a>

                   </li>
                   <li>
                        <a class="nav-link" href="L1.aspx">League1 <span class="sr-only">(current)</span></a>
                   </li>
              </ul>
     
              <form class="form-inline my-2 my-lg-0">
                  <button class="btn btn-outline-info my-2 my-sm-0" type="submit"><a href ="Index.aspx" class="nav-link">Back to Home</a></button>
              </form>
     
          </div>
     </nav>

    <form id="form1" runat="server">
        <div>
            <br /> <br />
            <div class="container">

                <div class="row">
                    <div class="col-md-9">
                        <asp:TextBox ID="SearchTextBox" runat="server" CssClass="form-control" placeholder="ค้นหา Player"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <asp:Button ID="SearchButton" runat="server" Text="ค้นหา" CssClass="form-control" BackColor="#efb1b1" OnClick="SearchButton_Click"/>
                    </div>
                    <div class="row" id="usercontent" runat="server" style="margin-top:20px;padding-left: 20px;padding-right:20px;">
                         <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    </div>
                </div>  <br />
                <ul class="nav nav-pills mb-3 nav-fill " id="pills" role="tablist" runat="server">

                  <li class="nav-item">
                    <a class="nav-link active" id="pills-Tables-tab" data-toggle="pill" href="#pills-Tables" role="tab" aria-controls="pills-Tables" aria-selected="true">Tables</a>
                  </li>

                  <li class="nav-item">
                    <a class="nav-link" id="pills-Players-tab" data-toggle="pill" href="#pills-Players" role="tab" aria-controls="pills-Players" aria-selected="false">Players</a>
                  </li>
                </ul>
                <div class="tab-content" id="pills-tabContent">
                  <div class="tab-pane fade show active " id="pills-Tables" role="tabpanel" aria-labelledby="pills-Tables-tab">
                      <div class="container"> 
          
                          <asp:PlaceHolder ID="LFPPlaceHolder" runat="server"></asp:PlaceHolder>

                      </div>


                  </div>
  
                  <div class="tab-pane fade" id="pills-Players" role="tabpanel" aria-labelledby="pills-Players-tab">
                      <asp:PlaceHolder ID="phPlayerLFP" runat="server"></asp:PlaceHolder>
                  </div>
                </div>


            </div>
            







        </div>
    </form>


    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
</body>
</html>