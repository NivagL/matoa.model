using System.Text;
using Common.Model;
namespace Matoa.Model;

public class Contact : IHasImage
{
  public int Id { get; set; }
  public string? Title { get; set; } = null;
  public string FirstName { get; set; } = string.Empty;
  public string? MiddleNames { get; set; } = null;
  public string LastName { get; set; } = string.Empty;
  public string? AlternateName { get; set; } = null;
  public DateTime? DateOfBirth { get; set; } = null;
  public DateTime? DateOfDeath { get; set; } = null;
  public string? Email { get; set; } = null;
  public string? Phone { get; set; } = null;
  public Guid? ImageId { get; set; } = null;
  public string? ImageUrl { get; set; } = null;
  public string? Geneology { get; set; } = null;

  public string FullName
  {
    get
    {
      var sb = new StringBuilder();
      if (!string.IsNullOrEmpty(Title))
        sb.Append(Title);
      if (!string.IsNullOrEmpty(FirstName))
      {
        if (sb.Length > 0)
          sb.Append(" ");
        sb.Append(FirstName);
      }
      if (!string.IsNullOrEmpty(MiddleNames))
      {
        if (sb.Length > 0)
          sb.Append(" ");
        sb.Append(MiddleNames);
      }
      if (!string.IsNullOrEmpty(LastName))
      {
        if (sb.Length > 0)
          sb.Append(" ");
        sb.Append(LastName);
      }
      if (!string.IsNullOrEmpty(AlternateName))
      {
        if (sb.Length > 0)
          sb.Append(" ");
        sb.Append("(").Append(AlternateName).Append(")");
      }
      return sb.ToString();
    }
  }
}
