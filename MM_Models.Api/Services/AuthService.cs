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

namespace MM_Models.Api.Services
{
#nullable disable
    public class AuthService : IAuthRepository
    {
        private readonly DbConnection _dbConnection;
        public AuthService(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public ICommandResult Execute(RegisterCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();

                    _dbConnection.ExecuteNonQuery("MMSP_Register", true, command);
                    return
                        ICommandResult.Success();
                }
            }
            catch (Exception ex)
            {
                return ICommandResult.Failure(ex.Message);
            }
        }

        public User Execute(LoginQuery query)
        {
            _dbConnection.Open();
            User user = _dbConnection.ExecuteReader("MMSP_Login", dr => dr.ToUser(), true, query).SingleOrDefault();
            _dbConnection.Close();
            return user;
        }

        //public ICommandResult Execute(AddArtistCommand command)
        //{
        //    try
        //    {
        //        using (_dbConnection)
        //        {
        //            _dbConnection.Open();

        //            _dbConnection.ExecuteNonQuery("MMSP_AddArtist", true, command);
        //            return
        //                ICommandResult.Success();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return ICommandResult.Failure(ex.Message);
        //    }
        //}
    }

}

