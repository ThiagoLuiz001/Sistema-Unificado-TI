namespace S.U.TI.Model
{
    public class ComputerMapping
    {
        public uint Id { get; }
        public string? Name { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? User { get; set; }
        public Department? Department { get; set; }
        public string? OperationalSystem { get; set; }
        public string? Ip { get; set; }
        public string? Mask { get; set; }
        public string? Gateway { get; set; }
        public string? DNS1 { get; set; }
        public string? DNS2 { get; set; }
        public string? Proxy { get; set; }
        public string? Port { get; set; }
        public string? Domain { get; set; }
        public string? AnyDesk { get; set; }
        public string? MAC { get; set; }
        public string? Notes { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public Company? Company { get; set; }

    }
}
