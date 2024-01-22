import { Component } from '@angular/core';
import { GlobalServiceService } from '../../services/global-services/global-service.service';

@Component({
  selector: 'app-direct-page',
  templateUrl: './direct-page.component.html',
  styleUrl: './direct-page.component.scss'
})
export class DirectPageComponent {
  constructor(public g_services:GlobalServiceService){
  }
  
}
