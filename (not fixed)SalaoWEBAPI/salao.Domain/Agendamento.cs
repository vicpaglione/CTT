
using System;
using System.Collections.Generic;
using System.Text;

namespace salao.Domain
{
    public class Agendamento
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public ServicoSolicitado ServicoSolicitado { get; set; }
        public DateTime DataAgendamento { get; set; }
        public string Anotacao { get; set; }
        public StatusAgenda Status { get; set; }
        public Pagamento Pagamento { get; set; }

        public enum StatusAgenda
        {
            Realizado,
            Reagendado,
            CanceladoPeloCliente,
            NaoCompareceu,
            CanceladoPeloSalao,
            Pendente
        }
    }
}
