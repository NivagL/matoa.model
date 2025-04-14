namespace Matoa.Model;

public class UserChat
{
  public int UserId { get; set; } = -1;
  public User? User { get; set; } = null;
  public int ChatThreadId { get; set; } = -1;
  public ChatThread? ChatThread { get; set; } = null;
  public DateTime DateTime { get; set; } = DateTime.MinValue;
  public string Content { get; set; } = "";
}
