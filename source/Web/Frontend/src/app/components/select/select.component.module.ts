import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { SelectComponent } from "./select.component";

@NgModule({
    declarations: [
        SelectComponent
    ],
    exports: [
        SelectComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule
    ]
})
export class SelectComponentModule { }
