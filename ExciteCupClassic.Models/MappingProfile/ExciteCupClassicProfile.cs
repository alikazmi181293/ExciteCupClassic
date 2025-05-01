using AutoMapper;
using ExciteCupClassic.Models.Core;
using ExciteCupClassic.Models.DTO;

namespace ExciteCupClassic.Models.MappingProfile;

public class ExciteCupClassicProfile : Profile
{
    public ExciteCupClassicProfile() 
    {
        CreateMap<Competition, CompetitionDto>();
        CreateMap<CompetitionDto, Competition>();
    }
}