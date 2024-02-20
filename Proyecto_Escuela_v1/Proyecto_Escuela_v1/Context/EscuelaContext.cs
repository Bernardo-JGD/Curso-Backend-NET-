﻿using Microsoft.EntityFrameworkCore;
using Proyecto_Escuela_v1.Models;

namespace Proyecto_Escuela_v1.Context
{
    public class EscuelaContext : DbContext
    {
        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {

        }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
