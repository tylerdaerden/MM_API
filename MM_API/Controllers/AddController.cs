using Microsoft.AspNetCore.Mvc;
using MM_Models.Api.Command;
using MM_Models.Api.Repositories;
using MM_Models.Api.Entities;
using MM_Models.Api.Queries;
using Tools.CQS.Command;
using MM_API.Forms;

namespace MM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddController: ControllerBase
    {
        private readonly IAddRepository _addRepository;
        private readonly ILogger _logger;


        public AddController(IAddRepository addRepository, ILogger<AddController> logger)
        {
            _addRepository = addRepository;
            _logger = logger;

        }

        [HttpPost("AddArtist")]
        public IActionResult AddArtist([FromBody] AddArtistForm form)
        {
            _logger.LogInformation($"New Artist Added : {form.ArtistName}  as a {form.Genres} artist");
            ICommandResult result = _addRepository.Execute(new AddArtistCommand(form.ArtistName, form.Genres));

            if (result.IsFailure)
            {
                _logger.LogError(result.Message);
                return BadRequest();
            }


            return NoContent();
        }

        [HttpPost("AddMasher")]
        public IActionResult AddMasher([FromBody] AddMasherForm form)
        {
            _logger.LogInformation($"New Masher Added : {form.MasherName} with the following link to his work {form.Weblink}");
            ICommandResult result = _addRepository.Execute(new AddMasherCommand(form.MasherName,form.Weblink));

            if (result.IsFailure)
            {
                _logger.LogError(result.Message);
                return BadRequest();
            }


            return NoContent();
        }

    }
}
