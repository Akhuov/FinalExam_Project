import { Injectable } from '@angular/core';
import { Router } from '@angular/router';


@Injectable({
  providedIn: 'root'
})
export class GlobalServiceService {
  constructor(private router : Router ){
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
  goto_login_page(){
    this.router.navigate(['/login-page'])
  }

}
