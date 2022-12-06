namespace csharp_boolflix.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Cover { get; set; }
        public List<Cast> Cast { get; set; }
    }
}
