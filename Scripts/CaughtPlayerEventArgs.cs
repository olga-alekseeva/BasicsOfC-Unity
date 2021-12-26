using System;
using UnityEngine;

namespace RollingBall
{
    public sealed class CaughtPlayerEventArgs : EventArgs
    {
        public Color Color { get; }

        public CaughtPlayerEventArgs(Color Color)
        {
            Color = Color;
        }
    }
}