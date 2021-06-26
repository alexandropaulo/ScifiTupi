import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Article } from '../_models/Article';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ContentService {
  baseUrl = environment.apiUrl;
  constructor(private http: HttpClient) { }

 
  getContent(page) : Observable<Article[]> {
    return this.http.get<Article[]>(this.baseUrl + 'content/' + page);
  }
}
