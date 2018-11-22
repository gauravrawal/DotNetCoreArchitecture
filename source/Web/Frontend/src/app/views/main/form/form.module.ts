import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CoreModule } from "../../../core/core.module";
import { FormComponent } from "./form.component";

const routes: Routes = [
    { path: "", component: FormComponent }
];

@NgModule({
    declarations: [FormComponent],
    imports: [
        RouterModule.forChild(routes),
        CoreModule
    ]
})
export class FormModule { }
