namespace Data.Models;

public class Card
{
    public long Id { get; set; }
    public Person Person { get; set; } 
    public long PersonId { get; set; }
   
    public Discont Discont{ get; set; } = null!;
    public long DiscontId { get; set; }
}