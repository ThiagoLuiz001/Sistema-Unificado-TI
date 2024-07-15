using Microsoft.Data.SqlClient;
using System.Data;
using S.U.TI.Model;

namespace S.U.TI.DAO
{
    public class CompanyDAO
    {
        public void Insert(Company company)
        {

            var command = new SqlCommand();

            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO COMPANY "
                + "VALUES(@Name, @CorporateReason, @CNPJ, @Branch)";

            command.Parameters.AddWithValue("@Name", company.Name);
            command.Parameters.AddWithValue("@CorporateReason", company.CorporateReason);
            command.Parameters.AddWithValue("@CNPJ", company.CNPJ);
            command.Parameters.AddWithValue("@Branch", company.Branch);

            Connection.Execute(command);
        }
    }
}
