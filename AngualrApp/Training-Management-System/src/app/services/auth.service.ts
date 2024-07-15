import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = 'http://your-api-url/api/auth';
  private role: string = '';

  constructor(private http: HttpClient) {}

  login(username: string, password: string): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/login`, { username, password }).pipe(
      map(response => {
        localStorage.setItem('token', response.token);
        this.role = response.role;
        return response;
      })
    );
  }

  getRole(): string {
    return this.role;
  }

  isAuthenticated(): boolean {
    return !!localStorage.getItem('token');
  }
}
