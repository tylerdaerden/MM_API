using Microsoft.AspNetCore.Mvc;
using MM_API.Forms;
using MM_Models.Api.Entities;
using MM_Models.Api.Queries;
using MM_Models.Api.Repositories;

namespace MM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetByController : ControllerBase
    {

        private readonly IGetRepository _getRepository;
        private readonly ILogger _logger;

        public GetByController(IGetRepository getRepository, ILogger<GetByController> logger)
        {
            _getRepository = getRepository;
            _logger = logger;
        }

        [HttpGet("GetMashupByArtist")]
        public IActionResult GetMashupByArtist([FromQuery] GetMashupByArtistForm form)
        {
            _logger.LogInformation($"Mashup Request by Artist : {form.MashupArtist} ");
            Mashup? mashup = _getRepository.Execute(new GetMashupByArtistQuery(form.MashupArtist));

            if(mashup is null)
            {
                _logger.LogWarning("No Mashup Found");
                return NotFound();
            }

            return Ok(mashup) ;
        }


















    }
}
