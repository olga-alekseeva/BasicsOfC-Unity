using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RollingBall
{
    public sealed class DisplayBonuses: IView //метод, вывода на экран заработанных баллов
    {
        private Text _text;
        private int _point;
        public DisplayBonuses()
        {
            _text = Object.FindObjectOfType<Text>();
        }

        public void Display(int value)
        {
            _point += value;
            _text.text = $"—чЄт {_point}";
        }
    }
    //class MyClassrtty : IView
    //{
    //    public void Display(int value)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}
}