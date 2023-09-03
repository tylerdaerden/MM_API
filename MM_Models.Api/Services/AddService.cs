using MM_Models.Api.Command;
using MM_Models.Api.Entities;
using MM_Models.Api.Queries;
using MM_Models.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Command;
using Tools.Ado;
using MM_Models.Api.Mappers;
using System.Data;

namespace MM_Models.Api.Services
{
    public class AddService : IAddRepository
    {
        private readonly DbConnection _dbConnection;

        public AddService(DbConnection dbconnection)
        {
            _dbConnection = dbconnection;
        }

        public ICommandResult Execute(AddArtistCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();

                    _dbConnection.ExecuteNonQuery("MMSP_AddArtist", true, command);
                    return
                        ICommandResult.Success();
                }
            }
            catch (Exception ex)
            {
                return ICommandResult.Failure(ex.Message);
            }
        }

        public ICommandResult Execute(AddMasherCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();

                    _dbConnection.ExecuteNonQuery("MMSP_AddMasher", true, command);
                    return
                        ICommandResult.Success();
                }
            }
            catch (Exception ex)
            {
                return ICommandResult.Failure(ex.Message);
            }
        }

        public ICommandResult Execute(AddTrackCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();

                    _dbConnection.ExecuteNonQuery("MMSP_AddTrack", true, command);
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
