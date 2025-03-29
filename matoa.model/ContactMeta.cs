using matoa.model;

public class ContactMeta : IModelMeta<int, Contact>
{
  public Func<Contact, int> Key { get; set; } = x => x.Id;
  public Action<Contact, Contact> Assign { get; set; } = (source, target) =>
  {
    source.Title = target.Title;
    source.FirstName = target.FirstName;
    source.MiddleNames = target.MiddleNames;
    source.LastName = target.LastName;
    source.AlternateName = target.AlternateName;
    source.DateOfBirth = target.DateOfBirth;
    source.DateOfDeath = target.DateOfDeath;
    source.Email = target.Email;
    source.Phone = target.Phone;
    source.ImageId = target.ImageId;
    source.Geneology = target.Geneology;
  };

  public Func<Contact, Contact, bool> Equal { get; set; } = (left, right) =>
  {
    return left.Title == right.Title
      && left.FirstName == right.FirstName
      && left.MiddleNames == right.MiddleNames
      && left.LastName == right.LastName
      && left.AlternateName == right.AlternateName
      && left.DateOfBirth == right.DateOfBirth
      && left.DateOfDeath == right.DateOfDeath
      && left.Email == right.Email
      && left.Phone == right.Phone
      && left.ImageId == right.ImageId
      && left.Geneology == right.Geneology;
  };
}
