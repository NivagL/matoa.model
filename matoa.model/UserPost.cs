using Common.Model;
namespace Matoa.Model;

public class UserPost
{
  public int Id { get; set; }
  public int UserId { get; set; } = -1;
  public User? User { get; set; } = null;
  public string PostText { get; set; } = string.Empty;
  //public Collection<Guid> ImageIds { get; set; } = [];
}
