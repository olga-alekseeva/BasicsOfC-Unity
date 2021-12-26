using System;
using UnityEngine;
using UnityEngine.UI;

namespace RollingBall
{
    public sealed class DisplayEndGame //����� ����
    {
        private Text _finishGameLabel;

        public DisplayEndGame(Text finishGameLabel)
        {
            _finishGameLabel = finishGameLabel;
            _finishGameLabel.text = String.Empty;
        }

        public void GameOver(object o, CaughtPlayerEventArgs args)
        {
            _finishGameLabel.text = ("�� ���������");





            //$"��� ����{((GameObject)o).name} {args.Color}";
        }


        //


    }
}