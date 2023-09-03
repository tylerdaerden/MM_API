using System.ComponentModel.DataAnnotations;

namespace MM_API.Forms
{
#nullable disable
    public class GetMashupByMasherForm
    {

        [Required]
        public string MasherName { get; set; }
    }
}
