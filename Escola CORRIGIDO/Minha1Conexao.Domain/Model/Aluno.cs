﻿namespace Minha1Conexao.Domain
{
    public class Aluno : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }        
    }
}
