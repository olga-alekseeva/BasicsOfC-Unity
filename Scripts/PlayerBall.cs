using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public class PlayerBall : Player //������ �������� ������
    {
        private void FixedUpdate()
        {
            Move();
        }
    }
}