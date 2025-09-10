using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVeterinario
{
    internal class Conexao
    {
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=db_veterinario2;user=root;pwd=123456");

        public static string msg;

        public MySqlConnection ConnectarBD()
        {
            try
            {
                con.Open();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return con;
        }

        public MySqlConnection DesConnectarBD()
        {
            try
            {
                con.Close();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return con;
        }

    }
}
