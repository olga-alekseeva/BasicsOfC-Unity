using UnityEngine;

namespace RollABall
{
    public sealed class UIController : IController
    {
        public Canvas MainCanvas { get; set; }
       public UIController(Canvas mainCanvas)
        {
            MainCanvas = mainCanvas;
        }
    }
}