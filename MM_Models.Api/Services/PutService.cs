using MM_Models.Api.Command;
using MM_Models.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Ado;
using Tools.CQS.Command;

namespace MM_Models.Api.Services
{
    public class PutService : IUpdateRepository
    {
        private readonly DbConnection _dbConnection;

        public PutService(DbConnection dbconnection)
        {
            _dbConnection = dbconnection;
        }

        public ICommandResult Execute(UpdateMashupCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();

                    _dbConnection.ExecuteNonQuery("MMSP_UpdateMashup", true, command);
                    return
                        ICommandResult.Success();
                }
            }
            catch (Exception ex)
            {
                return ICommandResult.Failure(ex.Message);
            }
        }
    }
}
