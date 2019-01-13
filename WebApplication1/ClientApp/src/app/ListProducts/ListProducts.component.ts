import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'ListProducts',
  templateUrl: './ListProducts.component.html',
})
export class ListProducts {
  product: product[];
  constructor(http: HttpClient, @Inject('BASE_URL') url: string) {
    http.get<product[]>(url + 'api/product/getallproducts').subscribe(
      result => {
        //result.map((p, index) => { alert(`${p.id},${p.name},${p.price},${p.count},`) })
        this.product = result;
      },
      error => { alert(`Error: ${JSON.stringify(error)}`) }
    )
  }
}
class product {
  id: string;
  name: string;
  price: number;
  count: number;
  img: File;
  imgBase64: string;
}
