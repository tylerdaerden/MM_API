using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Models.Api.Entities
{
#nullable disable
    public class Masher
    {
        public int Id { get; init; }
        public string MasherName { get; init; }

        public Masher(int id , string mashername , string weblink) 
        {
            Id = id;
            MasherName = mashername;
        }

        public Masher(string mashername) 
        {   
            MasherName = mashername;
        }
    }
}

