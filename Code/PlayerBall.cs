
namespace RollABall
{
    public class PlayerBall : Player
    //запуск движения игрока
    {
        private void FixedUpdate()
        {

            MoveBehaviour move = new MoveBehaviour();

            

            move.Move(_speed, _rigidbody);


        }
    }
}