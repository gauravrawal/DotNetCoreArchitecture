import { Component, Input } from "@angular/core";
import { NG_VALUE_ACCESSOR } from "@angular/forms";
import { BaseComponent } from "../base/base.component";
import { OptionModel } from "./option.model";

@Component({
    providers: [{ provide: NG_VALUE_ACCESSOR, useExisting: SelectComponent, multi: true }],
    selector: "app-select",
    templateUrl: "./select.component.html"
})
export class SelectComponent extends BaseComponent {
    @Input() options: OptionModel[];
}
