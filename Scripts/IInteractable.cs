using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlekseevaOlgaLes1
{


    public interface IInteractable : IAction, IInitialization
    {
        bool IsInteractable { get; }
    }
}
