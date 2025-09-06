using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoVeterinario
{
    internal class Conexao
    {
        MySqlConnection Con = new MySqlConnection("Data Source=localhost;Initial Catalog=BDPizzaria1;user=root;pwd=123456");

        public static string msg;

        public MySqlConnection ConnectarBD()
        {
            try
            {
                Con.Open();
            }
            catch (Exception erro)
            {
                msg = "ocorreu um erro ao se conectar" + erro.Message;
            }
            return Con;
        }

        public MySqlConnection DesconnectarBD()
        {
            try
            {
                Con.Close();
            }
            catch(Exception erro)
            {
                msg = "ocorreu um erro ao se conectar" + erro.Message;
            }
            return Con;
        }
    }
}