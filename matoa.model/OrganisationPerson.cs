namespace Matoa.Model;

public class OrganisationPerson
{
  public int OrganisationId { get; set; }
  public Organisation? Organisation { get; set; } = null;
  public int PersonId { get; set; }
  public Person? Person { get; set; } = null;
}
