﻿using Microsoft.EntityFrameworkCore;
using Minha1Conexao.Data.Map;
using Minha1Conexao.Domain;
using Minha1Conexao.Domain.Model;

namespace Minha1Conexao.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<TurmaProfessor> TurmaProfessor { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public Contexto(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());
            modelBuilder.ApplyConfiguration(new TurmaProfessorMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }

}
