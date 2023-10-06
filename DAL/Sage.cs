namespace DAL
{
    public class Sage
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? Birthday { get; set; }

        public virtual List<Book> Books { get; set; } = new();
    }
}