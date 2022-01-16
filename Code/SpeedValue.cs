using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
       [CreateAssetMenu(fileName = "Speed", menuName = "CreateScriptablePbject/Properties/SpeedTuning", order = 1)]
    public sealed class SpeedValue : ScriptableObject
    {
        [Range( 0, 10)]
        public int Speed;
    }
}