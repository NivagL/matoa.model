using Common.Model;
namespace Matoa.Model;

public class LocationTypeMeta : IModelMeta<int, LocationType>
{
  public Func<LocationType, int> Key { get; set; } = x => x.Id;

  public Action<LocationType, LocationType> Assign { get; set; } = (source, target) =>
  {
    source.Name = target.Name;
  };

  public Func<LocationType, LocationType, bool> Equal { get; set; } = (left, right) =>
  {
    return left.Name == right.Name;
  };
}
