namespace matoa.model;

public class Location : IHasImage
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;
  public int LocationTypeId { get; set; } = -1;
  public LocationType LocationType { get; set; } = new LocationType();
  public int? AddressId { get; set; } = null;
  public Address? Address { get; set; } = null;
  public string? GoogleLink { get; set; } = null;
  public Guid? ImageId { get; set; } = null;
  public string? ImageUrl { get; set; } = null;
}
