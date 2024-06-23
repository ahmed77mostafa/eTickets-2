using System.ComponentModel.DataAnnotations;

namespace eTickets_2.Models
{
    public class Cinema
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
