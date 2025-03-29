namespace matoa.model;

public class DocumentInfo
{
  public int Id { get; set; }
  public string Name { get; set; } = "";
  public Guid DocumentId { get; set; } = Guid.Empty;
  public string Context { get; set; } = "";
  public int Reference { get; set; } = -1;
  public int UserId { get; set; } = -1;
  public User? User { get; set; } = null;
  public string? FileType { get; set; } = null;
  public string? Url { get; set; } = null;
  public DateTime? DateCreated { get; set; } = null;
}
