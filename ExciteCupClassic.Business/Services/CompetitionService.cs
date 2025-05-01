using AutoMapper;
using ExciteCupClassic.Business.Contracts;
using ExciteCupClassic.Database.ExciteCupDbContext;
using ExciteCupClassic.Models.Core;
using ExciteCupClassic.Models.DTO;

namespace ExciteCupClassic.Business.Services;

public class CompetitionService : ICompetitionService
{
    private ExciteCupClassicDbContext _dbContext;
    private IMapper _mapper;

    public CompetitionService(ExciteCupClassicDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task PostCompetition(CompetitionDto competitionDto)
    {
        Competition competition = _mapper.Map<Competition>(competitionDto);

        await _dbContext.AddAsync(competition);
        await _dbContext.SaveChangesAsync();
    }
}
