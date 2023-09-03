using System.ComponentModel.DataAnnotations;

namespace MM_API.Forms
{
#nullable disable
    public class AddTrackForm
    {
        [Required]
        [StringLength(50, MinimumLength =1)]
        public string Title { get; set; }
        [Required]
        public int Length { get; set; }
        [Required]
        public bool Explicit { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 1)]
        public string ArtistName { get; set; }
        [Required]
        public int ArtistId { get; }
    }
}
