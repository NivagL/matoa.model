namespace matoa.model;

public interface IHasImage
{
  public Guid? ImageId { get; set; }
  public string? ImageUrl { get; set; }
}
