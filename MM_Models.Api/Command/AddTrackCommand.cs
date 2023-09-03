using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Command;

namespace MM_Models.Api.Command
{
#nullable disable
    public class AddTrackCommand : ICommandDefinition
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public bool Explicit { get; set; }
        public string ArtistName { get; set; }
        public int ArtistId { get; }

        public AddTrackCommand(string title , int length , bool @explicit , string artistname, int artistid) 
        {
            Title = title;
            Length = length;
            Explicit = @explicit;
            ArtistName = artistname;
            ArtistId = artistid;

        }


    }
}
