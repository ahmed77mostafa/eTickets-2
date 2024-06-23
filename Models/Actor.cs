using System.ComponentModel.DataAnnotations;

namespace eTickets_2.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name= "Actor Name")]
        public string Name { get; set; }
        [Display(Name = "Picture")]
        public string ProfilePicURL { get; set; }
        public string Bio { get; set;}
        public List<ActorMovie> Actor_Movie { get; set; }
    }
}
