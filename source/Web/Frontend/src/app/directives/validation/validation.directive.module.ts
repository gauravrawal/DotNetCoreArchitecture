import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { CurrencyValidationDirective } from "./currency.validation.directive";
import { DateValidationDirective } from "./date.validation.directive";
import { DecimalValidationDirective } from "./decimal.validation.directive";
import { IntegerValidationDirective } from "./integer.validation.directive";

@NgModule({
    declarations: [
        CurrencyValidationDirective,
        DateValidationDirective,
        DecimalValidationDirective,
        IntegerValidationDirective
    ],
    exports: [
        CurrencyValidationDirective,
        DateValidationDirective,
        DecimalValidationDirective,
        IntegerValidationDirective
    ],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule
    ]
})
export class ValidationDirectiveModule { }
