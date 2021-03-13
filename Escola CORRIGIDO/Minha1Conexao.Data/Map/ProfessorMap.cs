﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minha1Conexao.Domain;

namespace Minha1Conexao.Data.Map
{
    public class ProfessorMap : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professor");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(x => x.Email)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(x => x.Banco)
               .HasColumnType("varchar(50)");

            builder.Property(x => x.Agencia)
               .HasColumnType("varchar(10)");

            builder.Property(x => x.Conta)
               .HasColumnType("varchar(20)");
        }
    }
}
