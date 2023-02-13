import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'product-add',
  templateUrl: './product-add.component.html'
})
export class ProductAddComponent {
  public product?: Product;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    //const headers = { 'content-type': 'application/json' }  
    //const body = JSON.stringify(product);
    //console.log(body)
    //http.post(baseUrl + 'product', body, { 'headers': headers })

  }
}

interface Product {
  productName: string;
  productInfo: string;
}
