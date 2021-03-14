using System;
using System.Collections.Generic;
using System.Text;

namespace salao.Domain
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public CargoFunc Cargo { get; set; }
        public DateTime HorarioEntrada { get; set; }
        public DateTime HorarioSaida { get; set; }
        public enum CargoFunc
        {
            Cabeleireiro,
            Manicure,
            Esteticista,
            Barbeiro
        }
    }
}
