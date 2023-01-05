namespace SABC.Data.Entidades;

public class ClientePagoDto
{
    public string Cedula { get; set; } = null!;
    public string NombreCompleto { get; set; } = string.Empty;
    public DateTime Fecha { get; set; } = DateTime.Now;
    public double Monto { get; set; } = 0.00;
}
