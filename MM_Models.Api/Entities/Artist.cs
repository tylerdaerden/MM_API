using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Models.Api.Entities
{
#nullable disable
    public class Artist
    {
        public int Id { get; init; }
        public string ArtistName { get; init; }
        public string Genres { get; init; }

        public Artist(int id, string artistName, string genre)
        {
            Id = id;
            ArtistName = artistName;
            Genres = genre;
        }

        public Artist(string artistName) 
        {
            ArtistName = artistName;
        }
    }

    
}
