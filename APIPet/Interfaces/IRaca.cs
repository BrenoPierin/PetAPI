using APIPet.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPet.Interfaces
{
    interface IRaca
    {
        List<Raca> ListarTodos();
        Raca BuscarPorID(int id);
        Raca Cadastrar(Raca pet);
        Raca Alterar(int id, Raca pet);
        void Excluir(int id);
    }
}
