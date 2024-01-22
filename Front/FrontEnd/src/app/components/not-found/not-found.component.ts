import { Component } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-not-found',
  templateUrl: './not-found.component.html',
  styleUrl: './not-found.component.scss'
})
export class NotFoundComponent{
  constructor(private router : Router ){
  }
  goto_home_page(){
    this.router.navigate(['/home-page'])
  }
}
