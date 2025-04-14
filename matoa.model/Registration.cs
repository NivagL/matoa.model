namespace Matoa.Model;

public class Registration
{
  public Registration()
  {
    // Ensure default values are set correctly, except for Id
    Created = DateTime.UtcNow;
    Username = string.Empty;
    Password = string.Empty;
    FirstName = string.Empty;
    LastName = string.Empty;
  }

  public int Id { get; set; }
  public DateTime Created { get; set; } = DateTime.MinValue;
  public string Username { get; set; } = string.Empty;
  public string Password { get; set; } = string.Empty;
  public string FirstName { get; set; } = string.Empty;
  public string? MiddleNames { get; set; } = null;
  public string LastName { get; set; } = string.Empty;
  public DateTime? DateOfBirth { get; set; } = null;
  public string? Email { get; set; } = null;
  public string? Phone { get; set; } = null;
  public Guid? ImageId { get; set; } = null;
  public string? ImageUrl { get; set; } = null;
  public string? Geneology { get; set; } = null;
  public int? UserId { get; set; } = null;
  public User? User { get; set; } = null;
  public int? ContactId { get; set; } = null;
  public Contact? Contact { get; set; } = null;
}
