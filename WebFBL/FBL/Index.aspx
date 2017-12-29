<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FBL.Index" %>

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
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
          <a class="navbar-brand" href="#">FootBall League</a>
          <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
              <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="navbarSupportedContent">
              <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                  <li class="nav-item">
                      <a class="nav-link" href="EPL.aspx">Premiere League</a>
                  </li>
                  <li class="nav-item">
                      <a class="nav-link " href="Laliga.aspx">La Liga</a>
                  </li>
                  <li class="nav-item">
                      <a class="nav-link " href="BUN.aspx">Bundesliga</a>
                  </li>
                  <li class="nav-item">
                      <a class="nav-link " href="SerieA.aspx">Calcio Serie A</a>
                  </li>
                  <li class="nav-item">
                      <a class="nav-link " href="L1.aspx">League1</a>
                  </li>
              </ul>

     
          </div>
       
        
     </nav>

     
  
    
    <form id="form1" runat="server">
        <div>
            <div class="container-fluid" style ="background-color: #1e1d1d">
                <br />

                <div class="row">
                    <div class="col-1"></div>

                    <div class="col-10">        



                    </div>

                    <div class="col-1"></div>


                </div>
                <br />
            </div>
     

            


            



            <div class="container-fluid">
                <div class="row">
                    <div class="col-1"></div>


                     
                    <div class="col col-3">
                        <br />
                        <ul class="nav nav-tabs" id="myTab" role="tablist">
                          <li class="nav-item">
                            <a class="nav-link active" id="EPL-tab" data-toggle="tab" href="#EPL" role="tab" aria-controls="EPL" aria-selected="true" >EPL</a>
                          </li>
                          <li class="nav-item">
                            <a class="nav-link" id="LFP-tab" data-toggle="tab" href="#LFP" role="tab" aria-controls="LFP" aria-selected="false">LFP</a>
                          </li>
                          <li class="nav-item">
                            <a class="nav-link" id="BL-tab" data-toggle="tab" href="#BL" role="tab" aria-controls="BL" aria-selected="false">BL</a>
                          </li>
                          <li class="nav-item">
                            <a class="nav-link" id="SA-tab" data-toggle="tab" href="#SA" role="tab" aria-controls="SA" aria-selected="false">SA</a>
                          </li>
                          <li class="nav-item">
                            <a class="nav-link" id="L1-tab" data-toggle="tab" href="#L1" role="tab" aria-controls="L1" aria-selected="false">L1</a>
                          </li>
                        </ul>
                        <div class="tab-content" id="myTabContent" style="font-family: 'Athiti', sans-serif; font-size: 12px; ">
                          <div class="tab-pane fade show active" id="EPL" role="tabpanel" aria-labelledby="EPL-tab" ><asp:PlaceHolder ID="EPLPlaceHolder" runat="server"></asp:PlaceHolder> </div>
                          <div class="tab-pane fade" id="LFP" role="tabpanel" aria-labelledby="LFP-tab"><asp:PlaceHolder ID="LFPPlaceHolder" runat="server"></asp:PlaceHolder></div>
                          <div class="tab-pane fade" id="BL" role="tabpanel" aria-labelledby="BL-tab"><asp:PlaceHolder ID="BLPlaceHolder" runat="server"></asp:PlaceHolder></div>
                          <div class="tab-pane fade" id="SA" role="tabpanel" aria-labelledby="SA-tab"><asp:PlaceHolder ID="SAPlaceHolder" runat="server"></asp:PlaceHolder></div>
                          <div class="tab-pane fade" id="L1" role="tabpanel" aria-labelledby="L1-tab"><asp:PlaceHolder ID="L1PlaceHolder" runat="server"></asp:PlaceHolder></div>
                        </div>

                       
                    </div> 

                     

                    <div class="col-7">
                        <br />
                        <div id="myCarousel" class="carousel slide" style ="font-family: 'Athiti', sans-serif; font-size: 18px; ">
                          <ol class="carousel-indicators">
                            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                            <li data-target="#myCarousel" data-slide-to="1" ></li>
                            <li data-target="#myCarousel" data-slide-to="2" ></li>
                          </ol>
                            
                            
                          <div class="carousel-inner">
                            <div class="carousel-item active">
                                <asp:Image CssClass="d-block w-100" ID="Image1" runat="server" />
                                <asp:Label  ID="TtNews1" runat="server" Text=""> 
                                    <div class="carousel-caption d-none d-md-block">
                                        <a>
                                            <h3> <%# News1 %> </h3>
                                        </a>
                                    </div>                     
                                           
                                </asp:Label>
                            </div>
                            <div class="carousel-item">
                                <asp:Image CssClass="d-block w-100" ID="Image2" runat="server" />
                                <asp:Label  ID="TtNews2" runat="server" Text=""> 
                                    <div class="carousel-caption d-none d-md-block">
                                        <a>
                                            <h3> <%# News1 %> </h3>
                                        </a>
                                    </div>                     
                                           
                                </asp:Label>
                            </div>
                            <div class="carousel-item">
                                <asp:Image CssClass="d-block w-100" ID="Image3" runat="server" />
                                <asp:Label  ID="TtNews3" runat="server" Text=""> 
                                    <div class="carousel-caption d-none d-md-block">
                                        <a>
                                            <h3> <%# News1 %> </h3>
                                        </a>
                                    </div>                     
                                           
                                </asp:Label>
   
                            </div>
                          </div>
                           <a class="carousel-control-prev" href="#myCarousel" role="button" data-slide="prev">
                             <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                             <span class="sr-only">Previous</span>
                           </a>
                           <a class="carousel-control-next" href="#myCarousel" role="button" data-slide="next">
                             <span class="carousel-control-next-icon" aria-hidden="true"></span>
                             <span class="sr-only">Next</span>
                           </a>
                          
                        </div>

                        <br />

                        <center>
                            <a style="font-family: 'Athiti', sans-serif; font-size: 30px; "><p> Latest News </p></a> <br />
                            <div class="container marketing">
                              <!-- Three columns of text below the carousel -->
                              <div class="row">


                                <div class="row" id="usercontent" runat="server">
                                      
                                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                              
                                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

                                </div>
                                
                                  
                              </div><!-- /.row -->
                            </div>
                             <button type="button" class="btn  btn-dark"><a class="nav-link" href="indexNews.aspx">อ่านทั้งหมด</a></button>
                        </center> 
                        
                    </div>

                    <div class="col-1"></div>
                      
                                    
                </div>
            </div>
            <br />
            <br /><br /><br /><br /><br />

        </div>
    </form>

    <footer class="text-muted"  id="myFooter" style ="background-color: #1e1d1d">
        <br /><br />
      <div class="container" >
        <p class="float-right" style ="font-family: 'Athiti', sans-serif; font-size: 18px; ">
          <a class=" nav-link" href="LoginAdmin.aspx">Admin</a>  
        </p>
          <div class="footer-copyright">
            <p>© 2016 FootBall League </p>
        </div>
        
        
      </div>
        <br />
    </footer>

    

    
    
    
    
    
    
    
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
    
</body>
</html>
