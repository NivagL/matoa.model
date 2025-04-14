namespace Matoa.Model;

public interface IValidator<TValue>
{
  (bool Valid, IEnumerable<string> Messages) Validate(TValue value);
}
