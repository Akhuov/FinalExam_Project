import { Component } from '@angular/core';
import { GlobalServiceService } from '../../services/global-services/global-service.service';
import { ApiService } from '../../services/http-services/api.service';


export interface ArtFullData {
  ArtName : string
  ArtCity : string
  ArtInform :string
  ImageUrl : string
  AutorNick: string
}


@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.scss'
})


export class HomePageComponent {
  constructor(
    public g_services : GlobalServiceService,
    public api : ApiService) { }
    
     
  }
