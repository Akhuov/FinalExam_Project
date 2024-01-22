import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { GlobalServiceService } from '../../services/global-services/global-service.service';
@Component({
  selector: 'app-not-found',
  templateUrl: './not-found.component.html',
  styleUrl: './not-found.component.scss'
})
export class NotFoundComponent{
  constructor(private router : Router,public services:GlobalServiceService ){
  }
  
}
