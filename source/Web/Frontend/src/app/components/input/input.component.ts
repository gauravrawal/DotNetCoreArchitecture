import { Component, Input } from "@angular/core";
import { NG_VALUE_ACCESSOR } from "@angular/forms";
import { BaseComponent } from "../base/base.component";

@Component({
    providers: [{ provide: NG_VALUE_ACCESSOR, useExisting: InputComponent, multi: true }],
    selector: "app-input",
    templateUrl: "./input.component.html"
})
export class InputComponent extends BaseComponent {
    @Input() type: string;
}
