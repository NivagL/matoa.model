namespace matoa.model;

public class OrganisationContact
{
  public int OrganisationId { get; set; }
  public Organisation? Organisation { get; set; } = null;
  public int ContactId { get; set; }
  public Contact? Contact { get; set; } = null;
}
