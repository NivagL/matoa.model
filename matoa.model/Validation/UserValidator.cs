namespace Matoa.Model;

public class UserValidator : IValidator<User>
{
  public (bool Valid, IEnumerable<string> Messages) Validate(User value)
  {
    var messages = new List<string>();

    //if (value.Id <= 0) messages.Add("Invalid user id");

    if (string.IsNullOrEmpty(value.Username) || value.Username.Length < ValidationConstants.EmailMinimumLength)
      messages.Add($"Email must be at least {ValidationConstants.EmailMinimumLength}");

    if (string.IsNullOrEmpty(value.Password) || value.Password.Length < ValidationConstants.PasswordMinimumLength)
      messages.Add($"Password must be at least {ValidationConstants.PasswordMinimumLength}"); ;

    return (!messages.Any(), messages);
  }
}
