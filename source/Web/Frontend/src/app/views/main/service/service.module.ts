import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CoreModule } from "../../../core/core.module";
import { ServiceComponent } from "./service.component";

const routes: Routes = [
    { path: "", component: ServiceComponent }
];

@NgModule({
    declarations: [ServiceComponent],
    imports: [
        RouterModule.forChild(routes),
        CoreModule
    ]
})
export class ServiceModule { }
