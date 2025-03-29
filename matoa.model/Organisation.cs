namespace matoa.model;

public class Organisation : IHasImage
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string Type { get; set; } = string.Empty;
  public string? District { get; set; } = null;
  public string? Reference { get; set; } = null;
  public string? Purpose { get; set; } = null;
  public Guid? ImageId { get; set; } = null;
  public string? ImageUrl { get; set; } = null;
}
