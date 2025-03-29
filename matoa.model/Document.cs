namespace matoa.model;

public class Document
{
  public Guid StreamId { get; set; }
  public byte[]? FileStream { get; set; } = null;
  public string Name { get; set; } = string.Empty;
  public string? FileType { get; set; } = null;
}