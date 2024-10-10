namespace API_Livre.Entities
{
    public class Reservations
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public Users? User { get; set; }
        public int IdBook { get; set; }
        public Books? Book { get; set; }
        public DateTime DateReservation { get; set; }
        public DateTime DateRetour { get; set; }
        public bool IsReturned { get; set; }
    }
}
