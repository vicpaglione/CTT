using System;
using System.Collections.Generic;
using System.Text;

namespace salao.Domain
{
    public class ServicoSolicitado
    {
        public int Id { get; set; }
        public Servico Servico { get; set; }
        public Funcionario Funcionario { get; set; }
        public List<Agendamento> Agendamentos { get; set; }
    }
}
