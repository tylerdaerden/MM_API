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
    public class GetMashupByMasherQuery : IQueryDefinitions<Mashup>
    {

        public string MasherName { get; init; }

        public GetMashupByMasherQuery(string masherName) 
        {
            MasherName = masherName;

        }

    }
}
