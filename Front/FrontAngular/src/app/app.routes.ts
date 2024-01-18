import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NewsPageComponent } from './Page_Components/news-page/news-page.component';

export const routes: Routes = [
    {path:'path' , component:NewsPageComponent}];
// @NgModule({
//     imports:[RouterModule.forRoot(routes)],
//     exports:[RouterModule]
// });
// export class AppRoutingModule{}