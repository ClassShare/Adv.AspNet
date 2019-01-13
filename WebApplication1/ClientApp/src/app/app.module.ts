import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { InsertProductComponent } from './InsertProduct/InsertProduct.component';
import { ListProducts } from './ListProducts/ListProducts.component';
import { productDetail } from './productDetail/productDetail.component';

import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    InsertProductComponent,
    ListProducts,
    productDetail
    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'home', component: HomeComponent },
      { path: 'newproduct', component: InsertProductComponent },
      { path: 'listproducts', component: ListProducts },
      { path: 'productdetail/:id', component: productDetail }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
