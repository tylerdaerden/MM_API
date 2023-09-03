using MM_Models.Api.Entities;
using MM_Models.Api.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Queries;

namespace MM_Models.Api.Repositories
{
    public interface IGetRepository : IQueryHandler<GetMashupByArtistQuery,Mashup>
    {
    }
}
