using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public sealed class MoveBehaviour
    {

        public void Move(SpeedValue _speed, Rigidbody rigidbody)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rigidbody.AddForce(movement * _speed.Speed);

        }


    }
}