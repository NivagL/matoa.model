namespace matoa.model;

public interface IValidator<TValue>
{
  (bool Valid, IEnumerable<string> Messages) Validate(TValue value);
}
