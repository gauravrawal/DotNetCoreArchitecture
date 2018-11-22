import { Directive, OnInit } from "@angular/core";
import { ValidationDirective } from "./validation.directive";

@Directive({ selector: "[appIntegerValidation]" })
export class IntegerValidationDirective extends ValidationDirective implements OnInit {
    ngOnInit() {
        this.cleave = new this.Cleave(this.selector, {
            blocks: [20],
            numericOnly: true
        });
    }
}
