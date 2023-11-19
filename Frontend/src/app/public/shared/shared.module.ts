import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { MenuHomeComponent } from './menu-home/menu-home.component';
import { AngularMaterialModule } from 'src/app/externo/angular-material/angular-material.module';
import { PrimeNgModule } from 'src/app/externo/prime-ng/prime-ng.module';
import { RouterModule } from '@angular/router';
import { FooterComponent } from './footer/footer.component';

@NgModule({
  declarations: [
    PageNotFoundComponent,
    MenuHomeComponent,
    FooterComponent
  ],
  imports: [
    CommonModule,
    AngularMaterialModule,
    PrimeNgModule,
    RouterModule
  ],
  exports: [
    MenuHomeComponent,
    PageNotFoundComponent,
    FooterComponent
  ]
})
export class SharedModule { }
