using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    [CreateAssetMenu(fileName = "Health", menuName = "CreateScriptablePbject/Properties/HealthTuning", order = 2)]
    public class HealthValue : ScriptableObject
    {
        [Range(0, 5)]
        public int Health;


        [Range(0, 5)]
        public int speed;
    }
}