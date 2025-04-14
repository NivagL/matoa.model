namespace Matoa.Model;

public class UserSetting
{
  public int UserId { get; set; }
  public User? User { get; set; } = null;
  public string Key { get; set; } = string.Empty;
  public string Value { get; set; } = string.Empty;
}
