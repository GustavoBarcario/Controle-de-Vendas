using System.Configuration;
using System.Data.SqlClient;

namespace Controle_de_Vendas.br.com.controlevendas.conexao
{
    public class ConnectionFactory
    {
        public SqlConnection GetSqlConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["BDVendas"].ConnectionString;
            
            return new SqlConnection(conexao);
        }
    }
}
