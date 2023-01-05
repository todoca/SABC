using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SABC.Data.Entidades;

public class Pago
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Cedula { get; set; } = string.Empty;
    public double Monto { get; set; }
    public DateTime Fecha { get; set; }
    [ForeignKey(nameof(Cliente))]
    public int ClienteId { get; set; }
}
