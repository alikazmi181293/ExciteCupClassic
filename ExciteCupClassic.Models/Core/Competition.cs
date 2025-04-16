
using System.ComponentModel.DataAnnotations.Schema;

namespace ExciteCupClassic.Models.Core;

[Table("competitions")]
public class Competition
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Fee { get; set; }
    public string Venue { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}