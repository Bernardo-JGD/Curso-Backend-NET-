using Microsoft.EntityFrameworkCore;
using Proyecto_Escuela_v1.Models;

namespace Proyecto_Escuela_v1.Context
{
    public class EscuelaContext : DbContext
    {
        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Materia_Estudiante
            modelBuilder.Entity<MateriaEstudiante>()
            .HasKey(me => new { me.MateriaID, me.EstudianteID }); // Establece la clave primaria compuesta
                
            modelBuilder.Entity<MateriaEstudiante>()
                    .HasOne(me => me.Materia) // Establece la relación con Materia
                    .WithMany(m => m.Estudiantes) // Establece la relación con Estudiante
                    .HasForeignKey(me => me.MateriaID); // Establece la clave foránea

            modelBuilder.Entity<MateriaEstudiante>()
                    .HasOne(me => me.Estudiante) // Establece la relación con Estudiante
                    .WithMany(e => e.Materias) // Establece la relación con Materia
                    .HasForeignKey(me => me.EstudianteID); // Establece la clave foránea

            modelBuilder.Entity<MateriaEstudiante>()
            .ToTable("MateriasEstudiantes") // Establece el nombre de la tabla de combinación
            .Property(me => me.MateriaID).HasColumnName("MateriaID"); // Establece el nombre de la columna de la clave foránea de Materia
            
            modelBuilder.Entity<MateriaEstudiante>()
                .Property(me => me.EstudianteID).HasColumnName("EstudianteID"); // Establece el nombre de la columna de la clave foránea de Estudiante
            #endregion

            #region Imparte

            modelBuilder.Entity<Imparte>()
                .HasKey(i => new { i.MaestroID, i.MateriaID, i.HorarioID, i.UbicacionID }); // Establece la clave 

            modelBuilder.Entity<Imparte>()
            .HasOne(i => i.Maestro) // Establece la relación con Maestro
            .WithMany(m => m.Impartes) // Establece la relación con Imparte
            .HasForeignKey(i => i.MaestroID); // Establece la clave foránea

            modelBuilder.Entity<Imparte>()
                .HasOne(i => i.Materia) // Establece la relación con Materia
                .WithMany(m => m.Impartes) // Establece la relación con Imparte
                .HasForeignKey(i => i.MateriaID); // Establece la clave foránea

            modelBuilder.Entity<Imparte>()
                .HasOne(i => i.Horario) // Establece la relación con Horario
                .WithMany(h => h.Impartes) // Establece la relación con Imparte
                .HasForeignKey(i => i.HorarioID); // Establece la clave foránea

            modelBuilder.Entity<Imparte>()
                .HasOne(i => i.Ubicacion) // Establece la relación con Ubicacion
                .WithMany(u => u.Impartes) // Establece la relación con Imparte
                .HasForeignKey(i => i.UbicacionID); // Establece la clave foránea

            modelBuilder.Entity<Imparte>()
                .ToTable("Impartes") // Establece el nombre de la tabla de combinación
                .Property(i => i.MaestroID).HasColumnName("MaestroID");// Establece el nombre de la columna de la clave foránea de Maestro

            modelBuilder.Entity<Imparte>()
                .Property(i => i.MateriaID).HasColumnName("MateriaID"); // Establece el nombre de la columna de la clave foránea de Materia

            modelBuilder.Entity<Imparte>()
                .Property(i => i.HorarioID).HasColumnName("HorarioID"); // Establece el nombre de la columna de la clave foránea de Horario
                
            modelBuilder.Entity<Imparte>()
                .Property(i => i.UbicacionID).HasColumnName("UbicacionID"); // Establece el nombre de la columna de la clave foránea de Ubicacion

            #endregion


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Maestro> Maestros { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Imparte> Impartes { get; set; }
    }
}
