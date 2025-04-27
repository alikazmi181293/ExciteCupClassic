using System.ComponentModel.DataAnnotations.Schema;

namespace ExciteCupClassic.Models.Core;

[Table("participants")]
public class Participant
{
    public long Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string CellPhone { get; set; }
    public required string Email {  get; set; }
}
