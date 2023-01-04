using Microsoft.AspNetCore.Mvc;
using SABC.Data.Entidades;

namespace SABC.Controllers;

[Route("[controller]")]
[ApiController]
public class PagosController : ControllerBase
{
    [HttpGet]
    public List<Cliente> GetClientes()
    {
        List<Cliente> clientes = new()
        {
            new Cliente()
                {
                    NombreCompleto = "Juan Perez",
                    Cedula="8-75-584",
                    PIN="1478",
                    Pagos= new()
                    {
                        new Pago(){Fecha=new DateTime(21,04,04), Monto=200.00m},
                        new Pago(){Fecha=new DateTime(21,05,01), Monto=201.00m},
                        new Pago(){Fecha=new DateTime(21,05,01), Monto=202.00m},

                    }
                },
                new Cliente()
                {
                    NombreCompleto = "Miguel Batista",
                    Cedula="PE-254-845",
                    PIN="1244",
                    Pagos= new()
                    {
                        new Pago(){Fecha=new DateTime(21,04,04), Monto=203.00m},
                        new Pago(){Fecha=new DateTime(21,05,01), Monto=204.00m},
                        new Pago(){Fecha=new DateTime(21,05,01), Monto=205.00m},
                    }
                }

        };
        return clientes;
    }
}
