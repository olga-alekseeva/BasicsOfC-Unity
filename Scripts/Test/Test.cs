using UnityEngine;

namespace Testing
{
    public class Test : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            try
            {
                int x = int.Parse("-3");
                if (x > 0) throw new MyException("введено недопустимое значение", x);
                Debug.Log("ok");
            }
            catch (MyException e)
            {
                Debug.Log($"{e.Message} {e.Value}");
            }

        }

       
    }
}