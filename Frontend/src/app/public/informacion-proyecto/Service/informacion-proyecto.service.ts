import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/app/environments/environment';
import { Observable, catchError, of, tap, throwError } from 'rxjs';
import { Product } from '../Interfaces/product.interfa';
import { Image } from '../Interfaces/image.interface';
import { CookieService } from 'ngx-cookie-service';
import { Cliente } from '../Interfaces/clientes.interface';

@Injectable({
  providedIn: 'root'
})
export class InformacionProyectoService {

  private baseUrl: string = environment.baseUrl;

  constructor(private http: HttpClient, private cookieService: CookieService) { }

  getClientes(): Observable<Cliente[]> {
    const token: string = this.cookieService.get('token');
    const headers = new HttpHeaders().set('Authorization', `Bearer ${token}`);
    return this.http.get<any>(`${this.baseUrl}/api/Cliente/obtenerClientes`, { headers });
  }

}
