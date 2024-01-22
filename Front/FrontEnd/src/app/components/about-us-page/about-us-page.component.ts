import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { GlobalServiceService } from '../../services/global-services/global-service.service';

@Component({
  selector: 'app-about-us-page',
  templateUrl: './about-us-page.component.html',
  styleUrl: './about-us-page.component.scss'
})
export class AboutUsPageComponent {
  constructor(private router : Router, public g_services:GlobalServiceService){
  }
}
