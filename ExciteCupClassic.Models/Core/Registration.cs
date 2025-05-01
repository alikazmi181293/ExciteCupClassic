namespace ExciteCupClassic.Models.Core;

public class Registration
{
    public long Id { get; set; }
    public int Fee { get; set; }
    public DateTime Date { get; set; }
    public required Team Team { get; set; }
    public required Competition Competition { get; set; }
}
