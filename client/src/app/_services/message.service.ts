import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { getPaginationHeaders, getPaginatedResult } from './paginationHelper';
import { Message } from '../_models/message';

@Injectable({
  providedIn: 'root'
})
export class MessageService {
  baseUrl = environment.baseUrl;
  
  constructor(private http: HttpClient) { }

  getMessages(pageNumber: number, pageSize: number, container: any) {
    let params = getPaginationHeaders(pageNumber, pageSize);
    params = params.append('Container', container);
    return getPaginatedResult<Message[]>(`${this.baseUrl}messages`, params, this.http);
  }

  getMessageThread(username: string) {
    const url = `${this.baseUrl}messages/thread/${username}`;
    console.log(url);
    return this.http.get<Message[]>(url);
  }

  sendMessage(username: string, content: string) {
    return this.http.post<Message>(`${this.baseUrl}messages`, {recipientUsername: username, content});
  }

  deleteMessage(id: number) {
    return this.http.delete(`${this.baseUrl}messages/${id}`)
  }
}
