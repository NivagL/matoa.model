namespace matoa.model;

public class Event : IHasImage
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;
  public int? EventTypeId { get; set; } = null;
  public EventType? EventType { get; set; } = null;
  public int? OrganiserId { get; set; } = null;
  public Contact? Organiser { get; set; } = null;
  public int? LocationId { get; set; } = null;
  public Location? Location { get; set; } = null;
  public DateTimeOffset? EventStart { get; set; } = null;
  public DateTimeOffset? EventEnd { get; set; } = null;
  public Guid? ImageId { get; set; } = null;
  public string? ImageUrl { get; set; } = null;
}
