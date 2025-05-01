using ExciteCupClassic.Business.Contracts;
using ExciteCupClassic.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ExciteCupClassic.API.Controllers.API;

[Route("api/[controller]")]
[ApiController]
public class CompetitionController : ControllerBase
{
    public readonly ICompetitionService _competitionService;

    public CompetitionController(ICompetitionService competitionService)
    {
        _competitionService = competitionService;
    }

    [HttpPost]
    public async Task<IActionResult> PostCompetition(CompetitionDto competitionDto)
    {
        await _competitionService.PostCompetition(competitionDto);

        return NoContent();
    }
}
