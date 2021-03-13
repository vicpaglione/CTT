using System;
using System.Collections.Generic;
using System.Text;

namespace salao.Data.Map
{
    class ClienteMap
    {
        public class ClienteMap : IEntityTypeConfiguration<Cliente>
        {
            public void Configure(EntityTypeBuilder<Cliente> builder)
            {
                builder.ToTable("Cliente");

                builder.HasKey(x => x.Id);

                builder.Property(x => x.Nome).HasColumnType("varchar(150)")
                    .IsRequired();

                builder.Property(x => x.Telefone).HasColumnType("varchar(15)")
                   .IsRequired();

                builder.Property(x => x.Cpf).HasColumnType("varchar(11)")
                   .IsRequired();
            }
        }
    }
}
