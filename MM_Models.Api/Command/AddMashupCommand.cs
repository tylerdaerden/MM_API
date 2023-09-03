using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Command;

namespace MM_Models.Api.Command
{
#nullable disable
    public  class TrackId
    {
        public int Track_Id { get; set; }
    }
    public class AddMashupCommand : ICommandDefinition
    {
        public string Title { get; set; }
        public string PathFile { get; set; }
        public int Length { get; set; }
        public TrackId TrackIds { get; }
        public int Masherid { get; }

        public AddMashupCommand(string title , string pathfile , int length , TrackId trackids , int masherid) 
        {
            Title = title;
            PathFile = pathfile;
            Length = length;
            TrackIds = trackids;
            Masherid = masherid;
        }
    }
}

