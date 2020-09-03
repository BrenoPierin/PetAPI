using APIPet.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPet.Interfaces
{
    interface ITipoPet
    {
        List<TipoPet> ListarTodos();
        TipoPet BuscarPorID(int id);
        TipoPet Cadastrar( TipoPet pet);
        TipoPet Alterar(int id, TipoPet pet);
        void Excluir(int id);
    }
}
