﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Parcial2_Joseph.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("DetallePaquetes", b =>
                {
                    b.Property<int>("DetallePaqueteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadPaquete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("PaqueteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetallePaqueteId");

                    b.ToTable("DetallePaquetes");
                });

            modelBuilder.Entity("Paquete", b =>
                {
                    b.Property<int>("PaqueteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PaqueteId");

                    b.ToTable("Paquete");
                });

            modelBuilder.Entity("Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Costo")
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Costo = 300.0,
                            Descripcion = "Mani",
                            Existencia = 30,
                            Precio = 10.0
                        },
                        new
                        {
                            ProductoId = 2,
                            Costo = 300.0,
                            Descripcion = "Pistachos",
                            Existencia = 30,
                            Precio = 28.0
                        },
                        new
                        {
                            ProductoId = 3,
                            Costo = 250.0,
                            Descripcion = "Ciruelas",
                            Existencia = 30,
                            Precio = 50.0
                        },
                        new
                        {
                            ProductoId = 4,
                            Costo = 350.0,
                            Descripcion = "Pasas",
                            Existencia = 30,
                            Precio = 100.0
                        },
                        new
                        {
                            ProductoId = 5,
                            Costo = 250.0,
                            Descripcion = "Arándanos",
                            Existencia = 30,
                            Precio = 10.0
                        });
                });

            modelBuilder.Entity("DetallePaquetes", b =>
                {
                    b.HasOne("Paquete", null)
                        .WithMany("DetallePaquetes")
                        .HasForeignKey("DetallePaqueteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Paquete", b =>
                {
                    b.Navigation("DetallePaquetes");
                });
#pragma warning restore 612, 618
        }
    }
}
