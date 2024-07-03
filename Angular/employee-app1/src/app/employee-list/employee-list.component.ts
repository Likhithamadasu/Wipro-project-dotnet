import { Component } from '@angular/core';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent {
  
  employees = [
    { firstName: 'yashasree', country: 'UK', salary: 8000},
    { firstName: 'yashu', country: 'India', salary: 3000},
    { firstName: 'sree', country: 'UK', salary: 90000},
    { firstName: 'sri', country: 'Australia', salary: 2000 }
  ];
}
