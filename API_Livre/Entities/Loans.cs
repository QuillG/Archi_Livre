namespace API_Livre.Entities
{
    public class Loans
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public Users? User { get; set; }
        public int IdBook { get; set; }
        public Books? Book { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsReturned { get; set; }
    }
}
