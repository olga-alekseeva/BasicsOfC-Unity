
namespace RollABall
{
    public class PlayerBall : Player
    //������ �������� ������
    {
        private void FixedUpdate()
        {

            MoveBehaviour move = new MoveBehaviour();

            

            move.Move(_speed, _rigidbody);


        }
    }
}