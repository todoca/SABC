import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-pagos',
  templateUrl: './pagos.component.html'
})
export class PagosComponent {
  public clientes: Cliente[] = [];
  public pagosList: Pago[] = [];
  

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Cliente[]>(baseUrl + 'pagos').subscribe(result => {
      this.clientes = result;
    }, error => console.error(error));
  }
}
interface Cliente {
  id?: number;
  nombreCompleto: string;
  cedula: string;
  pin: string;
  pagos?: Pago[];
}
interface Pago {
  fecha: string,
  monto:number
}

