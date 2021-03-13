﻿using Minha1Conexao.Domain.Model;
using System.Collections.Generic;

namespace Minha1Conexao.Domain
{
    public class Professor : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Turno Turno { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public List<TurmaProfessor> TurmaProfessor { get; set; }
    }

    public enum Turno
    {
        Manha,
        Tarde,
        Noite,
        Integral
    }
}
