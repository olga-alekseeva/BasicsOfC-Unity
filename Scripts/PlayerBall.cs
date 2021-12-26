using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public class PlayerBall : Player //запуск движения игрока
    {
        private void FixedUpdate()
        {
            Move();
        }
    }
}