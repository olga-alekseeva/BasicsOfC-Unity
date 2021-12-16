using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AlekseevaOlgaLes1
{


    public sealed class DisplayBonuses
    {
        private Text _text;
        public DisplayBonuses()
        {
            _text = Object.FindObjectOfType<Text>();

        }
        public void Display<T>(ref T value)
        {
            _text.text = $"Ñ÷¸ò {value}";
        }
    }
}