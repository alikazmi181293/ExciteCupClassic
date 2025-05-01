using ExciteCupClassic.Models.DTO;

namespace ExciteCupClassic.Business.Contracts;

public interface ICompetitionService
{
    Task PostCompetition(CompetitionDto competitionDto);
}
