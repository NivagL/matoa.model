using Common.Model;
namespace Matoa.Model;

public class AddressMeta : IModelMeta<int, Address>
{
  public Func<Address, int> Key { get; set; } = x => x.Id;

  public Action<Address, Address> Assign { get; set; } = (source, target) =>
  {
    source.Line1 = target.Line1;
    source.Line2 = target.Line2;
    source.City = target.City;
    source.Suburb = target.Suburb;
    source.Region = target.Region;
    source.Postcode = target.Postcode;
    source.Country = target.Country;
    source.Lat = target.Lat;
    source.Lng = target.Lng;
  };

  public Func<Address, Address, bool> Equal { get; set; } = (left, right) =>
  {
    return left.Line1 == right.Line1
      && left.Line2 == right.Line2
      && left.City == right.City
      && left.Suburb == right.Suburb
      && left.Region == right.Region
      && left.Postcode == right.Postcode
      && left.Country == right.Country
      && left.Lat == right.Lat
      && left.Lng == right.Lng;
  };
}
