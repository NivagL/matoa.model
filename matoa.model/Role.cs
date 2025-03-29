using System.Collections.ObjectModel;

namespace matoa.model;

public class Role
{
  public int Id { get; set; } = 0;
  public string Name { get; set; } = string.Empty;
  public Collection<UserRole> UserRoles { get; set; } = [];
}
