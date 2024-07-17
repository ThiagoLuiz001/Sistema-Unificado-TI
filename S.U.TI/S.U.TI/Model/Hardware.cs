namespace S.U.TI.Model
{
    public class Hardware
    {
        public uint Id { get; set; }
        public string? Platform { get; set; }
        public string? MAC {  get; set; }

        public string? CPU { get; set; }
        public string? Socket { get; set; }
        public string? MotherBoard { get; set; }
        public string? Memory { get; set; }
        public string? DDR { get; set; }
        public string? Frequency { get; set; }
        public string? Slots { get; set; }
        public string? GPU { get; set; }
        public string? Disk { get; set; }
        public string? DiskType { get; set; }
        public string? DiskUsed { get; set; }
        public string? OffBoard1 { get; set; }
        public string? OffBoard2 { get; set; }
        public Department? Department { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? Notes { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
