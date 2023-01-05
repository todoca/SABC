using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SABC.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientePagos",
                columns: table => new
                {
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PIN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cedula", "NombreCompleto", "PIN" },
                values: new object[] { 1, "8-75-584", "Juan Perez", "1478" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cedula", "NombreCompleto", "PIN" },
                values: new object[] { 2, "PE-254-845", "Miguel Batista", "1244" });

            migrationBuilder.InsertData(
                table: "Pagos",
                columns: new[] { "Id", "Cedula", "ClienteId", "Fecha", "Monto" },
                values: new object[,]
                {
                    { 1, "8-75-584", 1, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { 2, "8-75-584", 1, new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 198.22 },
                    { 3, "8-75-584", 1, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 210.0 },
                    { 4, "PE-254-845", 2, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { 5, "PE-254-845", 2, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 198.22 },
                    { 6, "PE-254-845", 2, new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 210.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ClienteId",
                table: "Pagos",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientePagos");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
