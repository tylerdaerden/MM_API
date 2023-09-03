using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Models.Api.Entities
{
#nullable disable
    public class Track
    {
        public int Id { get; init; }
        public string Title { get; init; }
        public int Length { get; init; }
        public bool Explicit { get; init; }
        public string ArtistName { get; init; }
        public int ArtistId { get;}

        public Track (int id, string title, int length ,bool @explicit ,string artistname, int artistid)
        {
            Id = id;
            Title = title;
            Length = length;
            Explicit = @explicit;
            ArtistName = artistname;   
            ArtistId = artistid;
        }


        public Track (string artistname)
        {
            ArtistName = artistname;
        }

    }
}
