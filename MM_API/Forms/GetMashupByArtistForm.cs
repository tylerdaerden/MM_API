using System.ComponentModel.DataAnnotations;

namespace MM_API.Forms
{
#nullable disable
    public class GetMashupByArtistForm
    {

        [Required]
        public string MashupArtist { get; set; }
    }
}
