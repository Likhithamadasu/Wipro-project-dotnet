import { Component } from "@angular/core";
import { NgForm } from "@angular/forms";
import { Employee } from "../models/employee";


@Component({
    selector:'create-emp',
    templateUrl:'./create-emp.component.html'
})
export class CreateEmployee
{
  emp:Employee={
     name:"",
     gender:"",
     password:"",
     emailid:"",
  };
    emailid:string="";
    password:string="";
    gender:string="";
    country:string="";
  getData(formdata:NgForm){
  //console.log(formdata);
  console.log(formdata.value);
  //console.log(formdata.controls['emailid'].value);
  //console.log(formdata.controls['password'].value);
  console.log(this.emp);
  console.log(this.emp.emailid);
  }
}