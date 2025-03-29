namespace matoa.model;

public class Block : IHasImage
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string? District { get; set; } = null;
  public string? Plan { get; set; } = null;
  public string? Reference { get; set; } = null;
  public double? Shares { get; set; } = null;
  public double? Metres { get; set; } = null;
  public double? Acres { get; set; } = null;
  public Guid? ImageId { get; set; } = null;
  public string? ImageUrl { get; set; } = null;
}
