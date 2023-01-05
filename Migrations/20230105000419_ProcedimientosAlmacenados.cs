using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SABC.Migrations
{
    public partial class ProcedimientosAlmacenados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE PROCEDURE dbo.ConsultaPagosCliente
                @cedula nvarchar(max)
                
                AS
                BEGIN
                SELECT C.NOMBRECOMPLETO, C.CEDULA, P.FECHA, P.MONTO FROM CLIENTES AS C INNER JOIN PAGOS P ON C.CEDULA=P.CEDULA 
                WHERE C.CEDULA=@cedula or @cedula is null or @cedula=''
                ORDER BY P.FECHA DESC
                END
                ");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE dbo.ConsultaPagosCliente");
        }
    }
}
