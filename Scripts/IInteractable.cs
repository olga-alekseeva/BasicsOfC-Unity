using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public interface IInteractable : IAction, IInitialization //интерфейс активного объекта наследует интерфейс действия и инициализации
    {
       bool IsInteractable { get;  }

    }
}