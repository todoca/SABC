namespace SABC.Data.Entidades;

public class Pago
{
    public int Id { get; set; }
    public string Cedula { get; set; } = string.Empty;
    public decimal Monto { get; set; }
    public DateTime Fecha { get; set; }
    public int ClienteId { get; set; }
}
