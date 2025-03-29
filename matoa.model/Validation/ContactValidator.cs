namespace matoa.model;

public class ContactValidator : IValidator<Contact>
{
  public (bool Valid, IEnumerable<string> Messages) Validate(Contact value)
  {
    var messages = new List<string>();

    //if (value.Id <= 0) messages.Add("Invalid user id");

    if (string.IsNullOrEmpty(value.FirstName) || value.FirstName.Length < ValidationConstants.FirstMinimumLength)
      messages.Add($"First name must be at least {ValidationConstants.FirstMinimumLength}");

    if (string.IsNullOrEmpty(value.LastName) || value.LastName.Length < ValidationConstants.LastMinimumLength)
      messages.Add($"Last name must be at least {ValidationConstants.LastMinimumLength}");

    if (value.Email != null)
    {
      if (string.IsNullOrEmpty(value.Email) || value.Email.Length < ValidationConstants.EmailMinimumLength)
        messages.Add($"Email must be at least {ValidationConstants.EmailMinimumLength}");
    }

    if (value.Phone != null)
    {
      if (string.IsNullOrEmpty(value.Phone) || value.Phone.Length < ValidationConstants.EmailMinimumLength)
        messages.Add($"Email must be at least {ValidationConstants.EmailMinimumLength}");
    }

    return (!messages.Any(), messages);
  }
}
