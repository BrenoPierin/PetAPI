using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APIPet.Context
{
    public class TipoPetContext
    {
        SqlConnection conex = new SqlConnection();
        public TipoPetContext()
        {
            conex.ConnectionString = "Data Source=DESKTOP-AMAFSNH/SQLEXPRESS;Initial Catalog=PetShop;User ID=sa;Password=sa132;";
        }

        public SqlConnection Conectar()
        {
            if(conex.State == System.Data.ConnectionState.Closed)
            {
                conex.Open();
            }

            return conex;
        }

        public void Desconectar()
        {
            if(conex.State == System.Data.ConnectionState.Open)
            {
                conex.Close();
            }
        }
    }
}
