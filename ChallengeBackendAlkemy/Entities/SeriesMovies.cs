namespace Entities
{
    public class SeriesMovies
    {

        public int Id { get; set; }
        public byte[] Image { get; set; } = null!;
        public string? Title { get; set; }
        public DateTime? CreationDate { get; set; }
        public int Qualification { get; set; }
        public int IdCharacter { get; set; }


       
        public ICollection<Character> Characters { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}
