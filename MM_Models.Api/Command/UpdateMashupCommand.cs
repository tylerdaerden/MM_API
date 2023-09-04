using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Command;

namespace MM_Models.Api.Command
{
#nullable disable

    public class UpdateMashupCommand : ICommandDefinition
    {
        public string Title { get; set; }
        public string PathFile { get; set; }
        public int Length { get; set; }
        public int[] TrackIds { get; }
        public int Masherid { get; }

        public UpdateMashupCommand(string title, string pathfile, int length, int[] trackids, object tracksid, int masherid)
        {
            Title = title;
            PathFile = pathfile;
            Length = length;
            TrackIds = trackids;
            Masherid = masherid;
        }

    }
}
