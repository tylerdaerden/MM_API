using System.ComponentModel.DataAnnotations;

namespace MM_API.Forms
{
    public class GetMashupByIdForm
    {
        [Required]
        public int MashupId { get; set; }
    }
}
