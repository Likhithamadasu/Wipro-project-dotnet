import { Component } from "@angular/core";
import { EmployeeService } from "../services/employee-service";
import { dateTimestampProvider } from "rxjs/internal/scheduler/dateTimestampProvider";

@Component({
    selector:'emp-list',    
    templateUrl:'./emp-list.component.html',
    // to tell the angular Injector you have to create the instance for this service
    //providers:[EmployeeService]
})

export class EmpListComponent
{
    employees:any[]=[];
    constructor(private _empService:EmployeeService)
    {
   
    }
    ngOnInit()
    {
        // To subscribe the data from observable we use subscribe method
         this._empService.getEmployees().subscribe(data=>{
            this.employees=data;
         });
    }
    
   name:string="JOhn";
}