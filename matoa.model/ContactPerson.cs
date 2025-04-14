namespace Matoa.Model;

public class ContactPerson
{
  public int ContactId { get; set; }
  public Contact? Contact { get; set; } = null;
  public int PersonId { get; set; }
  public Person? Person { get; set; } = null;
}
