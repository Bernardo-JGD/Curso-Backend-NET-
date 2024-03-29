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
    [Migration("20240302000949_Alter_Estado_Abreviatura")]
    partial class Alter_Estado_Abreviatura
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
                        .HasColumnType("VARCHAR(5)");

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

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Horario", b =>
                {
                    b.Property<int>("HorarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HorarioID"));

                    b.Property<byte>("Dia")
                        .HasColumnType("TINYINT");

                    b.Property<byte>("HoraFin")
                        .HasColumnType("TINYINT");

                    b.Property<byte>("HoraInicio")
                        .HasColumnType("TINYINT");

                    b.Property<byte>("MinutoFin")
                        .HasColumnType("TINYINT");

                    b.Property<byte>("MinutoInicio")
                        .HasColumnType("TINYINT");

                    b.HasKey("HorarioID");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Imparte", b =>
                {
                    b.Property<int>("MaestroID")
                        .HasColumnType("int")
                        .HasColumnName("MaestroID");

                    b.Property<int>("MateriaID")
                        .HasColumnType("int")
                        .HasColumnName("MateriaID");

                    b.Property<int>("HorarioID")
                        .HasColumnType("int")
                        .HasColumnName("HorarioID");

                    b.Property<byte>("UbicacionID")
                        .HasColumnType("TINYINT")
                        .HasColumnName("UbicacionID");

                    b.HasKey("MaestroID", "MateriaID", "HorarioID", "UbicacionID");

                    b.HasIndex("HorarioID");

                    b.HasIndex("MateriaID");

                    b.HasIndex("UbicacionID");

                    b.ToTable("Impartes", (string)null);
                });

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Maestro", b =>
                {
                    b.Property<int>("MaestroID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaestroID"));

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("MaestroID");

                    b.ToTable("Maestros");
                });

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Materia", b =>
                {
                    b.Property<int>("MateriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MateriaID"));

                    b.Property<string>("ClaveMateria")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.Property<byte>("CreditosOtorgados")
                        .HasColumnType("TINYINT");

                    b.Property<byte>("CreditosRequeridos")
                        .HasColumnType("TINYINT");

                    b.Property<byte>("Cupo")
                        .HasColumnType("TINYINT");

                    b.Property<DateTime>("FechaFinSemestre")
                        .HasColumnType("DATE");

                    b.Property<DateTime>("FechaInicioSemestre")
                        .HasColumnType("DATE");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<byte>("Semestre")
                        .HasColumnType("TINYINT");

                    b.HasKey("MateriaID");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.MateriaEstudiante", b =>
                {
                    b.Property<int>("MateriaID")
                        .HasColumnType("int")
                        .HasColumnName("MateriaID");

                    b.Property<int>("EstudianteID")
                        .HasColumnType("int")
                        .HasColumnName("EstudianteID");

                    b.HasKey("MateriaID", "EstudianteID");

                    b.HasIndex("EstudianteID");

                    b.ToTable("MateriasEstudiantes", (string)null);
                });

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Ubicacion", b =>
                {
                    b.Property<byte>("UbicacionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TINYINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("UbicacionID"));

                    b.Property<byte>("Edificio")
                        .HasColumnType("TINYINT");

                    b.Property<byte>("Planta")
                        .HasColumnType("TINYINT");

                    b.Property<byte>("Salon")
                        .HasColumnType("TINYINT");

                    b.HasKey("UbicacionID");

                    b.ToTable("Ubicaciones");
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

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Imparte", b =>
                {
                    b.HasOne("Proyecto_Escuela_v1.Models.Horario", "Horario")
                        .WithMany("Impartes")
                        .HasForeignKey("HorarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_Escuela_v1.Models.Maestro", "Maestro")
                        .WithMany("Impartes")
                        .HasForeignKey("MaestroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_Escuela_v1.Models.Materia", "Materia")
                        .WithMany("Impartes")
                        .HasForeignKey("MateriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_Escuela_v1.Models.Ubicacion", "Ubicacion")
                        .WithMany("Impartes")
                        .HasForeignKey("UbicacionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Horario");

                    b.Navigation("Maestro");

                    b.Navigation("Materia");

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.MateriaEstudiante", b =>
                {
                    b.HasOne("Proyecto_Escuela_v1.Models.Estudiante", "Estudiante")
                        .WithMany("Materias")
                        .HasForeignKey("EstudianteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_Escuela_v1.Models.Materia", "Materia")
                        .WithMany("Estudiantes")
                        .HasForeignKey("MateriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estudiante");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Estudiante", b =>
                {
                    b.Navigation("Materias");
                });

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Horario", b =>
                {
                    b.Navigation("Impartes");
                });

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Maestro", b =>
                {
                    b.Navigation("Impartes");
                });

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Materia", b =>
                {
                    b.Navigation("Estudiantes");

                    b.Navigation("Impartes");
                });

            modelBuilder.Entity("Proyecto_Escuela_v1.Models.Ubicacion", b =>
                {
                    b.Navigation("Impartes");
                });
#pragma warning restore 612, 618
        }
    }
}
