using matoa.model;

public class RegistrationMeta : IModelMeta<int, Registration>
{
  private IModelMeta<int, User> _userMeta;
  private IModelMeta<int, Contact> _contactMeta;

  public Func<Registration, int> Key { get; set; } = registration => registration.Id;
  public Action<Registration, Registration> Assign { get; set; }
  public Func<Registration, Registration, bool> Equal { get; set; }

  public RegistrationMeta(IModelMeta<int, User> userMeta, IModelMeta<int, Contact> contactMeta)
  {
    _userMeta = userMeta;
    _contactMeta = contactMeta;

    Assign = (source, target) =>
    {
      source.Created = target.Created;
      source.Username = target.Username;
      source.Password = target.Password;
      source.FirstName = target.FirstName;
      source.MiddleNames = target.MiddleNames;
      source.LastName = target.LastName;
      source.DateOfBirth = target.DateOfBirth;
      source.Email = target.Email;
      source.Phone = target.Phone;
      source.ImageId = target.ImageId;
      source.ImageUrl = target.ImageUrl;
      source.Geneology = target.Geneology;
      source.UserId = target.UserId;
      source.ContactId = target.ContactId;

      if (target.User != null)
      {
        if (source.User == null) 
          source.User = new User();

        _userMeta.Assign(source.User, target.User);
      }
      if (target.Contact != null)
      {
        if (source.Contact == null)
          source.Contact = new Contact();

        _contactMeta.Assign(source.Contact, target.Contact);
      }
    };

    Equal = (left, right) =>
    {
      return left.Created == right.Created
        && left.Username == right.Username
        && left.Password == right.Password
        && left.FirstName == right.FirstName
        && left.MiddleNames == right.MiddleNames
        && left.LastName == right.LastName
        && left.DateOfBirth == right.DateOfBirth
        && left.Email == right.Email
        && left.Phone == right.Phone
        && left.ImageId == right.ImageId
        && left.ImageUrl == right.ImageUrl
        && left.Geneology == right.Geneology
        && left.UserId == right.UserId
        && left.ContactId == right.ContactId;
    };
  }
}
