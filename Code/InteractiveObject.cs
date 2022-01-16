using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{

    public class InteractiveObject:PickUpsData
    {
        private PickUpsData data;

        public void Initialization(PickUpsData _data)
        {
            data = _data;

            FindObjectOfType<InteractiveObject>().pickUpObject = data.pickUpObject;
        }

    
    }
}