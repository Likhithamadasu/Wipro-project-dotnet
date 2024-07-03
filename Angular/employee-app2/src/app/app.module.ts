import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmpComponent } from '../emp/emp.component';
import { EmpListComponent } from '../emp-list/emp-list.component';
import { FormsModule } from '@angular/forms';
import { EmployeeTitlePipe } from '../pipes/employee-title.pipe';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeService } from '../services/employee-service';
import { CreateEmployee } from '../Create-emp/create-emp.component';
import { HttpClient, HttpClientModule, HttpHandler, provideHttpClient } from '@angular/common/http';
// import { PageNotFoundComponent } from '../page-not-found/pagenot-found.component';

const appRoutes :Routes=[
  // each route maps to a  URL path to a component
    { path:'emp-list', component:EmpListComponent },
    { path:'emp-data/:empCode', component:EmpComponent },
    {path:'emp-create', component:CreateEmployee},
    { path:'', redirectTo:'/emp-list', pathMatch:'full' },
    // user is trying to access the URL and that is not present
    { path:'**', component:EmpListComponent }

];
@NgModule({
  declarations: [
    AppComponent, EmpComponent, EmpListComponent, EmployeeTitlePipe,CreateEmployee
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [EmployeeService, provideHttpClient() ],
  bootstrap: [AppComponent]
})
export class AppModule { }
