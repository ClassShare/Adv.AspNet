import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'InsertProduct',
  templateUrl: './InsertProduct.component.html',
})
export class InsertProductComponent {
  InsertProductFormvalidators: FormGroup;
  private formbuilder: FormBuilder = new FormBuilder();
  product: Product;
  //constructor(fb: FormBuilder) {
  constructor() {

    this.InsertProductFormvalidators =
      this.formbuilder.group({
        name: ['', [Validators.maxLength(30), Validators.required, Validators.minLength(2)]],
        price: ['', [Validators.required, Validators.pattern(/^\d{1,10}$/)]],
        count: ['', [Validators.required, Validators.pattern(/^\d{1,4}$/)]],
      });
  }
}

class Product {
  name: string;
  price: number;
  count: number;
}
