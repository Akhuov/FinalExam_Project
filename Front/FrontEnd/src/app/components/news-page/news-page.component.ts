import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { GlobalServiceService } from '../../services/global-services/global-service.service';

@Component({
  selector: 'app-news-page',
  templateUrl: './news-page.component.html',
  styleUrl: './news-page.component.scss'
})

export class NewsPageComponent {
  constructor(private router : Router,public g_services : GlobalServiceService ){
  }
  
  // goto_news_page(){
  //   this.router.navigate(['/news-page'])
  // }
  
  // goto_direct_page(){
  //   this.router.navigate(['/direct-page'])
  // }

  // goto_arxiv_page(){
  //   this.router.navigate(['/arxiv-page'])
  // }

  // goto_about_us_page(){
  //   this.router.navigate(['/about-us-page'])
  // }

  // goto_home_page(){
  //   this.router.navigate(['/home-page'])
  // }
  // goto_register_page(){
  //   this.router.navigate(['/register-page'])
  // }

}
