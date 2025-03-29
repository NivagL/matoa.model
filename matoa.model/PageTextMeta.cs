using matoa.model;

public class PageTextMeta : IModelMeta<int, PageText>
{
  public Func<PageText, int> Key { get; set; } = x => x.Id;

  public Action<PageText, PageText> Assign { get; set; } = (source, target) =>
  {
    source.Page = target.Page;
    source.Reference = target.Reference;
    source.X = target.X;
    source.Y = target.Y;
    source.H = target.H;
    source.W = target.W;
    source.Content = target.Content;
  };

  public Func<PageText, PageText, bool> Equal { get; set; } = (left, right) =>
  {
    return left.Page == right.Page
      && left.Reference == right.Reference
      && left.X == right.X
      && left.Y == right.Y
      && left.H == right.H
      && left.W == right.W
      && left.Content == right.Content;
  };
}
