using System.ComponentModel.DataAnnotations.Schema;

namespace ExciteCupClassic.Models.Core;

[Table("competitions")]
public class Competition
{
    public long Id { get; set; }
    public required string Name { get; set; }
    public required int Fee { get; set; }
    public required string Venue { get; set; };
    public required DateTime Date { get; set; }
}