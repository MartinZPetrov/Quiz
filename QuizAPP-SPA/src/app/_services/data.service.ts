import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {map} from 'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  baseUrl = 'http://localhost:5000/api/data/';
  constructor(private http: HttpClient) {}

  getSetting() {
    return this.http.get(this.baseUrl + 'settings');
  }
  getQuestions() {
    return this.http.get(this.baseUrl + 'questions');
  }
  getMultipleQuestions() {
    return this.http.get(this.baseUrl + 'multiplequestions');
  }
}
