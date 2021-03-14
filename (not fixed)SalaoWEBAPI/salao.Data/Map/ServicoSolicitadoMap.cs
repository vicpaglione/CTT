using System;
using System.Collections.Generic;
using System.Text;

namespace salao.Data.Map
{
    public class ServicoSolicitadoMap : IEntityTypeConfiguration<ServicoSolicitado>
    {
        public void Configure(EntityTypeBuilder<ServicoSolicitado> builder)
        {
            builder.ToTable("ServicoSolicitado");

            builder.HasKey(x => x.Id);

            builder.HasOne<Servico>(ss => ss.Servico).WithMany(s => s.ServicosSolicitados);

            builder.HasOne<Funcionario>(ss => ss.Funcionario).WithMany(f => f.ServicosSolicitados);

        }
    }
