using System;
using System.Collections.Generic;
using System.Text;

namespace salao.Domain
{
   public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public List<Agendamento> Agendamentos { get; set; }
    }
}
