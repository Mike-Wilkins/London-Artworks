using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public class Artwork
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Year { get; set; }

        [Required]
        [DisplayName("Art Medium")]
        public string ArtMedium { get; set; }

        [Required]
        public string WebLink { get; set; }

        public int ArtistId { get; set; }
    }
}
