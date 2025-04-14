namespace Matoa.Model;

public class PageText
{
  public int Id { get; set; }
  public string Page { get; set; } = string.Empty;
  public string Reference { get; set; } = string.Empty;
  public int X { get; set; }
  public int Y { get; set; }
  public int H { get; set; }
  public int W { get; set; }
  public string Content { get; set; } = string.Empty;
}
