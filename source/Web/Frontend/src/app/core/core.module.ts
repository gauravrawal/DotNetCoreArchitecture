import { CommonModule } from "@angular/common";
import { HttpClientModule } from "@angular/common/http";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { GuardsModule } from "./guards/guards.module";
import { HandlersModule } from "./handlers/handlers.module";
import { InterceptorsModule } from "./interceptors/interceptors.module";

@NgModule({
    exports: [
        CommonModule,
        FormsModule,
        HttpClientModule,
        ReactiveFormsModule,
        GuardsModule,
        HandlersModule,
        InterceptorsModule
    ],
    imports: [
        CommonModule,
        FormsModule,
        HttpClientModule,
        ReactiveFormsModule,
        GuardsModule,
        HandlersModule,
        InterceptorsModule
    ]
})
export class CoreModule { }
