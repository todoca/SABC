import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-pagos',
  templateUrl: './pagos.component.html'
})
export class PagosComponent {
  public pagos: Pago[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Pago[]>(baseUrl + 'pagos').subscribe(result => {
      this.pagos = result;
    }, error => console.error(error));
  }
}

interface Pago {
  nombre: string;
  cedula: string;
  fecha: string;
  monto: number;
}
