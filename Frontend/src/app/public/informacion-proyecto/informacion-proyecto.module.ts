import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './pages/home/home.component';
import { RouterModule } from '@angular/router';
import { PrimeNgModule } from '../../externo/prime-ng/prime-ng.module';
import { LoginComponent } from './pages/crearFactura/crea-factura.component';
import { RegistrarComponent } from './pages/registrar/registrar.component';
import { AngularMaterialModule } from 'src/app/externo/angular-material/angular-material.module';
import { SharedModule } from "../shared/shared.module";
import { InformacionRoutingModule } from './informacion-routing.module';


@NgModule({
    declarations: [
        HomeComponent,
        LoginComponent,
        RegistrarComponent
    ],
    imports: [
        RouterModule,
        CommonModule,
        PrimeNgModule,
        AngularMaterialModule,
        SharedModule,
        InformacionRoutingModule
    ]
})
export class InformacionProyectoModule { }
