namespace Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte[] Image { get; set; } = null!;
        public int IdSeriesMovies { get; set; }

       
    }
}
