using matoa.model;

public class OrganisationMeta : IModelMeta<int, Organisation>
{
  public Func<Organisation, int> Key { get; set; } = item => item.Id;

  public Action<Organisation, Organisation> Assign { get; set; } = (source, target) =>
  {
    source.Name = target.Name;
    source.Type = target.Type;
    source.District = target.District;
    source.Reference = target.Reference;
    source.Purpose = target.Purpose;
    source.ImageId = target.ImageId;
    //existing.ImageUrl = updated.ImageUrl;
  };

  public Func<Organisation, Organisation, bool> Equal { get; set; } = (left, right) =>
  {
    return left.Name == right.Name
      && left.Type == right.Type
      && left.District == right.District
      && left.Reference == right.Reference
      && left.Purpose == right.Purpose
      && left.ImageId == right.ImageId;
      //&& left.ImageUrl == right.ImageUrl;
  };
}
