
namespace RollABall
{
    public sealed class Initializator 
    {
       public Initializator(GameData _data, ControllersRepository _repository)
        {
            var uiController = new UIControllerFactory(_data).Create();

            _repository.Add(uiController);
        }
    }
}