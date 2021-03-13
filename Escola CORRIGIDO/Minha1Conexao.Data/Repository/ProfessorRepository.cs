﻿using Minha1Conexao.Data.Interface;
using Minha1Conexao.Domain;

namespace Minha1Conexao.Data.Repository
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(Contexto contexto) : base(contexto)
        {

        }
    }
}
