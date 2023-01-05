namespace SABC.Data.Entidades;

public class Cliente
{
    public int Id { get; set; }
    public string NombreCompleto { get; set; } = string.Empty;
    public string? Cedula { get; set; } = string.Empty;
    public string? PIN { get; set; } = string.Empty;
    public List<Pago> Pagos { get; set; } = null!;
}
