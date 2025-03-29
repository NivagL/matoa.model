namespace matoa.model;

public class LoginResponse
{
  public int Id { get; set; }
  public int UserId { get; set; }
  public User? User { get; set; } = null;
  public DateTime LoggedIn { get; set; } = DateTime.MinValue;
  public string Token { get; set; } = string.Empty;
  public DateTime Expires { get; set; } = DateTime.MinValue;
  public DateTime? LoggedOut { get; set; } = null;
}
