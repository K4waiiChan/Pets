import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class PetsService {
  url: string;
  constructor(public http: HttpClient) {
    this.url = require('../../../assets/config.json').url + '/api/pets';
  }

  add(data: any) {
    console.log(this.url);
    return this.http.post(this.url, data);
  }

  getAll() {
    return this.http.get(this.url);
  }

  getOne(id) {
    return this.http.get(this.url + '/' + id);
  }

  edit(id, data: any) {
    return this.http.put(this.url + '/' + id, data);
  }

  delete(id) {
    return this.http.get(this.url + '/' + id);
  }
}
