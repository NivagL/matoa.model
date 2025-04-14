using Common.Model;
namespace Matoa.Model;

public class AccountInfoMeta : IModelMeta<int, AccountInfo>
{
  public Func<AccountInfo, int> Key { get; set; } = x => x.Id;

  public Action<AccountInfo, AccountInfo> Assign { get; set; } = (existing, updated) =>
  {
    existing.Name = updated.Name;
    existing.AccountId = updated.AccountId;
    existing.Context = updated.Context;
    existing.Reference = updated.Reference;
    existing.UserId = updated.UserId;
  };

  public Func<AccountInfo, AccountInfo, bool> Equal { get; set; } = (left, right) =>
  {
    return left.Name == right.Name
      && left.AccountId == right.AccountId
      && left.Context == right.Context
      && left.Reference == right.Reference
      && left.UserId == right.UserId;
  };
}
