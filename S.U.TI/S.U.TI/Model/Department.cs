namespace S.U.TI.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Company? Company { get; set; }
        public string? Description {  get; set; }
    }
}
