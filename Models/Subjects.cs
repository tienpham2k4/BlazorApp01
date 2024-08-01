namespace BlazorApp01.Models
{
    public class Subjects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string code { get; set; }
        public int MajorId { get; set; }
        public Majors Major { get; set; }
    }
}
