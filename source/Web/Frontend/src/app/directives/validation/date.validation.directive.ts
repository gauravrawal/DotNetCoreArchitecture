import { Directive, OnInit } from "@angular/core";
import { ValidationDirective } from "./validation.directive";

@Directive({ selector: "[appDateValidation]" })
export class DateValidationDirective extends ValidationDirective implements OnInit {
    ngOnInit() {
        this.cleave = new this.Cleave(this.selector, {
            date: true,
            datePattern: ["d", "m", "Y"]
        });
    }
}
