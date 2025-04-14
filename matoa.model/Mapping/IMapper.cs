namespace Matoa.Model;

public interface IMapper<TViewModel, TModel>
{
  TViewModel FromModel(TModel model);
  TModel ToModel(TViewModel observable);
}
