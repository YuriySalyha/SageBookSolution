namespace DAL
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public virtual List<Sage> Sages {  get; set; } = new();
    }
}