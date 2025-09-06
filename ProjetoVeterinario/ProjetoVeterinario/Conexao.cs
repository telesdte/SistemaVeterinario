using System;
using MySql.Data.MySqlClient;

namespace ProjetoVeterinario
{
    internal class Conexao
    {
        private MySqlConnection Con;

        public Conexao()
        {
            Con = new MySqlConnection("Data Source=localhost;Initial Catalog=dbveterinario;user=root;pwd=123456");
        }

        public MySqlConnection ConectarBD()
        {
            if (Con.State == System.Data.ConnectionState.Closed)
            {
                Con.Open();
            }
            return Con;
        }

        public void DesconectarBD()
        {
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }
        }
    }
}