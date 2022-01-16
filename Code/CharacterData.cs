using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    [CreateAssetMenu(fileName = "Data", menuName = "CreateScriptablePbject/Properties/CharacterSettings", order = 3)]

    public class CharacterData : ScriptableObject
    {
         public Material material;
      
    }
}