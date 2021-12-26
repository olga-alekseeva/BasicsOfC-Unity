using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public interface IInteractable : IAction, IInitialization //��������� ��������� ������� ��������� ��������� �������� � �������������
    {
       bool IsInteractable { get;  }

    }
}