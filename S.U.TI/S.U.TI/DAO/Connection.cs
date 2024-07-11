using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;
namespace S.U.TI.DAO
{
    public class Connection
    {
        private static string SetConnectionString()
        {
            string connectionString;

            string jsonPath = "conexao.json";
            if (File.Exists(jsonPath))
            {
                string jsonContent = File.ReadAllText(jsonPath);
                var config = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent);

                if (config.TryGetValue("Server", out string? source) && config.TryGetValue("Database", out string? catalog))
                {
                    //string user = config["User Id"];
                    //string password = config["Password"];
                    connectionString = $"Server=np:{source};Database={catalog}; Integrated Security=True; TrustServerCertificate=true";//;User Id={user};Password={password}";
                }
                else
                {
                    throw new Exception("Arquivo de configuração de conexão inválido.");
                }
            }
            else
            {
                throw new Exception("Arquivo de configuração de conexão não encontrado.");
            }

            return connectionString;
        }

        public static SqlConnection Connect()
        {
            string connectionString = SetConnectionString();
            SqlConnection connection = new(connectionString);
            connection.Open();
            return connection;
        }

        public static void Execute(SqlCommand command)
        {
            using SqlConnection connection = Connect();
            command.Connection = connection;
            command.ExecuteNonQuery();
        }

        public static SqlDataReader Read(SqlCommand command)
        {
            using SqlConnection connection = Connect();
            command.Connection = connection;
            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
    }
}
