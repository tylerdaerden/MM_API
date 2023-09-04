using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Command;

namespace MM_Models.Api.Command
{
#nullable disable

    public class AddMashupCommand : ICommandDefinition
    {
        public string Title { get; set; }
        public string PathFile { get; set; }
        public int Length { get; set; }
        public DataTable TrackIds { get; init; }
        public int Masherid { get; }

        public AddMashupCommand(string title , string pathfile , int length , int[] trackids , int masherid) 
        {
            Title = title;
            PathFile = pathfile;
            Length = length;
            Masherid = masherid;
            TrackIds = Fill(trackids);
        }

        private DataTable Fill(int[] trackids)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TrackId", typeof(int)); 

            foreach (int trackid in trackids)
            {
                dt.Rows.Add(trackid);
            }

            return dt;

        }
    }
}

