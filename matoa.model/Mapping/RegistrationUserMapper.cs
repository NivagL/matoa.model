namespace matoa.model;

public class RegistrationUserMapper : IMapper<Registration, User>
{
  public Registration FromModel(User model)
  {
    throw new NotImplementedException();
  }

  public User ToModel(Registration observable)
  {
    return new User()
    {
      Username = observable.Username,
      //SendEmail = observable.SendEmail,
      Password = observable.Password,
      Contact = new Contact()
      {
        FirstName = observable.FirstName,
        LastName = observable.LastName,
        Phone = observable.Phone,
        //SendSMS = observable.SendSMS,
        Email = observable.Email,
        ImageId = observable.ImageId
      }
    };
  }
}
