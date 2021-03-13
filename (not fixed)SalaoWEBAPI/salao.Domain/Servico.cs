using System;
using System.Collections.Generic;
using System.Text;

namespace salao.Domain
{
    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int MinutosParaExecucao { get; set; }
        public float Preco { get; set; }
        public List<FuncionarioServico> Funcionari { get; set; }
        public List<ServicoSolicitado> ServicoSol { get; set; }
    }
}
