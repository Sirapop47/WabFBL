<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="FBL.Admin" %>

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


    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-dark bg-dark">
                <a class="navbar-brand" style ="color:beige">
                    <a class="nav-link" style="font-family:'Athiti', sans-serif;font-size: 30px; color:#e01818">Admin           
                    <asp:Label ID="lblUserConnect" runat="server" Text="" style="font-family:'Athiti', sans-serif;font-size: 20px; color:#f2eded"></asp:Label> </a>
                                            
                </a>
                <form class="form-inline my-2 my-lg-0">
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-outline-secondary" OnClick="btnLogout_Click"/>
                </form>

                

                

            </nav><br /><center><a style="font-family:'Athiti', sans-serif;font-size: 40px;"><asp:Label ID="lblErrorMessage" runat="server" Text=""></asp:Label>
                




                                </a></center><br />
            

        
            <div class="container"> 
                <nav class="nav nav-tabs" id="myTab1" role="tablist">
                   <a class="nav-item nav-link active" id="nav-Update-tab" data-toggle="tab" href="#nav-Update" role="tab" aria-controls="nav-Update" aria-selected="true">Update Table</a>
                   <a class="nav-item nav-link" id="nav-News-tab" data-toggle="tab" href="#nav-News" role="tab" aria-controls="nav-News" aria-selected="false">News</a>
                   
                 </nav>
                 <div class="tab-content" id="nav-tabContent">
                     

         <!----------------------------------------------------------------------#Table--------------------------------------------------------------------------------------------------------------------------------->
                      
                   <div class="tab-pane fade show active" id="nav-Update" role="tabpanel" aria-labelledby="nav-Update-tab">
                       <br />
                        <ul class="nav nav-tabs " id="myTab2" role="tablist">
                                <li class="nav-item">
                                    <a class="nav-link active" id="EPL-tab" data-toggle="tab" href="#EPL" role="tab" aria-controls="EPL" aria-selected="true" >Premier League</a>
                                </li>
                                <li class="nav-item">             
                                    <a class="nav-link" id="LFP-tab" data-toggle="tab" href="#LFP" role="tab" aria-controls="LFP" aria-selected="false">LaLiga</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" id="BL-tab" data-toggle="tab" href="#BL" role="tab" aria-controls="BL" aria-selected="false">BundesLiga</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" id="SA-tab" data-toggle="tab" href="#SA" role="tab" aria-controls="SA" aria-selected="false">Serie A</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" id="L1-tab" data-toggle="tab" href="#L1" role="tab" aria-controls="L1" aria-selected="false">Ligue 1</a>
                                </li>
                            </ul>
                            <div class="tab-content" id="myTabContent" ">
                              <div class="tab-pane fade show active" id="EPL" role="tabpanel" aria-labelledby="EPL-tab"> <!--Premier League-->
                                  <a style="font-family: 'Athiti', sans-serif; font-size: 14px;">
                                      <asp:PlaceHolder ID="EPLPlaceHolder" runat="server"></asp:PlaceHolder>
                                  </a>
                                  <br /><br />


                              </div>

                              <div class="tab-pane fade" id="LFP" role="tabpanel" aria-labelledby="LFP-tab"> <!--LaLiga-->
                                  <a style="font-family: 'Athiti', sans-serif; font-size: 14px;">
                                      <asp:PlaceHolder ID="LFPPlaceHolder" runat="server"></asp:PlaceHolder>

                                  </a>
                                  <br /><br />



                              </div>

                              <div class="tab-pane fade" id="BL" role="tabpanel" aria-labelledby="BL-tab">   <!--BundesLiga-->
                                  <a style="font-family: 'Athiti', sans-serif; font-size: 14px;">
                                      <asp:PlaceHolder ID="BLPlaceHolder" runat="server"></asp:PlaceHolder>

                                  </a>

                                  <br /><br />



                              </div>

                              <div class="tab-pane fade" id="SA" role="tabpanel" aria-labelledby="SA-tab">   <!------Serie A------>
                                  <a style="font-family: 'Athiti', sans-serif; font-size: 14px;">
                                      <asp:PlaceHolder ID="SAPlaceHolder" runat="server"></asp:PlaceHolder>

                                  </a>

                                  <br /><br />




                              </div>

                              <div class="tab-pane fade" id="L1" role="tabpanel" aria-labelledby="L1-tab">    <!--Ligue 1-->
                                  <a style="font-family: 'Athiti', sans-serif; font-size: 14px;">
                                      <asp:PlaceHolder ID="L1PlaceHolder" runat="server"></asp:PlaceHolder>

                                  </a>

                                  <br /><br />

                              </div>
                            </div>  <!------------------------------------------------------------UPDATA TABLE------------------------------------------------------------>

                       <a style="font-family: 'Athiti', sans-serif; font-size: 30px; "><center><p style="font-size: 50px;">Update Table</p></center>
                      
                                <div class="row">
                                  <div class="col-sm"> 
                        
                                  </div>
                                  <div class="col-sm">
       
           
                                      ID ของสโมสร : <asp:TextBox ID="IDClub" runat="server" CssClass="form-control" placeholder="ID Club (number only)" type="number"></asp:TextBox>
                                      <br />
                                      จำนวนประตูที่ทำได้ :<asp:TextBox ID="GFTextBox" runat="server" CssClass="form-control" placeholder="Goals For (number only)" type="number" ></asp:TextBox> 
                                      
                                      <br />
                                      จำนวนประตูที่เสีย : <asp:TextBox ID="GATextBox" runat="server" CssClass="form-control" placeholder="Goals Againstr (number only)" type="number" ></asp:TextBox>
                                      
                                     
                                      <br />
                        
                                      <center></center>

                                      <br /><asp:Button ID="btUpdate" runat="server" Text="Update" class="btn btn-lg btn-primary btn-block" OnClick="btUpdate_Click"/>
                                      
                                  </div>
                                  <div class="col-sm">
                                  </div>
                                </div>
                        
                        


                        </a><br />

                        <a style="font-family: 'Athiti', sans-serif; font-size: 30px; "><center><p style="font-size: 50px;">Edit Table</p></center>
                              
                                <div class="row">
                                  <div class="col-sm">
                                      ID ของสโมสร : <asp:TextBox ID="tbIDClubEdit" runat="server" CssClass="form-control" placeholder="ID Club (number only)" type="number"></asp:TextBox>
                                      Won : <asp:TextBox ID="tbWonEdit" runat="server" CssClass="form-control" placeholder="Won (number only)" type="number" ></asp:TextBox> 
                                      GF : <asp:TextBox ID="tbGFEdit" runat="server" CssClass="form-control" placeholder="GF (number only)" type="number" ></asp:TextBox>
                                  </div>
                                  <div class="col-sm">
                        
                                      ClubName :<asp:TextBox ID="tbClubNameEdit" runat="server" CssClass="form-control" placeholder="ClubName" ></asp:TextBox>                               
                                      Drawn : <asp:TextBox ID="tbDrawnEdit" runat="server" CssClass="form-control" placeholder="Drawn (number only)" type="number" ></asp:TextBox>                 
                                      GA : <asp:TextBox ID="tbGAEdit" runat="server" CssClass="form-control" placeholder="GA (number only)" type="number" ></asp:TextBox>
                                      Points : <asp:TextBox ID="tbPointsEdit" runat="server" CssClass="form-control" placeholder="Points (number only)" type="number" ></asp:TextBox>


                                      <br /><asp:Button ID="btnEditEdit" runat="server" Text="Update" class="btn btn-lg btn-primary btn-block" OnClick="btnEditEdit_Click"/>
                                      
                                  </div>
                                  <div class="col-sm">
                                      Played : <asp:TextBox ID="tbPlayerEdit" runat="server" CssClass="form-control" placeholder="Played (number only)" type="number" ></asp:TextBox> 
                                      Lost : <asp:TextBox ID="tbLostEdit" runat="server" CssClass="form-control" placeholder="Drawn (number only)" type="number" ></asp:TextBox>
                                      GD : <asp:TextBox ID="tbGDEdit" runat="server" CssClass="form-control" placeholder="GD (number only)" type="number" ></asp:TextBox>
                                  </div>
                                </div>
                        
                        


                        </a>
                        
                        
                        <br /><br /><br />

                      </div>
                     <!---------------------------------------------------------------------------------------------#News--------------------------------------------------------------------------------------------------------------------------------------------> 
                     <div class="tab-pane fade" id="nav-News" role="tabpanel" aria-labelledby="nav-News-tab">
                         <br /><br /> 

                         

                         <div class="row">
                           <div class="col-sm"> 
                         
                           </div>
                           <div class="col-sm" style="font-family: 'Athiti', sans-serif; font-size: 28px;" > 
                                
                                  <div class="form-group">
                                      ID League:<asp:TextBox ID="IDLeagueTextBox" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                                  </div>
                                  <div class="form-group mx-sm-3">
                                    
                                  </div>
                                    <div class="row" style="font-family: 'Athiti', sans-serif; font-size: 14px;" >
                                      <div class="col-3">
                                           BundesLiga = 501
                                      </div>
                                      <div class="col-4">
                                        Serie A = 502
                                      </div>
                                      <div class="col-3">
                                         League 1 = 503
                                      </div>
                                      <div class="col-3">
                                        LaLiga = 504
                                      </div>
                                      <div class="col-4">
                                        Premier League = 505
                                      </div>
                                    </div><br />
            
                                 <!--------------------------------------------------------------------------------->
       
                                        
                               หัวข้อข่าว : <asp:TextBox ID="tbTitle" runat="server" CssClass="form-control"></asp:TextBox>
                               <br />
                               บทนำ :<asp:TextBox ID="tbLead" runat="server" CssClass="form-control"></asp:TextBox> 
                               
                               <br />
                               เนื้อหาข่าว :<a style="font-family: 'Athiti', sans-serif; font-size: 18px;"><asp:TextBox runat="server" ID="tbContent" TextMode="Multiline" Columns="80" Name="S1" Rows="20"></asp:TextBox></a>
                               
                               
                              
                               <br />

                               <asp:FileUpload ID="FileUpload1" runat="server" />
                               <br />
                               
                               


                               <br /><asp:Button ID="btnUpdateNews" runat="server" Text="UpdateNews" class="btn btn-lg btn-primary btn-block" OnClick="UpdateNews_Click1"/> <br />
                               
                               <br /><br />
                               
                           </div>
                             


                           <div class="col-sm">
                           </div>
                         </div>





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
