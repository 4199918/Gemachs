import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/';
import { map } from 'rxjs/operators'; 

@Injectable({
  providedIn: 'root'
})
export class GemachesService {

  private mailApi = 'https://mailthis.to/codeninja'

  constructor(private http: HttpClient) { }

  postMessage(input: any) {
    return this.http.post(this.mailApi, input, { responseType: 'text' }).pipe(
      map(
        (response) => {
          if (response) {
            return response;
          }
        },
        (error: any) => {
          return error;
        }
      )
    )
  }

  getGemaches(): Observable<Object>{
    console.log("Now on getGemaches() (api)")
    return this.http.get('https://localhost:5001/api/gemaches')

  }

  getGemach( gemachid:string ): Observable<Object>{
    let gemach= this.http.get(`https://localhost:5001/api/gemaches/gemachid/+${gemachid}`)
    console.log(`Now on getGemach() (api) gemachid = ${gemachid} gemachName = ${gemach["gemachName"]}`)
    return gemach
  }

}
