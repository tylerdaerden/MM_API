using MM_Models.Api.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Command;

namespace MM_Models.Api.Repositories
{
    public interface IUpdateRepository : ICommandHandler<UpdateMashupCommand>
    {
    }
}
