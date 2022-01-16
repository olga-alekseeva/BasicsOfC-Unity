using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RollABall
{
    public sealed class RotationBehaviour: MonoBehaviour, IRotation
    {
        public void Rotation(SpeedValue speed)
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * speed.Speed), Space.World);
        }
    }
}