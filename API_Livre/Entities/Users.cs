namespace API_Livre.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Reservations> Reservations { get; set; }
        public ICollection<Loans> Loans { get; set; } 

    }
}
