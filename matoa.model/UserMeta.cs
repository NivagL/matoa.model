using matoa.model;

public class UserMeta : IModelMeta<int, User>
{
  public Func<User, int> Key { get; set; } = user => user.Id;
  public Action<User, User> Assign { get; set; } = (source, target) =>
  {
    source.Username = target.Username;
    source.Password = target.Password;
    source.ContactId = target.ContactId;
    //existing.Contact = updated.Contact;
  };

  public Func<User, User, bool> Equal { get; set; } = (left, right) =>
  {
    return left.Username == right.Username
      && left.Password == right.Password
      && left.ContactId == right.ContactId;
      //&& left.Contact == right.Contact;
  };
}
