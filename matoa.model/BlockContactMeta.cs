using Common.Model;
namespace Matoa.Model;

public class BlockContactMeta : IModelMeta<(int, int), BlockContact>
{
  public (string Type, string Name)[] KeyNames 
  { 
    get 
    { return [ ("int", "blockid"), ("int", "contactid") ]; 
    } 
  }

  public Func<BlockContact, (int, int)> Key { get; set; } = x => (x.BlockId, x.ContactId);

  public Action<BlockContact, BlockContact> Assign { get; set; } = (source, target) =>
  {
    source.BlockId = target.BlockId;
    source.ContactId = target.ContactId;
  };

  public Func<BlockContact, BlockContact, bool> Equal { get; set; } = (left, right) =>
  {
    return left.BlockId == right.BlockId
      && left.ContactId == right.ContactId
;
  };
}
