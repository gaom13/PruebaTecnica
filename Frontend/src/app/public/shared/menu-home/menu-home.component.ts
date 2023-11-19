import { Component } from '@angular/core';
import { environment } from 'src/app/environments/environment';

@Component({
  selector: 'app-menu-home',
  templateUrl: './menu-home.component.html',
  styleUrls: ['./menu-home.component.css']
})
export class MenuHomeComponent {
  crearFactura: String = environment.ruta.crearFactura;
  buscarFactura: String = environment.ruta.buscarFactura;
}
