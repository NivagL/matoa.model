namespace matoa.model;

public class ChatThread
{
  public int Id { get; set; }
  public string ThreadType { get; set; } = "";
  public string Context { get; set; } = "";
  public int Reference { get; set; } = -1;
}
