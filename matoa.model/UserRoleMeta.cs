using Common.Model;
namespace Matoa.Model;

public class UserRoleMeta : IModelMeta<(int, int), UserRole>
{
  public (string Type, string Name)[] KeyNames
  {
    get
    {
      return [("int", "userid"), ("int", "roleid")];
    }
  }

  public Func<UserRole, (int, int)> Key { get; set; } = x => (x.UserId, x.RoleId);

  public Action<UserRole, UserRole> Assign { get; set; } = (source, target) =>
  {
    source.UserId = target.UserId;
    //existing.User = new User() { Id = updated.UserId };
    source.RoleId = target.RoleId;
    //existing.Role = new Role() { Id = updated.RoleId };
  };

  public Func<UserRole, UserRole, bool> Equal { get; set; } = (left, right) =>
  {
    return left.UserId == right.UserId
      && left.RoleId == right.RoleId;
  };
}
