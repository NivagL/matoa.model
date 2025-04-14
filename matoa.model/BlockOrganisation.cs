namespace Matoa.Model;

public class BlockOrganisation
{
  public int BlockId { get; set; }
  public Block? Block { get; set; } = null;
  public int OrganisationId { get; set; }
  public Organisation? Organisation { get; set; } = null;
}
