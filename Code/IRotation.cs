using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public interface IRotation//интерфейс кручения
    {
        public void Rotation(SpeedValue speed);
    }
}