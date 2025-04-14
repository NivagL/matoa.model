using Common.Model;
namespace Matoa.Model;

public class LocationMeta : IModelMeta<int, Location>
{
  public Func<Location, int> Key { get; set; } = x => x.Id;

  public Action<Location, Location> Assign { get; set; } = (source, target) =>
  {
    source.Name = target.Name;
    source.Description = target.Description;
    source.LocationTypeId = target.LocationTypeId;
    //existing.LocationType = updated.LocationType;
    source.AddressId = target.AddressId;
    //existing.Address = updated.Address;
    source.GoogleLink = target.GoogleLink;
    source.ImageId = target.ImageId;
  };

  public Func<Location, Location, bool> Equal { get; set; } = (existing, updated) =>
  {
    return existing.Name == updated.Name
      && existing.Description == updated.Description
      && existing.LocationTypeId == updated.LocationTypeId
      //&& existing.LocationType == updated.LocationType
      && existing.AddressId == updated.AddressId
      //&& existing.Address == updated.Address
      && existing.GoogleLink == updated.GoogleLink
      && existing.ImageId == updated.ImageId;
  };
}
