import { Component } from "@angular/core";
import { ActivatedRoute,Router } from '@angular/router'
import { EmployeeService } from "../services/employee-service";

@Component({
    selector:'emp',   
    templateUrl:'./emp.component.html',
    styleUrl:'./emp.component.css'
})

export class EmpComponent
{
   name:string="";
   gender:string="";
   colspanNumber : number=2;
   showDetail:boolean=true;
   // to crate a constructor use constructor keyword directly
   constructor(private _activateRoute :ActivatedRoute,
    private _empService:EmployeeService,
    private _router:Router
   )
   {
    
   }

   ngOnInit()
   {
    let code:string= this._activateRoute.snapshot.params['empCode'];
     let empData= this._empService.getEmployeeByCode(code);
     this.name= empData[0].name;
     this.gender= empData[0].gender;
   }

   GoBack()
   {
     this._router.navigate(['/emp-list']);
   }
   onClick():void {
    this.showDetail= !this.showDetail;
    console.log(this.showDetail);
   }
}

// Angular Life hook events
// ngOnChanges-> inout property change.
//ngOnInit -> after the constructor of the component. Only one time ( API calls)
// ngDoCheck 
     // ngAfterContentInit
     // ngAfterContentChecked
     // ngAfterViewInit
     // ngAfterViewChecked
// ngOnDestroy