using Microsoft.Data.SqlClient;
using S.U.TI.Model;
using System.Data;

namespace S.U.TI.DAO
{
    internal class HardwareDAO
    {
        public void Insert (Hardware hardware, DateTime criado)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO PC_HARDWARE_MAPPING" +
                "(Platform, CPU, Socket, Motherboard, MACAddress, Memory, DDR, Frequency, Slots, GPU, Disk, TypeDisk, Used, Offboard1, Offboard2, RegistrationNumber, Notes,Date , Status)" +
                "VALUES(@platform, @cpu, @socket, @motherboard, @macaddress, @memory, @ddr, @frequency, @slots, @gpu, @disk, @typedisk, @used, @off1, @off2, @registration, @notes, @date, 1)";
            command.Parameters.AddWithValue("@platform", hardware.Platform);
            command.Parameters.AddWithValue("@cpu",hardware.CPU);
            command.Parameters.AddWithValue("@socket",hardware.Socket);
            command.Parameters.AddWithValue("@motherboard",hardware.MotherBoard);
            command.Parameters.AddWithValue("@macaddress",hardware.MAC);
            command.Parameters.AddWithValue("@memory",hardware.Memory);
            command.Parameters.AddWithValue("@ddr", hardware.DDR);
            command.Parameters.AddWithValue("@frequency",hardware.Frequency);
            command.Parameters.AddWithValue("@slots",hardware.Slots);
            command.Parameters.AddWithValue("@gpu",hardware.GPU);
            command.Parameters.AddWithValue("@disk",hardware.Disk);
            command.Parameters.AddWithValue("@typedisk",hardware.DiskType);
            command.Parameters.AddWithValue("@used",hardware.DiskUsed);
            command.Parameters.AddWithValue("@off1",hardware.OffBoard1);
            command.Parameters.AddWithValue("@off2",hardware.OffBoard2);
            command.Parameters.AddWithValue("@registration",hardware.RegistrationNumber);
            command.Parameters.AddWithValue("@notes",hardware.Notes);
            command.Parameters.AddWithValue("@date",criado);

            Connection.Execute(command);
        } 

        public int SelectId()
        {
            int id;
            var command = new SqlCommand(); 
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT TOP 1 Id From PC_HARDWERE_MAPPING" +
                "ORDER BY Id DESC";

            SqlDataReader reader = Connection.Read(command);
            id = reader.GetInt32("Id");
            return id;
        }

    }
}
