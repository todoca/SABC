﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SABC.Data.Contexts;

#nullable disable

namespace SABC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230105000419_ProcedimientosAlmacenados")]
    partial class ProcedimientosAlmacenados
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SABC.Data.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PIN")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cedula = "8-75-584",
                            NombreCompleto = "Juan Perez",
                            PIN = "1478"
                        },
                        new
                        {
                            Id = 2,
                            Cedula = "PE-254-845",
                            NombreCompleto = "Miguel Batista",
                            PIN = "1244"
                        });
                });

            modelBuilder.Entity("SABC.Data.Entidades.ClientePagoDto", b =>
                {
                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<double>("Monto")
                        .HasColumnType("float");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("ClientePagos");
                });

            modelBuilder.Entity("SABC.Data.Entidades.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<double>("Monto")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pagos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cedula = "8-75-584",
                            ClienteId = 1,
                            Fecha = new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 200.0
                        },
                        new
                        {
                            Id = 2,
                            Cedula = "8-75-584",
                            ClienteId = 1,
                            Fecha = new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 198.22
                        },
                        new
                        {
                            Id = 3,
                            Cedula = "8-75-584",
                            ClienteId = 1,
                            Fecha = new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 210.0
                        },
                        new
                        {
                            Id = 4,
                            Cedula = "PE-254-845",
                            ClienteId = 2,
                            Fecha = new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 200.0
                        },
                        new
                        {
                            Id = 5,
                            Cedula = "PE-254-845",
                            ClienteId = 2,
                            Fecha = new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 198.22
                        },
                        new
                        {
                            Id = 6,
                            Cedula = "PE-254-845",
                            ClienteId = 2,
                            Fecha = new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 210.0
                        });
                });

            modelBuilder.Entity("SABC.Data.Entidades.Pago", b =>
                {
                    b.HasOne("SABC.Data.Entidades.Cliente", null)
                        .WithMany("Pagos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SABC.Data.Entidades.Cliente", b =>
                {
                    b.Navigation("Pagos");
                });
#pragma warning restore 612, 618
        }
    }
}
