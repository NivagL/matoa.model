using Common.Model;
namespace Matoa.Model;

public class OrganisationAddress
{
  public int OrganisationId { get; set; }
  public Organisation? Organisation { get; set; } = null;
  public int AddressId { get; set; }
  public Address? Address { get; set; } = null;
}
