using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    [CreateAssetMenu(fileName = "Data", menuName = "CreateScriptablePbject/PickUpsData", order = 1)]
    public class PickUpsData : ScriptableObject
    {
        [SerializeField] private GameObject gameObject;
        public GameObject pickUpObject
        {
            get { return gameObject; }
            protected set { }
        }


        [Range(-10, 10)]
        [SerializeField] private float value;

        public float Value
        {
            get { return value; }
            protected set { }
        }

        [SerializeField] private Material material;

        public Material _material
        {
            get { return material; }
            protected set { }
        }
    }
} 