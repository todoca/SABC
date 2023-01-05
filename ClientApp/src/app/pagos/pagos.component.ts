import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-pagos',
  templateUrl: './pagos.component.html'
})
export class PagosComponent {
  public clientes: Cliente[] = [];
  public cedulaBuscar = '';
  public ultimaCedula = '';
  public mensaje = '';
  

  constructor(private http: HttpClient, @Inject('BASE_URL')  private baseUrl: string) {
    http.get<Cliente[]>(baseUrl + 'pagos').subscribe(result => {
      this.clientes = result;
    }, error => console.error(error));
  }

  public buscarcliente() {
    this.ultimaCedula = this.cedulaBuscar;
    this.http.get<Cliente[]>(this.baseUrl + 'pagos/'+this.cedulaBuscar).subscribe(result => {
      this.clientes = result;
      this.cedulaBuscar = '';
      if (this.clientes.length == 0) this.mensaje = 'Cliente no encontrado... por favor vuelve a intentar.';
      else this.mensaje = '';
    }, error => console.error(error));
  }
}
interface Cliente {
  nombreCompleto: string;
  cedula: string;
  fecha: string;
  monto: number;
}


