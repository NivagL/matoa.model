using matoa.model;

public class UserErrorMeta : IModelMeta<int, UserError>
{
  public Func<UserError, int> Key { get; set; } = userError => userError.Id;
  public Action<UserError, UserError> Assign { get; set; } = (source, target) =>
  {
    source.User = target.User;
    source.Error = target.Error;
    source.Severity = target.Severity;
  };

  public Func<UserError, UserError, bool> Equal { get; set; } = (left, right) =>
  {
    return left.User == right.User
      && left.Error == right.Error
      && left.Severity == right.Severity;
  };
}
