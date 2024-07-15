using ApicativoRelatorio.Modulos;
using Microsoft.Data.SqlClient;
using S.U.TI.Formularios.Mapeamento.Computadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.U.TI.Modulos
{
    internal class ConexaoMapaPc
    {
        ConexaoBanco banco = new ConexaoBanco();
        //_________________________MAPA COMPUTADOR______________________________________
        public void SalvarMpComp(ClassComputador dados, DateTime criado)
        {
            string sql = " INSERT INTO PCMAPPING" +
                "([Name], [Login], [Password], [User], Sector, [System], [IP], Mask, Gateway, DNS, DNS2, Proxy, [Port], Domain, AnyDesk, MAC, [Platform] , CPU, Socket, Motherboard, Memory, DDR, Frequency, Slots, GPU, [Disk] , TypeDisk, Used, Offboard1, Offboard2, Registry, Observation, [Date], Active)" +
                "VALUES(@Name, @Login, @Password, @User, @Sector , @System, @IP, @Mask, @Gateway, @DNS, @DNS2, @Proxy, @Port, @Domain, @AnyDesk, @MAC, @Platform, @CPU, @Socket, @Motherboard, @Memory, @DDR, @Frequency, @Slots, @GPU, @Disk, @TypeDisk, @Used, @Offboard1, @Offboard2, @Registry, @Observation, @Date, 1)";
            using (SqlConnection conexao = new SqlConnection(banco.connectionString))
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



        public string PegarId()
        {
            string ID = string.Empty;
            string sql = string.Empty;
            sql = "Select TOP 1 Id From PCMAPPING Order By Id Desc";


            using (SqlConnection conexao = new SqlConnection(banco.connectionString))
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
        }

            

    }
}
