namespace Matoa.Model;

public class BlockOwnership
{
  public int BlockId { get; set; }
  public Block? Block { get; set; } = null;
  public int OwnerId { get; set; }
  public string Ownership { get; set; } = string.Empty;
  public string Reference { get; set; } = string.Empty;
  public string? OwnerType { get; set; } = null;
  public double? Shares { get; set; } = null;
  public double? Ratio { get; set; } = null;
}
