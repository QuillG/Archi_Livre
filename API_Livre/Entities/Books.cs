namespace API_Livre.Entities
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Located { get; set; }
        public ICollection<Reservations> Reservations { get; set; } 
        public ICollection<Loans> Loans { get; set; }
    }
}
