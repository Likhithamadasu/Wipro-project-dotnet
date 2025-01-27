import { HttpClient } from '@angular/common/http';
import{ Injectable } from '@angular/core'
import { Observable, map} from 'rxjs'
import { EmployeeList } from '../models/employeeList';

@Injectable()
export class EmployeeService
{
  constructor(private _http:HttpClient)
  {

  }
     employees:any[] =[];
    getEmployees():Observable<EmployeeList[]>{ 
   // API call here
      return this._http.get<EmployeeList[]>("http://localhost:3000/employees");
      //  this.employees = [{
        //     code:'1', name:'Likhitha', gender:'female',salary:4000, dob :'14/10/2000'
        //   },
        //   {
        //       code:'2', name:'Jayanth', gender:'male',salary:6000, dob :'10/06/2001'
        //     },
        //     {
        //       code:'3', name:'Haswin', gender:'male',salary:5000, dob :'12/05/2001'
        //     },
        //     {
        //       code:'4', name:'Bindu', gender:'Female',salary:2000, dob :'05/07/2000'
        //     }];
        //     return this.employees;
    }
    getEmployeeByCode(empId:string):any{
        this.getEmployees();        
          return this.employees.filter(x=>x.code==empId);
    } 
}