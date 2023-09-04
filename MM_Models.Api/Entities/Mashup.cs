//using MM_Models.Api.Command;
//using MM_Models.Api.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MM_Models.Api.Entities
//{
//#nullable disable
//    public class Mashup
//    {
//        public int Id { get; init; }
//        public string Title { get; init; }
//        public string PathFile { get; init; }
//        public string ArtistName { get; init; }
//        public string MasherName { get; init; }
//        public int Length { get; init; }
//        public TrackId TracksId { get; }
//        public int MasherId { get; }


//        public Mashup(int id, string title, string pathfile, int length, TrackId tracksid, int masherid)
//        {
//            Id = id;
//            Title = title;
//            PathFile = pathfile;
//            Length = length;
//            TracksId = tracksid;
//            MasherId = masherid;
//        }

//        public Mashup(string pathfile, string artistname)
//        {
//            PathFile = pathfile;
//            ArtistName = artistname;
//        }

//        public Mashup(string pathfile, string mashername)
//        {
//            PathFile = pathfile;
//            MasherName = mashername;

//        }


//    }
//}

using MM_Models.Api.Command;
using MM_Models.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Models.Api.Entities
{
#nullable disable
    public class Mashup
    {
        public int Id { get; init; }
        public string Title { get; init; }
        public string PathFile { get; init; }
        public string ArtistName { get; init; }
        public string MasherName { get; init; }
        public int Length { get; init; }
        public TrackId TracksId { get; }
        public int MasherId { get; }

        public Mashup(int id, string title, string pathfile, int length, TrackId tracksid, int masherid)
        {
            Id = id;
            Title = title;
            PathFile = pathfile;
            Length = length;
            TracksId = tracksid;
            MasherId = masherid;
        }

        public Mashup(string artistname, string pathfile)
        {
            ArtistName = artistname;
            PathFile = pathfile;
        }

        public Mashup(string mashername , string pathfile, int masherid) 
        {
            MasherName = mashername;
            PathFile = pathfile;
            MasherId = masherid;

        }

        public Mashup(int id, string title , string pathfile)
        {
            Id = id;
            Title = title;
            PathFile = pathfile;

        }

        public Mashup(string pathfile) 
        {
            PathFile = pathfile;
        }
    }
}



