using Common.Model;
namespace Matoa.Model;

public class LocationContact
{
  public int LocationId { get; set; }
  public Location? Location { get; set; } = null;
  public int ContactId { get; set; }
  public Contact? Contact { get; set; } = null;
}
