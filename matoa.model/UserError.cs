namespace Matoa.Model;

public class UserError
{
  public int Id {  get; set; } = 0;
  public string User { get; set; } = string.Empty;
  public string Error { get; set; } = string.Empty;
  public int Severity { get; set; } = -1;
}
