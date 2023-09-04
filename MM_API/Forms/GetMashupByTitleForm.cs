using System.ComponentModel.DataAnnotations;

namespace MM_API.Forms
{
#nullable disable
    public class GetMashupByTitleForm
    {
        [Required]
        public string Title { get; set; }
    }
}
