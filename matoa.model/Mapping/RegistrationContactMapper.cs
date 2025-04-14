namespace Matoa.Model;

public class RegistrationContactMapper : IMapper<Registration, Contact>
{
  public Registration FromModel(Contact model)
  {
    throw new NotImplementedException();
  }

  public Contact ToModel(Registration observable)
  {
    return new Contact()
    {
      FirstName = observable.FirstName,
      LastName = observable.LastName,
      Email = observable.Email,
      Phone = observable.Phone,
      ImageId = observable.ImageId
    };
  }
}
