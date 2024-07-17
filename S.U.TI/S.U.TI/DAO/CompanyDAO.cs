using Microsoft.Data.SqlClient;
using System.Data;
using S.U.TI.Model;

namespace S.U.TI.DAO
{
    public class CompanyDAO
    {
        public void InsertCompany(Company company)
        {

            var command = new SqlCommand();

            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO COMPANY "
                + "VALUES(@Name, @CorporateReason, @CNPJ, @Branch, @Phone, 1)";

            command.Parameters.AddWithValue("@Name", company.Name);
            command.Parameters.AddWithValue("@CorporateReason", company.CorporateReason);
            command.Parameters.AddWithValue("@CNPJ", company.CNPJ);
            command.Parameters.AddWithValue("@Branch", company.Branch);
            command.Parameters.AddWithValue("@Phone", company.Phone);

            Connection.Execute(command);
        }

        public int SelectId()
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT TOP 1 Id FROM COMPANY" +
                "ORDER BY Id DESC";
            SqlDataReader reader = Connection.Read(command);
            int id = reader.GetInt32("Id");
            return id;
        }

        public void InsertAddress(CompanyAddress address)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO COMPANY_ADRESS" +
                "VALUES(@Cep, @PublicPlace, @Neighborhood, @City, @Number, @CompanyId)";
            command.Parameters.AddWithValue("@Cep",address.CEP);
            command.Parameters.AddWithValue("@PublicPlace",address.PublicPlace);
            command.Parameters.AddWithValue("@Neighborhood", address.Neighborhood);
            command.Parameters.AddWithValue("@City",address.City);
            command.Parameters.AddWithValue("@Number",address.Number);
            command.Parameters.AddWithValue("@CompanyId",address.CompanyId);

            Connection.Execute(command);
        }
    }
}
