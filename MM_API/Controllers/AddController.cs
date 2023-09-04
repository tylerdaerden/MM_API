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

        [HttpPost("AddTrack")]
        public IActionResult AddTrack([FromBody] AddTrackForm form)
        {
            _logger.LogInformation($"New Track Added : {form.Title} with a length of {form.Length} performed by {form.ArtistName} explicit lyrics = {form.Explicit}");
            ICommandResult result = _addRepository.Execute(new AddTrackCommand(form.Title, form.Length, form.Explicit, form.ArtistName , form.ArtistId));

            if (result.IsFailure)
            {
                _logger.LogError(result.Message);
                return BadRequest();
            }


            return NoContent();
        }

        [HttpPost("AddMashup")]
        public IActionResult AddMashup([FromBody] AddMashupForm form)
        {
            _logger.LogInformation($" New Mashup Added : {form.Title} with a length of {form.Length} at path {form.PathFile} mashed by Masher with id({form.MasherId}) in MasherTable ");
            ICommandResult result = _addRepository.Execute(new AddMashupCommand(form.Title, form.PathFile, form.Length, form.TrackIds, form.MasherId));
            if (result.IsFailure) 
            {
                _logger.LogError(result.Message);
                return BadRequest();
            }

            return NoContent();
        }
    }
}
