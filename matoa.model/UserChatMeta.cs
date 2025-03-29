using matoa.model;

public class UserChatMeta : IModelMeta<(int UserId, int ThreadId, DateTime DateTime), UserChat>
{
  public (string Type, string Name)[] KeyNames
  {
    get
    {
      return [("int", "userid"), ("int", "thredid"), ("datetime", "datetime")];
    }
  }

  public Func<UserChat, (int UserId, int ThreadId, DateTime DateTime)> Key { get; set; } 
    = userChat => (userChat.UserId, userChat.ChatThreadId, userChat.DateTime);
  public Action<UserChat, UserChat> Assign { get; set; } = (source, target) =>
  {
    source.UserId = target.UserId;
    source.ChatThreadId = target.ChatThreadId;
    source.DateTime = target.DateTime;
    source.Content = target.Content;
  };

  public Func<UserChat, UserChat, bool> Equal { get; set; } = (left, right) =>
  {
    return left.UserId == right.UserId
      && left.ChatThreadId == right.ChatThreadId
      && left.DateTime == right.DateTime
      && left.Content == right.Content;
  };
}
