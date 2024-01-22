import { Component } from '@angular/core';
import { ApiService } from '../../services/http-services/api.service';
import { FormBuilder,FormGroup,Validators } from '@angular/forms';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrl: './login-page.component.scss',
})
export class LoginPageComponent {
  constructor(private api : ApiService,private fromBuilder : FormBuilder){}

  userForm !: FormGroup
  ngOnInit():void{
    this.userForm = this.fromBuilder.group({
      NickName:["",Validators.required],
      UserName:["",Validators.required],
      Password:["",Validators.required],
    })
  }

  post(){
    this.api.postUser(this.userForm.value)
    .subscribe({
      next:()=>{
        alert("Success")
        this.userForm.reset()
      },
      error:() =>{
        alert("Error")
      }
    })
  }



}
