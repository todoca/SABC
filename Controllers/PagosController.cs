using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SABC.Data.Contexts;
using SABC.Data.Entidades;

namespace SABC.Controllers;

[Route("[controller]")]
[ApiController]
public class PagosController : ControllerBase
{
    private readonly AppDbContext _db;

    public PagosController(AppDbContext db) => _db = db;

    [HttpGet]
    [HttpGet("{cedula}")]
    public async Task<ActionResult<List<ClientePagoDto>>> GetClientes(string? cedula)
    {
        string cedulaBuscar = cedula ?? "";
        var clientesSQL = await _db.ClientePagos.FromSqlRaw($"ConsultaPagosCliente @cedula",
            new SqlParameter("@cedula", cedulaBuscar)).ToListAsync();
        return clientesSQL == null ? NotFound() : clientesSQL;
    }
}
