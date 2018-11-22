import { Directive, HostListener, OnInit } from "@angular/core";
import { ValidationDirective } from "./validation.directive";

@Directive({ selector: "[appCurrencyValidation]" })
export class CurrencyValidationDirective extends ValidationDirective implements OnInit {
    ngOnInit() {
        this.cleave = new this.Cleave(this.selector, {
            delimiter: ".",
            numeral: true,
            numeralDecimalMark: ",",
            numeralDecimalScale: 2,
            numeralIntegerScale: 20,
            prefix: "R$ "
        });
    }

    @HostListener("blur") onBlur() { this.setRawValue(); }
}
