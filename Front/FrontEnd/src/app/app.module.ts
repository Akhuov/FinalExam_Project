import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './components/home-page/home-page.component';
import { NewsPageComponent } from './components/news-page/news-page.component';
import { AboutUsPageComponent } from './components/about-us-page/about-us-page.component';
import { DirectPageComponent } from './components/direct-page/direct-page.component';
import { ArxivPageComponent } from './components/arxiv-page/arxiv-page.component';
import { RegisterPageComponent } from './components/register-page/register-page.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { LoginPageComponent } from './components/login-page/login-page.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatButtonModule} from '@angular/material/button';
import {MatDialogModule} from '@angular/material/dialog';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    NewsPageComponent,
    AboutUsPageComponent,
    DirectPageComponent,
    ArxivPageComponent,
    RegisterPageComponent,
    NotFoundComponent,
    LoginPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatDialogModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
