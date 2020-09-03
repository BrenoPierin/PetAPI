using APIPet.Context;
using APIPet.Domains;
using APIPet.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APIPet.Repositories
{
    public class RacaRepository : IRaca
    {
        RacaContext conexao = new RacaContext();

        // 2 - Chamamos nosso objeto que dará os comandos SQL
        SqlCommand cmd = new SqlCommand();
        public Raca Alterar(int id, Raca pet)
        {
            cmd.Connection = conexao.Conectar();
            cmd.CommandText = "UPDATE Raca SET " +
                "Descricao = @Descricao WHERE IdRaca = @id";

            cmd.Parameters.AddWithValue("id", id);

            cmd.Parameters.AddWithValue("@Descricao", pet.Descricao);

            cmd.ExecuteNonQuery();

            conexao.Desconectar();
            return pet;
        }

        public Raca BuscarPorID(int id)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "SELECT * FROM Raca WHERE IdRaca = @id";
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dados = cmd.ExecuteReader();

            Raca pet = new Raca();

            while (dados.Read())
            {

                pet.IdRaca = Convert.ToInt32(dados.GetValue(0));
                pet.Descricao = dados.GetValue(1).ToString();
            }

            conexao.Desconectar();

            return pet;
        }

        public Raca Cadastrar(Raca pet)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText =
                "INSERT INTO Raca (Descricao) " +
                "VALUES" +
                "(@Descricao)";
            cmd.Parameters.AddWithValue("@Descricao", pet.Descricao);

            cmd.ExecuteNonQuery();

            conexao.Desconectar();

            return pet;
        }

        public void Excluir(int id)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "DELETE FROM Aluno WHERE IdRaca = @id";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            conexao.Desconectar();
        }

        public List<Raca> ListarTodos()
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "SELECT * FROM Raca";

            SqlDataReader dados = cmd.ExecuteReader();

            List<Raca> pets = new List<Raca>();

            while (dados.Read())
            {
                pets.Add(
                    new Raca()
                    {
                        IdRaca = Convert.ToInt32(dados.GetValue(0)),
                        Descricao = dados.GetValue(1).ToString(),
                    }
                );
            }

            conexao.Desconectar();

            return pets;
        }
    }
}
