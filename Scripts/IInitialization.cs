using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public interface IInitialization //интерфейс инициализации объектов
    {
        void Initialization(IView view);
    }
}