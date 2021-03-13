using System;
using System.Collections.Generic;
using System.Text;

namespace salao.Domain
{
   public class Pagamento
    {
        public int Id { get; set; }
        public float ValorServico { get; set; }
        public float Comissao { get; set; }
    }
}
