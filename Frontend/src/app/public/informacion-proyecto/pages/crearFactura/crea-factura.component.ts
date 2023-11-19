import { Component, OnInit } from '@angular/core';
import { InformacionProyectoService } from '../../Service/informacion-proyecto.service';
import { MessageService } from 'primeng/api';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { City } from '../../Interfaces/city.interface';
import { Cliente } from '../../Interfaces/clientes.interface';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './crea-factura.html',
  styleUrls: ['./crea-factura.css']
})
export class LoginComponent implements OnInit{

  displayMessage = false;
  numbeFactura!: number;

  clientes!: Cliente[] ;

  seleccionadoCliente!: Cliente ;
  positionOptions!: String[];
  position!: FormControl;

  data = [
    { name: 'Ejemplo 1', age: 30, email: 'ejemplo1@example.com' },
    { name: 'Ejemplo 2', age: 25, email: 'ejemplo2@example.com' },
    // ... más datos
  ];

  selectedOption: string | undefined = undefined;

  selectOptions = [
    { label: 'Volvo', value: 'volvo' },
    { label: 'Saab', value: 'saab' },
    { label: 'Mercedes', value: 'mercedes' },
    { label: 'Audi', value: 'audi' }
  ]; // Columna seleccionada por el usuario

  // Columnas a mostrar en la tabla
  displayedColumns: string[] = ['selects', 'name', 'age', 'email'];

  constructor( private informacionService: InformacionProyectoService,private messageService: MessageService,
              private _snackBar: MatSnackBar, private router: Router ){}

  ngOnInit(): void {
    this.informacionService.getClientes()
      .subscribe( resp => {
        console.log(resp);
        this.clientes = resp;
      });
  }

  MostrarAlerta(inf: string){
    this._snackBar.open(inf, 'Cerrar', {
      duration: 2000
    });
  }

}
