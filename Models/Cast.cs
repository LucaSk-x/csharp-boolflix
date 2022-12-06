namespace csharp_boolflix.Models
{
    public class Cast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Role { get; set; }
        public List<Content>? Contents { get; set; }
    }
}
