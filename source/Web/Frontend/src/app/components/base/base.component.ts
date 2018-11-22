import { ElementRef, Input } from "@angular/core";
import { ControlValueAccessor } from "@angular/forms";

export abstract class BaseComponent implements ControlValueAccessor {
    @Input() required: any;
    @Input() value: any;

    isDisabled: boolean;

    onTouched: any;

    constructor(private readonly el: ElementRef) {
        this.required = this.el.nativeElement.attributes.required;
    }

    onChange(value: any) { this.writeValue(value); }

    registerOnChange(fn: any): void { this.onChange = fn; }

    registerOnTouched(fn: any): void { this.onTouched = fn; }

    setDisabledState(isDisabled: boolean): void { this.isDisabled = isDisabled; }

    writeValue(obj: any): void { this.value = obj; }
}
