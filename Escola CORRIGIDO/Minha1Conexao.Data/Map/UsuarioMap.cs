﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minha1Conexao.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minha1Conexao.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Senha)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(x => x.Perfil)
                .HasColumnType("varchar(100)");
        }
    }
}
