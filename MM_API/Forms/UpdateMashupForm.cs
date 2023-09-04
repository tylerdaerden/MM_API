using MM_Models.Api.Command;
using System.ComponentModel.DataAnnotations;

namespace MM_API.Forms
{
#nullable disable
    public class UpdateMashupForm
    {
        [Required]
        [StringLength(80, MinimumLength = 1)]
        public string Title { get; set; }
        [Required]
        [StringLength(384, MinimumLength = 1)]
        public string PathFile { get; set; }
        [Required]
        public int Length { get; set; }
        [Required]
        public int[] TrackIds { get; }
        [Required]
        public int MasherId { get; }
    }
}
