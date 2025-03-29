using matoa.model;

public class LoginResponseMeta : IModelMeta<int, LoginResponse>
{
  public Func<LoginResponse, int> Key { get; set; } = x => x.Id;

  public Action<LoginResponse, LoginResponse> Assign { get; set; } = (source, target) =>
  {
    source.UserId = target.UserId;
    source.User = target.User;
    source.LoggedIn = target.LoggedIn;
    source.Token = target.Token;
    source.Expires = target.Expires;
  };

  public Func<LoginResponse, LoginResponse, bool> Equal { get; set; } = (left, right) =>
  {
    return left.UserId == right.UserId
      && left.User == right.User
      && left.LoggedIn == right.LoggedIn
      && left.Token == right.Token
      && left.Expires == right.Expires;
  };
}
