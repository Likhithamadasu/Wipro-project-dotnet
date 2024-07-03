import { Component } from '@angular/core'


@Component({
  selector:'app-root',
  // nif we have single line we can use "", but if more than one and in next line use ` special character
  // TemplateURL if line exceeds by 3 lines ( Move HTML into a separate HTML file)
  // template:`<h1> {{title}} - {{ 100 - 20 }} - {{ getFullName() }}</h1> 
  //           <p>This is my Paragraph</p>
  //           <h2> THis is heading 2</h2>` // interpolation
  templateUrl:'./app.component.html'

})
export class AppComponent {
  // Property in typescript
  // name_of_property : type = Value
    title : string=" My First App";
     firstName:string = "JOhn";
     lastName : string ="Hegman";
     isDiabled:boolean=true;

     imageUrl:string ="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABwAAAAcCAMAAABF0y+mAAAAvVBMVEVHcEz8/f3////////+/v7s7u/6+vr5+vr5+vr9/f3////////5+vr////////Kzs/////////9/v74+fn4+fn////8vwbsTkJFiPPrQjI7q1gpp00yqVPrSTlAhfX9/f2hv/nwgHj2tLGt2bkqe/Q2gPV+qPd7woza5f2WuPns8v5ZtnHD48n92Yj80Wn+6sD4yMXtZ13znpn8xSnwuh3v6+WIwbFwoPb0qKPpKxT1mx7AtydjuXgcpjNCk8nTYqeQAAAAFXRSTlMA5d2fnApdnVLJpWJiowsJZNGXl5g9ng+vAAABP0lEQVQokY2S2XqCMBCFQVGWulRbkIRABASK0FZtq3Z9/8fqZCDK0oueCzJf/sxhJhlF+Z/G1kJVF9a4T2ZD+6LhrM1u7ZZumsyyO5pe2RQ3+O4Qhoddbd32jHzigwiJms4jTAvJqtb7GekIoSbC0F+tCNnvCSFhZawhRE/I84UfP4eyKMEMEXxA3lunYqN2fXZe/ajbjvA1YX10HIeLjXyNyrcQmwAHsD45zgue3gSozQPEgx50UYmELdtTmqYngNJ2WRVEY1nIOnATsS5lK5+MenUr28ANUtmKIvxij1KGuaUbuFgPxxvSxd4Xo9TzisLz2E+SS1e4eCylgFzK4Aj7PuJLVBevTPBfMSQxBp+qsol8UK167DLLsmNZlaVfR0Hv3muDwVjyJuKd8ZzrF8z1eX90jXtTVc07o0/+1C9hwDM1yvfWEgAAAABJRU5ErkJggg==";
     
     isBold:boolean=true;     
     isItalic:boolean=true;

     addStyle()
     {
       let styles= {
         'font-weight': this.isBold ?'bold':'normal',
         'font-style': this.isItalic? 'italic':'normal'
       }
       return styles;
     }
     
     onClick():void{
      console.log('Button CLicked');
     }


     // Method_Name (parameterList): returnType { }

     getFullName(): string {
      return this.firstName+ " "+this.lastName;
  }
}
// Data Bindings
//One way -> from component to HTML ( interpolation or property Binding or attribute or style binding) 
// One way -> from view template to Component ( event Binding)
 // When perform an action of click on button
// Two Way Data binding-> from component to template and from template to component

// DOM HTML( Attributes) <input id="" value="" type="">
// Properties are defined by DOM