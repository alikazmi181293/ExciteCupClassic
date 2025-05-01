namespace ExciteCupClassic.Models.DTO;

public class CompetitionDto
{
    public required string Name { get; set; }
    public required int Fee { get; set; }
    public required string Venue { get; set; }
    public required DateTime Date { get; set; }
}