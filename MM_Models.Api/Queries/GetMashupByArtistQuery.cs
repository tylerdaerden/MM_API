using MM_Models.Api.Command;
using MM_Models.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Queries;

namespace MM_Models.Api.Queries
{
#nullable disable
    public class GetMashupByArtistQuery : IQueryDefinitions<Mashup>
    {
        public string MashupArtist { get; init; }


        public GetMashupByArtistQuery(string mashupArtist)
        {
            MashupArtist = mashupArtist;

        }
    }
}