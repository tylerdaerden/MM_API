using MM_Models.Api.Command;
using MM_Models.Api.Entities;
using MM_Models.Api.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Command;
using Tools.CQS.Queries;

namespace MM_Models.Api.Repositories
{
    public interface IAuthRepository : ICommandHandler<RegisterCommand>,
        IQueryHandler<LoginQuery, User>
        //,
        //ICommandHandler<AddArtistCommand>
    {

    }
}
