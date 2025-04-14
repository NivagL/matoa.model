using Common.Model;
namespace Matoa.Model;

public class EventMeta : IModelMeta<int, Event>
{
  public Func<Event, int> Key { get; set; } = x => x.Id;

  public Action<Event, Event> Assign { get; set; } = (source, target) =>
  {
    source.Name = target.Name;
    source.Description = target.Description;
    source.EventTypeId = target.EventTypeId;
    //existing.EventType = updated.EventType;
    source.OrganiserId = target.OrganiserId;
    //existing.Organiser = updated.Organiser;
    source.LocationId = target.LocationId;
    //existing.Location = updated.Location;
    source.EventStart = target.EventStart;
    source.EventEnd = target.EventEnd;
    source.ImageId = target.ImageId;
    //existing.ImageUrl = updated.ImageUrl;
  };

  public Func<Event, Event, bool> Equal { get; set; } = (existing, updated) =>
  {
    return existing.Name == updated.Name
      && existing.Description == updated.Description
      && existing.EventTypeId == updated.EventTypeId
      //&& existing.EventType == updated.EventType
      && existing.OrganiserId == updated.OrganiserId
      //&& existing.Organiser == updated.Organiser
      && existing.LocationId == updated.LocationId
      //&& existing.Location == updated.Location
      && existing.EventStart == updated.EventStart
      && existing.EventEnd == updated.EventEnd
      && existing.ImageId == updated.ImageId;
      //&& existing.ImageUrl == updated.ImageUrl;
  };
}
