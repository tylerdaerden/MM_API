using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Command;

namespace MM_Models.Api.Command
{
#nullable disable
    public class AddArtistCommand : ICommandDefinition
    {
        public string ArtistName { get; set; }
        public string Genre { get; set;}

        public AddArtistCommand(string artistName, string genre)
        {
            ArtistName = artistName;
            Genre = genre;
        }
    }
}


