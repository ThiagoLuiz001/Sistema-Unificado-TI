using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using S.U.TI.Formularios.Mapeamento.Computadores;
using S.U.TI.Formularios.Operacional.Empresas;
namespace ApicativoRelatorio.Modulos
{
    internal class ConexaoBanco
    {
        public string connectionString;

        public ConexaoBanco() //procura o arquivo no computador, lê e atribui os valores do arquivo encontrado na string de conexão
        {
            string caminhoJson = "conexao.json";
            if (File.Exists(caminhoJson))
            {
                string conteudoJson = File.ReadAllText(caminhoJson);
                var config = JsonConvert.DeserializeObject<Dictionary<string, string>>(conteudoJson);

                if (config.TryGetValue("Server", out string? source) && config.TryGetValue("Database", out string? catalog))
                {
                    //string usuario = config["User Id"];
                    //string senha = config["Password"];
                    connectionString = $"Server=np:{source};Database={catalog}; Integrated Security=True; TrustServerCertificate=true";//;User Id={usuario};Password={senha}";
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
        }

        //_______________________________EMPRESAS_____________________________________________
        public void SalvarEmpresa(ClassEmpresas dados)
        {
            DateTime tempo = DateTime.UtcNow;
            string sql = "INSERT INTO COMPANY" +
                "(CompanyName, CorporationReason, CNPJ, Activite, Phone, CompanyCEP, PublicPlace, Neofhborhood, City, Estate, Country, Number,[Date], Active)" +
                "VALUES(@Nome, @Razao, @CNPJ, @Atividade, @Phone, @CEP, @Logradouro, @Bairro, @Cidade, @Estado, @Pais, @Numero, @Data, 1)";
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();
                using(SqlCommand command = new SqlCommand(sql, conexao))
                {
                    command.Parameters.AddWithValue("@Nome", dados.Name);
                    command.Parameters.AddWithValue("@Razao", dados.CorporationReason );
                    command.Parameters.AddWithValue("@CNPJ",dados.CNPJ );
                    command.Parameters.AddWithValue("@Atividade", dados.Activite);
                    command.Parameters.AddWithValue("@Phone",dados.Phone );
                    command.Parameters.AddWithValue("@CEP",dados.CEP);
                    command.Parameters.AddWithValue("@Logradouro", dados.PublicPlace);
                    command.Parameters.AddWithValue("@Bairro", dados.Neoghborhood);
                    command.Parameters.AddWithValue("@Cidade", dados.City);
                    command.Parameters.AddWithValue("@Estado",dados.Estate);
                    command.Parameters.AddWithValue("@Pais", dados.Country);
                    command.Parameters.AddWithValue("@Numero",dados.Number);
                    command.Parameters.AddWithValue("@Data", tempo);
                    command.ExecuteNonQuery();
                }
            }
        }


        /*_________________________MAPA COMPUTADOR______________________________________
        public void SalvarMpComp(ClassComputador dados, DateTime criado)
        {
            string sql = " INSERT INTO PCMAPPING" +
                "([Name], [Login], [Password], [User], Sector, [System], [IP], Mask, Gateway, DNS, DNS2, Proxy, [Port], Domain, AnyDesk, MAC, [Platform] , CPU, Socket, Motherboard, Memory, DDR, Frequency, Slots, GPU, [Disk] , TypeDisk, Used, Offboard1, Offboard2, Registry, Observation, [Date], Active)" +
                "VALUES(@Name, @Login, @Password, @User, @Sector , @System, @IP, @Mask, @Gateway, @DNS, @DNS2, @Proxy, @Port, @Domain, @AnyDesk, @MAC, @Platform, @CPU, @Socket, @Motherboard, @Memory, @DDR, @Frequency, @Slots, @GPU, @Disk, @TypeDisk, @Used, @Offboard1, @Offboard2, @Registry, @Observation, @Date, 1)";
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();
                using (SqlCommand command = new SqlCommand(sql, conexao))
                {
                    command.Parameters.AddWithValue("@Name", dados._name);
                    command.Parameters.AddWithValue("@Login", dados._login);
                    command.Parameters.AddWithValue("@Password", dados._password);
                    command.Parameters.AddWithValue("@User", dados._user);
                    command.Parameters.AddWithValue("@Sector", dados._sector);
                    command.Parameters.AddWithValue("@System", dados._operationSystem);
                    command.Parameters.AddWithValue("@IP", dados._ip);
                    command.Parameters.AddWithValue("@Mask", dados._mask);
                    command.Parameters.AddWithValue("@Gateway", dados._gateway);
                    command.Parameters.AddWithValue("@DNS", dados._dns1);
                    command.Parameters.AddWithValue("DNS2", dados._dns2);
                    command.Parameters.AddWithValue("@Proxy", dados._proxy);
                    command.Parameters.AddWithValue("@Port", dados._port);
                    command.Parameters.AddWithValue("@Domain", dados._domain);
                    command.Parameters.AddWithValue("@AnyDesk", dados._anyDesk);
                    command.Parameters.AddWithValue("@MAC", dados._mac);
                    command.Parameters.AddWithValue("@Platform", dados._type);
                    command.Parameters.AddWithValue("@CPU", dados._cpu);
                    command.Parameters.AddWithValue("@Socket", dados._socket);
                    command.Parameters.AddWithValue("@Motherboard", dados._motherboard);
                    command.Parameters.AddWithValue("@Memory", dados._memory);
                    command.Parameters.AddWithValue("@DDR", dados._ddr);
                    command.Parameters.AddWithValue("@Frequency", dados._frequency);
                    command.Parameters.AddWithValue("@Slots", dados._slots);
                    command.Parameters.AddWithValue("@GPU", dados._gpu);
                    command.Parameters.AddWithValue("@Disk", dados._disk);
                    command.Parameters.AddWithValue("TypeDisk", dados._typedisk);
                    command.Parameters.AddWithValue("@Used", dados._diskUsed);
                    command.Parameters.AddWithValue("@Offboard1", dados._offboard1);
                    command.Parameters.AddWithValue("@Offboard2", dados._offboard2);
                    command.Parameters.AddWithValue("@registry", dados._register);
                    command.Parameters.AddWithValue("@Observation", dados._observation);
                    command.Parameters.AddWithValue("@Date", criado);

                    command.ExecuteNonQuery();
                }
            }

        }
        */
        //____________________PEGA O ID E MANDA PARA OS FORMULARIOS______________________
       /* public string PegarId(int tela)
        {
            string ID = string.Empty;
            string sql = string.Empty;
            switch (tela)
            {
                //Mapa de Comptadores
                case 0:
                    sql = "Select TOP 1 Id From PCMAPPING Order By Id Desc";
                    break;
                //Mapa Impressora
                case 1:
                    sql = "Select TOP 1 Id From TbMpImp Order By Id Desc";
                    break;
            }
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();
                using (SqlCommand command = new SqlCommand(sql, conexao))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ID = reader.GetInt32(0).ToString();
                        }
                    }
                }
            }

            return ID;
        }*/
    }
}
