using Microsoft.Data.SqlClient;
using System;
using S.U.TI.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace S.U.TI.DAO
{
    internal class SystemDAO
    {
        public List<Model.System> Select()
        {
            var list = new List<Model.System>();
            var command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT Id, SystemName, Date, Status, DateStatus FROM  SYSTEM_MAPPING WHERE Status = 1";

            SqlDataReader reader = Connection.Read(command);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var system = new Model.System();
                    system.Id = reader.GetInt32("Id");
                    system.Name = reader.GetString("Name");
                    system.Date = reader.GetDateTime("Data");
                    system.Status = reader.GetBoolean("Status");
                    system.StatusDate = reader.GetDateTime("StatusDate");
                    list.Add(system);
                }
            }

            return list;
        }

    }
}
