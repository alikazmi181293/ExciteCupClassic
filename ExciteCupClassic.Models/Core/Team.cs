using System.ComponentModel.DataAnnotations.Schema;

namespace ExciteCupClassic.Models.Core;

[Table("teams")]
public class Team
{
    public long Id { get; set; }
    public required string Name { get; set; }
    public required ICollection<Participant> Participants { get; set; } = new List<Participant>();
}