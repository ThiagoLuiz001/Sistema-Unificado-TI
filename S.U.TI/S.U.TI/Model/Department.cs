namespace S.U.TI.Model
{
    public class Department
    {
        public uint Id { get; }
        public string? Name { get; set; }
        public Company? Company { get; set; }
        public string? Description {  get; set; }
    }
}
