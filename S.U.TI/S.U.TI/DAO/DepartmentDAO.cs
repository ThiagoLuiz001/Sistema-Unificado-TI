using Microsoft.Data.SqlClient;
using S.U.TI.Model;
using System.Data;

namespace S.U.TI.DAO
{
    public class DepartmentDAO
    {
        public void Insert(Department department)
        {

            var command = new SqlCommand();

            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO DEPARTMENT "
                + "VALUES(@Name, @CompanyId, @Description)";

            command.Parameters.AddWithValue("@Name", department.Name);
            command.Parameters.AddWithValue("@CompanyId", department.Company.Id);
            command.Parameters.AddWithValue("@Description", department.Description);

            Connection.Execute(command);
        }
    }
}
