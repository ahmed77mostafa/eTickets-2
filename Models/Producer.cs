using System.ComponentModel.DataAnnotations;

namespace eTickets_2.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string ProfilePicURL { get; set; }
        public string Bio { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
