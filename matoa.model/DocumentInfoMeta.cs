using Common.Model;
namespace Matoa.Model;

public class DocumentInfoMeta : IModelMeta<int, DocumentInfo>
{
  public Func<DocumentInfo, int> Key { get; set; } = x => x.Id;

  public Action<DocumentInfo, DocumentInfo> Assign { get; set; } = (source, target) =>
  {
    source.Name = target.Name;
    source.DocumentId = target.DocumentId;
    source.Context = target.Context;
    source.Reference = target.Reference;
    source.UserId = target.UserId;
    source.FileType = target.FileType;
    source.Url = target.Url;
    source.DateCreated = target.DateCreated;
  };

  public Func<DocumentInfo, DocumentInfo, bool> Equal { get; set; } = (left, right) =>
  {
    return left.Name == right.Name
      && left.DocumentId == right.DocumentId
      && left.Context == right.Context
      && left.Reference == right.Reference
      && left.UserId == right.UserId
      && left.FileType == right.FileType
      && left.Url == right.Url
      && left.DateCreated == right.DateCreated;
  };
}
