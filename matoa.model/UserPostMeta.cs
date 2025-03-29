using matoa.model;

public class UserPostMeta : IModelMeta<int, UserPost>
{
  public Func<UserPost, int> Key { get; set; } = x => x.Id;
  public Action<UserPost, UserPost> Assign { get; set; } = (source, target) =>
  {
    source.UserId = target.UserId;
    source.PostText = target.PostText;
    //if(existing.ImageIds.Any())
    //{
    //  updated.ImageIds.Clear();
    //  foreach (var image in existing.ImageIds)
    //    updated.ImageIds.Add(image);
    //}
  };

  public Func<UserPost, UserPost, bool> Equal { get; set; } = (left, right) =>
  {
    return left.Id == right.Id
      && left.PostText == right.PostText;
      //&& left.ImageIds == right.ImageIds; //TODO eekkk
  };
}
