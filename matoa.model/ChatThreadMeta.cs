using Common.Model;
namespace Matoa.Model;

public class ChatThreadMeta : IModelMeta<int, ChatThread>
{
  public Func<ChatThread, int> Key { get; set; } = x => x.Id;
  public Action<ChatThread, ChatThread> Assign { get; set; } = (source, target) =>
  {
    source.Id = target.Id;
    source.ThreadType = target.ThreadType;
    source.Context = target.Context;
    source.Reference = target.Reference;
  };

  public Func<ChatThread, ChatThread, bool> Equal { get; set; } = (left, right) =>
  {
    return left.Id == right.Id
      && left.ThreadType == right.ThreadType
      && left.Context == right.Context
      && left.Reference == right.Reference;
  };
}
