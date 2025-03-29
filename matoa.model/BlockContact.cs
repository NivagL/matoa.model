namespace matoa.model;

public class BlockContact
{
  public int BlockId { get; set; }
  public Block? Block { get; set; } = null;
  public int ContactId { get; set; }
  public Contact? Contact { get; set; } = null;
}
