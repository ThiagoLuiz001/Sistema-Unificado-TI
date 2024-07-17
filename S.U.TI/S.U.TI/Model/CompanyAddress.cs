namespace S.U.TI.Model
{
    public class CompanyAddress
    {
        public uint Id { get; set; }
        public string? CEP { get; set; }
        public string? PublicPlace { get; set; }
        public string? Neighborhood { get; set; }
        public string? City { get; set; }
        public string? Estate { get; set; }
        public string? Number { get; set; }
        public int CompanyId { get; set; }
    }
}
