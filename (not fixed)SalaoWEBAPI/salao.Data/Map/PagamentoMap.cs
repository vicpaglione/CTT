using System;
using System.Collections.Generic;
using System.Text;

namespace salao.Data.Map
{
    class PagamentoMap
    {
        public class PagamentoMap : IEntityTypeConfiguration<Pagamento>
        {
            public void Configure(EntityTypeBuilder<Pagamento> builder)
            {
                builder.ToTable("Pagamento");

                builder.HasKey(x => x.Id);

                builder.HasOne<Agendamento>(p => p.AgendamentoRealizado).WithOne(a => a.Pagamento)
                    .HasForeignKey<Agendamento>(a => a.Id);

                builder.Property(x => x.ValorServico).HasColumnType("float")
                    .IsRequired();

                builder.Property(x => x.Comissao).HasColumnType("float")
                    .IsRequired();
            }
        }
    }
}
