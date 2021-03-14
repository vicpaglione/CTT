using System;
using System.Collections.Generic;
using System.Text;

namespace salao.Domain
{
    public class FuncionarioServico
    {
        public int Id { get; set; }
        public int IdFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }
        public int IdServico { get; set; }
        public Servico Servico { get; set; }
    }
}
