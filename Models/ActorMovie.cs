namespace eTickets_2.Models
{
    public class ActorMovie
    {
        public int ActorId { get; set; }
        public Actor actor { get; set; }
        public int MovieId { get; set; }
        public Movie movie { get; set; }
    }
}
