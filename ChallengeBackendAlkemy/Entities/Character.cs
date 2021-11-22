namespace Entities
{
    public class Character
    {
        public int Id { get; set; }
        public byte[] Image { get; set; } = null!;
        public string? Name { get; set; }
        public int? Age { get; set; }
        public double Weight { get; set; }
        public string History { get; set; } = null!;

        public int IdSeriesAndMovies { get; set; }
        
        public ICollection<SeriesMovies> SeriesMovies { get; set; }
    }
}
