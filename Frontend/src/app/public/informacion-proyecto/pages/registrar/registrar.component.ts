import { Component } from '@angular/core';
import { InformacionProyectoService } from '../../Service/informacion-proyecto.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-registrar',
  templateUrl: './registrar.component.html',
  styleUrls: ['./registrar.component.css']
})
export class RegistrarComponent {

  nombre!: string;
  apellidos!: string;
  telefono!: number;
  email!: string;
  password!: string;
  rolDefecto: number = 1;

  constructor( private informacionService: InformacionProyectoService,private router: Router) {}

}
