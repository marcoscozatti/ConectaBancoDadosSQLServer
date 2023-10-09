using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ConectaBancoDadosSQLServer.Controllers
{
    public class Conecta
    {
        private static string ConnStr = @"Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=BDASPNetProjetoConectaBanco;Data Source=DESKTOP-SEV4FT3\SQLEXPRESS";

        public static SqlConnection GetConnection()
        {
            var cn = new SqlConnection(ConnStr);
            return cn;
        }

        public static void TestaConexao()
        {
            try
            {
                var connection = Conecta.GetConnection();
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

          
        }

    }
}
