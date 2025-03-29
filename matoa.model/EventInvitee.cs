namespace matoa.model;

public class EventAttendee
{
  public int EventId { get; set; }
  public Event? Event { get; set; } = null;
  public int ContactId { get; set; }
  public Contact? Contact { get; set; } = null;
  public bool Invited { get; set; } = true;
  public bool Attended { get; set; } = false;
}
