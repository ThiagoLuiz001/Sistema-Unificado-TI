using Microsoft.Data.SqlClient;
using S.U.TI.Formularios.Mapeamento.Computadores;
using S.U.TI.Model;
using System.Data;

namespace S.U.TI.DAO
{
    public class ComputerInfoDAO
    {
        public void Insert (ComputerMapping dados, DateTime criado)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = " INSERT INTO PC_SYSTEM_MAPPING" +
                "(Name, Login, Password, User, SystemId, Ip, Mask, Gateway, DNS, DNS2, Proxy, Port, Domain, Anydesk, Date)" +
                "VALUES(@Name, @Login, @Password, @User, @System, @IP, @Mask, @Gateway, @DNS, @DNS2, @Proxy, @Port, @Domain, @AnyDesk, @Date, 1)";
            command.Parameters.AddWithValue("@Name", dados.Name);
            command.Parameters.AddWithValue("@Login", dados.Login);
            command.Parameters.AddWithValue("@Password", dados.Password);
            command.Parameters.AddWithValue("@User", dados.User);
            command.Parameters.AddWithValue("@System", dados.SystemOperational);
            command.Parameters.AddWithValue("@IP", dados.Ip);
            command.Parameters.AddWithValue("@Mask", dados.Mask);
            command.Parameters.AddWithValue("@Gateway", dados.Gateway);
            command.Parameters.AddWithValue("@DNS", dados.DNS1);
            command.Parameters.AddWithValue("DNS2", dados.DNS2);
            command.Parameters.AddWithValue("@Proxy", dados.Proxy);
            command.Parameters.AddWithValue("@Port", dados.Port);
            command.Parameters.AddWithValue("@Domain", dados.Domain);
            command.Parameters.AddWithValue("@AnyDesk", dados.AnyDesk);
            
            command.Parameters.AddWithValue("@Date", criado);
            Connection.Execute(command);

        }
    }
}
