namespace csharp_boolflix.Models
{
    public class Season
    {
        public int Id { get; set; }
        public int SeriesId { get; set; }
        public Serie Serie { get; set; }
    }
}
