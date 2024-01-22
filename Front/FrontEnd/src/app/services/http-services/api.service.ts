import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  httpOptions={
    headers: new HttpHeaders({'ContentType':'application/json'})
  }
  constructor(private http : HttpClient) { }

  postArt(data: any)
  {
    return this.http.post<any>("http://localhost:5001/api/Arts/CreateArt", data)
  }

  getAllArts(){
    return this.http.get<any>("http://localhost:5001/api/Arts/GetAllArts")
  }
  
  getByIdArt(id : number){
    return this.http.get<any>("http://localhost:5001/api/Arts/GetByIdArt?"+id)
  }

  getAllArtsWithFullInform(){
    return this.http.get<any>("http://localhost:5001/api/Arts/GetAllArtsWithFullInformation")
  }
  

  putArt(data: any, id: number){
    return this.http.put<any>("http://localhost:5001/api/Arts/UpdateArt" + id, data)
  }

  deleteArt(id: number){
    return this.http.delete<any>("http://localhost:5001/api/Arts/DeleteArt" + id)
  }




  postUser(data: any)
  {
    return this.http.post<any>("http://localhost:5001/api/Users/CreateAutor", data , this.httpOptions)
  }

  getAllUsers(){
    return this.http.get<any>("http://localhost:5001/api/Users/GetAllAutors")
  }
  
  getByIdUser(id : number){
    return this.http.get<any>("http://localhost:5001/api/Users/GetByIdAutor?"+id)
  }


  

  putUser(data: any, id: number){
    return this.http.put<any>("http://localhost:5001/api/Users/UpdateAutor" + id, data)
  }

  deleteUser(id: number){
    return this.http.delete<any>("http://localhost:5001/api/Users/DeleteAutor" + id)
  }
}
