import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  constructor(private http : HttpClient) { }

  postUser(data: any)
  {
    return this.http.post<any>("http://localhost:5001/api/Users/", data)
  }

  getAllUsers(){
    return this.http.get<any>("http://localhost:5001/api/Users/GetAllAutors")
  }

  putUser(data: any, id: number){
    return this.http.put<any>("http://localhost:5001/api/Users/" + id, data)
  }

  deleteUser(id: number){
    return this.http.delete<any>("http://localhost:5001/api/Users/" + id)
  }
}
