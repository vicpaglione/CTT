using System;
using System.Collections.Generic;
using System.Text;

namespace salao.Data.Interface
{
    interface IBase<T> where T : class
    {
        void Incluir(T entity);

        void Alterar(T entity);

        T Selecionar(int id);

        List<T> SelecionarTudo();

        void Excluir(int id);

        void Dispose();
    }
}
