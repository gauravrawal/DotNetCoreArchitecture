import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CoreModule } from "../../../core/core.module";
import { HomeComponent } from "./home.component";

const routes: Routes = [
    { path: "", component: HomeComponent }
];

@NgModule({
    declarations: [HomeComponent],
    imports: [
        RouterModule.forChild(routes),
        CoreModule
    ]
})
export class HomeModule { }
