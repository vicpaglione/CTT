﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minha1Conexao.Domain.Model;

namespace Minha1Conexao.Data.Map
{
    public class TurmaProfessorMap : IEntityTypeConfiguration<TurmaProfessor>
    {
        public void Configure(EntityTypeBuilder<TurmaProfessor> builder)
        {
            builder.ToTable("TurmaProfessor");

            builder.HasKey(x => new { x.IdProfessor, x.IdTurma });

            builder.HasOne(t => t.Turma)
                .WithMany(tp => tp.TurmaProfessor)
                .HasForeignKey(i => i.IdTurma);

            builder.HasOne(p => p.Professor)
                .WithMany(tp => tp.TurmaProfessor)
                .HasForeignKey(i => i.IdProfessor);

            builder.Property(x => x.Id)
                .UseIdentityColumn();

        }
    }
}
