using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Command;

namespace MM_Models.Api.Command
{
#nullable disable
    public class AddMasherCommand : ICommandDefinition
    {
        public string MasherName { get; set; }
        public string Weblink { get; set; }

        public AddMasherCommand(string mashername, string weblink) 
        {
            MasherName = mashername;
            Weblink = weblink;
        }
    }


}
