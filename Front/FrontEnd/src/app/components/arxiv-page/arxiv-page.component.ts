import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { GlobalServiceService } from '../../services/global-services/global-service.service';

@Component({
  selector: 'app-arxiv-page',
  templateUrl: './arxiv-page.component.html',
  styleUrl: './arxiv-page.component.scss'
})
export class ArxivPageComponent {
  constructor(private router : Router, public g_services:GlobalServiceService){
  }
  
}
