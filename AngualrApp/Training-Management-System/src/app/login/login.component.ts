// src/app/login/login.component.ts
import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  username: string = '';
  password: string = '';

  constructor(private router: Router) {}

  onLogin() {
    // Mock authentication logic for demonstration
    if (this.username === 'admin' && this.password === 'admin') {
      localStorage.setItem('role', 'admin');
      this.router.navigate(['/admin']);
    } else if (this.username === 'manager' && this.password === 'manager') {
      localStorage.setItem('role', 'manager');
      this.router.navigate(['/manager']);
    } else if (this.username === 'employee' && this.password === 'employee') {
      localStorage.setItem('role', 'employee');
      this.router.navigate(['/employee']);
    } else {
      alert('Invalid credentials');
    }
  }
}
