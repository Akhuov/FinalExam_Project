import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-about-us-page',
  templateUrl: './about-us-page.component.html',
  styleUrl: './about-us-page.component.scss'
})
export class AboutUsPageComponent {
  constructor(private router : Router){
  }
  
  goto_news_page(){
    this.router.navigate(['/news-page'])
  }
  
  goto_direct_page(){
    this.router.navigate(['/direct-page'])
  }

  goto_arxiv_page(){
    this.router.navigate(['/arxiv-page'])
  }

  goto_about_us_page(){
    this.router.navigate(['/about-us-page'])
  }

  goto_home_page(){
    this.router.navigate(['/home-page'])
  }
  goto_register_page(){
    this.router.navigate(['/register-page'])
  }
  goto_login_page(){
    this.router.navigate(['/login-page'])
  }
}
