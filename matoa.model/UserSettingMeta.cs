using matoa.model;

public class UserSettingMeta : IModelMeta<(int, String), UserSetting>
{
  public (string Type, string Name)[] KeyNames
  {
    get
    {
      return [("int", "userid"), ("string", "setting")];
    }
  }

  public Func<UserSetting, (int, string)> Key { get; set; } = setting => (setting.UserId, setting.Key );
  public Action<UserSetting, UserSetting> Assign { get; set; } = (source, target) =>
  {
    source.UserId = target.UserId;
    source.Key = target.Key;
    source.Value = target.Value;
  };

  public Func<UserSetting, UserSetting, bool> Equal { get; set; } = (left, right) =>
  {
    return left.UserId == right.UserId
      && left.Key == right.Key
      && left.Value == right.Value;
  };
}
