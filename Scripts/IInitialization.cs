using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public interface IInitialization //��������� ������������� ��������
    {
        void Initialization(IView view);
    }
}