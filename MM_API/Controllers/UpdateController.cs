using Microsoft.AspNetCore.Mvc;
using MM_API.Forms;
using MM_Models.Api.Repositories;
using Tools.CQS.Command;

namespace MM_API.Controllers
{
    public class UpdateController : ControllerBase
    {
        private readonly IUpdateRepository _updateRepository;
        private readonly ILogger _logger;


        public UpdateController(IUpdateRepository updateRepository, ILogger<AddController> logger)
        {
            _updateRepository = updateRepository;
            _logger = logger;

        }

        //[HttpPut("UpdateMashup")]
        //public IActionResult UpdateMashup([FromBody] UpdateMashupForm form) 
        //{
        //    _logger.LogInformation($"Mashup {form.Title} ");
        //    ICommandResult result = _updateRepository.Execute(new MM_Models.Api.Command.UpdateMashupCommand(form.Title,form.PathFile,form.Length,form.TrackId ,form.MasherId));

        //}




    }
}
