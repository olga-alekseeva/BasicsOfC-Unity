using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public sealed class Flicker: CharacterData
    {
        public void FlickColor(CharacterData _mateial)
        {
            _mateial.material.color = new Color(_mateial.material.color.r, _mateial.material.color.g,
                _mateial.material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }
    }
}