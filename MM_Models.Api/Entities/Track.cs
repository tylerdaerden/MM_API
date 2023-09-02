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
        public bool Explicit { get; init; }
        public string ArtistName { get; init; }

        public Track (int id, string title, bool @explicit ,string artistname)
        {
            Id = id;
            Title = title;
            Explicit = @explicit;
            ArtistName = artistname;
        }


        public Track (string artistname)
        {
            ArtistName = artistname;
        }

    }
}

//@Title NVARCHAR(50),
//	@Length INT,
//    @Explicit BIT, --mettre 1 pour True et 0 pour False
//    @ArtistName NVARCHAR(80),
