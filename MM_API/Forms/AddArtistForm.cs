using System.ComponentModel.DataAnnotations;

namespace MM_API.Forms
{
#nullable disable
    public class AddArtistForm
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string ArtistName { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 1)]
        public string Genres { get; set; }

    }
}


