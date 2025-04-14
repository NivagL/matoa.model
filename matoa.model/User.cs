using System.Collections.ObjectModel;
namespace Matoa.Model;

public class User
{
  public int Id { get; set; }
  public string Username { get; set; } = string.Empty;
  public string Password { get; set; } = string.Empty;
  public int? ContactId { get; set; } = null;
  public Contact? Contact { get; set; } = null;
  public Collection<UserRole> UserRoles { get; set; } = [];
}
