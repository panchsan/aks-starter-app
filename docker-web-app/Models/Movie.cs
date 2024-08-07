using System.ComponentModel.DataAnnotations;

namespace Docker_compose_web_app.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Actors { get; set; }
    }
}
