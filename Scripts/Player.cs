using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{


    public class Player: MonoBehaviour //����� ������
    {
        public float Speed = 3.0f;
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();

        }

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            _rigidbody.AddForce(movement * Speed);

        }
    }
}
