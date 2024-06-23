using eTickets_2.Data.Enum;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets_2.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory Category { get; set; }
        
        // Cinema
        public int cinemaId { get; set; }
        [ForeignKey("cinemaId")]
        public Cinema cinema { get; set; }

        // Producer
        public int producerId { get; set; }
        [ForeignKey("producerId")]
        public Producer producer { get; set; }
        public List<ActorMovie> Actor_Movie { get; set; }
    }
}
