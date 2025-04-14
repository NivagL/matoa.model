using Common.Model;
namespace Matoa.Model;

public class RoleMeta : IModelMeta<int, Role>
{
  public Func<Role, int> Key { get; set; } = et => et.Id;

  public Action<Role, Role> Assign { get; set; } = (source, target) =>
  {
    source.Name = target.Name;
  };

  public Func<Role, Role, bool> Equal { get; set; } = (left, right) =>
  {
    return left.Name == right.Name;
  };
}
