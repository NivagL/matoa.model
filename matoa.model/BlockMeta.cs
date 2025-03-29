namespace matoa.model
{
  public class BlockMeta : IModelMeta<int, Block>
  {
    public Func<Block, int> Key { get; set; } = x => x.Id;

    public Action<Block, Block> Assign { get; set; } = (source, target) =>
    {
      source.Name = target.Name;
      source.District = target.District;
      source.Plan = target.Plan;
      source.Reference = target.Reference;
      source.Shares = target.Shares;
      source.Metres = target.Metres;
      source.ImageId = target.ImageId;
      //existing.ImageUrl = updated.ImageUrl;
    };

    public Func<Block, Block, bool> Equal { get; set; } = (left, right) =>
    {
      return left.Name == right.Name
        && left.District == right.District
        && left.Plan == right.Plan
        && left.Reference == right.Reference
        && left.Shares == right.Shares
        && left.Metres == right.Metres
        && left.ImageId == right.ImageId;
        //&& left.ImageUrl == right.ImageUrl;
    };
  }
}
