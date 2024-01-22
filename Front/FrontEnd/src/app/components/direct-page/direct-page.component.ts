import { Component } from '@angular/core';
import { GlobalServiceService } from '../../services/global-services/global-service.service';
import { ApiService } from '../../services/http-services/api.service';

export interface ArtFullData{
  ArtName :string
  ArtCity :string
  ArtInform :string
  ImageUrl :string
  AutorNickName :string
}


@Component({
  selector: 'app-direct-page',
  templateUrl: './direct-page.component.html',
  styleUrl: './direct-page.component.scss'
})
export class DirectPageComponent {
  arts: ArtFullData[]=[];
  
  conditionUser: string[] = ["New", "Second Hand", "B/Y"]



  
  constructor(public g_services:GlobalServiceService
    ,private api: ApiService){
  }
  
  ngOnInit(){

    // this.arts = this.api.getAllArtsWithFullInform();
    this.getAllProductsMethod();
  }


  getAllProductsMethod(){
    this.api.getAllArtsWithFullInform().subscribe(
      {
        next: (response) => {
          this.arts = response;
          console.log(this.arts);
          alert("Malumotlar olib kelindi")
        },
        error: (err) => {
          alert("nimadur hato ketti")
        }
      }
    );
  }
}
