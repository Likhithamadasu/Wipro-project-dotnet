import { Component } from  '@angular/core';

@Component({

    selector: 'app-employee-directory',
    templateUrl:'./employee-directory.component.html',
    styleUrls: ['./employee-directory.component.css']

})

export class EmployeeDirectoryComponent {

    employees = [
        {name: 'John Doe', color: 'Green', salary: 5000},
        {name: 'Jane Smith', color: 'Red', salary: 4000},
        {name: 'Peter Johnson', color: 'Green', salary: 6000},
        {name: 'Paul Adams', color: 'Red', salary: 7000},
    ]
}