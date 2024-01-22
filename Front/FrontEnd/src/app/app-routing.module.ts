import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePageComponent } from './components/home-page/home-page.component';
import { ArxivPageComponent } from './components/arxiv-page/arxiv-page.component';
import { DirectPageComponent } from './components/direct-page/direct-page.component';
import { AboutUsPageComponent } from './components/about-us-page/about-us-page.component';
import { NewsPageComponent } from './components/news-page/news-page.component';
import { RegisterPageComponent} from './components/register-page/register-page.component';
import { LoginPageComponent } from './components/login-page/login-page.component';
import { NotFoundComponent } from './components/not-found/not-found.component';

const routes: Routes = [
  {path: '', component: HomePageComponent },
  {path: "home-page",component : HomePageComponent},
  {path: "arxiv-page",component : ArxivPageComponent},
  {path: "direct-page",component : DirectPageComponent},
  {path: "about-us-page",component : AboutUsPageComponent},
  {path: "news-page",component : NewsPageComponent},
  {path: "register-page",component:RegisterPageComponent},
  {path: "login-page",component : LoginPageComponent},
  {path: '**',component : NotFoundComponent},
];




@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }


