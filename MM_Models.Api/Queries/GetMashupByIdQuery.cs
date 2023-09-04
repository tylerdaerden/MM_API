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
    public class GetMashupByIdQuery : IQueryDefinitions<Mashup>
    {

        public int MashupId { get; init; }    


        public GetMashupByIdQuery(int mashupid)
        {
            MashupId = mashupid;

        }



    }
}
