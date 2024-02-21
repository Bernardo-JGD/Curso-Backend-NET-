﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_Escuela_v1.Context;

#nullable disable

namespace Proyecto_Escuela_v1.Migrations
{
    [DbContext(typeof(EscuelaContext))]
    [Migration("20240221001028_PropiedadesEstado")]
    partial class PropiedadesEstado
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Estado", b =>
                {
                    b.Property<int>("EstadoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoID"));

                    b.Property<string>("Abreviatura")
                        .IsRequired()
                        .HasColumnType("VARCHAR(3)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(25)");

                    b.HasKey("EstadoID");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Estudiante", b =>
                {
                    b.Property<int>("EstudianteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstudianteID"));

                    b.Property<string>("CURP")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.Property<int>("EstadoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("DATE");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("EstudianteID");

                    b.HasIndex("EstadoID");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Estudiante", b =>
                {
                    b.HasOne("Proyecto_Escuela_v1.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });
#pragma warning restore 612, 618
        }
    }
}
