using MM_Models.Api.Entities;
using MM_Models.Api.Mappers;
using MM_Models.Api.Queries;
using MM_Models.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Ado;

namespace MM_Models.Api.Services
{
#nullable disable
    public class GetService : IGetRepository
    {
        private readonly DbConnection _dbConnection;

        public GetService(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Mashup Execute(GetMashupByArtistQuery query)
        {
            _dbConnection.Open();
            Mashup mashup = _dbConnection.ExecuteReader("MMSP_GetMashupbyArtist", dr => dr.ToMashupByArtist() , true , query).FirstOrDefault();
            _dbConnection.Close();
            return mashup;
        }
    }
}
