using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public class Player : MonoBehaviour
    {
       // [SerializeField] public CharacterData _characterData;
       
        
        [SerializeField] public SpeedValue _speed;

        [SerializeField] public HealthValue _health;

   //     [SerializeField] public CharacterData _material;

        public Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        
    }
}