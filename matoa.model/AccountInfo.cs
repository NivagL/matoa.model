namespace matoa.model;

public class AccountInfo
{
  public int Id { get; set; }
  public string Name { get; set; } = "";
  public Guid AccountId { get; set; } = Guid.Empty;
  public string Context { get; set; } = "";
  public int Reference { get; set; } = -1;
  public int UserId { get; set; } = -1;
  public User? User { get; set; } = null;
}
