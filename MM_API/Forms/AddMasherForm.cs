using System.ComponentModel.DataAnnotations;

namespace MM_API.Forms
{
#nullable disable
    public class AddMasherForm
    {
        [Required]
        [StringLength(50,MinimumLength =1)]
        public string MasherName { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 1)]
        public string Weblink { get; set; }


    }
}

