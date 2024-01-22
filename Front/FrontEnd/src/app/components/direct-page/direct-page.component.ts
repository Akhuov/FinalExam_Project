import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { GlobalServiceService } from '../../services/global-services/global-service.service';

@Component({
  selector: 'app-direct-page',
  templateUrl: './direct-page.component.html',
  styleUrl: './direct-page.component.scss'
})
export class DirectPageComponent {
  constructor(private router : Router, public g_services:GlobalServiceService){
  }
  
}
