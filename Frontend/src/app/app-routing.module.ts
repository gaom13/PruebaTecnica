import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { PageNotFoundComponent } from './public/shared/page-not-found/page-not-found.component';
import { HomeComponent } from './public/informacion-proyecto/pages/home/home.component';
import { LoginComponent } from './public/informacion-proyecto/pages/crearFactura/crea-factura.component';
import { RegistrarComponent } from './public/informacion-proyecto/pages/registrar/registrar.component';
const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    redirectTo: '/informacion'
  },
  {
    path: 'informacion',
    loadChildren: () => import ('./public/informacion-proyecto/informacion-proyecto.module').then( m => m.InformacionProyectoModule )
  },
  {
    path: '404',
    component: PageNotFoundComponent
  },
  {
    path: '**',
    redirectTo: '404'
  }
]

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot( routes )
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
