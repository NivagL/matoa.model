using Common.Model;
namespace Matoa.Model;

public class AccountMeta : IModelMeta<Guid, Account>
{
  public Func<Account, Guid> Key { get; set; } = x => x.StreamId;

  public Action<Account, Account> Assign { get; set; } = (existing, updated) =>
  {
    existing.FileStream = updated.FileStream;
    existing.Name = updated.Name;
    existing.FileType = updated.FileType;
  };

  public Func<Account, Account, bool> Equal { get; set; } = (left, right) =>
  {
    return left.FileStream == right.FileStream
      && left.Name == right.Name
      && left.FileType == right.FileType;
  };
}
