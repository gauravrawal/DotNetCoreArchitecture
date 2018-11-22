import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CoreModule } from "../../../core/core.module";
import { UploadComponent } from "./upload.component";

const routes: Routes = [
    { path: "", component: UploadComponent }
];

@NgModule({
    declarations: [UploadComponent],
    imports: [
        RouterModule.forChild(routes),
        CoreModule
    ]
})
export class UploadModule { }
