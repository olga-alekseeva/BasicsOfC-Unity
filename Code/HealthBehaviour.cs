using System;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public class HealthBehaviour : HealthValue

    {
        [SerializeField] private HealthValue _health;



        public void HealthChanges(GameObject gameObject)
        {
            if (_health.Health <= 0)
            {
                Destroy(gameObject);
            }
         
        }
    }
}